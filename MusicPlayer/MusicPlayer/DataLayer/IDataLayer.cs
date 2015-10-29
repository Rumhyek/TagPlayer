using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    public interface IDataLayer
    {
        /// <summary>
        /// Returns a list of tags based on the TagParmas.
        /// Throws ArgumentNullExection if tagParams is not passed in.
        /// </summary>
        List<tblTag> GetTags(TagParams tagParams);

        /// <summary>
        /// Will save a given tag to the database. (Either update or insert)
        /// Throws ArgumentNullExection if tag is not passed in.
        /// </summary>
        /// <param name="tag">The tag you wish to save</param>
        bool SaveTag(tblTag tag);

        /// <summary>
        /// Will get a list of songs based on the songParams passed in.
        /// Throws ArgumentNullExection if songParams is not passed in.
        /// </summary>
        /// <param name="songParams">The parameters you wish to use to filter by</param>
        /// <returns></returns>
        List<tblSong> GetSongs(SongParams songParams);

        /// <summary>
        /// Insert or Updates the given song into the database.
        /// Throws ArgumentNullExection if song is not passed in.
        /// </summary>
        /// <param name="song">The song you wish to save</param>
        bool SaveSong(tblSong song);

        /// <summary>
        /// Creates a connection between a tag and a song
        /// Throws CanNotFindException if tag or song does not exists
        /// </summary>
        /// <param name="tagId">The id of the tag you wish to add</param>
        /// <param name="songId">The id of the song you wish to add</param>
        /// <returns>True if connection exists</returns>
        bool ConnectSongToTag(int tagId, int songId);

        /// <summary>
        /// Creates a connection between a multiple tags and multiple songs
        /// </summary>
        /// <param name="tagIds">A list of tags</param>
        /// <param name="songIds">A list of songs</param>
        /// <returns>returns true if all connections were made</returns>
        bool ConnectSongsToTags(List<int> tagIds, List<int> songIds);

        /// <summary>
        /// Removes a connections from a song
        /// </summary>
        /// <param name="songId">The song you wish to remove connnections from</param>
        /// <param name="tagIdsToRemove">The tags to remove the connection from</param>
        /// <returns>True if the tags were removed</returns>
        bool RemoveTagsFromSong(int songId, List<int> tagIdsToRemove);

        /// <summary>
        /// Removes connections from a tag
        /// </summary>
        /// <param name="tagId">The tag you wish to remove connections from</param>
        /// <param name="songIdsToRemove">The songs you want to remove the connections from</param>
        /// <returns>True if the songs were removed</returns>
        bool RemoveSongsFromTag(int tagId, List<int> songIdsToRemove);

        /// <summary>
        /// Inserts or updates a new location to database
        /// Thows Arguement null expection if location is null.
        /// </summary>
        /// <param name="location">The location you wish to add</param>
        /// <returns>True if saved successfully</returns>
        bool SaveLocation(tblLocation location);

        /// <summary>
        /// Returns a list of all locations
        /// </summary>
        /// <returns>List of locations</returns>
        List<tblLocation> GetLocations();
    }
}
