using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace PadDL
{
    class PadDL
    {
        public static async Task<string> Download(string url, int SIZEBUFFER = 500)
        {
            HttpClient httpClient = new HttpClient();

            String[] fileNameArray = url.Trim().Split(new[] { '/' });
            String filename = fileNameArray[fileNameArray.Length];
            Console.WriteLine($"Download {filename}");
            try
            {
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
                httpResponseMessage.EnsureSuccessStatusCode();

                var stream = await httpResponseMessage.Content.ReadAsStringAsync();

                var streamFile = File.OpenWrite(filename);
                byte[] buffer = new byte[SIZEBUFFER];

                bool end = false;

                do
                {
                    //int numberRead = await stream.ReadAsync(buffer, 0, SIZEBUFFER);
                } while (!end);
            } 
            catch(Exception ex)
            {

            }
        }
    }
}
