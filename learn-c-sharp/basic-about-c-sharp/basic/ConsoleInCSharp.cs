using System;

namespace basic_about_c_sharp.basic
{
    class ConsoleInCSharp
    {
        public static void ConsoleMain()
        {
            Console.Title = "test";
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(key.KeyChar);
            Console.WriteLine(key.Modifiers);
            Console.Read();
        }
    }
}
