using System;
using System.Threading.Tasks;
using learn_crawl.Utils;

namespace learn_crawl
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var result = await Request.GetInfoCovid();
            Console.WriteLine(result.Locations[0].Cases);
        }
    }
}