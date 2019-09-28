using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApi.Infrastructure;
using MusicApi.Models;

namespace MusicApi.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepo repo;

        public HomeController(IProductRepo repository)
        {
            repo = repository;
        }
        public async Task<ActionResult> Index()
        {
            // return View(repo.Albums.Include(p => p.AlbumPicture).Include(a => a.Artist).Include(s => s.TblSong));
            // var albums = await repo.Albums;

            //await repo.Albums.Include(p => p.AlbumPicture).Include(a => a.Artist).Include(s => s.TblSong);


            //var albums = repo.Albums.Include(p => p.AlbumPicture).Include(a => a.Artist).Include(s => s.TblSong);

            //var songsData = repo.Songs.Include(s => s.SongData);

            //await Task.WhenAll(this.repo.)


            var model = new ListView
            {
                GetAlbums = repo.Albums.Include(p => p.AlbumPicture).Include(a => a.Artist).Include(s => s.TblSong),
                Songs = repo.Songs.Include(s => s.SongData)
            };



            return View(model); // View(model);
        }

        //[HttpGet()]
        //public ActionResult LoadData([FromQuery(Name = "albumName")] string albumName)
        //{
        //    Response.Cookies.Append("AlbumName", albumName);

        //    return View(repo.Songs.Include(s => s.SongData).Where(name => name.Album.AlbumName.Equals(albumName)));
        //}
        [HttpGet()]
        public ActionResult GetAlbumsViews([FromQuery(Name = "playlistID")] string albumName)
        {
            Response.Cookies.Append("AlbumName", albumName);
            return View(repo.Songs.Include(s => s.SongData).Where(name => name.Album.AlbumName.Equals(albumName)));
                     
        }



        public ViewResult UserPlaylistCreate()
        {
            //UserPlaylist playlist = new UserPlaylist();
            
            //ViewData["UserIDs"] = Request.Cookies["UserID"];
            //ViewBag.userIDs = Request.Cookies["UserID"];

            //foreach(var item in repo.UserPlaylists)
            //{
            //    if(item.UserId.Equals())
            //}
            //int userIDs = int.Parse(ViewBag.userIDs);
            return View(new ListView
            {
                UserPlaylists = repo.UserPlaylists.Where(a => a.UserId.Equals(int.Parse(Request.Cookies["UserID"])))
            });
            //return View();
        }

        [HttpGet()]
        public ViewResult GetSongsView([FromQuery(Name = "com")] string albumName)
        {
            Response.Cookies.Append("AlbumName", albumName);
            IEnumerable<Song> songs = repo.Songs.Include(s => s.SongData).Include(a => a.Album).Include(apic => apic.Album.AlbumPicture).Include(art => art.Album.Artist).Where(name => name.Album.AlbumName.Equals(albumName));
            songs = songs.OrderBy(song => song.TrackNum);
            return View(new ListView
            {
                Songs = songs,
                UserPlaylists = repo.UserPlaylists
            });
        }

        [HttpGet()]
        public async Task<IActionResult> AddSongItem([FromQuery(Name = "playlistID")] string playlistID, [FromQuery(Name = "songName")] string songID)
        {
            PlaylistItem playlistItem = new PlaylistItem
            {
                PlaylistId = Int16.Parse(playlistID),
                SongId = Int16.Parse(songID)
            };

            bool result = await repo.CreatePlayListItem(playlistItem);

            if (result)
            {
                if(Request.Cookies["AlbumName"].Equals(null))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("GetSongsView", new { com = Request.Cookies["AlbumName"] });
                }
              
            }
            else
            {
                ViewData["Error"] = "There was an Error";
            }
            return View("Index");

        }

        [HttpPost]
        public async Task<IActionResult> UserPlaylistCreate(ListView userPlaylist)
        {
            // Request.Cookies.
            // PlaylistId = context.TblUserPlaylist.Count() +1,
            if (ModelState.IsValid)
            {
                UserPlaylist playlist = new UserPlaylist
                {

                    PlaylistName = userPlaylist.GetPlaylist.PlaylistName,
                    PlaylistDesc = userPlaylist.GetPlaylist.PlaylistDesc,
                    UserId = Convert.ToInt32(Request.Cookies["UserID"])

                };
             //   string id = Request.Cookies["UserName"];

                //playlist.UserId = 1;

                bool result = await repo.CreateUserPlaylist(playlist);
                if (result)
                {
                    //return View("Index");
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "An error occured while creating the UserPlaylist");
                }
            }
            return View(userPlaylist);
        }

        public ActionResult Testing()
        {
            return View();
        }
    }
}