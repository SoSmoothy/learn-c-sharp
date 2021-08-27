using System;

namespace basic_about_c_sharp.basic.Generic
{
    public class ExampleGeneric
    {
        private static void Swap<T>(ref T a, ref T b)
        {
            (a, b) = (b, a);
        }

        public static void Test()
        {
            int a = 5, b = 1;
            ExampleGeneric.Swap(ref a,ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}