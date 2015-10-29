using MusicPlayer.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.ServiceLayer
{
    public class ApplyTagToSongServices
    {
        private Tag ActiveTag { get; set; }

        public ApplyTagToSongServices(int tagID)
        {

        }

        public ActiveTagVM GetActiveTag()
        {
            throw new NotImplementedException();
        }

        public SongListVM GetSongList(SongSortOrder sortOrder, bool isSelected)
        {
            throw new NotImplementedException();
        }

        private SongListVM GetUnselectedSongList(SongSortOrder sortOrder)
        {
            throw new NotImplementedException();
        }

        private SongListVM GetSelectedSongList(SongSortOrder sortOrder)
        {
            throw new NotImplementedException();
        }

        public bool AddSong(Song song)
        {
            throw new NotImplementedException();
        }

        public bool RemoveSong(Song song)
        {
            throw new NotImplementedException();
        }
    }
}
