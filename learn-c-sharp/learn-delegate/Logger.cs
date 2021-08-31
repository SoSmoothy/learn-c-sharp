using System;
using System.Collections.Generic;
using System.Text;

namespace learn_delegate
{
    class Logger
    {
        public delegate void ShowLog(string message);

        public static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Info: {0}", message));
            Console.ResetColor();
        }

        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Error: {0}", message));
            Console.ResetColor();
        }

        public static int Sum(int a, int b) => a + b;


        public static void TestShowLog()
        {
            ShowLog show;

            show = null;
            //show?.Invoke("Success");

            //show += Info;
            //show("Success");
            //show -= Info;

            //show += Error;
            //show("Error");
            //show -= Error;

            //ShowLog showLog1 = (string message) => Console.WriteLine($"{message}");
            //ShowLog showLog2 = Error;

            //var all = showLog1 + showLog2;
            //all("Hello");

            Func<int, int, int> func;
            func = Sum;

            Console.WriteLine(func?.Invoke(4, 3)); // 7

            Action<string> showMessage = null;
            showMessage = Info;

            showMessage?.Invoke("Hello World");
        }

        public static void TinhTong(int a, int b, Action<string> callback)
        {
            int temp = a + b;

            callback(temp.ToString());
        }

        public static void testTinhTong()
        {
            TinhTong(4, 3, (x) => Console.WriteLine($"= {x}"));
            TinhTong(4, 3, Info);
        }
    }
}
