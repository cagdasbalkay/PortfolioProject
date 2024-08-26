#pragma checksum "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\SenderMessageList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7a789e5c9000bd49cd66586a9a2de03c00473a23a3a08b50dacffc60c72df91d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMessage_SenderMessageList), @"mvc.1.0.view", @"/Views/AdminMessage/SenderMessageList.cshtml")]
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
#line 1 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\SenderMessageList.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7a789e5c9000bd49cd66586a9a2de03c00473a23a3a08b50dacffc60c72df91d", @"/Views/AdminMessage/SenderMessageList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminMessage_SenderMessageList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\SenderMessageList.cshtml"
  
    ViewData["Title"] = "SenderMessageList";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yazar-Admin Giden Kutusu</h4>

            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>

                        <tr>
                            <th>#</th>
                            <th>Alıcı</th>
                            <th>Konu</th>
                            <th>Tarih</th>
                            <th>Sil</th>
                            <th>Mesajı Gör</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 27 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\SenderMessageList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <tr>\r\n                                <td>");
            Write(
#nullable restore
#line 30 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\SenderMessageList.cshtml"
                                     item.WriterMessageID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td>");
            Write(
#nullable restore
#line 31 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\SenderMessageList.cshtml"
                                     item.ReceiverName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td>");
            Write(
#nullable restore
#line 32 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\SenderMessageList.cshtml"
                                     item.Subject

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td>");
            Write(
#nullable restore
#line 33 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\SenderMessageList.cshtml"
                                     item.Date

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1225, "\"", 1286, 2);
            WriteAttributeValue("", 1232, "/AdminMessage/AdminMessageDelete/", 1232, 33, true);
            WriteAttributeValue("", 1265, 
#nullable restore
#line 34 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\SenderMessageList.cshtml"
                                                                               item.WriterMessageID

#line default
#line hidden
#nullable disable
            , 1265, 21, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1371, "\"", 1433, 2);
            WriteAttributeValue("", 1378, "/AdminMessage/AdminMessageDetails/", 1378, 34, true);
            WriteAttributeValue("", 1412, 
#nullable restore
#line 35 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\SenderMessageList.cshtml"
                                                                                item.WriterMessageID

#line default
#line hidden
#nullable disable
            , 1412, 21, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Mesajı Gör</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\SenderMessageList.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
