using System;
using System.IO;
using System.Text;

namespace basic_about_c_sharp.FileStream
{
    public class ReadDir
    {
        public static void Test()
        {
            System.IO.FileStream fs = new System.IO.FileStream("data.bin", FileMode.Create);
            int dob = 2002;
            string str = "Hello World";
            
            fs.Write(BitConverter.GetBytes(dob), 0, 4);
            fs.Write(Encoding.UTF8.GetBytes(str), 0, Encoding.UTF8.GetByteCount(str));
            
            fs.Flush();
            fs.Close();
            
            
        }
    }
}