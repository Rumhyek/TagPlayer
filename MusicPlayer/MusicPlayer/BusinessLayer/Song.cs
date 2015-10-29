using MusicPlayer.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.BusinessLayer
{
    public class Song
    {
        public int SongID { get; set; }
        public string Name { get; set; }
        public string RelativePath { get; set; }
        public int LocationID { get; set; }
        public DateTime DateAdded { get; set; }

        private Song(tblSong song)
        {

        }

        /// <summary>
        /// For creating a new song
        /// </summary>
        /// <param name="name">The name of the song</param>
        /// <param name="path">The path of the song</param>
        /// <param name="LocationID">The location that this song belongs to</param>
        public Song(string name, string path, int LocationID)
        {

        }

        public static Song GetSong(int songId)
        {
            throw new NotImplementedException();
        }
        
        public static List<Song> GetSongs(SongParams song)
        {

        }

        public SongData GetSongData()
        {
            throw new NotImplementedException();
        }

        public List<Tag> GetTags()
        {
            throw new NotImplementedException();
        }

        public bool IncludeThisSong(List<Tag> selectedTags)
        {
            throw new NotImplementedException();
        }

        public bool AddTag(Tag tag)
        {
            throw new NotImplementedException();
        }

        public bool AddTag(int tagID)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTag(Tag tag)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTag(int tagID)
        {
            throw new NotImplementedException();
        }

        public bool IsSongPlayable()
        {
            throw new NotImplementedException();
        }

        public bool SaveSong()
        {
            throw new NotImplementedException();
        }
    }
}
