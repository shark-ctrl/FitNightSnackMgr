#pragma checksum "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\UpdatePassWord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd36341885713c3de49b18f172b7389bb10a78b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_UpdatePassWord), @"mvc.1.0.view", @"/Views/Admins/UpdatePassWord.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd36341885713c3de49b18f172b7389bb10a78b8", @"/Views/Admins/UpdatePassWord.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e42a31b6838bd61ee2d0d1f7faed55e126407454", @"/Views/_ViewImports.cshtml")]
    public class Views_Admins_UpdatePassWord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FitNightSnackMgr.ViewModels.AdminViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\UpdatePassWord.cshtml"
  
    Layout = "~/Views/Shared/_Layout _admin.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\UpdatePassWord.cshtml"
  
    ViewData["Title"] = "密码修改";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>密码修改</h1>\r\n\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-lg-10\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd36341885713c3de49b18f172b7389bb10a78b84976", async() => {
                WriteLiteral("\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd36341885713c3de49b18f172b7389bb10a78b85250", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 18 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\UpdatePassWord.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.AdminId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <div class=""form-group"">
                <label class=""control-label"">旧密码</label>
                <input id=""old_password"" class=""form-control"" placeholder=""请输入旧密码"" required type=""password""/>
                <span id=""valid_old_password"" class=""text-danger""></span>
            </div>



            <div class=""form-group"">
                <label class=""control-label"">新密码</label>
                <input id=""new_password"" class=""form-control"" placeholder=""请输入新密码"" required type=""password""/>
                <span id=""valid_new_password"" class=""text-danger""></span>
            </div>

            <div class=""form-group"">
                <label class=""control-label"">确认新密码</label>
                <input id=""new_password2"" class=""form-control"" placeholder=""请再次输入新密码"" required type=""password""/>
                <span id=""valid_new_password2"" class=""text-danger""></span>
            </div>




            <div class=""form-group"">
                <input id=""btn"" type=""button"" value=""保存""");
                WriteLiteral(" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd36341885713c3de49b18f172b7389bb10a78b89131", async() => {
                WriteLiteral("回到列表");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<script>
    

    $(""#old_password"").blur(function () {
        if ($(this).val() == """") {
            $(""#valid_old_password"").text(""请输入旧密码"")
            return false;
        }
       

       


        $(""#valid_old_password"").text("""")
                 
          
    });





    $(""#new_password"").blur(function () {
        if ($(this).val() == """") {
            $(""#valid_new_password"").text(""请输入新密码"")
            return false;
        }

        let reg = new RegExp(/^(?![^a-zA-Z]+$)(?!\D+$)/);
        if (!reg.test($(this).val())) {
            $(""#valid_new_password"").text(""新密码过于简单"")
            return false;
        }



        $(""#valid_new_password"").text("""")


    });




    $(""#new_password2"").blur(function () {
        if ($(this).val() == """") {
            $(""#valid_new_password2"").text(""请输入确认密码"")
            return false;
        }

        if ($(this).val() != $(""#new_password"").val()) {
            $(""#valid_new_password2"").te");
            WriteLiteral("xt(\"两次确认密码不一致\")\r\n            return false;\r\n        }\r\n\r\n\r\n\r\n        $(\"#valid_new_password2\").text(\"\")\r\n\r\n\r\n    });\r\n\r\n\r\n\r\n\r\n\r\n    $(\"#btn\").click(function (e) {\r\n        let userid =");
#nullable restore
#line 120 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\UpdatePassWord.cshtml"
               Write(Model.AdminId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        let txt_old_pwd = $(""#old_password"").val();
        let txt_new_pwd = $('#new_password').val();
        let txt_new_pwd2 = $('#new_password2').val();
        e.preventDefault();

        if (txt_old_pwd == """"  ) {

            $(""#valid_old_password"").text(""请输入旧密码"")
           
            return false;

        }

        if (txt_new_pwd == """") {
            $(""#valid_new_password"").text(""请输入新密码"")
            return false;
        }

        if ( txt_new_pwd2 == """") {
            $(""#valid_new_password2"").text(""请输入确认密码"")
            return false;
        }

        $(""#valid_old_password"").text("""")
        $(""#valid_new_password"").text("""")
        $(""#valid_new_password2"").text("""")


        $.post(

            """);
#nullable restore
#line 151 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Admins\UpdatePassWord.cshtml"
        Write(Url.Action("UpdatePassWord","Admins"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            {
                userid: userid,
                oldpassword: txt_old_pwd,
                newpassword: txt_new_pwd
            },
            function (data) {
                switch (data) {
                    case 301
                        : swal(""账号修改异常"",""请联系管理员"",
                        ""error"");
                        break;
                    case 302:
                        swal(""用户账号异常"",""请联系管理员"",
                            ""error"");
                        break;
                    case 303:
                        swal(""旧密码错误"",""请重试"",
                            ""error"");
                        break;
                    case 310:
                        swal({
                            title: ""密码修改成功"",
                            text: `请妥善保管！`,
                            type: ""success"",
                            confirmButtonColor: ""rgb(134,204,235)"",
                            confirmButtonText: ""确定"",
                            closeOnCon");
            WriteLiteral(@"firm: false,
                            closeOnCancel: false
                        },
                            function (isConfirm) {
                                if (isConfirm) {

                                    window.location.href = `https://localhost:44320/admins/Login`
                                }
                            });
                        
                        break;

                }
            }


        )
    })


</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FitNightSnackMgr.ViewModels.AdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
