using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    public class tblSongTag
    {
        [PrimaryKey, AutoIncrement]
        public int SongTagID { get; set; }
        public int SongID { get; set; }
        public int TagID { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
