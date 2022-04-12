using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ImageDownloaderApp
{
    public class Program
    {

        public const string WebsiteUrl = "https://172.67.131.170/photos";
        //public const string WebsiteUrl = "https://www.ipify.org/";
        public static void Main()
        {
            Console.WriteLine("Start");
            CheckConnection();
            Console.ReadKey();
        }

        public static async void CheckConnection()
        {
            using var client = new WebClient();
            WebProxy proxy = new WebProxy("192.168.1.1");
            var response = client.DownloadString(WebsiteUrl);
            if (!string.IsNullOrEmpty(response))
            {
                Console.WriteLine(response);
            }
            else
            {
                Console.WriteLine("sucka");
            }
        }

    }
}