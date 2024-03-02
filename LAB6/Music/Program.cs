using Music.BL;
using Music.DL;
using System;
using System.Collections.Generic;

namespace Music
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs song1 = new Songs("Naat 1", "Sufi 1");
            //Songs song2 = new Songs("Naat 2", "Sufi 2");
            List<Playlists> list = new List<Playlists>();
            Playlists playlist1 = new Playlists("My Playlist");
            list.Add(playlist1);

            Console.WriteLine($"Playlist: {playlist1.GetPlayListName()}");
            Console.WriteLine($"Songs: {song1.GetSong()}");
            Console.WriteLine($"Artist: {song1.GetArtist()}");

            playlist1.SetPlayListName("NEW NAAT");
            Console.WriteLine($"Playlist: {playlist1.GetPlayListName()}");

            song1.SetArtist(" NEW SUFI ");
            Console.WriteLine($"Artist: {song1.GetArtist()}");
            Console.ReadKey();

        }
    }



}
