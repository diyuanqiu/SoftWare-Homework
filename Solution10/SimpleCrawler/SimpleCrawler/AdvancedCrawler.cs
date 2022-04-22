using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    public class AdvancedCrawler
    {
        private ConcurrentDictionary<string, bool> urls = new ConcurrentDictionary<string, bool>();
        private ConcurrentQueue<string> urlsQueue = new ConcurrentQueue<string>();
        public string firstUrl { get; set; }
        private int downNumber;
        public string HostFilter { get; set; }
        public string FileFilter { get; set; }
        //正则表达式
        public string strRef = @"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']";
        public string urlRef = @"(https?://(?<hostname>[\w\d.]+)(:\d+)?($|/))([\w\d]+/)*(?<file>[^#?]*)";
        public ConcurrentDictionary<string, bool> DownloadedPages { get => urls; }
        public event Action<AdvancedCrawler, string, string> PageDownload;
        public AdvancedCrawler(int downNumber)
        {
            this.downNumber = downNumber;
        }
        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = urls.Count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
        public string ParseToAbsolute(string relativeUrl, string downloadUrl)
        {
            Uri uri = new Uri(downloadUrl);
            Uri absoluteUrl = new Uri(uri, relativeUrl);
            return absoluteUrl.ToString();
        }

        public void Parse(string html,string current)
        {
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                string url = match.Groups["url"].Value;
                if (url == null || url == "") continue;
                url = ParseToAbsolute(url,current);
                Match urlMatch = Regex.Match(url, urlRef);
                string host = urlMatch.Groups["hostname"].Value;
                string file = urlMatch.Groups["file"].Value;
                if (file == "") file = "index.html";

                if (Regex.IsMatch(host,HostFilter)&&Regex.IsMatch(file,FileFilter)&&!urls.ContainsKey(url))
                {
                    urlsQueue.Enqueue(url);
                    urls.TryAdd(url, false);
                }
            }
        }
        public void ParseAdd(string nextUrl)
        {
            try
            {
               string html = DownLoad(nextUrl);
               urls[nextUrl] = true;
               PageDownload(this, nextUrl, "success");
               Parse(html, nextUrl);
            }
            catch (Exception ex)
            {
            PageDownload(this, nextUrl, "Error:" + ex.Message);
            }
        }
        public void Start()
        {
            urls.Clear();
            urlsQueue.Enqueue(firstUrl);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //List<Action> actions = new List<Action>();
            List<Task> tasks = new List<Task>();
            while (tasks.Count < downNumber)
            {
                if (!urlsQueue.TryDequeue(out string nextUrl))
                {
                    continue;
                }
                //Action action = new Action(() => { ParseAdd(nextUrl); });
                //actions.Add(action);
                Task task = Task.Run(() => { ParseAdd(nextUrl); });
                tasks.Add(task);
            }
            //Parallel.Invoke(actions.ToArray());   have a problem of waiting
            Task.WaitAll(tasks.ToArray());
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
