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

        public Song(tblSong song)
        {

        }
        public Song(string name, string path, int LocationID)
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
