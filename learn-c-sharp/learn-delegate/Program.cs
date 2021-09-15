using System;

namespace learn_delegate
{
    class Program
    {
        static void TinhTong(int x, int y, Action<int> display)
        {
            display?.Invoke(x + y);
        }
        
        static void Main(string[] args)
        {
            TinhTong(1, 2, result =>
            {
                Console.WriteLine(result); // 3
            });
        }
    }
}
