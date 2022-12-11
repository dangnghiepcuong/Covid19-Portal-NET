#pragma checksum "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\Components\ViewHeaderORG\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "159a845d8cc73f0f06f1f133faef7e546c7b4102"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ViewHeaderORG_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ViewHeaderORG/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"159a845d8cc73f0f06f1f133faef7e546c7b4102", @"/Views/Shared/Components/ViewHeaderORG/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6cf68f1de3d4ed5694007f3e39407c7f9dba19", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ViewHeaderORG_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link rel=""stylesheet"" href=""/css/header.css"">

<!-- HEADER -->
<div class=""header"">
    <a class=""title"" href=""index.cshtml"">
        <img src=""image/CVM-Logo.png"" alt=""CVM-Logo"">
        <span>CỔNG THÔNG TIN TIÊM CHỦNG COVID-19</span>
    </a>

    <div class=""nav"">
        <div>
            <ul>
                <a href=""index.cshtml"">
                <li class=""menu-section"">Trang chủ</li>
                </a>

                <a href=""ORGSchedule.cshtml"">
                <li class=""menu-section"" id=""menu-section-schedule"">Lịch tiêm</li>
                </a>

                <a href=""#"">
                <li class=""menu-section"">Văn bản</li>
                </a>

                <a href=""#"">
                <li class=""menu-section"">Thống kê</li>
                </a>
            </ul>
        </div>
        <a class=""avatar"" href=""#"">
            <img src=""image/Avatar-ORG.png"" alt=""Avata đơn vị tiêm chủng"">
        </a>
    </div>

    <!-- DROP DOWN MENU PROFILE -->
    <");
            WriteLiteral(@"div class=""drop-down-menu"" id=""drop-down-menu-profile"">
        <div class=""holder"">
            <ul>
                <a href=""ORGAccountInfo.cshtml"">
                <li>Thông tin tài khoản</li>
                </a>

                <a href=""ORGProfile.cshtml"">
                <li>Thông tin tổ chức</li>
                </a>

                <a");
            BeginWriteAttribute("href", " href=\"", 1397, "\"", 1404, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""btn-logout"">
                <li>Đăng xuất</li>
                </a>
            </ul>
        </div>
    </div>
    <!-- END DROP DOWN MENU PROFILE -->
    <!-- DROP DOWN MENU SCHEDULE -->
    <div class=""drop-down-menu"" id=""drop-down-menu-schedule"">
        <div class=""holder"">
            <ul>
                <a href=""ORGSchedule.cshtml"">
                <li>Danh sách lịch tiêm</li>
                </a>

                <a href=""ORGCreateSchedule.cshtml"">
                <li>Tạo lịch tiêm chủng</li>
                </a>
            </ul>
        </div>
    </div>
    <!-- END DROP DOWN MENU SCHEDULE -->
</div>

<!-- END HEADER -->

<div class=""header-virtual""></div>");
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
