using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ImageDownloaderApp
{
    public class Program
    {

        public const string WebsiteUrl = "https://jsonplaceholder.typicode.com/photos";

        // I had trouble accessing website above without using VPN, so I Implemented reading
        // from file information about photos that need to be downloaded 
        public const string PhotosInfoFilename = "photos.json";
        
        public static void Main()
        {
            Console.WriteLine("Start");
            CheckPhotosInfoJson();
            Console.ReadKey();
        }

        // Checks whether photos.json file exists inside Debug folder, 
        // if not creates new file and writes to it information about photos
        // from jsonplaceholder.typicode.com/photos
        public static void CheckPhotosInfoJson()
        {
            if (!File.Exists(PhotosInfoFilename))
            {
                DownloadPhotosInfo();
            }
            else { Console.WriteLine("we have him"); };
        }

        public static void DownloadPhotosInfo()
        {
            using var client = new WebClient();
            ;
            try 
            {
                client.DownloadFile(WebsiteUrl, "photos.json");
            }
            catch
            {
                Console.WriteLine("sucka");
            }
        }

    }
}