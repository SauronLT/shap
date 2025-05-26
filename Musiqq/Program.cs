using Musiqq.Services;

namespace Musiqq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var songService = new SongService();
            var playlistService = new PlaylistService();
        }
    }
}
