#pragma checksum "C:\Users\cagda\source\repos\PortfolioProject\PortfolioProject\Views\Admin\NewSideBar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "dd9986625a6d2cd46bb32eb187c0b7491e3fe65bf5a7d9b425d876d2f5b10954"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_NewSideBar), @"mvc.1.0.view", @"/Views/Admin/NewSideBar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"dd9986625a6d2cd46bb32eb187c0b7491e3fe65bf5a7d9b425d876d2f5b10954", @"/Views/Admin/NewSideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_NewSideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-xs rounded-circle "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/corona-free-dark-bootstrap-admin-template-1.0.0/template/assets/images/faces/face15.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<ul class=\"nav\">\r\n    <li class=\"nav-item profile\">\r\n        <div class=\"profile-desc\">\r\n            <div class=\"profile-pic\">\r\n                <div class=\"count-indicator\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dd9986625a6d2cd46bb32eb187c0b7491e3fe65bf5a7d9b425d876d2f5b109544641", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <span class=""count bg-success""></span>
                </div>
                <div class=""profile-name"">
                    <h5 class=""mb-0 font-weight-normal"">Admin</h5>
                    <span>Admin Paneli</span>
                </div>
            </div>
            <a href=""#"" id=""profile-dropdown"" data-toggle=""dropdown""><i class=""mdi mdi-dots-vertical""></i></a>
            <div class=""dropdown-menu dropdown-menu-right sidebar-dropdown preview-list"" aria-labelledby=""profile-dropdown"">
                <a href=""/Writer/Profile/Index/"" class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                        <div class=""preview-icon bg-dark rounded-circle"">
                            <i class=""mdi mdi-settings text-primary""></i>
                        </div>
                    </div>
                    <div class=""preview-item-content"">
                        <p class=""preview-subject ellipsis mb-1 text-small"">Hesap Ayarları</");
            WriteLiteral(@"p>
                    </div>
                </a>
                <div class=""dropdown-divider""></div>
                <a href=""/Writer/Profile/Index/"" class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                        <div class=""preview-icon bg-dark rounded-circle"">
                            <i class=""mdi mdi-onepassword  text-info""></i>
                        </div>
                    </div>
                    <div class=""preview-item-content"">
                        <p class=""preview-subject ellipsis mb-1 text-small"">Şifreyi Değiştir</p>
                    </div>
                </a>
                <div class=""dropdown-divider""></div>
                <a href=""/AdminMessage/ReceiverMessageList/"" class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                        <div class=""preview-icon bg-dark rounded-circle"">
                            <i class=""mdi mdi-calendar-today text-success""></i>
 ");
            WriteLiteral(@"                       </div>
                    </div>
                    <div class=""preview-item-content"">
                        <p class=""preview-subject ellipsis mb-1 text-small"">Gelen Mesajlar</p>
                    </div>
                </a>
            </div>
        </div>
    </li>
    <li class=""nav-item nav-category"">
        <span class=""nav-link"">Navigation</span>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Dashboard/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-speedometer""></i>
            </span>
            <span class=""menu-title"">Dashboard</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Writer/Dashboard/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-comment-account-outline""></i>
            </span>
            <span class=""menu-title"">Yazar Paneli</span>
        </a>
    </li>
    <li class=""nav-item");
            WriteLiteral(@" menu-items"">
        <a class=""nav-link"" href=""/Skill/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-laptop""></i>
            </span>
            <span class=""menu-title"">Yetenekler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Experience/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-playlist-play""></i>
            </span>
            <span class=""menu-title"">Deneyimler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Default/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-table-large""></i>
            </span>
            <span class=""menu-title"">Siteye Git</span>
        </a>
    </li>
  
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Service/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-contacts""></i>
            </s");
            WriteLiteral(@"pan>
            <span class=""menu-title"">Hizmetler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Portfolio/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-github-circle""></i>
            </span>
            <span class=""menu-title"">Projeler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/AdminMessage/ReceiverMessageList/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-message""></i>
            </span>
            <span class=""menu-title"">Gelen Mesajlar</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/AdminMessage/SenderMessageList/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-message""></i>
            </span>
            <span class=""menu-title"">Gönderilen Mesajlar</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
     ");
            WriteLiteral(@"   <a class=""nav-link"" href=""/Contact/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-phone""></i>
            </span>
            <span class=""menu-title"">İletişim</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/About/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-account""></i>
            </span>
            <span class=""menu-title"">Hakkımda</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/ContactSubplace/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-calendar""></i>
            </span>
            <span class=""menu-title"">Alt İletişim Bilgileri</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Testimonial/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-contacts""></i>
            </span>
          ");
            WriteLiteral(@"  <span class=""menu-title"">Referanslar</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Feature/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-contacts""></i>
            </span>
            <span class=""menu-title"">Öne Çıkan Gönderiler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/SocialMedia/Index"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-youtube""></i>
            </span>
            <span class=""menu-title"">Sosyal Medya</span>
        </a>
    </li>
   
    
");
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
