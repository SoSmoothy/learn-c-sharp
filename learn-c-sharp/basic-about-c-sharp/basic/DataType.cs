using System;
using System.Text;

namespace basic_about_c_sharp.basic
{
    public class DataType
    {
        public static void DataTypeMain()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // khai bao Number
            Console.WriteLine("Khoảng giá trị của Sbyte là {0} đến {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("Khoảng giá trị của Short là {0} đến {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Khoảng giá trị của Int16 là {0} đến {1}", Int16.MinValue, Int16.MaxValue);
            Console.WriteLine("Khoảng giá trị của Int là {0} đến {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Khoảng giá trị của Int32 là {0} đến {1}", Int32.MinValue, Int32.MaxValue);
            Console.WriteLine("Khoảng giá trị của Int64 là {0} đến {1}", Int64.MinValue, Int64.MaxValue);

            Console.WriteLine("Khoảng giá trị của long là {0} đến {1}", long.MinValue, long.MaxValue);
            // Int16 = short va Int = Int32 va Int64 = long 
            //
            bool isStudent = true;
            Console.WriteLine(isStudent);
            char c = 'D';
            Console.WriteLine(c);

            string myString = "Hello World";
            Console.WriteLine(myString);

            string path = @"C:\Hello\World";
            string solution = $"{c} is my first char in my name";
            Console.WriteLine(path);
            Console.WriteLine(solution);

            Console.WriteLine();
        }
    }
}