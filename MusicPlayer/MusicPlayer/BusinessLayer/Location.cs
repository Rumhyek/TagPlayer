using MusicPlayer.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.BusinessLayer
{
    class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }

        public Location(string location)
        {

        }
        
        public Location(tblLocation location)
        {

        }

        public Location(int LocationID)
        {

        }

        public static List<Location> GetAllLocations()
        {
            throw new NotImplementedException();
        }

        public List<Song> GetAllSongsInLocation(bool saveNewSongs)
        {
            throw new NotImplementedException();
        }

        public bool DeleteLocation()
        {
            throw new NotImplementedException();
        }

        private bool RemoveAllSongsInLocation()
        {
            throw new NotImplementedException();
        }
    }
}
