using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    public class TagParams
    {
        /// <summary>
        /// A list of tag ids to filter by. If null then ignore
        /// </summary>
        public List<int> TagIds { get; set; }
        
        /// <summary>
        /// A list of song ids to filter by. If null then ignore
        /// </summary>
        public List<int> BySongIds { get; set; }
        
        /// <summary>
        /// A list of tag names to filter by. If null then ignore
        /// </summary>
        public List<string> TagNames { get; set; }

        /// <summary>
        /// Adds tag ids to TagIds
        /// </summary>
        /// <remarks>
        /// This funciton should make sure TagIds exists. If it doesnt
        /// it should instansiate TagIds
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <param name="input">The tags</param>
        public void AddTagIds(params int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                bool hasValue = false;
                for (int j = 0; j < TagIds.Count; j++)
                {
                    if (TagIds[j]==input[i])

                    {
                        hasValue = true;
                    }
                }
                if (hasValue == false)
                    TagIds.Add(input[i]);

            }
        }

        /// <summary>
        /// Adds song ids to filter by to BySongIds
        /// </summary>
        /// <remarks>
        /// This function should make sure BySongIds exists. If it doesnt
        /// instansiate BySongIds
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <param name="songIds">The song ids to add</param>
        public void AddSongIds(params int[] songIds)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds tag names to filter by to TagNames
        /// </summary>
        /// <remarks>
        /// This funciton should make sure TagNames exists. If it doesnt
        /// it should instansiate TagNames
        /// </remarks>
        /// <difficulty>Easy</difficulty>
        /// <param name="tagNames">The tag names to add</param>
        public void AddTagNames(params string[] tagNames)
        {
            throw new NotImplementedException();
        }
    }
}
