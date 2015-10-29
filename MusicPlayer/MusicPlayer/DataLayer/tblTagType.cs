using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    public class tblTagType
    {
        [PrimaryKey, AutoIncrement]
        public int TagTypeID { get; set; }
        public string Type { get; set; }
        public bool FileAttribute { get; set; }
        public bool ReadOnlyType { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
