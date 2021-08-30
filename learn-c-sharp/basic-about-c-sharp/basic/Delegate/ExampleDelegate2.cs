using System;
using System.Runtime.CompilerServices;

namespace basic_about_c_sharp.basic.Delegate
{
    public class ExampleDelegate2
    {
        public delegate void Action();

        public delegate void Action<in T>(T obj);

        public delegate TV Func<in T, out TV>(T x);

        public delegate bool Perdicate<in T>(T obj);

        public static void Start()
        {
            String x = Console.ReadLine();
            Action<string> action = (s) => Console.WriteLine(s);
            action(x);

            Func<int, float> func = (x) => (float)x / 10;
            var result = func(2);
            Console.WriteLine(result);

            Perdicate<int> perdicate = (x) => x > 100;
            var res = perdicate(50);
            Console.WriteLine(res);
        }
    }
}