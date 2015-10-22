using MusicPlayer.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.BusinessLayer
{
    class Tag
    {
        public int TagID { get; set; }
        public int TagTypeID { get; set; }
        public string TagName { get; set; }
        public DateTime DateCreated { get; set; }

        public Tag(tblTag tag)
        {

        }

        public Tag(int tagTypeID, string tagName)
        {

        }

        public static List<Tag> GetAllTags()
        {
            throw new NotImplementedException();
        }

        public List<Song> GetSongs()
        {
            throw new NotImplementedException();
        }

        public TagType GetTagType()
        {
            throw new NotImplementedException();
        }

        public bool AddSong(Song song)
        {
            throw new NotImplementedException();
        }

        public bool AddSong(int songID)
        {
            throw new NotImplementedException();
        }

        public bool RemoveSong(Song song)
        {
            throw new NotImplementedException();
        }

        public bool RemoveSong(int songID)
        {
            throw new NotImplementedException();
        }

        public int PossibleSongCount(List<Tag> currentTags)
        {
            throw new NotImplementedException();
        }

        public bool SaveTag()
        {
            throw new NotImplementedException();
        }
    }
}
