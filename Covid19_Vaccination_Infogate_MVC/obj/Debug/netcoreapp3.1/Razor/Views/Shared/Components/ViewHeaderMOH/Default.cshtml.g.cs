#pragma checksum "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\Components\ViewHeaderMOH\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88cf9c40df35a33fd1975643d6f4a2ffea4103d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ViewHeaderMOH_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ViewHeaderMOH/Default.cshtml")]
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
#line 1 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\_ViewImports.cshtml"
using Covid19_Vaccination_Infogate_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\_ViewImports.cshtml"
using Covid19_Vaccination_Infogate_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88cf9c40df35a33fd1975643d6f4a2ffea4103d3", @"/Views/Shared/Components/ViewHeaderMOH/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6cf68f1de3d4ed5694007f3e39407c7f9dba19", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ViewHeaderMOH_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""header"">
    <a class=""title"" href=""index.cshtml"">
        <img src=""image/CVM-Logo.png"" alt=""CVM-Logo"">
        <span>CỔNG THÔNG TIN TIÊM CHỦNG COVID-19</span>
    </a>

    <div class=""nav"">
        <div>
            <ul>
                <a href=""index.cshtml"">
                <li class=""menu-section"">Tổng quan</li>
                </a>

                <a href=""#"">
                <li class=""menu-section"">Dữ liệu</li>
                </a>

                <a href=""MOHManageOrg.cshtml"">
                <li class=""menu-section"">Các đơn vị</li>
                </a>
            </ul>
        </div>

        <a class=""avatar"" href=""#"">
            <img src=""image/Avatar-MOH.png"" alt=""Avata Bộ Y Tế"">
        </a>
    </div>

    <!-- DROP DOWN MENU PROFILE -->
    <div class=""drop-down-menu"" id=""drop-down-menu-profile"">
        <div class=""holder"">
            <ul>
                <a href=""ORGAccountInfo.cshtml"">
                <li>Thông tin tài khoản</li>
         ");
            WriteLiteral("       </a>\r\n\r\n                <a href=\"ORGProfile.cshtml\">\r\n                <li>Thông tin đơn vị</li>\r\n                </a>\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1170, "\"", 1177, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"btn-logout\">\r\n                <li>Đăng xuất</li>\r\n                </a>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <!-- END DROP DOWN MENU PROFILE -->\r\n</div>\r\n<!-- END HEADER -->\r\n\r\n<div class=\"header-virtual\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
