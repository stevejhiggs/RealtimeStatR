using Microsoft.Owin.Hosting;
using RealtimeStatR.EventReceiver.App_Start;
using System;

namespace RealtimeStatR.EventReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:9999";

            using (WebApplication.Start<Startup>(url))
            {
                Console.WriteLine("Server running on {0}", url);
                Console.ReadLine();
            }
        }
    }
}
