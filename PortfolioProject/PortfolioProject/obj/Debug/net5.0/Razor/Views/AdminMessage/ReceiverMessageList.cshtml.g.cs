#pragma checksum "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\ReceiverMessageList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "527a5146fcc88d631f4abba7468349bbd82fae39a16b782f37462098c98d91a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMessage_ReceiverMessageList), @"mvc.1.0.view", @"/Views/AdminMessage/ReceiverMessageList.cshtml")]
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
#line 1 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\ReceiverMessageList.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"527a5146fcc88d631f4abba7468349bbd82fae39a16b782f37462098c98d91a1", @"/Views/AdminMessage/ReceiverMessageList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminMessage_ReceiverMessageList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\ReceiverMessageList.cshtml"
  
    ViewData["Title"] = "ReceiverMessageList";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yazar-Admin Gelen Kutusu</h4>

            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>

                        <tr>
                            <th>#</th>
                            <th>Gönderen</th>
                            <th>Konu</th>
                            <th>Tarih</th>
                            <th>Sil</th>
                            <th>Mesajı Gör</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 27 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\ReceiverMessageList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <tr>\r\n                                <td>");
            Write(
#nullable restore
#line 30 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\ReceiverMessageList.cshtml"
                                     item.WriterMessageID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td>");
            Write(
#nullable restore
#line 31 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\ReceiverMessageList.cshtml"
                                     item.SenderName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td>");
            Write(
#nullable restore
#line 32 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\ReceiverMessageList.cshtml"
                                     item.Subject

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td>");
            Write(
#nullable restore
#line 33 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\ReceiverMessageList.cshtml"
                                     item.Date

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1228, "\"", 1289, 2);
            WriteAttributeValue("", 1235, "/AdminMessage/AdminMessageDelete/", 1235, 33, true);
            WriteAttributeValue("", 1268, 
#nullable restore
#line 34 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\ReceiverMessageList.cshtml"
                                                                               item.WriterMessageID

#line default
#line hidden
#nullable disable
            , 1268, 21, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1374, "\"", 1436, 2);
            WriteAttributeValue("", 1381, "/AdminMessage/AdminMessageDetails/", 1381, 34, true);
            WriteAttributeValue("", 1415, 
#nullable restore
#line 35 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\ReceiverMessageList.cshtml"
                                                                                item.WriterMessageID

#line default
#line hidden
#nullable disable
            , 1415, 21, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Mesajı Gör</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\AdminMessage\ReceiverMessageList.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                       
                    </tbody>
                </table>
                <a href=""/AdminMessage/AdminMessageSend/"" class=""btn btn-outline-primary"">Yeni Mesaj Oluştur</a>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
