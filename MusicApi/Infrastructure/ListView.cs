﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicApi.Models;

namespace MusicApi.Infrastructure
{
    public class ListView
    {
        //public IEnumerable<Album> _albums { get; }
        //public IEnumerable<AlbumPicture> _albumPictures { get; }

        public IEnumerable<Song> Songs { get; set; }

        public IEnumerable<UserPlaylist> UserPlaylists { get; set; }

        public UserPlaylist GetPlaylist { get; set; }

        public IEnumerable<Album> GetAlbums { get; set; }

        public IEnumerable<AlbumPicture> GetAlbumPictures { get; set; }

        public Task<IEnumerable<Album>> AlbumsAsync { get; set; }
    }
}
