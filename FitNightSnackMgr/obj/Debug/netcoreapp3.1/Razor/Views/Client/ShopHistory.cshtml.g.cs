#pragma checksum "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05b4e7816c305e57088614e7e69f6bd4678f3595"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_ShopHistory), @"mvc.1.0.view", @"/Views/Client/ShopHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05b4e7816c305e57088614e7e69f6bd4678f3595", @"/Views/Client/ShopHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e42a31b6838bd61ee2d0d1f7faed55e126407454", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_ShopHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FitNightSnackMgr.ViewModels.OrdersViewModel.OrderDetailAndPage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShopHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("上一页"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("下一页"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
  
    Layout = "~/Views/Shared/_Layout_client.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>购物车</h2>\r\n\r\n<div id=\"cartDetails\">\r\n    <table class=\"table table-bordered table-hover table-striped\"");
            BeginWriteAttribute("style", " style=\"", 243, "\"", 251, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bind=""visible: cart.cartItems().length > 0"">
        <tbody>
            <tr>
                <th>订单编号</th>
                <th>订单详情</th>
                <th>总价</th>
                <th>状态</th>
                <th>&nbsp;</th>
            </tr>

");
#nullable restore
#line 21 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
             foreach (var item in Model.OrderDetailModels)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("id", " id=\"", 607, "\"", 625, 1);
#nullable restore
#line 23 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
WriteAttributeValue("", 612, item.OrderId, 612, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>\r\n                        ");
#nullable restore
#line 25 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
                   Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 27 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
                   Write(item.OrderDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> $");
#nullable restore
#line 28 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
                     Write(item.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 29 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
                     if (item.Status == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>未完成</td>\r\n");
#nullable restore
#line 32 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
}
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>已完成</td>\r\n");
#nullable restore
#line 36 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        <button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("data_order_id", " data_order_id=\"", 1111, "\"", 1140, 1);
#nullable restore
#line 38 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
WriteAttributeValue("", 1127, item.OrderId, 1127, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">移除</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 41 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- /ko -->\r\n        </tbody>\r\n    </table>\r\n    <nav aria-label=\"Page navigation \" style=\"text-align:center\">\r\n        <ul class=\"pagination pagination-lg\">\r\n            <li>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05b4e7816c305e57088614e7e69f6bd4678f35958075", async() => {
                WriteLiteral("\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
                                                       WriteLiteral(Model.PageIndex-1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 52 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
             for (int i = 1; i <= Model.PageTotal; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05b4e7816c305e57088614e7e69f6bd4678f359510727", async() => {
#nullable restore
#line 54 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
                                                                     Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
                                                          WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 55 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <li>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05b4e7816c305e57088614e7e69f6bd4678f359513345", async() => {
                WriteLiteral("\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
                                                       WriteLiteral(Model.PageIndex+1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n    </nav>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n<script>\r\n\r\n\r\n    $(\".btn.btn-danger\").click(function () {\r\n        let data_order_id = $(this).attr(\'data_order_id\');\r\n        \r\n        $.post(\"");
#nullable restore
#line 78 "F:\FitNightSnackMgr\FitNightSnackMgr\Views\Client\ShopHistory.cshtml"
           Write(Url.Action("HiddenUserOrder", "Client"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            { data_order_id: data_order_id },
            function (res) {
                if (res == 888) {
                    //$(`#tr ${snackNum}`).remove();
                    $(`#${data_order_id}`).remove();


                } else if (res==440) {
                    swal(""用户状态异常"", ""请联系管理员"",
                        ""error"");
                } else if (res == 110) {
                    swal(""登录状态异常"", ""请重新登录"",
                        ""error"");
                } else if (res == 4004) {
                    swal(""订单状态异常"", ""请联系管理员"",
                        ""error"");
                }
            }

        )
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FitNightSnackMgr.ViewModels.OrdersViewModel.OrderDetailAndPage> Html { get; private set; }
    }
}
#pragma warning restore 1591
