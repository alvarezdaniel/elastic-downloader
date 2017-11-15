using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace elastic_downloader
{
    public class Downloader
    {
        public void Run()
        {
            var remote = "https://artifacts.elastic.co/downloads/elasticsearch/elasticsearch-6.0.0.zip";
            var local = "elasticsearch-6.0.0.zip";

            using (var wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFile(new Uri(remote), local);
            }



        }
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine(e.ProgressPercentage);
        }
    }
}
