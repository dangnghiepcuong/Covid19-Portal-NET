#pragma checksum "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Citizen\MedicalForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "540011e6a8e837abc9bcc749771cc0ff89f30459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Citizen_MedicalForm), @"mvc.1.0.view", @"/Views/Citizen/MedicalForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"540011e6a8e837abc9bcc749771cc0ff89f30459", @"/Views/Citizen/MedicalForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6cf68f1de3d4ed5694007f3e39407c7f9dba19", @"/Views/_ViewImports.cshtml")]
    public class Views_Citizen_MedicalForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "\' . $citizen->get_ID() . \'", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Citizen\MedicalForm.cshtml"
  
    Layout = "_LayoutFeaturePage";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- FUNCTION PANEL -->\r\n<div class=\"holder-function-panel\">\r\n    <!-- MENU -->\r\n");
#nullable restore
#line 8 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Citizen\MedicalForm.cshtml"
   Write(await Component.InvokeAsync("ViewFunctionMenu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Citizen\MedicalForm.cshtml"
                                                        ;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- END MENU -->\r\n\r\n    <div class=\"function-panel\">\r\n        <br>\r\n        <div class=\"panel-target-citizen\">\r\n            <p>Đối tượng: </p>\r\n            <select");
            BeginWriteAttribute("name", " name=\"", 366, "\"", 373, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 374, "\"", 379, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "540011e6a8e837abc9bcc749771cc0ff89f304594642", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </select>
        </div>'
        <br>

        <div class=""panel-form-medical"">
            <div class=""form-medical"">
                <div class=""input_date"">
                    <label for=""input_date"">
                        Ngày thực hiện khai báo:
                    </label>
                    <input type=""date"" id=""input-date"">
                </div>
                <p>
                    Trong vòng 14 ngày qua, Anh/Chị có thấy xuất hiện ít nhất 1 trong các dấu hiệu:
                    ho, khó thở, viêm phổi, đau họng, mệt mỏi không?
                </p>
                <div class=""form-btn-input"">
                    <label for=""q1_no"">Không</label>
                    <input type=""radio"" name=""q1"" id=""q1_no"" value=""0"" checked=""checked"">
                    <label for=""q1_yes"">Có</label>
                    <input type=""radio"" name=""q1"" id=""q1_yes"" value=""1"">
                </div>

                <p>
                    Trong vòng 14 ngày qua, Anh/Chị có ti");
            WriteLiteral(@"ếp xúc với Người bệnh hoặc nghi ngờ, mắc bệnh Covid-19 không?
                </p>
                <div class=""form-btn-input"">
                    <label for=""q2_no"">Không</label>
                    <input type=""radio"" name=""q2"" id=""q2_no"" value=""0"" checked=""checked"">
                    <label for=""q2_yes"">Có</label>
                    <input type=""radio"" name=""q2"" id=""q2_yes"" value=""1"">
                </div>

                <p>
                    Anh/Chị có đang dương tính với Covid-19 không?
                </p>
                <div class=""form-btn-input"">
                    <label for=""q3_no"">Không</label>
                    <input type=""radio"" name=""q3"" id=""q3_no"" value=""0"" checked=""checked"">
                    <label for=""q3_yes"">Có</label>
                    <input type=""radio"" name=""q3"" id=""q3_yes"" value=""1"">
                </div>

                <p>
                    Anh/Chị có đang là đối tượng trì hoẵn tiêm chủng vaccine Covid-19
                    hoặc đang là đ");
            WriteLiteral(@"ối tượng chống chỉ định tiêm chủng Covid-19 không?
                </p>
                <div class=""form-btn-input"">
                    <label for=""q4_no"">Không</label>
                    <input type=""radio"" name=""q4"" id=""q4_no"" value=""0"" checked=""checked"">
                    <label for=""q4_yes"">Có</label>
                    <input type=""radio"" name=""q4"" id=""q4_yes"" value=""1"">
                </div>
                <br>
                <div class=""form-btn-input"">
                    <button class=""btn-medium-filled"" id=""btn-submit"">Xác nhận</button>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- END FUNCTION PANEL -->
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
