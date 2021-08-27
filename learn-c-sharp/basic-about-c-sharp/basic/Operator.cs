using System;
using System.Collections.Generic;
using System.Text;

namespace basic_about_c_sharp.basic
{
    class Operator
    {
        public static void OperatorMain()
        {
            Console.WriteLine("Prefix");
            int x = 5;
            int y = ++x;
            Console.WriteLine(y); // 6

            Console.WriteLine("Postfix");
            int a = 5;
            int b = a++; // 5
            Console.WriteLine(b); // 5

            Console.WriteLine("Casting type");
            object o1 = "Hello World";
            //string s1 = (string)o1;
            //Console.WriteLine(s1);

            string s2 = o1 as string;
            Console.WriteLine(s2);

            object o2 = 123123;
            string s3 = o2 as string;
            Console.WriteLine();
        }
    }
}
