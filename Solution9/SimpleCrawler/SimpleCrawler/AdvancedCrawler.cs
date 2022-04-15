using System;
using System.Collections;
using System.Collections.Generic;
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
        private Dictionary<string, bool> urls = new Dictionary<string, bool>();
        private Queue<string> urlsQueue = new Queue<string>();
        public string url { get; set; }
        private int downNumber { get; set; }
        public string HostFilter { get; set; }
        //正则表达式
        public string strRef = @"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']";
        public string urlRef = @"(https?://(?<hostname>[\w\d.]+)(:\d+)?($|/))([\w\d]+/)*([^#?]*)";
        public Dictionary<string, bool> DownloadedPages { get => urls; }
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
            if (relativeUrl.Contains("://"))
            {
                return relativeUrl;
            }
            if (relativeUrl.Contains("//"))
            {
                return "http:" + relativeUrl;
            }
            if (relativeUrl.StartsWith("/"))
            {
                if (downloadUrl.EndsWith("/"))
                {
                    relativeUrl = downloadUrl + relativeUrl;
                }
                else
                    relativeUrl = downloadUrl + "/" + relativeUrl;
            }

            if (relativeUrl.StartsWith("../"))
            {
                if (downloadUrl.EndsWith("/"))
                {
                    relativeUrl = downloadUrl + relativeUrl;
                }
                else
                    relativeUrl = downloadUrl + "/" + relativeUrl;
            }

            if (relativeUrl.StartsWith("./"))
            {
                if (downloadUrl.EndsWith("/"))
                {
                    relativeUrl = downloadUrl + relativeUrl;
                }
                else
                    relativeUrl = downloadUrl + "/" + relativeUrl;
            }
            return relativeUrl;
            
        }

        public void Parse(string html,string current)
        {
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                string url = match.Groups["url"].Value;
                if (url == null || url == "") continue;
                url = ParseToAbsolute(url,current);
                Match hostMatch = Regex.Match(url, urlRef);
                string host = hostMatch.Groups["hostname"].Value;
                if (Regex.IsMatch(host,HostFilter)&&!urls.ContainsKey(url))
                {
                    urlsQueue.Enqueue(url);
                    urls.Add(url, false);
                }
            }
        }
        public void Start()
        {
            urls.Clear();
            urlsQueue.Clear();
            urlsQueue.Enqueue(url);
            while(urls.Count < downNumber && urlsQueue.Count > 0)
            {
                string nextUrl = urlsQueue.Dequeue();
                try
                {
                    string html = DownLoad(nextUrl);
                    urls[nextUrl] = true;
                    PageDownload(this, nextUrl, "success");
                    Parse(html,nextUrl);
                }
                catch (Exception ex)
                {
                    PageDownload(this, nextUrl, "Error:" + ex.Message);
                }
            }
        }
    }
}
