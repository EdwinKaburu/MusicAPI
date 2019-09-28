using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MusicApi.Infrastructure;
using Microsoft.AspNetCore.Identity;

namespace MusicApi.Models
{
    public class EFProductRepository : IProductRepo
    {
        public MusicAPIsContext context;
        public EFProductRepository(MusicAPIsContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Album> Albums
        {
            get
            {
                Task<IQueryable<Album>> albums = Task.Factory.StartNew<IQueryable<Album>>(() =>
                {                    
                    return context.TblAlbum;
                });

                return albums.Result;
            }
        } //=> context.TblAlbum;

        public IQueryable<Artist> Artists => context.TblArtist;

        public IQueryable<GenreCategory> Genres => context.TblGenreCategory;

        public IQueryable<AlbumPicture> AlbumPictures => context.TblAlbumPicture;

        public IQueryable<ArtistPicture> ArtistPictures => context.TblArtistPicture;

        public IQueryable<User> Users => context.TblUser;

        public IQueryable<Song> Songs => context.TblSong;

        public IQueryable<SongData> SongDatas
        {
            get
            {
                Task<IQueryable<SongData>> songDatas = Task.Factory.StartNew<IQueryable<SongData>>(() =>
                {
                    return context.TblSongData;
                });

                return songDatas.Result;
            }
        } //=> context.TblSongData;

        //public Task<IQueryable<SongData>> SongDatas
        //{
        //    get { return context.TblSongData.ToAsyncEnumerable() }
        //}

        public IQueryable<UserPlaylist> UserPlaylists
        {
            get { return context.TblUserPlaylist; }
        }

        public async Task<bool> CreateUserPlaylist(UserPlaylist playlist)
        {
            context.Add(playlist);

            await context.SaveChangesAsync();

            return await Task.FromResult(true);
            //await conte
            //throw new NotImplementedException();
        }

        public async Task<bool> CreatePlayListItem(PlaylistItem playlistItem)
        {
            context.Add(playlistItem);

            await context.SaveChangesAsync();

            return await Task.FromResult(true);
        }
        public async Task<bool> CreateArtistPicAsync(ArtistPicture artistPic)
        {
            context.Add(artistPic);

            await context.SaveChangesAsync();
            return await Task.FromResult(true);
        }

        public async Task<bool> CreateArtistAsync(Artist artist)
        {
            context.Add(artist);

            await context.SaveChangesAsync();
            return await Task.FromResult(true);
        }

        public async Task<bool> CreateAlbumPicAsync(AlbumPicture albumPic)
        {
            context.Add(albumPic);

            await context.SaveChangesAsync();
            return await Task.FromResult(true);
        }

        public async Task<bool> CreateAlbumAsync(Album album)
        {
            context.Add(album);

            await context.SaveChangesAsync();
            return await Task.FromResult(true);
        }

        public async Task<bool> CreateSongAsync(Song song)
        {
            context.Add(song);

            await context.SaveChangesAsync();
            return await Task.FromResult(true);
        }

        public async Task<bool> CreateSongDataAsync(SongData songData)
        {
            context.Add(songData);

            await context.SaveChangesAsync();
            return await Task.FromResult(true);
        }
    }
}
