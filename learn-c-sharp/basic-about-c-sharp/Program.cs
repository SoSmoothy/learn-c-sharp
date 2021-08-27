using System;
using System.Text;
using basic_about_c_sharp.basic;
using basic_about_c_sharp.basic.Generic;
using basic_about_c_sharp.basic.PhanSo;

namespace basic_about_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //BasicCode.BasicMain();
            //DataType.DataTypeMain();
            //Operator.OperatorMain();
            //ConsoleInCSharp.ConsoleMain();

            // PhanSo phanSo = new PhanSo();
            // phanSo.TuSo = 2;
            // phanSo.MauSo = 0;
            // Console.WriteLine(phanSo);
            
            //ExampleGeneric.Test();
            ExampleList<string> listString = new ExampleList<string>(5);
            listString.Set(1, "Hello World");
            Console.WriteLine(listString.Get(1));
        }
    }
}
