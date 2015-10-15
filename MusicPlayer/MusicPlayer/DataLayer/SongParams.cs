using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    public class SongParams
    {
        public List<tblSong> SongIds { get; set; }
        public List<int> ByTagIds { get; set; }
        public List<string> SongNames { get; set; }
    }
}
