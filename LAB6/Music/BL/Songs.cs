using Music.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.BL
{
    internal class Songs
    {
        private string music;
        private string artist;
        //private List<Playlists> songlist;
        public Songs(string music, string artist)
        {
            this.music = music;
            this.artist = artist;
        }
        public string GetSong()
        {
            return music;
        }
        public void SetSong(string music)
        {
            this.music = music;
        }
        public string GetArtist()
        {
            return artist;
        }
        public void SetArtist(string artist)
        {
            this.artist=artist;
        }
    }
}
