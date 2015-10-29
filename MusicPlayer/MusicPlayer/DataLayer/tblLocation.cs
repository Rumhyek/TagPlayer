using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    public class tblLocation
    {
        /// <summary>
        /// The unquie id for this location
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int LocationID { get; set; }
        /// <summary>
        /// The location for this
        /// </summary>
        public string Location { get; set; }
    }
}
