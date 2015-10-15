using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    public class tblTag
    {
        public int TagID { get; set; }
        public int TagTypeID { get; set; }
        public string TagName { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
