using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("BEAUTIFUL PEOPLE", "ED SHEERAN", 3.15, Genre.Pop);
            Song song2 = new Song("Dance Monkey", "TONES & 1", 4.20, Genre.Dance);
            Song song3 = new Song("CIRCLES", "POST MALONE", 3.25, Genre.Pop);
            Song song4 = new Song("RIDE IT", "REGARD", 3.37, Genre.Dance );
            Song song5 = new Song("SOUTH OF THE BORDER", "ED SHEERAN", 4.26, Genre.Pop);


            List<Song> playlist = new List<Song>();

            playlist.Add(song1);
            playlist.Add(song2);
            playlist.Add(song3);
            playlist.Add(song4);
            playlist.Add(song5);

            Display(playlist);
        }

        private static void Display (List<Song> playlist)
        {
            Console.WriteLine("{0, -20}{1, -25}{2, -10}{3, -10}", "Artist", "Song", "Duration", "Genre");

            foreach (Song song in playlist)
            {
                Console.WriteLine($"{song.Artist, -20}{song.Title, -25}{song.Duration, -10}{song.MusicGenre, -10}");
            }
        }
    }
}
