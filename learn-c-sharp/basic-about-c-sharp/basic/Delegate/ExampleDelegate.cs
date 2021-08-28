using System;

namespace basic_about_c_sharp.basic.Delegate
{
    internal delegate double MathFunction(double x);
    
    internal class ExampleDelegate
    {
        public MathFunction Function { get; set; }

        public void Render(MathFunction function, double[] range)
        {
            Function = function;
            
            Console.WriteLine($"Drawing the function graph: {function.Method}");

            foreach (var x in range)
            {
                var y = function(x);
                
                Console.WriteLine($"{y:f3}  ");
            }
            Console.WriteLine("rn------------------");
        }
    }

    internal class Mathematics
    {
        public static double Cos(double x) => Math.Cos(x);
        public static double Tan(double x) => Math.Tan(x);
        public static double Sin(double x) => Math.Sin(x);
    }
}