#pragma checksum "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Testimonial\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fc7e7f4d578bf17ef01810fb074b022da61506c1cbc5178923021f7ad07d51e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Testimonial_Index), @"mvc.1.0.view", @"/Views/Testimonial/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\_ViewImports.cshtml"
using Core_Proje

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\_ViewImports.cshtml"
using Core_Proje.Models

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Testimonial\Index.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fc7e7f4d578bf17ef01810fb074b022da61506c1cbc5178923021f7ad07d51e6", @"/Views/Testimonial/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Testimonial_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Testimonial\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Referans Listesi</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Ad Soyad</th>
                                <th>Şirket </th>
                                <th>Unvan</th>
                                <th>Sil</th>
                                <th>Detaylar</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 26 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Testimonial\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                <tr>\r\n\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1103, "\"", 1123, 1);
            WriteAttributeValue("", 1109, 
#nullable restore
#line 31 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Testimonial\Index.cshtml"
                                                   item.ImageUrl

#line default
#line hidden
#nullable disable
            , 1109, 14, false);
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" />\r\n                                    </td>\r\n                                    <td>");
            Write(
#nullable restore
#line 33 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Testimonial\Index.cshtml"
                                         item.ClientName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td>");
            Write(
#nullable restore
#line 34 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Testimonial\Index.cshtml"
                                         item.Company

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td>");
            Write(
#nullable restore
#line 35 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Testimonial\Index.cshtml"
                                         item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1407, "\"", 1464, 2);
            WriteAttributeValue("", 1414, "/Testimonial/DeleteTestimonial/", 1414, 31, true);
            WriteAttributeValue("", 1445, 
#nullable restore
#line 36 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Testimonial\Index.cshtml"
                                                                                 item.TestimonialID

#line default
#line hidden
#nullable disable
            , 1445, 19, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1553, "\"", 1608, 2);
            WriteAttributeValue("", 1560, "/Testimonial/EditTestimonial/", 1560, 29, true);
            WriteAttributeValue("", 1589, 
#nullable restore
#line 37 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Testimonial\Index.cshtml"
                                                                               item.TestimonialID

#line default
#line hidden
#nullable disable
            , 1589, 19, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Detaylar</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Testimonial\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                        </tbody>
                    </table>
                    <a href=""/Testimonial/AddTestimonial/"" class=""btn btn-outline-info"">Yeni Referans Ekle</a>
                </div>
            </div>
        </div>
    </div>
</div>


");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
