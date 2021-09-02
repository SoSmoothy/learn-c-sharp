using System;
using System.Data;

namespace learn_exeption
{
    class DataToLong : Exception
    {
        public DataToLong() : base("Data to long")
        {
            
        }
    }

    class Program
    {
        static void UserInput(string s)
        {
            if (s.Length > 5)
            {
                Exception e = new DataException();
                throw e;
            }
        }
        
        static void Main(string[] args)
        {
            try
            {
                string s = Console.ReadLine();
                UserInput(s);
            }
            catch (DataToLong ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}