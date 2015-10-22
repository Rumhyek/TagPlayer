using MusicPlayer.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.BusinessLayer
{
    class TagType
    {
        public int TagTypeID { get; set; }
        public string TypeName { get; set; }
        public bool FileAttribute { get; set; }
        public bool ReadOnlyType { get; set; }
        public DateTime DateCreated { get; set; }

        public TagType(tblTagType tagType)
        {

        }

        public TagType(string typeName, bool isFileAttr, bool isReadOnly)
        {

        }

        public List<Tag> GetTags()
        {
            throw new NotImplementedException();
        }

        public static List<TagType> GetAllTagTypes()
        {
            throw new NotImplementedException();
        }
    }
}
