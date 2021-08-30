using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace basic_about_c_sharp.basic.Download
{
    public class DLImage
    {
        public static async Task Download(string url, int SizeBuffer = 500)
        {
            try
            {
                using HttpClient httpClient = new HttpClient();

                String[] fileNameArray = url.Trim().Split(new[] { '/' });
                String filename = fileNameArray[fileNameArray.Length - 1];
                Console.WriteLine($"Download {filename}");
                HttpResponseMessage responseMessage = await httpClient.GetAsync(url);
                responseMessage.EnsureSuccessStatusCode();

                using var stream = await responseMessage.Content.ReadAsStreamAsync();
                int length = Convert.ToInt32(responseMessage.Content.Headers.First(h => h.Key.Equals("Content-Length")).Value.First());

                await using var streamFile = File.OpenWrite(filename);
                byte[] buffer = new byte[SizeBuffer];
                bool endread = false;
                int currentSize = 0;
                do
                {
                    int numberRead = await stream.ReadAsync(buffer, 0, SizeBuffer);
                    currentSize += numberRead;
                    Console.WriteLine($"{currentSize}/{length}");
                    
                    if (numberRead == 0)
                    {
                        endread = true;
                    }
                    else
                    {
                        await streamFile.WriteAsync(buffer, 0, numberRead);
                    }
                } while (!endread);
                
                Console.WriteLine("Done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}