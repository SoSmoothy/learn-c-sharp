using System;
using System.Net.NetworkInformation;

namespace learn_networking
{
    class Program
    {
        static void Main(string[] args)
        {
            Ping ping = new Ping();
            PingReply pingReply = ping.Send("google.com.vn");
            if (pingReply?.Status == IPStatus.Success)
            {
                Console.WriteLine(pingReply.RoundtripTime + "ms");
                Console.WriteLine(pingReply.Address);
            }
        }
    }
}