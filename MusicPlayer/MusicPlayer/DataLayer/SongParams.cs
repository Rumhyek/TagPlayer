using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    public class SongParams
    {
        /// <summary>
        /// A list of song ids to filter by. If null then ignore
        /// </summary>
        public List<tblSong> SongIds { get; set; }
        
        /// <summary>
        /// A list of tag ids to filter by. If null then ignore
        /// </summary>
        public List<int> ByTagIds { get; set; }

        /// <summary>
        /// A list of song names to filter by. If null then ignore
        /// </summary>
        public List<string> SongNames { get; set; }

        /// <summary>
        /// Adds song ids to filter by to SongIds
        /// </summary>
        /// <remarks>
        /// This funciton should make sure SongIds exists. If it doesnt
        /// it should instansiate SongIds
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <param name="songIds">The songs</param>
        public void AddSongIds(params int[] songIds)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds tag ids to filter by to ByTagIds
        /// </summary>
        /// <remarks>
        /// This function should make sure ByTagIds exists. If it doesnt
        /// instansiate ByTagIds
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <param name="tagIds">The tag ids to add</param>
        public void AddTagIds(params int[] tagIds)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds tag names to filter by to SongNames
        /// </summary>
        /// <remarks>
        /// This funciton should make sure SongNames exists. If it doesnt
        /// it should instansiate SongNames
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <param name="songNames">The song names to add</param>
        public void AddSongNames(params string[] songNames)
        {
            throw new NotImplementedException();
        }
    }
}
