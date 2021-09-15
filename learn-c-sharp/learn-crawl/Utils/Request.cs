using System;
using System.Net.Http;
using System.Threading.Tasks;
using learn_crawl.Model;
using Newtonsoft.Json;

namespace learn_crawl.Utils
{
    public class Request
    {
        public static async Task<Covid> GetInfoCovid()
        {
            string baseUrl = "https://static.pipezero.com/covid/data.json";
            Covid result = new Covid();
            
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(baseUrl);
                    response.EnsureSuccessStatusCode();
                    result = JsonConvert.DeserializeObject<Covid>(await response.Content.ReadAsStringAsync());
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            return result;
        }
    }
}