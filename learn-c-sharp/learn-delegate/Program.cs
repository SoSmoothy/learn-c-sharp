using System;

namespace learn_delegate
{
    class Program
    {
        public delegate void Logger(string s);

        public static void LogSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static int SumNum(int x)
        {
            return x * 2;
        }
        
        static void Main(string[] args)
        {
            Logger logger = null;
            logger += LogSuccess;
            logger += LogError;
            logger("Log Error");

            Action<string> log;
            log = LogSuccess;
            log("Done");

            Func<int, int> sum;
            sum = SumNum;
            Console.WriteLine(sum(2));
        }
    }
}
