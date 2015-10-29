using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    public class tblTag
    {
        [PrimaryKey, AutoIncrement]
        public int TagID { get; set; }
        [Indexed]
        public int TagTypeID { get; set; }
        public string TagName { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
