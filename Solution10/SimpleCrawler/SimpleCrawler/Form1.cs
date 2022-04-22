using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrawler
{
    public partial class Form1 : Form
    {
        public string keyword { get; set; }
        AdvancedCrawler advancedCrawler = new AdvancedCrawler(120);
        public Form1()
        {
            InitializeComponent();
            url_dataGridView.DataSource = url_bindingSource;
            URL_textBox.DataBindings.Add("Text", this, "keyword");
            advancedCrawler.PageDownload += AdvancedCrawler_Download;
        }


        private void AdvancedCrawler_Download(AdvancedCrawler advancedcrawler, string url1, string status1)
        {
            lock (this)
            {
                var urlInfo = new { index = url_bindingSource.Count, url = url1, status = status1 };
                Action action = () => { url_bindingSource.Add(urlInfo); };
                if (InvokeRequired)
                {
                    Invoke(action);
                }
                else
                {
                    action();
                }
            }
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            url_bindingSource.Clear();
            advancedCrawler.firstUrl = URL_textBox.Text;
            Match match = Regex.Match(advancedCrawler.firstUrl, advancedCrawler.urlRef);
            if (match.Length == 0) return;
            string host = match.Groups["hostname"].Value;
            advancedCrawler.HostFilter = "^" + host + "$";
            advancedCrawler.FileFilter = ".html?$";
            Thread thread = new Thread(advancedCrawler.Start);
            thread.Start();
        }
    }
}
