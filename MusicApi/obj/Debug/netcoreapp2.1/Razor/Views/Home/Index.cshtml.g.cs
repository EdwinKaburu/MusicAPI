#pragma checksum "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abbd3b9a7d9cf41d74b5fcdbcc5668000935b460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\_ViewImports.cshtml"
using MusicApi;

#line default
#line hidden
#line 2 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\_ViewImports.cshtml"
using MusicApi.Models;

#line default
#line hidden
#line 3 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\_ViewImports.cshtml"
using MusicApi.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abbd3b9a7d9cf41d74b5fcdbcc5668000935b460", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66fd6e91688898acb3c8d2088d5cf09a459845", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";



#line default
#line hidden
            BeginContext(140, 292, true);
            WriteLiteral(@"<style>
    .card {
        background: #353535 !important;
        border: 1px solid #f2f2f2;
        color: #ffffff;
    }

    #playIcon:hover {
        color: #1db954;
    }
</style>
<div class=""grid-container"">
    <div class=""grid-x grid-padding-x small-up-2 medium-up-3"">
");
            EndContext();
#line 22 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
          
            int count = 0;

            foreach (var item in Model.GetAlbums)
            {

                //Byte data for both music and photos
                string imgMusic = string.Format("data:image/gif;base64,{0}", Convert.ToBase64String(item.AlbumPicture.PictureOne));

                string albumsName = item.AlbumName.Trim();

#line default
#line hidden
            BeginContext(792, 104, true);
            WriteLiteral("                <div class=\"cell\">\r\n                    <div class=\"card\">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 896, "\"", 911, 1);
#line 34 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 902, imgMusic, 902, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 912, "\"", 1011, 3);
            WriteAttributeValue("", 922, "location.href=\'", 922, 15, true);
#line 34 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 937, Url.Action("GetSongsView","Home", new { com = item.AlbumName.Trim() }), 937, 73, false);

#line default
#line hidden
            WriteAttributeValue("", 1010, "\'", 1010, 1, true);
            EndWriteAttribute();
            BeginContext(1012, 204, true);
            WriteLiteral(" style=\"width:370px !important; height:300px !important;\">\r\n                        <div class=\"card-section\">\r\n\r\n                            <div style=\"float:left\">\r\n                                <h5>");
            EndContext();
            BeginContext(1217, 14, false);
#line 38 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
                               Write(item.AlbumName);

#line default
#line hidden
            EndContext();
            BeginContext(1231, 45, true);
            WriteLiteral("</h5>\r\n                                <p>By ");
            EndContext();
            BeginContext(1277, 22, false);
#line 39 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
                                 Write(item.Artist.ArtistName);

#line default
#line hidden
            EndContext();
            BeginContext(1299, 183, true);
            WriteLiteral(" </p>\r\n                               \r\n                            </div>\r\n                            <div class=\"player2\" style=\"float:right\">\r\n                                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1482, "\"", 1521, 1);
#line 43 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 1490, string.Format("player"+ count), 1490, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1522, 41, true);
            WriteLiteral(">\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1563, "\"", 1602, 1);
#line 44 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 1568, string.Format("swapImage"+ count), 1568, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1603, "\"", 1626, 1);
#line 44 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 1611, item.AlbumName, 1611, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1627, 137, true);
            WriteLiteral(" class=\"step fi-play size-72\" style=\"font-size:2.5em;\"></a>\r\n                                </div>\r\n                                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1764, "\"", 1805, 1);
#line 46 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 1772, string.Format("playlist"+ count), 1772, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1806, 5, true);
            WriteLiteral(">\r\n\r\n");
            EndContext();
#line 48 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
                                     foreach (var song in Model.Songs)
                                    {
                                        if (song.AlbumId.Equals(item.AlbumId))
                                        {


#line default
#line hidden
            BeginContext(2047, 48, true);
            WriteLiteral("                                            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2095, "\"", 2132, 1);
#line 53 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 2103, string.Format("song"+ count), 2103, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("url", " url=\"", 2133, "\"", 2227, 1);
#line 53 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 2139, string.Format("data:audio/mpeg;base64,{0}", Convert.ToBase64String(song.SongData.Data)), 2139, 88, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2228, 55, true);
            WriteLiteral(">\r\n                                            </div>\r\n");
            EndContext();
#line 55 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
                                        }

                                    }

#line default
#line hidden
            BeginContext(2367, 162, true);
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 64 "C:\Users\EdwinPc\Downloads\API\MusicAPI\MusicApi\Views\Home\Index.cshtml"
                count++;
            }
        

#line default
#line hidden
            BeginContext(2581, 3602, true);
            WriteLiteral(@"
    </div>
    <hr />

</div>
<script type=""text/javascript"">

    $(document).ready(function () {

        function hasClass(element, cls) {
            return (' ' + element.className + ' ').indexOf(' ' + cls + ' ') > -1;
        }

        var audios = [];
        var count = 2;

        var musicTracker = 'noMusic';

        $('#swapImage0').click(function (e) {

            if (musicTracker == 'noMusic' && count == 2) {
                audios = [];

                $("".song0"").each(function () {
                    var load = new Audio($(this).attr(""url""));
                    load.load();
                    load.addEventListener('ended', function () {
                        forward();
                    });
                    audios.push(load);
                });

            }
            playPause();

        });


        // Use  Variable to Check which song is playing in order to be dynamic
        $('#swapImage1').click(function (e) {


            if");
            WriteLiteral(@" (musicTracker == 'noMusic' && count ==2) {

                audios = [];
                $("".song1"").each(function () {
                    var load = new Audio($(this).attr(""url""));
                    load.load();
                    load.addEventListener('ended', function () {
                        forward();
                    });
                    audios.push(load);
                });

            }
            playPause();

        });

        $('#swapImage2').click(function (e) {


            if (musicTracker == 'noMusic' && count == 2) {

                audios = [];
                $("".song2"").each(function () {
                    var load = new Audio($(this).attr(""url""));
                    load.load();
                    load.addEventListener('ended', function () {
                        forward();
                    });
                    audios.push(load);
                });

            }
            playPause();

        });


        var im");
            WriteLiteral(@"ageTracker = 'playImage';


        var activeTrack = 0;


        var playPause = function () {
            if (musicTracker == 'noMusic') {

                count = 0;
                audios[activeTrack].play();

               // count = 0;
                console.log('playing');
                musicTracker = 'playMusic';

            } else {
                count = 2;
                audios[activeTrack].pause();

                //audios[activeTrack].currentTime = 0;

                //audios = [];
                //count = 2;
                console.log('paused');

                musicTracker = 'noMusic';
            }
            showPlaying();
        };
        var forward = function () {
            function increment() {
                if (activeTrack < audios.length - 1)
                    activeTrack++;
                else activeTrack = 0;


            }
            if (musicTracker == 'playMusic') {
                audios[activeTrack].pause();


  ");
            WriteLiteral(@"              //audios[activeTrack].currentTime = 0;
                increment();
                audios[activeTrack].play();
            } else {
                increment();
            }
            showPlaying();
        };
        var showPlaying = function () {
            var src = audios[activeTrack].src;
            $("".song13"").removeClass(""playing"");
            $(""div[url='"" + src + ""']"").addClass(""playing"");
            console.log($(""div[url='"" + src + ""']""));
        };
    });


</script>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListView> Html { get; private set; }
    }
}
#pragma warning restore 1591
