using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    /// <summary>
    /// Data stored in the database that identifies a connection between a song and a tag
    /// </summary>
    public class tblSongTag
    {
        /// <summary>
        /// A unquie value assigned by the database that respersents this connection
        /// </summary>
        /// <example>12323</example>
        [PrimaryKey, AutoIncrement]
        public int SongTagID { get; set; }
        /// <summary>
        /// The unquie id to access the song from the database
        /// </summary>
        /// <example>12323</example>
        public int SongID { get; set; }
        /// <summary>
        /// The unquie id to access the tag from the database
        /// </summary>
        /// <example>12323</example>
        public int TagID { get; set; }
        /// <summary>
        /// The date / time this connection was created
        /// </summary>        
        /// <example>1/1/2014 10:30 PM</example>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets the current song that belongs to this connection
        /// </summary>
        /// <remarks>
        /// Returns the song data from the database using songId
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <returns>Null or the instance of tblSong</returns>
        public tblSong GetSong()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the current tag that belongs to this connection
        /// </summary>
        /// <remarks>
        /// Returns the tag data from the database using tagId
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <returns>Null or the instance of tblTag</returns>
        public tblTag GetTag()
        {
            throw new NotImplementedException();
        }
    }
}
