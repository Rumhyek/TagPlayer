using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataLayer
{
    public class DataContext : IDataLayer, IDisposable
    {
        private SQLiteConnection Context { get; set; }

        /// <summary>
        /// Call to create an instance of the DataContext. Will create the database if it doesnt exists
        /// </summary>
        public DataContext()
        {
            var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");

            //check to see if it exists
            if(File.Exists(path) == false)
                //create file
                SetupDatabase(path);
            else
                Context = new SQLiteConnection(new SQLitePlatformWinRT(), path);
        }

        /// <summary>
        /// Privately called to create the database for the first time
        /// </summary>
        /// <param name="path"></param>
        private void SetupDatabase(string path)
        {
            SQLiteConnection conn = new SQLiteConnection(new SQLitePlatformWinRT(), path);
            
            conn.CreateTable<tblTag>();
            conn.CreateTable<tblLocation>();
            conn.CreateTable<tblSong>();
            conn.CreateTable<tblSongTag>();
            conn.CreateTable<tblTagType>();
            Context = conn;
        }
        
        /// <summary>
        /// Call to dispose of this connection
        /// </summary>
        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
        }

        //Refer to MusicPlayer.DataLayer.IDataLayer implementation requirements
        #region IDataLayer

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
