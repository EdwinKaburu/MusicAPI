#pragma checksum "C:\Users\EdwinPc\Downloads\DataBase\MusicAPI\MusicApi\Views\Account\UserAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f95e537651fd46552f80fd064f653e7a08f7b245"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_UserAccount), @"mvc.1.0.view", @"/Views/Account/UserAccount.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/UserAccount.cshtml", typeof(AspNetCore.Views_Account_UserAccount))]
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
#line 1 "C:\Users\EdwinPc\Downloads\DataBase\MusicAPI\MusicApi\Views\_ViewImports.cshtml"
using MusicApi;

#line default
#line hidden
#line 2 "C:\Users\EdwinPc\Downloads\DataBase\MusicAPI\MusicApi\Views\_ViewImports.cshtml"
using MusicApi.Models;

#line default
#line hidden
#line 3 "C:\Users\EdwinPc\Downloads\DataBase\MusicAPI\MusicApi\Views\_ViewImports.cshtml"
using MusicApi.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f95e537651fd46552f80fd064f653e7a08f7b245", @"/Views/Account/UserAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66fd6e91688898acb3c8d2088d5cf09a459845", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_UserAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Album>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\EdwinPc\Downloads\DataBase\MusicAPI\MusicApi\Views\Account\UserAccount.cshtml"
  
    ViewData["Title"] = "UserAccount";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(121, 368, true);
            WriteLiteral(@"<h1>Welcome!!!</h1>
<style>
    .card {
        background: #353535 !important;
        border: 1px solid #f2f2f2;
        color: #ffffff;
    }

    #playIcon:hover {
        color: #1db954;
    }
</style>
<script>
    function returnValue()


</script>

<div class=""grid-container"">
    <div class=""grid-x grid-padding-x small-up-2 medium-up-3"">
");
            EndContext();
#line 26 "C:\Users\EdwinPc\Downloads\DataBase\MusicAPI\MusicApi\Views\Account\UserAccount.cshtml"
         foreach (var item in Model)
        {

            //Byte data for both music and photos
            string imgMusic = string.Format("data:image/gif;base64,{0}", Convert.ToBase64String(item.AlbumPicture.PictureOne));


#line default
#line hidden
            BeginContext(722, 92, true);
            WriteLiteral("            <div class=\"cell\">\r\n                <div class=\"card\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 814, "\"", 829, 1);
#line 34 "C:\Users\EdwinPc\Downloads\DataBase\MusicAPI\MusicApi\Views\Account\UserAccount.cshtml"
WriteAttributeValue("", 820, imgMusic, 820, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(830, 190, true);
            WriteLiteral(" style=\"width:370px !important; height:300px !important;\">\r\n                    <div class=\"card-section\">\r\n                        <div style=\"float:left\">\r\n                            <h5>");
            EndContext();
            BeginContext(1021, 14, false);
#line 37 "C:\Users\EdwinPc\Downloads\DataBase\MusicAPI\MusicApi\Views\Account\UserAccount.cshtml"
                           Write(item.AlbumName);

#line default
#line hidden
            EndContext();
            BeginContext(1035, 41, true);
            WriteLiteral("</h5>\r\n                            <p>By ");
            EndContext();
            BeginContext(1077, 22, false);
#line 38 "C:\Users\EdwinPc\Downloads\DataBase\MusicAPI\MusicApi\Views\Account\UserAccount.cshtml"
                             Write(item.Artist.ArtistName);

#line default
#line hidden
            EndContext();
            BeginContext(1099, 299, true);
            WriteLiteral(@" </p>
                        </div>
                        <div style=""float:right"">
                            <i id=""playIcon"" class=""step fi-play size-72"" style=""font-size:2.5em;""></i>
                        </div>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 46 "C:\Users\EdwinPc\Downloads\DataBase\MusicAPI\MusicApi\Views\Account\UserAccount.cshtml"

        }

#line default
#line hidden
            BeginContext(1411, 40, true);
            WriteLiteral("    </div>\r\n\r\n    <hr />\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Album>> Html { get; private set; }
    }
}
#pragma warning restore 1591
