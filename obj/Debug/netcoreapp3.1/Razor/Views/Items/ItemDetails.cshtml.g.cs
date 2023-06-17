#pragma checksum "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9704114763f0450b513bafd5afa50398719edccc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_ItemDetails), @"mvc.1.0.view", @"/Views/Items/ItemDetails.cshtml")]
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
#nullable restore
#line 1 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\_ViewImports.cshtml"
using Grad_Proj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\_ViewImports.cshtml"
using Grad_Proj.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9704114763f0450b513bafd5afa50398719edccc", @"/Views/Items/ItemDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08b87f1a31db8e213cb24e0dfe670d748e8145c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_ItemDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Grad_Proj.Entites.Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
  
    var realtedItems = _db
                        .Items
                        .Where(x => x.AuthorId == Model.AuthorId)
                        .Include(x => x.Category)
                        .Include(x => x.Author)
                        .Include(x => x.ItemImages)
                        .ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- main content -->
<main class=""main"">
    <div class=""container"">
        <div class=""row row--grid"">
            <!-- breadcrumb -->
            <div class=""col-12"">
                <ul class=""breadcrumb"">
                    <li class=""breadcrumb__item""><a href=""/"">Home</a></li>
                    <li class=""breadcrumb__item""><a href=""javascript:void(0)"">Author</a></li>
                    <li class=""breadcrumb__item breadcrumb__item--active"">Item</li>
                </ul>
            </div>
            <!-- end breadcrumb -->
            <!-- title -->
            <div class=""col-12"">
                <div class=""main__title main__title--page"">
                    <h1>");
#nullable restore
#line 33 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                </div>
            </div>
            <!-- end title -->
        </div>

        <div class=""row"">
            <!-- content -->
            <div class=""col-12 col-xl-8"">
                <div class=""asset__item"">
                    <a class=""asset__img""");
            BeginWriteAttribute("href", " href=\"", 1628, "\"", 1683, 2);
            WriteAttributeValue("", 1635, "/images/", 1635, 8, true);
#nullable restore
#line 43 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
WriteAttributeValue("", 1643, Model.ItemImages.FirstOrDefault().Image, 1643, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9704114763f0450b513bafd5afa50398719edccc6163", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1695, "~/images/", 1695, 9, true);
#nullable restore
#line 43 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
AddHtmlAttributeValue("", 1704, Model.ItemImages.FirstOrDefault().Image, 1704, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                    <!-- likes -->
                    <button class=""asset__likes"" type=""button"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M20.16,5A6.29,6.29,0,0,0,12,4.36a6.27,6.27,0,0,0-8.16,9.48l6.21,6.22a2.78,2.78,0,0,0,3.9,0l6.21-6.22A6.27,6.27,0,0,0,20.16,5Zm-1.41,7.46-6.21,6.21a.76.76,0,0,1-1.08,0L5.25,12.43a4.29,4.29,0,0,1,0-6,4.27,4.27,0,0,1,6,0,1,1,0,0,0,1.42,0,4.27,4.27,0,0,1,6,0A4.29,4.29,0,0,1,18.75,12.43Z""></path></svg>
                        <span>");
#nullable restore
#line 47 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
                         Write(Model.ItemLikes.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </button>
                    <!-- end likes -->
                </div>
            </div>
            <!-- end content -->
            <!-- sidebar -->
            <div class=""col-12 col-xl-4"">
                <div class=""asset__info"">
                    <div class=""asset__desc"">
                        <h2>Descriptions</h2>
                        <p>");
#nullable restore
#line 58 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>

                    <ul class=""asset__authors"">
                        <li>
                            <span>Creator</span>
                            <div class=""asset__author asset__author--verified"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9704114763f0450b513bafd5afa50398719edccc9513", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3008, "~/images/", 3008, 9, true);
#nullable restore
#line 65 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
AddHtmlAttributeValue("", 3017, Model.Author.Image, 3017, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3081, "\"", 3168, 2);
            WriteAttributeValue("", 3088, "/Author/AuthorDetials?id=", 3088, 25, true);
#nullable restore
#line 66 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
WriteAttributeValue("", 3113, HttpContextAccessor.HttpContext.Session.GetInt32("Id"), 3113, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 66 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
                                                                                                                       Write(HttpContextAccessor.HttpContext.Session.GetInt32("NickName"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </div>
                        </li>
                    </ul>




                    <!-- actions -->
                    <!--<div class=""asset__btns"">
                        <a href=""#modal-bid"" class=""asset__btn asset__btn--full asset__btn--clr open-modal"">Place a bid</a>
                    </div>-->
                    <!-- end actions -->
                </div>
            </div>
            <!-- end sidebar -->
        </div>

        <!-- explore -->
        <section class=""row row--grid"">
            <!-- title -->
            <div class=""col-12"">
                <div class=""main__title main__title--border-top"">
                    <h2><a href=""explore.html"">Other author assets</a></h2>
                </div>
            </div>
            <!-- end title -->
            <!-- carousel -->
            <div class=""col-12"">
                <div class=""main__carousel-wrap"">
                    <div class=""main__carousel main__carousel--explo");
            WriteLiteral("re owl-carousel\" id=\"explore\">\r\n\r\n");
#nullable restore
#line 98 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
                         foreach (var item in realtedItems)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card\">\r\n                                <div class=\"card__cover card__cover--carousel owl-carousel\">\r\n");
#nullable restore
#line 102 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
                                     foreach (var image in item.ItemImages)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9704114763f0450b513bafd5afa50398719edccc13966", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4686, "~/images/", 4686, 9, true);
#nullable restore
#line 104 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
AddHtmlAttributeValue("", 4695, image.Image, 4695, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 105 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <h3 class=\"card__title\"><a href=\"javascript:void(0)\">");
#nullable restore
#line 107 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
                                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <div class=\"card__author card__author--verified\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9704114763f0450b513bafd5afa50398719edccc16369", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5033, "~/images/", 5033, 9, true);
#nullable restore
#line 109 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
AddHtmlAttributeValue("", 5042, item.Author.Image, 5042, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5109, "\"", 5141, 2);
            WriteAttributeValue("", 5116, "/Items/Create?id=", 5116, 17, true);
#nullable restore
#line 110 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
WriteAttributeValue("", 5133, item.Id, 5133, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 110 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
                                                                    Write(item.Author.NickName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                </div>
                                <div class=""card__info"">
                                    <div class=""card__price"">
                                        <span>Reserve price</span>
                                        <span>");
#nullable restore
#line 115 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                    <button class=""card__likes"" type=""button"">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M20.16,5A6.29,6.29,0,0,0,12,4.36a6.27,6.27,0,0,0-8.16,9.48l6.21,6.22a2.78,2.78,0,0,0,3.9,0l6.21-6.22A6.27,6.27,0,0,0,20.16,5Zm-1.41,7.46-6.21,6.21a.76.76,0,0,1-1.08,0L5.25,12.43a4.29,4.29,0,0,1,0-6,4.27,4.27,0,0,1,6,0,1,1,0,0,0,1.42,0,4.27,4.27,0,0,1,6,0A4.29,4.29,0,0,1,18.75,12.43Z"" /></svg>
                                        <span></span>
                                    </button>
                                </div>
                            </div>
");
#nullable restore
#line 123 "C:\Users\nader\Desktop\Grad_Proj-20210713T121444Z-001\Grad_Proj\Views\Items\ItemDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>

                    <button class=""main__nav main__nav--prev"" data-nav=""#explore"" type=""button""><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M17,11H9.41l3.3-3.29a1,1,0,1,0-1.42-1.42l-5,5a1,1,0,0,0-.21.33,1,1,0,0,0,0,.76,1,1,0,0,0,.21.33l5,5a1,1,0,0,0,1.42,0,1,1,0,0,0,0-1.42L9.41,13H17a1,1,0,0,0,0-2Z"" /></svg></button>
                    <button class=""main__nav main__nav--next"" data-nav=""#explore"" type=""button""><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M17.92,11.62a1,1,0,0,0-.21-.33l-5-5a1,1,0,0,0-1.42,1.42L14.59,11H7a1,1,0,0,0,0,2h7.59l-3.3,3.29a1,1,0,0,0,0,1.42,1,1,0,0,0,1.42,0l5-5a1,1,0,0,0,.21-.33A1,1,0,0,0,17.92,11.62Z"" /></svg></button>
                </div>
            </div>
            <!-- end carousel -->
        </section>
        <!-- end explore -->
    </div>
</main>
<!-- end main content -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Grad_Proj.Infrastructure.ThemesShopDbContext _db { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Core.Interfaces.IUnitOfWork<Grad_Proj.Entites.Item> _items { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Grad_Proj.Entites.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591