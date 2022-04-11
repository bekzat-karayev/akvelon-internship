using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ImageDownloaderApp
{
    public class Program
    {

        public const string WebsiteUrl = "https://www.google.com/";
        public static void Main()
        {
            Console.WriteLine("Start");
            CheckConnection();
            Console.ReadKey();
        }

        public static async void CheckConnection()
        {
            HttpClient client = new HttpClient();
            var checkingResponse = await client.GetAsync(WebsiteUrl);
            Console.WriteLine(checkingResponse.StatusCode);

        }
    }
}