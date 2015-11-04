using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    /// <summary>
    /// Data stored in the database that identifies a particular song.
    /// </summary>
    public class tblSong
    {
        /// <summary>
        /// A unquie number given to this song from the database.
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int SongId { get; set; }
        /// <summary>
        /// The name of the song
        /// </summary>
        /// <example>My First Song</example>
        public string Name { get; set; }
        /// <summary>
        /// The relativePath from the location path
        /// </summary>
        /// <example>\Album Name\My First Song.mp3</example>
        public string RelativePath { get; set; }
        /// <summary>
        /// The location in which this song is stored
        /// </summary>
        /// <example>1232</example>
        public int LocationID { get; set; }
        /// <summary>
        /// The date / time in which this song was added to the system
        /// </summary>
        /// <example>1/1/2014 10:30 PM</example>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// Gets this song's location
        /// </summary>
        /// <remarks>
        /// Returns the tblLocation from the database using locationId
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <returns>Null or the instance of tblLocation</returns>
        public List<tblSong> GetLocation()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the current tags that are connected to this song
        /// </summary>
        /// <remarks>
        /// Returns the tag data from the database using songId
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <returns>a list of tblTags with count 0 or more</returns>
        public List<tblTag> GetTags()
        {
            throw new NotImplementedException();
        }
    }
}
