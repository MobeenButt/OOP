using Music.BL;
using System.Collections.Generic;

namespace Music.DL
{
    internal class Playlists
    {
       private string Name;
       //private List<Songs> Songs;

        public Playlists(string name)
        {
            Name = name;
            
        }   

        public string GetPlayListName()
        {
            return Name;    
        }
        public void SetPlayListName(string name)
        {
            this.Name = name;
        }
       
    }
}




