#pragma checksum "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\MOH\ManageOrg.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "273391ca24c98b3a11520b266f311631ed7d921b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MOH_ManageOrg), @"mvc.1.0.view", @"/Views/MOH/ManageOrg.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"273391ca24c98b3a11520b266f311631ed7d921b", @"/Views/MOH/ManageOrg.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6cf68f1de3d4ed5694007f3e39407c7f9dba19", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MOH_ManageOrg : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\MOH\ManageOrg.cshtml"
  
    Layout = "_LayoutFeaturePage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"/css/MOHManageOrg.css\">\r\n<script src=\"/js/MOHManageOrg.js\"></script>\r\n\r\n<div class=\"holder-function-panel\">\r\n    <!-- MENU -->\r\n");
#nullable restore
#line 11 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\MOH\ManageOrg.cshtml"
   Write(await Component.InvokeAsync("ViewFunctionMenu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\MOH\ManageOrg.cshtml"
                                                        ;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- END MENU -->

    <!-- FUNCTIONAL PANEL -->
    <div class=""function-panel"">
        <br>
        <div class=""filter-panel"">
            <div class=""filter-pane"">
                <div>
                    <label for=""province-name"">Tỉnh/Thành phố</label>
                    <select type=""text"" name=""province-name"" id=""select-province"">
");
            WriteLiteral("                    </select>\r\n                </div>\r\n                <div>\r\n                    <label for=\"district-name\">Quận/Huyện/Thị xã</label>\r\n                    <select type=\"text\" name=\"district-name\" id=\"select-district\">\r\n");
            WriteLiteral("                    </select>\r\n                </div>\r\n\r\n                <div>\r\n                    <label for=\"town-name\">Xã/Phường/Thị trấn</label>\r\n                    <select type=\"drop-down\" name=\"town-name\" id=\"select-town\">\r\n");
            WriteLiteral(@"                    </select>
                </div>

                <button class=""btn-medium-bordered-icon btn-filter"" id=""btn-filter-org"">
                    Tìm kiếm
                </button>
            </div>
        </div>
        <br>

        <div class=""panel-list"">
            <div class=""list-name"">
                <div class=""org"" id=""list-name-org"">Danh sách các đơn vị tiêm chủng</div>
            </div>
            <br>

            <div class=""holder"">
                <div class=""list-org"" id=""list-org"">
                </div>
            </div>
        </div>

    </div>
    <br>
</div>
    </div>

<br>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591