#pragma checksum "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98cf07fd943b909b2adb3a7e14a4117383fd4c71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Lists), @"mvc.1.0.view", @"/Views/Courses/Lists.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Lists.cshtml", typeof(AspNetCore.Views_Courses_Lists))]
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
#line 1 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\_ViewImports.cshtml"
using EducationProject;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\_ViewImports.cshtml"
using EducationProject.Models;

#line default
#line hidden
#line 3 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98cf07fd943b909b2adb3a7e14a4117383fd4c71", @"/Views/Courses/Lists.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f31ebb1ff696a844a4c4eafea7c3bacf329caef9", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Lists : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EducationProject.Models.Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inImages"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onerror", new global::Microsoft.AspNetCore.Html.HtmlString("this.onerror=null;this.src=\'../img/default.png\';"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("imag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
  
    ViewData["Title"] = "Lists";

#line default
#line hidden
            BeginContext(95, 490, true);
            WriteLiteral(@"

<style>
   
    #Tb2 {
        margin-left: 20px;
        
    }

    #imag {
        width: 30px;
        height: 30px;
    }

    .IndexImages {
        
        border: solid 2px;
        padding: 100px;
        margin:200px;
    }

    #inImages {
        text-align: center;
        width: 100px;
        height: 100px;
        margin: 5px;
    }

    #Image4 {
        width: 202px;
        height: 400px;
        border: solid 1px;
    }
</style>
");
            EndContext();
            BeginContext(585, 3445, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83cfb270427e44c380eb51be04a14579", async() => {
                BeginContext(591, 35, true);
                WriteLiteral("\r\n    <div class=\"IndexImages\">\r\n\r\n");
                EndContext();
#line 43 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
         foreach (var item in Model)
        {
            string ImgUrl = item.ThumbnailUrl;
           

#line default
#line hidden
                BeginContext(736, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(748, 99, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6c6487754d674587a3f6700b939dfae2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 772, "~/img/", 772, 6, true);
#line 47 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
AddHtmlAttributeValue("", 778, ImgUrl, 778, 7, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(847, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 48 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
            
        }

#line default
#line hidden
                BeginContext(874, 119, true);
                WriteLiteral("        \r\n            <table class=\"table\">\r\n\r\n                <tr>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(994, 40, false);
#line 55 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1034, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1114, 41, false);
#line 58 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1155, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1235, 44, false);
#line 61 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
                EndContext();
                BeginContext(1279, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1359, 48, false);
#line 64 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayNameFor(model => model.ThumbnailUrl));

#line default
#line hidden
                EndContext();
                BeginContext(1407, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1487, 44, false);
#line 67 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayNameFor(model => model.VideoUrl));

#line default
#line hidden
                EndContext();
                BeginContext(1531, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1611, 47, false);
#line 70 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(1658, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1738, 43, false);
#line 73 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayNameFor(model => model.Trainer));

#line default
#line hidden
                EndContext();
                BeginContext(1781, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1861, 53, false);
#line 76 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayNameFor(model => model.DetailDescription));

#line default
#line hidden
                EndContext();
                BeginContext(1914, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1994, 47, false);
#line 79 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayNameFor(model => model.VidCategory));

#line default
#line hidden
                EndContext();
                BeginContext(2041, 87, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n\r\n\r\n");
                EndContext();
#line 85 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                     foreach (var item in Model)
                    {
                        string ImgUrl = item.ThumbnailUrl;


#line default
#line hidden
                BeginContext(2263, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2336, 39, false);
#line 91 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(2375, 54, true);
                WriteLiteral("\r\n\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2430, 40, false);
#line 94 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
                EndContext();
                BeginContext(2470, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2550, 43, false);
#line 97 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
                EndContext();
                BeginContext(2593, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2673, 47, false);
#line 100 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ThumbnailUrl));

#line default
#line hidden
                EndContext();
                BeginContext(2720, 81, true);
                WriteLiteral("\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2802, 43, false);
#line 104 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayFor(modelItem => item.VideoUrl));

#line default
#line hidden
                EndContext();
                BeginContext(2845, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2925, 46, false);
#line 107 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
                EndContext();
                BeginContext(2971, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(3051, 42, false);
#line 110 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Trainer));

#line default
#line hidden
                EndContext();
                BeginContext(3093, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(3173, 52, false);
#line 113 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DetailDescription));

#line default
#line hidden
                EndContext();
                BeginContext(3225, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(3305, 46, false);
#line 116 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                   Write(Html.DisplayFor(modelItem => item.VidCategory));

#line default
#line hidden
                EndContext();
                BeginContext(3351, 112, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a>\r\n                            ");
                EndContext();
                BeginContext(3463, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f7b6328184a4adbb09fe3a450a50b74", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3483, "~/img/", 3483, 6, true);
#line 120 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
AddHtmlAttributeValue("", 3489, ImgUrl, 3489, 7, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3559, 109, true);
                WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(3668, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d6be5da3f9244659f22981cf77debff", async() => {
                    BeginContext(3713, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 124 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3721, 28, true);
                WriteLiteral(" |\r\n                        ");
                EndContext();
                BeginContext(3749, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e755d2133bab4c4a82c4c0e6ccc35244", async() => {
                    BeginContext(3797, 7, true);
                    WriteLiteral("Details");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 125 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3808, 28, true);
                WriteLiteral(" |\r\n                        ");
                EndContext();
                BeginContext(3836, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f57d5213df094bfe96feae88c4572201", async() => {
                    BeginContext(3883, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 126 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3893, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 129 "C:\Users\Administrator\Desktop\.net tanıtım\Projects\EducationProject\EducationProject\Views\Courses\Lists.cshtml"
                }

#line default
#line hidden
                BeginContext(3964, 59, true);
                WriteLiteral("                </table>\r\n         \r\n        </div>\r\n\r\n    ");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EducationProject.Models.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591