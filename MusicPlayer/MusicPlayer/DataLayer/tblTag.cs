using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    /// <summary>
    /// Data stored in the database that identifies a particular tag.
    /// </summary>
    public class tblTag
    {
        /// <summary>
        /// A unquie value given by the database to repersent this tag
        /// </summary>
        /// <example>2142</example>
        [PrimaryKey, AutoIncrement]
        public int TagID { get; set; }
        
        /// <summary>
        /// The type of tag this is
        /// </summary>
        /// <example>2142</example>
        [Indexed]
        public int TagTypeID { get; set; }

        /// <summary>
        /// The name of this tag
        /// </summary>
        /// <example>Spooky</example>
        public string TagName { get; set; }

        /// <summary>
        /// The date this tag was created.
        /// </summary>
        /// <example>1/1/2014 10:30 PM</example>
        public DateTime DateCreated { get; set; }


        /// <summary>
        /// Gets all songs that are connected to this tag
        /// </summary>
        /// <remarks>
        /// Returns a list of songs that are connected via a tblSongTag
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <returns>a list of tblSong with count 0 or more</returns>
        public List<tblSong> GetSongs()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the tagType based on TagTypeID
        /// </summary>
        /// <returns>null or a tblTagType</returns>
        public tblTagType GetTagType()
        {
            throw new NotImplementedException();
        }
    }
}
