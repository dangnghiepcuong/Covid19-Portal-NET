#pragma checksum "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\ORG\AccountInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e2828b96ed2782f3252e3a0b2f9a57dd02c76d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ORG_AccountInfo), @"mvc.1.0.view", @"/Views/ORG/AccountInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e2828b96ed2782f3252e3a0b2f9a57dd02c76d8", @"/Views/ORG/AccountInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6cf68f1de3d4ed5694007f3e39407c7f9dba19", @"/Views/_ViewImports.cshtml")]
    public class Views_ORG_AccountInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\ORG\AccountInfo.cshtml"
  
    Layout = "_LayoutFeaturePage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"/css/CitizenAccountInfo.css\">\r\n<script src=\"/js/ORGAccountInfo.js\"></script>\r\n\r\n<div class=\"holder-function-panel\">\r\n    <!-- MENU -->\r\n");
#nullable restore
#line 11 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\ORG\AccountInfo.cshtml"
   Write(await Component.InvokeAsync("ViewFunctionMenu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\ORG\AccountInfo.cshtml"
                                                        ;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- END MENU -->

    <!-- FUNCTIONAL PANEL -->
    <div class=""function-panel"">
        <div class=""accinfo-panel"">
            <div class=""frame"">
                <div class=""account"">
                    <br>
                    <p>Tài khoản</p>
                    <br>
                    <label for=""id"">Mã đơn vị tiêm chủng</label><br>
");
            WriteLiteral(@"<br>
                    <hr>
                    <div class=""message msg1""></div>
                    <br>

                    <label for=""password"">Nhập mật khẩu hiện tại</label><br>
                    <input type=""password"" name=""password"" required");
            BeginWriteAttribute("value", " value=\"", 1013, "\"", 1021, 0);
            EndWriteAttribute();
            WriteLiteral(@"><br>
                    <hr>
                    <div class=""message msg2""></div>
                </div>
            </div>

            <div class=""frame"">
                <div class=""change-pass"">
                    <br>
                    <p>Đổi mật khẩu</p>
                    <br>
                    <label for=""new-password"">Mật khẩu mới</label><br>
                    <input type=""password"" name=""new-password"" required");
            BeginWriteAttribute("value", " value=\"", 1467, "\"", 1475, 0);
            EndWriteAttribute();
            WriteLiteral(@"><br>
                    <hr>
                    <div class=""message msg1""></div>
                    <br>

                    <label for=""repeat-new-password"">Nhập mật khẩu mới</label><br>
                    <input type=""password"" name=""repeat-new-password"" required");
            BeginWriteAttribute("value", " value=\"", 1753, "\"", 1761, 0);
            EndWriteAttribute();
            WriteLiteral(@"><br>
                    <hr>
                    <div class=""message msg2""></div>
                </div>
            </div>
        </div>

        <div class=""group_btn"">
            <button class=""btn-medium-filled"" id=""update-account-info"">Cập nhật</button>
            <button class=""btn-medium-bordered"" id=""cancel-update-account-info"">Hủy bỏ</button>
        </div>
    </div>
</div>

<br>");
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
