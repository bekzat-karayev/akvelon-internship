using System.Threading;
using System;
namespace DiscoApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Disco opens");
            Thread.Sleep(1000);
            Console.WriteLine("Dancers enter disco");
            Thread.Sleep(1000);
            Console.WriteLine("DJ creates tracklist");
            Thread.Sleep(1000);
            var tracklist = CreateTracklist();
            foreach (var track in tracklist)
            {
                PlayMusic(track);
                Thread.Sleep(2000);
            }
            Console.WriteLine("Tracklist has ended");
            Thread.Sleep(1000);
            Console.WriteLine("Dancers go home");
            Console.ReadKey();
        }

        static List<Track> CreateTracklist()
        {
            var newTracklist = new List<Track>();
            for (int i = 1; i < 11; i++)
            {
                newTracklist.Add(GenerateTrack(i));
            }

            return newTracklist;
        }

        static Track GenerateTrack(int id)
        {
            var musicStyles = new List<string>() { "Latino", "Hardbass", "Rock" };
            var random = new Random();
            var track = new Track("Track " + id,
                musicStyles[random.Next(musicStyles.Count)]);

            return track;
        }

        static void PlayMusic(Track track)
        {
            Console.WriteLine("Now DJ plays " + track.Name 
                + " in " + track.Style + " style");
        }
    }
}