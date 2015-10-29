using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    public class tblSong
    {
        [PrimaryKey, AutoIncrement]
        public int SongId { get; set; }
        public string Name { get; set; }
        public string RelativePath { get; set; }
        public int LocationID { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
