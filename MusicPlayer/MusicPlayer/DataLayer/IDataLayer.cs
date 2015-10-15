using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    interface IDataLayer
    {
        List<tblTag> GetTags(TagParams tagParams);
        bool SaveTag(tblTag tag);

        List<tblSong> GetSongs(SongParams songParams);
        bool SaveSong(tblSong song);

        bool ConnectSongToTag(int tagId, int songId);
        bool ConnectSongsToTags(List<int> tagIds, List<int> songIds);
        bool RemoveTagsFromSong(int songId, List<int> tagIdsToRemove);
        bool RemoveSongsFromTag(int tagId, List<int> songIdsToRemove);

        bool SaveLocation(tblLocation location);
        List<tblLocation> GetLocations();
    }
}
