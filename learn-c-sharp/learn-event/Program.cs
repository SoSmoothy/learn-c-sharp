using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace learn_event
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri("http://st.imageinstant.net/data/comics/32/vo-luyen-dinh-phong.jpg"), "asfaf.jpg");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}