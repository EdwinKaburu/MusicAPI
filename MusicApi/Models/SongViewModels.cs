using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MusicApi.Models
{
    public class CreateSongModel
    {
        [Required]
        [Display(Name = "Song Name")]
        public string SongName { get; set; }
        [Required]
        [Display(Name ="Track Number")]
        public int TrackNum { get; set; }
        [Required]
        [Display(Name = "Album")]
        public int AlbumId { get; set; }
        [Required]
        [Display(Name = "Song File")]
        public IFormFile SongData { get; set; }
        [Display(Name = "Video Link")]
        [RegularExpression(@"^(https|http):\/\/(?:www\.)?youtube.com\/embed\/[A-z0-9]+", ErrorMessage = "Video Link must be an embeded Youtube link.")]
        public string VideoLink { get; set; }
    }
}
