#pragma checksum "C:\Users\atul.sanap\source\repos\CoreDemo\CoreDemo\Views\Home\Bookdetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6550b1fde99f914c05e8a4ba9fad7d289a56d3d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Bookdetails), @"mvc.1.0.view", @"/Views/Home/Bookdetails.cshtml")]
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
#line 1 "C:\Users\atul.sanap\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\atul.sanap\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6550b1fde99f914c05e8a4ba9fad7d289a56d3d3", @"/Views/Home/Bookdetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Bookdetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreDemo.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\atul.sanap\source\repos\CoreDemo\CoreDemo\Views\Home\Bookdetails.cshtml"
  
    ViewData["Title"] = "Bookdetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Bookdetails</h1>\r\n\r\n\r\n<div class=\"container\">\r\n    <h3 class=\"display-4\"></h3>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 13 "C:\Users\atul.sanap\source\repos\CoreDemo\CoreDemo\Views\Home\Bookdetails.cshtml"
         foreach (Book B in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <div class=\"card-mb-4 shadow-sm\">\r\n                    <svg class=\"bd-placeholder-img card-img-top\" width=\"100\" height=\"225\"");
            BeginWriteAttribute("xml:base", " xml:base=\"", 423, "\"", 434, 0);
            EndWriteAttribute();
            WriteLiteral("></svg>\r\n                    <div class=\"card-body\">\r\n                        <p class=\"card-title\">Name: ");
#nullable restore
#line 19 "C:\Users\atul.sanap\source\repos\CoreDemo\CoreDemo\Views\Home\Bookdetails.cshtml"
                                               Write(B.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                       \r\n                        <p class=\"card-body\">Language: ");
#nullable restore
#line 21 "C:\Users\atul.sanap\source\repos\CoreDemo\CoreDemo\Views\Home\Bookdetails.cshtml"
                                                  Write(B.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-body\">price: ");
#nullable restore
#line 22 "C:\Users\atul.sanap\source\repos\CoreDemo\CoreDemo\Views\Home\Bookdetails.cshtml"
                                               Write(B.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <small class=\"text-muted\">Author: ");
#nullable restore
#line 23 "C:\Users\atul.sanap\source\repos\CoreDemo\CoreDemo\Views\Home\Bookdetails.cshtml"
                                                     Write(B.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\atul.sanap\source\repos\CoreDemo\CoreDemo\Views\Home\Bookdetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreDemo.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591