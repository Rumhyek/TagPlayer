using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.ServiceLayer
{
    public class SongViewServices
    {
        public AddLocationVM GetAddLocationInfo()
        {
            throw new NotImplementedException();
        }

        public bool SaveLocation(LocationVM newTag)
        {
            throw new NotImplementedException();
        }

        public bool ImportLocation(LocationVM location)
        {
            throw new NotImplementedException();
        }

        public List<LocationVM> GetLocations()
        {
            throw new NotImplementedException();
        }

        public SongListVM GetSongList(SongSortingOptions sortOptions)
        {
            throw new NotImplementedException();
        }

        public TagListVM GetTagListBySong(SongVM song)
        {
            throw new NotImplementedException();
        }
    }
}
