using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using learn_crawl.Utils;

namespace learn_crawl
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Controller.Controller controller = new Controller.Controller();

            if (controller.Covid == null)
            {
                Console.WriteLine("Null");
            }

            await controller.GetCovidData();

            controller.NewCovidData += (sender, eventArgs) =>
            {
                Console.WriteLine("Newest Data Covid Update!");
            };
        }
    }
}