#pragma checksum "C:\Users\aliye\source\repos\Code\Views\Home\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "299453f65950814eb04d2d7a2a173c3178675654"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_News), @"mvc.1.0.view", @"/Views/Home/News.cshtml")]
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
#line 1 "C:\Users\aliye\source\repos\Code\Views\_ViewImports.cshtml"
using Code.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aliye\source\repos\Code\Views\_ViewImports.cshtml"
using Code.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"299453f65950814eb04d2d7a2a173c3178675654", @"/Views/Home/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce14d28d6da9ac89ac700530ce87797bc8c0ee83", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Report>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("pr-sample13"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailNews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\aliye\source\repos\Code\Views\Home\News.cshtml"
  
    ViewData["Title"] = "News";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"custom_container\">\r\n");
#nullable restore
#line 9 "C:\Users\aliye\source\repos\Code\Views\Home\News.cshtml"
         foreach (Report news in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <figure class=\"snip1529\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "299453f65950814eb04d2d7a2a173c31786756544686", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 295, "~/img/", 295, 6, true);
#nullable restore
#line 12 "C:\Users\aliye\source\repos\Code\Views\Home\News.cshtml"
AddHtmlAttributeValue("", 301, news.Image, 301, 11, false);

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
            WriteLiteral("\r\n                <div class=\"date\"><span class=\"day\">");
#nullable restore
#line 13 "C:\Users\aliye\source\repos\Code\Views\Home\News.cshtml"
                                               Write(news.ArticleDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                <figcaption>\r\n                    <h3>");
#nullable restore
#line 15 "C:\Users\aliye\source\repos\Code\Views\Home\News.cshtml"
                   Write(news.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("                </figcaption>\r\n                <div class=\"hover\"><i class=\"ion-android-open\"></i></div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "299453f65950814eb04d2d7a2a173c31786756546963", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\aliye\source\repos\Code\Views\Home\News.cshtml"
                                                                   WriteLiteral(news.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </figure>\r\n");
#nullable restore
#line 21 "C:\Users\aliye\source\repos\Code\Views\Home\News.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <div class=""shopify-footer-section-stockits"">
        <a href=""#"" class=""article__grid-image"">
            <div class=""image-wrap"" style=""height: 0; padding-bottom: 25.142857142857146%;"">
                <img class=""lazyautosizes lazyloaded"" data-widths=""[180, 360, 540, 720, 900, 1080]""
                     data-aspectratio=""3.977272727272727"" data-sizes=""auto""");
            BeginWriteAttribute("alt", " alt=\"", 1159, "\"", 1165, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                     data-srcset=""//cdn.shopify.com/s/files/1/0206/6982/5088/files/FINDUS-INSTORE_01-3_180x.png?v=1581430862 180w, //cdn.shopify.com/s/files/1/0206/6982/5088/files/FINDUS-INSTORE_01-3_360x.png?v=1581430862 360w, //cdn.shopify.com/s/files/1/0206/6982/5088/files/FINDUS-INSTORE_01-3_540x.png?v=1581430862 540w, //cdn.shopify.com/s/files/1/0206/6982/5088/files/FINDUS-INSTORE_01-3_720x.png?v=1581430862 720w, //cdn.shopify.com/s/files/1/0206/6982/5088/files/FINDUS-INSTORE_01-3_900x.png?v=1581430862 900w, //cdn.shopify.com/s/files/1/0206/6982/5088/files/FINDUS-INSTORE_01-3_1080x.png?v=1581430862 1080w""
                     sizes=""699px""
                     srcset=""//cdn.shopify.com/s/files/1/0206/6982/5088/files/FINDUS-INSTORE_01-3_180x.png?v=1581430862 180w, //cdn.shopify.com/s/files/1/0206/6982/5088/files/FINDUS-INSTORE_01-3_360x.png?v=1581430862 360w, //cdn.shopify.com/s/files/1/0206/6982/5088/files/FINDUS-INSTORE_01-3_540x.png?v=1581430862 540w, //cdn.shopify.com/s/files/1/0206/6982/5088/file");
            WriteLiteral(@"s/FINDUS-INSTORE_01-3_720x.png?v=1581430862 720w, //cdn.shopify.com/s/files/1/0206/6982/5088/files/FINDUS-INSTORE_01-3_900x.png?v=1581430862 900w, //cdn.shopify.com/s/files/1/0206/6982/5088/files/FINDUS-INSTORE_01-3_1080x.png?v=1581430862 1080w"">
                <noscript>
                    <img class=""lazyloaded""
                         src=""//cdn.shopify.com/s/files/1/0206/6982/5088/files/FINDUS-INSTORE_01-3_400x.png?v=1581430862""
                         alt=""&lt;center&gt;HARDCORE STOCKISTS&lt;/center&gt;"">
                </noscript>
            </div>
        </a>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Report>> Html { get; private set; }
    }
}
#pragma warning restore 1591