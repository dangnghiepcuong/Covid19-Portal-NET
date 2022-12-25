#pragma checksum "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a75527fcfcb08cbcbcd760cb0fd1f6a6476b29cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
using Covid19_Vaccination_Infogate_MVC.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
using Covid19_Vaccination_Infogate_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a75527fcfcb08cbcbcd760cb0fd1f6a6476b29cc", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6cf68f1de3d4ed5694007f3e39407c7f9dba19", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a75527fcfcb08cbcbcd760cb0fd1f6a6476b29cc3720", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Cổng thông tin tiêm chủng Covid-19</title>
    <link rel=""stylesheet"" href=""/css/style.css"">
    <link rel=""stylesheet"" href=""/css/HomepageSlider.css"">
    <link rel=""stylesheet"" href=""/css/index.css"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
    <script src=""/js/index.js""></script>
    <script type=""text/javascript"" src=""/js/main.js""></script>
    ");
#nullable restore
#line 18 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a75527fcfcb08cbcbcd760cb0fd1f6a6476b29cc5630", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
      
        Account account = SessionHelper.GetObjectFromJson<Account>(Context.Session, "AccountInfo");
        string username = ViewBag.username;
        if (account == null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
       Write(await Component.InvokeAsync("ViewHeader"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
                                                      ;
        }
        else
        {
            switch (account.Role)
            {
                case 0:
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
               Write(await Component.InvokeAsync("ViewHeaderMOH"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
                                                                 ;
                    break;
                case 1:
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
               Write(await Component.InvokeAsync("ViewHeaderORG"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
                                                                 ;
                    break;
                case 2:
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
               Write(await Component.InvokeAsync("ViewHeaderCitizen"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
                                                                     ;
                    Console.WriteLine(2);
                    break;
                default:
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
               Write(await Component.InvokeAsync("ViewHeader"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
                                                              ;
                    break;
            }
        }

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
                     ;

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("ViewFooter"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
                                                  ;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("ViewSignupLoginForm"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
                                                           ;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("ViewWebElements"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\Lychthac\Covid19_Vaccination_Infogate_MVC\Views\Shared\_Layout.cshtml"
                                                       ;
    

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
