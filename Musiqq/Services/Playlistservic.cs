using Musiqq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musiqq.Services
{
    public class PlaylistService
    {
        private readonly List<Playlist> playlists = new();
        private int idCounter = 1;

        public Playlist Create(Playlist playlist)
        {
            playlist.Id = idCounter++;
            playlists.Add(playlist);
            return playlist;
        }

        public List<Playlist> GetAll() => playlists;

        public Playlist GetById(int id) => playlists.FirstOrDefault(p => p.Id == id);

        public bool Update(int id, Playlist updatedPlaylist)
        {
            var playlist = GetById(id);
            if (playlist == null) return false;

            playlist.PlaylistName = updatedPlaylist.PlaylistName;
            playlist.Songs = updatedPlaylist.Songs;
            return true;
        }

        public bool Delete(int id)
        {
            var playlist = GetById(id);
            if (playlist == null) return false;
            return playlists.Remove(playlist);
        }

       
    }
}
