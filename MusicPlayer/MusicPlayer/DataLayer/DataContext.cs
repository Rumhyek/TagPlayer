using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    public class DataContext : IDataLayer
    {
        private MusicPlayerEntities Context { get; set; }

        public DataContext(string connectionName)
        {
            throw new NotImplementedException();
        }

        public List<tblTag> GetTags(TagParams tagParams)
        {
            throw new NotImplementedException();
        }

        public bool SaveTag(tblTag tag)
        {
            throw new NotImplementedException();
        }

        public List<tblSong> GetSongs(SongParams songParams)
        {
            throw new NotImplementedException();
        }

        public bool SaveSong(tblSong song)
        {
            throw new NotImplementedException();
        }

        public bool ConnectSongToTag(int tagId, int songId)
        {
            throw new NotImplementedException();
        }

        public bool ConnectSongsToTags(List<int> tagIds, List<int> songIds)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTagsFromSong(int songId, List<int> tagIdsToRemove)
        {
            throw new NotImplementedException();
        }

        public bool RemoveSongsFromTag(int tagId, List<int> songIdsToRemove)
        {
            throw new NotImplementedException();
        }

        public bool SaveLocation(tblLocation location)
        {
            throw new NotImplementedException();
        }

        public List<tblLocation> GetLocations()
        {
            throw new NotImplementedException();
        }
    }
}
