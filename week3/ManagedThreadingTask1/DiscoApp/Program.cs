using System.Threading;
using System;

namespace DiscoApp
{
    public class Program
    {
        // Here we can set up quantity of music tracks, dancers, as well as 
        // length of tracks and delays between console messages in milliseconds
        public const int TrackCount = 20;
        public const int DancerCount = 10;
        public const int DefaultDelay = 1000;
        public const int ShortDelay = 500;

        // Although in task description it is said that each track should last 10-20 secs, 
        // in order to speed up app execution it is set to 3 secs
        public const int TrackLength = 3000;

        public static void Main()
        {
            OpenDisco();
            var tracklist = CreateTracklist();
            PlayMusic(tracklist);
            CloseDisco();
            Console.ReadKey();
        }

        public static void OpenDisco()
        {
            Console.WriteLine("Disco opens");
            Thread.Sleep(DefaultDelay);
            Console.WriteLine("Dancers enter disco");
            Thread.Sleep(DefaultDelay);
            Console.WriteLine("DJ creates tracklist");
            Thread.Sleep(DefaultDelay);
        }

        public static void PlayMusic(List<Track> tracklist)
        {
            foreach (var track in tracklist)
            {
                PlayTrack(track);

                // This is a simple implementation of "dancers",
                // each dancer is a separate thread. 
                // Every time new track is played new threads-dancers are created from scratch
                // although console messages show as if they are the same as before. 
                // Obviously reusable threads could be implemented using ThreadPools
                for (int i = 1; i <= DancerCount; i++)
                {
                    Thread thread = new Thread(Dance) { Name = "Dancer " + i };
                    thread.Start(track);
                }

                Thread.Sleep(TrackLength);
            }

        }

        public static void CloseDisco()
        {
            Console.WriteLine("Tracklist has ended");
            Thread.Sleep(DefaultDelay);
            Console.WriteLine("Dancers go home");
            Thread.Sleep(DefaultDelay);
            Console.WriteLine("Press any key to close the disco");
        }

        public static List<Track> CreateTracklist()
        {
            var newTracklist = new List<Track>();
            for (int i = 1; i <= TrackCount; i++)
            {
                newTracklist.Add(GenerateTrack(i));
            }

            return newTracklist;
        }

        // Music tracks are generated from scratch each time a playlist is created
        // They have generic names (e.g. "Track 7") and music style,
        // that is assigned randomly
        public static Track GenerateTrack(int id)
        {
            var musicStyles = new List<string>() { "Latino", "Hardbass", "Rock" };
            var random = new Random();
            var track = new Track("Track " + id,
                musicStyles[random.Next(musicStyles.Count)]);

            return track;
        }

        public static void PlayTrack(Track track)
        {
            Console.WriteLine("Now DJ plays " + track.Name
                + " in " + track.Style.ToUpper() + " style");
        }

        // This method contains logic, by which "dancers" know what style of music is played
        // and what bodypart they should "move" 
        public static void Dance(object? trackObj)
        {
            if (trackObj is Track track)
            {
                Thread.Sleep(ShortDelay);
                switch (track.Style)
                {
                    case "Latino":
                        Console.WriteLine(Thread.CurrentThread.Name + " is moving hips");
                        break;
                    case "Hardbass":
                        Console.WriteLine(Thread.CurrentThread.Name + " is moving elbows");
                        break;
                    case "Rock":
                        Console.WriteLine(Thread.CurrentThread.Name + " is moving head");
                        break;
                }
            }
        }
    }
}