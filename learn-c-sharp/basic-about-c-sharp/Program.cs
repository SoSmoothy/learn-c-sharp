using System;
using System.Text;
using System.Threading.Tasks;
using basic_about_c_sharp.basic.Download;
using basic_about_c_sharp.basic.Event;
using basic_about_c_sharp.FileStream;

namespace basic_about_c_sharp
{
    class Program
    {

        static async Task Main(string[] args)
        {
            while(true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Title = "Download img";
                Console.WriteLine("Nhập Link: ");
                String url = Console.ReadLine();
                await DLImage.Download(url);
            }
        }
    }
}
