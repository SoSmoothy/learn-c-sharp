using System;
using System.ComponentModel;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace learn_thread
{
    class Program
    {
        
        private static void Progress_Changed(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine($"{e.BytesReceived/e.TotalBytesToReceive} {e.ProgressPercentage}");
        }

        private static void Completed(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine($"Done");
        }
        static void Download(string url, string filename)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadProgressChanged += Progress_Changed;
                webClient.DownloadFileCompleted += Completed;
                webClient.DownloadFile(url, filename);
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(() =>
                {
                    Download("https://images4.alphacoders.com/109/1094088.jpg", $"{i}.png");
                });
                
                t.Start();
            }
        }
    }
}