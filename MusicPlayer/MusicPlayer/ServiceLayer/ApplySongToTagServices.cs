using MusicPlayer.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.ServiceLayer
{
    public class ApplySongToTagServices
    {
        private Song ActiveSong { get; set; }

        public ApplySongToTagServices(int songID)
        { 

        }

        public ActiveSongVM GetActiveSong()
        {
            throw new NotImplementedException();
        }

        public TagListVM GetTagList(TagSortOrder sortOrder, bool isSelected)
        {
            throw new NotImplementedException();
        }

        private TagListVM GetUnselectedTagList(TagSortOrder sortOrder)
        {
            throw new NotImplementedException();
        }

        private TagListVM GetSelectedTagList(TagSortOrder sortOrder)
        {
            throw new NotImplementedException();
        }

        public bool AddTag(Tag tag)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTag(Tag tag)
        {
            throw new NotImplementedException();
        }
    }
}
