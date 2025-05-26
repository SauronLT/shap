using Musiqq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musiqq.Services
{
    public class SongService
    {
        private readonly List<Song> songs = new();
        private int idCounter = 1;

        public Song Create(Song song)
        {
            song.Id = idCounter++;
            songs.Add(song);
            return song;
        }

        public List<Song> GetAll() => songs;

        public Song GetById(int id) => songs.FirstOrDefault(s => s.Id == id);

        public bool Update(int id, Song updatedSong)
        {
            var song = GetById(id);
            

            song.SongName = updatedSong.SongName;
            song.ArtistName = updatedSong.ArtistName;
            song.Genre = updatedSong.Genre;
            song.Duration = updatedSong.Duration;
            return true;
        }

        public bool Delete(int id)
        {
            var song = GetById(id);
           
            return songs.Remove(song);
        }
    }
}
