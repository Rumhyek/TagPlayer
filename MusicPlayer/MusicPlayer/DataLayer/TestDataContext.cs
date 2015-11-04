using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    /// <summary>
    /// The purpose of this class is to populate fake data into the system so we can test our functions
    /// </summary>
    public class TestDataContext : IDataLayer
    {
        public List<tblTag> TagList { get; set; }
        public List<tblSong> SongList { get; set; }
        public List<tblLocation> LocationList { get; set; }
        public List<tblSongTag> SongTagList { get; set; }
        public List<tblTagType> TagTypeList { get; set; }
        public TestDataContext()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This needs to populate TagList, SongList, and LocationList
        /// </summary>
        private void LoadTestData()
        {
            throw new NotImplementedException();
        }

        #region IDataLayer
        //Refer to MusicPlayer.DataLayer.IDataLayer implementation requirements

        List<tblTag> IDataLayer.GetTags(TagParams tagParams)
        {
            throw new NotImplementedException();
        }

        bool IDataLayer.SaveTag(tblTag tag)
        {
            throw new NotImplementedException();
        }

        List<tblSong> IDataLayer.GetSongs(SongParams songParams)
        {
            throw new NotImplementedException();
        }

        bool IDataLayer.SaveSong(tblSong song)
        {
            throw new NotImplementedException();
        }

        bool IDataLayer.ConnectSongToTag(int tagId, int songId)
        {
            throw new NotImplementedException();
        }

        bool IDataLayer.ConnectSongsToTags(List<int> tagIds, List<int> songIds)
        {
            throw new NotImplementedException();
        }

        bool IDataLayer.RemoveTagsFromSong(int songId, params int[] tagIdsToRemove)
        {
            throw new NotImplementedException();
        }

        bool IDataLayer.RemoveSongsFromTag(int tagId, params int[] songIdsToRemove)
        {
            throw new NotImplementedException();
        }

        bool IDataLayer.SaveLocation(tblLocation location)
        {
            throw new NotImplementedException();
        }

        List<tblLocation> IDataLayer.GetLocations()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
