#pragma checksum "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c5c442cc6ddf56cc2155d2c71b02aada4ff4e59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRoles_Edit), @"mvc.1.0.view", @"/Views/UserRoles/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserRoles/Edit.cshtml", typeof(AspNetCore.Views_UserRoles_Edit))]
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
#line 1 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\_ViewImports.cshtml"
using WebApp4;

#line default
#line hidden
#line 2 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\_ViewImports.cshtml"
using WebApp4.Models;

#line default
#line hidden
#line 3 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c5c442cc6ddf56cc2155d2c71b02aada4ff4e59", @"/Views/UserRoles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a82e1e2c06b3f49264e23630cf92803705880280", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRoles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(60, 173, true);
            WriteLiteral("<div class=\"whole-wrap\">\r\n    <div class=\"container\">\r\n        <div class=\"container\" style=\"padding:5%;text-align:center\">\r\n\r\n            <br /><br /><br />\r\n\r\n            ");
            EndContext();
            BeginContext(233, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c547e80773e44e2994d30b2d3134b8de", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 11 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(299, 16, true);
            WriteLiteral("\r\n\r\n            ");
            EndContext();
            BeginContext(315, 2167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "965376e916d343f2b166de0c4725d237", async() => {
                BeginContext(353, 54, true);
                WriteLiteral("\r\n\r\n                <input type=\"hidden\" name=\"RoleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 407, "\"", 429, 1);
#line 15 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
WriteAttributeValue("", 415, Model.Role.Id, 415, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(430, 57, true);
                WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"RoleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 487, "\"", 511, 1);
#line 16 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
WriteAttributeValue("", 495, Model.Role.Name, 495, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(512, 85, true);
                WriteLiteral(" />\r\n\r\n                <h6 class=\"bg-info p-1 text-white\">\r\n                    Rol( ");
                EndContext();
                BeginContext(598, 15, false);
#line 19 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
                    Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(613, 97, true);
                WriteLiteral(" )\'e ekle\r\n                </h6>\r\n                <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 22 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
                     if (Model.NotMembers.Count() == 0)
                    {

#line default
#line hidden
                BeginContext(790, 90, true);
                WriteLiteral("                        <tr><td colspan=\"2\">Tüm kullanıcılar bu yetkiye sahip.</td></tr>\r\n");
                EndContext();
#line 25 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#line 28 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
                         foreach (var user in Model.NotMembers)
                        {

#line default
#line hidden
                BeginContext(1044, 70, true);
                WriteLiteral("                            <tr>\r\n                                <td>");
                EndContext();
                BeginContext(1115, 13, false);
#line 31 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
                               Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1128, 121, true);
                WriteLiteral("</td>\r\n                                <td>\r\n                                    <input type=\"checkbox\" name=\"UsersToAdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1249, "\"", 1265, 1);
#line 33 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
WriteAttributeValue("", 1257, user.Id, 1257, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1266, 79, true);
                WriteLiteral(" />\r\n                                </td>\r\n                            </tr>\r\n");
                EndContext();
#line 36 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
                        }

#line default
#line hidden
#line 36 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
                         
                    }

#line default
#line hidden
                BeginContext(1395, 108, true);
                WriteLiteral("                </table>\r\n\r\n\r\n                <h6 class=\"bg-info p-1 text-white\">\r\n                    Rol( ");
                EndContext();
                BeginContext(1504, 15, false);
#line 42 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
                    Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1519, 99, true);
                WriteLiteral(" )\'den sil.\r\n                </h6>\r\n                <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 45 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
                     if (Model.Members.Count() == 0)
                    {

#line default
#line hidden
                BeginContext(1695, 69, true);
                WriteLiteral("                        <tr><td colspan=\"2\">Kullanıcı Yok</td></tr>\r\n");
                EndContext();
#line 48 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#line 51 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
                         foreach (var user in Model.Members)
                        {

#line default
#line hidden
                BeginContext(1925, 70, true);
                WriteLiteral("                            <tr>\r\n                                <td>");
                EndContext();
                BeginContext(1996, 13, false);
#line 54 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
                               Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(2009, 124, true);
                WriteLiteral("</td>\r\n                                <td>\r\n                                    <input type=\"checkbox\" name=\"UsersToDelete\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2133, "\"", 2149, 1);
#line 56 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
WriteAttributeValue("", 2141, user.Id, 2141, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2150, 79, true);
                WriteLiteral(" />\r\n                                </td>\r\n                            </tr>\r\n");
                EndContext();
#line 59 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
                        }

#line default
#line hidden
#line 59 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\UserRoles\Edit.cshtml"
                         
                    }

#line default
#line hidden
                BeginContext(2279, 125, true);
                WriteLiteral("\r\n                </table>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Güncelle</button>\r\n                ");
                EndContext();
                BeginContext(2404, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc2227c1fd5c490fabb83c64bce5582f", async() => {
                    BeginContext(2452, 5, true);
                    WriteLiteral("İptal");
                    EndContext();
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
                EndContext();
                BeginContext(2461, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2482, 64, true);
            WriteLiteral("\r\n\r\n\r\n            <br /><br /><br />\r\n        </div></div></div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
