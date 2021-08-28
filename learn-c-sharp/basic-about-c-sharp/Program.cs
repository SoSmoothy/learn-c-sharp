using System;
using System.Text;
using basic_about_c_sharp.basic;
using basic_about_c_sharp.basic.Delegate;
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
            // ExampleList<string> listString = new ExampleList<string>(5);
            // listString.Set(1, "Hello World");
            // Console.WriteLine(listString.Get(1));

            // ExampleDelegate exampleDelegate = new ExampleDelegate();
            // double[] range = new[] {1.0, 1.2, 1.4, 1.6, 1.8, 2.0};
            // exampleDelegate.Render(Mathematics.Sin, range);
            // exampleDelegate.Render(Mathematics.Cos, range);
            // exampleDelegate.Render(Math.Sqrt, range);
            //
            // MathFunction function = delegate(double x) { return x *= 2; };
            // exampleDelegate.Render(function, range);
            //
            // exampleDelegate.Render(delegate(double d) { return d++; }, range);
            // exampleDelegate.Render((double x) => { return x *= 10; }, range);
            // exampleDelegate.Render(x => x / 10, range);
            
            ExampleDelegate2.Start();
        }
    }
}
