#pragma checksum "C:\Hossein\Packages\.NetCoreMvcApi\examples\Razor_Blog\Razor_Blog\Pages\ArticleDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d38cefc35f786e1ce2ff5608b93ab09570bfca31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Razor_Blog.Pages.Pages_ArticleDetails), @"mvc.1.0.razor-page", @"/Pages/ArticleDetails.cshtml")]
namespace Razor_Blog.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Hossein\Packages\.NetCoreMvcApi\examples\Razor_Blog\Razor_Blog\Pages\_ViewImports.cshtml"
using Razor_Blog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d38cefc35f786e1ce2ff5608b93ab09570bfca31", @"/Pages/ArticleDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bae798a29d0bafe887fe070a5a24f28dc658652", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ArticleDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-12 mb-3\">\r\n    <h1>");
#nullable restore
#line 7 "C:\Hossein\Packages\.NetCoreMvcApi\examples\Razor_Blog\Razor_Blog\Pages\ArticleDetails.cshtml"
   Write(Model.Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<div class=\"col-12 mb-3\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 177, "\"", 205, 1);
#nullable restore
#line 10 "C:\Hossein\Packages\.NetCoreMvcApi\examples\Razor_Blog\Razor_Blog\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 183, Model.Article.Picture, 183, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 206, "\"", 237, 1);
#nullable restore
#line 10 "C:\Hossein\Packages\.NetCoreMvcApi\examples\Razor_Blog\Razor_Blog\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 212, Model.Article.PictureAlt, 212, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 238, "\"", 273, 1);
#nullable restore
#line 10 "C:\Hossein\Packages\.NetCoreMvcApi\examples\Razor_Blog\Razor_Blog\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 246, Model.Article.PictureTitle, 246, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n</div>\r\n<div class=\"col-12\">\r\n    <p class=\"article-content\">\r\n        ");
#nullable restore
#line 14 "C:\Hossein\Packages\.NetCoreMvcApi\examples\Razor_Blog\Razor_Blog\Pages\ArticleDetails.cshtml"
   Write(Model.Article.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Razor_Blog.Pages.ArticleDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Razor_Blog.Pages.ArticleDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Razor_Blog.Pages.ArticleDetailsModel>)PageContext?.ViewData;
        public Razor_Blog.Pages.ArticleDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
