#pragma checksum "C:\learningDotNet\firstWebApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "163c4425a64bdef8e4a5ce5a78459f5dea93e285"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(firstWebApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace firstWebApp.Pages
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
#line 1 "C:\learningDotNet\firstWebApp\Pages\_ViewImports.cshtml"
using firstWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163c4425a64bdef8e4a5ce5a78459f5dea93e285", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b61595a94114f5349a6ddcea84f13a2e6829e4b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\learningDotNet\firstWebApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Learning ASP.Net";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Learning ASP.NET</h1>\r\n    <p>The time on the server is ");
#nullable restore
#line 9 "C:\learningDotNet\firstWebApp\Pages\Index.cshtml"
                            Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"card-columns\">\r\n");
#nullable restore
#line 13 "C:\learningDotNet\firstWebApp\Pages\Index.cshtml"
     foreach (var product in Model.Products)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-img\"");
            BeginWriteAttribute("style", " \r\n            style=\"", 370, "\"", 431, 3);
            WriteAttributeValue("", 392, "background-image:url(\'", 392, 22, true);
#nullable restore
#line 18 "C:\learningDotNet\firstWebApp\Pages\Index.cshtml"
WriteAttributeValue("", 414, product.Image, 414, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 428, "\');", 428, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div class=\"card-body\">                \r\n                <div class=\"card-title\">\r\n                    <h3>");
#nullable restore
#line 21 "C:\learningDotNet\firstWebApp\Pages\Index.cshtml"
                   Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>    \r\n                    <p>");
#nullable restore
#line 22 "C:\learningDotNet\firstWebApp\Pages\Index.cshtml"
                  Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <i>");
#nullable restore
#line 23 "C:\learningDotNet\firstWebApp\Pages\Index.cshtml"
                  Write(product.Maker);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\learningDotNet\firstWebApp\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
