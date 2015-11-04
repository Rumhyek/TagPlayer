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
        /// <remarks>
        /// By default this function will return all tags an uses
        /// tagParams to filter down the list.
        /// </remarks>
        /// <difficulty>Medium</difficulty>
        /// <returns>Outputs a list of tblTag of count 0 or greater.</returns>
        List<tblTag> GetTags(TagParams tagParams);

        /// <summary>
        /// Will save a given tag to the database. (Either update or insert)
        /// Throws ArgumentNullExection if tag is not passed in.
        /// Throws InvalidOperationException if tagid != 0 and is not in the database
        /// </summary>
        /// <remarks>
        /// This function has two branches of logic
        ///     tag.TagID = 0  - Insert into the database
        ///     tag.TagID != 0 - Check to make sure the tblTag exists in the db.
        ///                      If it does update it's values otherwise throw InvalidOperationException
        /// </remarks>
        /// <difficulty>Medium</difficulty>
        /// <param name="tag">The tag you wish to save</param>
        bool SaveTag(tblTag tag);

        /// <summary>
        /// Will get a list of songs based on the songParams passed in.
        /// Throws ArgumentNullExection if songParams is not passed in.
        /// </summary>
        /// <remarks>
        /// By default this function will return all songs an uses
        /// songParams to filter down the list.
        /// </remarks>
        /// <difficulty>Medium</difficulty>
        /// <param name="songParams">The parameters you wish to use to filter by</param>
        /// <returns>Outputs a list of tblSong of count 0 or greater.</returns>
        List<tblSong> GetSongs(SongParams songParams);

        /// <summary>
        /// Insert or Updates the given song into the database.
        /// Throws ArgumentNullExection if song is not passed in.
        /// Throws InvalidOperationException if songid != 0 and is not in the database
        /// </summary>
        /// <remarks>
        /// This function has two branches of logic
        ///     song.SongID = 0  - Insert into the database
        ///     song.SongID != 0 - Check to make sure the tblSong exists in the db.
        ///                        If it does update it's values otherwise throw InvalidOperationException
        /// </remarks>
        /// <difficulty>Medium</difficulty>
        /// <param name="song">The song you wish to save</param>
        bool SaveSong(tblSong song);

        /// <summary>
        /// Creates a connection between a tag and a song
        /// Throws CanNotFindException if tag or song does not exists
        /// </summary>
        /// <remarks>
        /// This function should create a tblTagSong instance. 
        /// Fill in it's properties and save it to the database.
        /// </remarks>
        /// <param name="tagId">The id of the tag you wish to add</param>
        /// <param name="songId">The id of the song you wish to add</param>
        /// <difficulty>Medium</difficulty>
        /// <returns>True if connection exists</returns>
        bool ConnectSongToTag(int tagId, int songId);

        /// <summary>
        /// Creates a connection between a multiple tags and multiple songs
        /// Throws CanNotFindException if tag or song does not exists
        /// </summary>
        /// <remarks>
        /// This function should create a tblTagSong instance for 
        /// every combination between tagids and songids that do not
        /// exist in the database and insert them into the database.
        /// It should also make sure each tagid and songid exists in the database prior to saving any.
        /// </remarks>
        /// <difficulty>Hard</difficulty>
        /// <param name="tagIds">A list of tags</param>
        /// <param name="songIds">A list of songs</param>
        /// <returns>returns true if all connections were made</returns>
        bool ConnectSongsToTags(List<int> tagIds, List<int> songIds);

        /// <summary>
        /// Removes a connections from a song
        /// Throws CanNotFindException if songId does not exists
        /// </summary>
        /// <remarks>
        /// This function should delete tblTagSong's from the database
        /// where tblTagSong.songId = songId and tblTagSong.tagId is one
        /// of the values in tagIdsRemove
        /// </remarks>
        /// <difficulty>Medium</difficulty>
        /// <param name="songId">The song you wish to remove connnections from</param>
        /// <param name="tagIdsToRemove">The tags to remove the connection from</param>
        /// <returns>True if the tags were removed</returns>
        bool RemoveTagsFromSong(int songId, params int[] tagIdsToRemove);

        /// <summary>
        /// Removes connections from a tag
        /// Throws CanNotFindException if tagId does not exists
        /// </summary>
        /// <remarks>
        /// This function should delete tblTagSong's from the database
        /// where tblTagSong.tagId = tagId and tblTagSong.songId is one
        /// of the values in songIdsRemove
        /// </remarks>
        /// <difficulty>Medium</difficulty>
        /// <param name="tagId">The tag you wish to remove connections from</param>
        /// <param name="songIdsToRemove">The songs you want to remove the connections from</param>
        /// <returns>True if the songs were removed</returns>
        bool RemoveSongsFromTag(int tagId, params int[] songIdsToRemove);

        /// <summary>
        /// Inserts or updates a new location to database
        /// Thows Arguement null expection if location is null.
        /// Throws InvalidOperationException if tagid != 0 and is not in the database
        /// </summary>
        /// <remarks>
        /// This function has two branches of logic
        ///     location.LocationID = 0  - Insert into the database
        ///     location.LocationID != 0 - Check to make sure the tblLocation exists in the db.
        ///                                If it does update it's values otherwise 
        ///                                throw InvalidOperationException
        /// </remarks>
        /// <difficulty>Medium</difficulty>
        /// <param name="location">The location you wish to add</param>
        /// <returns>True if saved successfully</returns>
        bool SaveLocation(tblLocation location);

        /// <summary>
        /// Returns a list of all locations
        /// </summary>
        /// <remarks>
        /// Queries the database to return all of the locations.
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <returns>List of locations with count of 0 or more</returns>
        List<tblLocation> GetLocations();
    }
}
