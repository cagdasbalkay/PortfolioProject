#pragma checksum "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bffab60719d6fb599d7b921e56c8d26bde6eb66cd082343ba1b36999a28ac7d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_AddPortfolio), @"mvc.1.0.view", @"/Views/Portfolio/AddPortfolio.cshtml")]
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

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bffab60719d6fb599d7b921e56c8d26bde6eb66cd082343ba1b36999a28ac7d8", @"/Views/Portfolio/AddPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_AddPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Portfolio>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
  
    ViewData["Title"] = "AddPortfolio";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n           <h3 class=\"card-description\">Proje Ekle</h3>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
             using (Html.BeginForm("AddPortfolio", "Portfolio", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <br />\r\n");
            Write(
#nullable restore
#line 16 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
                 Html.Label("Proje Başlığı")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 17 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
                 Html.TextBoxFor(x => x.Name, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 18 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
                 Html.ValidationMessageFor(x => x.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("                <br />\r\n                <label>Görsel 1</label>\r\n");
            Write(
#nullable restore
#line 21 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
                 Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 22 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
                 Html.ValidationMessageFor(x => x.ImageUrl)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("                <br />\r\n                <label>Görsel 2</label>\r\n");
            Write(
#nullable restore
#line 26 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
                 Html.TextBoxFor(x => x.ImageUrl2, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 27 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
                 Html.ValidationMessageFor(x => x.ImageUrl2)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("                <br />\r\n                <label>Proje URL</label>\r\n");
            Write(
#nullable restore
#line 31 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
                 Html.TextBoxFor(x => x.ProjectUrl, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 32 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
                 Html.ValidationMessageFor(x => x.ProjectUrl)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("                <br />\r\n");
            WriteLiteral("                <label>Fiyat</label>\r\n");
            Write(
#nullable restore
#line 37 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
                 Html.TextBoxFor(x => x.Price, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 38 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
                 Html.ValidationMessageFor(x => x.Price)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("                <br />\r\n");
            WriteLiteral("                <label>Tamamlanma Oranı</label>\r\n");
            Write(
#nullable restore
#line 43 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
                 Html.TextBoxFor(x => x.Value, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 44 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
                 Html.ValidationMessageFor(x => x.Value)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("                <br />\r\n");
            WriteLiteral("                <button class=\"btn btn-info\">Kaydet</button>\r\n");
#nullable restore
#line 51 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Portfolio\AddPortfolio.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Portfolio> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
