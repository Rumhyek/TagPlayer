using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    /// <summary>
    /// Data stored in the database that reperesents a particular type of tag
    /// </summary>
    public class tblTagType
    {
        /// <summary>
        /// A unquie value given by the database that repersents this tag type
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int TagTypeID { get; set; }

        /// <summary>
        /// The name of this type
        /// </summary>
        /// <example>Artist</example>
        public string Type { get; set; }

        /// <summary>
        /// If true this type's tags are from file attributes
        /// </summary>
        public bool IsFileAttribute { get; set; }
        /// <summary>
        /// If true this type's tags cannot be removed from songs
        /// </summary>
        public bool ReadOnlyType { get; set; }

        /// <summary>
        /// The date this tag type was created
        /// </summary>
        public DateTime DateCreated { get; set; }


        /// <summary>
        /// Gets the tags that have this type
        /// </summary>
        /// <remarks>
        /// Returns the tag data from the database using tagTypeId
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <returns>a list of tblTags with count 0 or more</returns>
        public List<tblTag> GetTags()
        {
            throw new NotImplementedException();
        }
    }
}
