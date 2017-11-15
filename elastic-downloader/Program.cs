using System;
using System.IO;

namespace elastic_downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://stackoverflow.com/questions/307688/how-to-download-a-file-from-a-url-in-c
            var fileUrl = "https://artifacts.elastic.co/downloads/elasticsearch/elasticsearch-6.0.0.zip";
            var fullPathWhereToSave = Path.Combine(Environment.CurrentDirectory, "elasticsearch-6.0.0.zip");
            var timeoutInMilliSec = 5000;

            var success = FileDownloader.DownloadFile(fileUrl, fullPathWhereToSave, timeoutInMilliSec);
            Console.WriteLine("Done  - success: " + success);
            Console.ReadLine();
        }

    }
}
