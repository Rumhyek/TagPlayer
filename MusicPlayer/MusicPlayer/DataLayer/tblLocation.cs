using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    /// <summary>
    /// Data stored in the database that reveals a location where music is stored
    /// </summary>
    public class tblLocation
    {
        /// <summary>
        /// The unquie id for this location.
        /// </summary>
        /// <example>12321</example>
        [PrimaryKey, AutoIncrement]
        public int LocationID { get; set; }
        /// <summary>
        /// The location for this group of songs
        /// </summary>
        /// <example>C:\Users\Public\Music</example>
        public string Location { get; set; }
        
        /// <summary>
        /// Gets all songs that belong to this location
        /// </summary>
        /// <remarks>
        /// Returns a list of songs that reside within this locationID
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <returns>a list of tblSong with count 0 or more</returns>
        public List<tblSong> GetSongs()
        {
            throw new NotImplementedException();
        }
    }
}
