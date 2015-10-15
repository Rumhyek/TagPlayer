using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    public class TagParams
    {
        public List<tblTag> TagIds { get; set; }
        public List<int> BySongIds { get; set; }
        public List<string> TagNames { get; set; }
    }
}
