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
            
                await controller.GetCovidData();
                Console.WriteLine(controller.Covid.Today.Internal.Cases);
                
                controller.NewCovidData += (sender, eventArgs) =>
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Chương trình được chạy lần đầu đang lấy dữ liệu Covid!");
                    Console.ResetColor();
                };
                
                controller.CovidUpdate += (sender, update) =>
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Đã lấy được data!");
                    Console.WriteLine(update.Data.Today.Internal.Cases);
                    Console.ResetColor();
                };

                controller.NothingChanged += (sender, eventArgs) =>
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Không có gì thay đổi! Chương trình sẽ tiếp tục ngủ 300s");
                    Thread.Sleep(10000);
                    Console.ResetColor();
                };
        }
    }
}