#pragma checksum "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\AdminInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3c1c40423ff44e9b5c31abdde638c809f3a7813"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_AdminInfo), @"mvc.1.0.view", @"/Views/Admins/AdminInfo.cshtml")]
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
#line 1 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\_ViewImports.cshtml"
using FitNightSnackMgr;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\_ViewImports.cshtml"
using FitNightSnackMgr.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c1c40423ff44e9b5c31abdde638c809f3a7813", @"/Views/Admins/AdminInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e42a31b6838bd61ee2d0d1f7faed55e126407454", @"/Views/_ViewImports.cshtml")]
    public class Views_Admins_AdminInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FitNightSnackMgr.Models.Admin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\AdminInfo.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>管理员详细信息</h1>\r\n\r\n<div>\r\n\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 14 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\AdminInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-2\">\r\n            ");
#nullable restore
#line 17 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\AdminInfo.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 21 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\AdminInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.AdminName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-2\">\r\n            ");
#nullable restore
#line 24 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\AdminInfo.cshtml"
       Write(Html.DisplayFor(model => model.AdminName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n\r\n        <dt class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 30 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\AdminInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.LoginAccount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-2\">\r\n            ");
#nullable restore
#line 33 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\AdminInfo.cshtml"
       Write(Html.DisplayFor(model => model.LoginAccount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 36 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\AdminInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.Permissions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n");
#nullable restore
#line 38 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\AdminInfo.cshtml"
         if (Model.Permissions == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-md-2\">管理员 </dd>\r\n");
#nullable restore
#line 41 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\AdminInfo.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-md-2\">普通员工</dd>\r\n");
#nullable restore
#line 45 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\AdminInfo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <dt class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 48 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\AdminInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-2\">\r\n            ");
#nullable restore
#line 51 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\AdminInfo.cshtml"
       Write(Html.DisplayFor(model => model.CreateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3c1c40423ff44e9b5c31abdde638c809f3a78137574", async() => {
                WriteLiteral("回到列表");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FitNightSnackMgr.Models.Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591