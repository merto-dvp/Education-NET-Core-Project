#pragma checksum "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\Home\CoursesUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d498740864f79b2c3c4a3f23f3e9423528a37e3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CoursesUser), @"mvc.1.0.view", @"/Views/Home/CoursesUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CoursesUser.cshtml", typeof(AspNetCore.Views_Home_CoursesUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d498740864f79b2c3c4a3f23f3e9423528a37e3f", @"/Views/Home/CoursesUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a82e1e2c06b3f49264e23630cf92803705880280", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CoursesUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp4.Models.UsersAndCourses>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 476, true);
            WriteLiteral(@"<!-- start banner Area -->


<section class=""banner-area relative about-banner"" id=""home"" style=""height:300px"">
    <div class=""overlay overlay-bg""></div>
    <div class=""container"">
        <div class=""row d-flex align-items-center justify-content-center"" style=""height:300px"">
            <div class=""about-content col-lg-12"">
                <h1 class=""text-white"">
                    Mağaza
                </h1>
                <p class=""text-white link-nav"">");
            EndContext();
            BeginContext(515, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25a186940bc34bdc95caa2a201f0cf49", async() => {
                BeginContext(559, 8, true);
                WriteLiteral("Kurslar ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(571, 45, true);
            WriteLiteral("  <span class=\"lnr lnr-arrow-right\"></span>  ");
            EndContext();
            BeginContext(616, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c88080e21d94487aaf32c5ecfb36191", async() => {
                BeginContext(662, 5, true);
                WriteLiteral(" Tümü");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(671, 967, true);
            WriteLiteral(@"</p>
            </div>
        </div>
    </div>
</section>
<!-- End banner Area -->
<!-- Start popular-courses Area -->
<style>
    input[type=text] {
        width: 180px;
        box-sizing: border-box;
        border: 2px solid #ccc;
        border-radius: 4px;
        font-size: 16px;
        background-color: white;
        background-image: url(""https://www.w3schools.com/howto/searchicon.png"");
        background-position: 10px 10px;
        background-repeat: no-repeat;
        text-align: center;
        -webkit-transition: width 0.4s ease-in-out;
        transition: width 0.4s ease-in-out;
        margin-top: -25%;
    }

        input[type=text]:focus {
            width: 600px;
            margin-top: -10%;
        }
</style>






<section class=""popular-courses-area section-gap courses-page"">
    <div class=""container"">
        <div class=""row d-flex justify-content-center"">
            
            ");
            EndContext();
            BeginContext(1638, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59c58c31401444728e5a974c199b4cd0", async() => {
                BeginContext(1644, 166, true);
                WriteLiteral("\r\n                <input class=\"list-group-item\" type=\"text\" name=\"search\" id=\"searchbar\" placeholder=\"Arama\" onkeyup=\"javascript:getCourses()\" /><br />\r\n            ");
                EndContext();
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
            EndContext();
            BeginContext(1817, 86, true);
            WriteLiteral("\r\n\r\n            \r\n\r\n\r\n        </div>\r\n\r\n\r\n        <div id=\"courses\" class=\"row\">\r\n\r\n\r\n");
            EndContext();
            BeginContext(4082, 83, true);
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n<!-- End popular-courses Area -->\r\n\r\n");
            EndContext();
            BeginContext(4165, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c823504cf59491b8862ffd14a73f162", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4220, 119, true);
            WriteLiteral("\r\n<script>\r\n\r\n    loadCourses(\"\");\r\n    var courses;\r\n\r\n    function loadCourses(search) {\r\n        var jsonCourses = \'");
            EndContext();
            BeginContext(4340, 39, false);
#line 120 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\Home\CoursesUser.cshtml"
                      Write(Html.Raw(Json.Serialize(Model.Kurslar)));

#line default
#line hidden
            EndContext();
            BeginContext(4379, 2539, true);
            WriteLiteral(@"';
        courses = JSON.parse(jsonCourses);

        var items = [];

        for (var i = 0; i < courses.length; i++) {

            var course = courses[i];
            if (!course.isDele) {
                if (search !== """" && course.name.toLowerCase().indexOf(search.toLowerCase()) === -1)
                    continue;

                items.push('<div class=""single-popular-carusel col-lg-3 col-md-6"">');
                i
                items.push('<div class=""thumb-wrap relative"">');

                items.push('<div class=""thumb relative"">');
                items.push('<div class=""overlay overlay-bg""></div>');

                items.push('<a href=""javascript:goDetail(' + course.id + ')"">');

                items.push('<img class=""img-fluid"" style=""width:320px;height:240px"" src=""../img/' + course.thumbnailUrl + '""/>');
                items.push('</a>');

                items.push('</div>');
                items.push('<div class=""meta d-flex justify-content-between text-bla");
            WriteLiteral(@"ck"">');

                items.push('<p><span class=""lnr lnr-users"" ></span> 20 <span class=""lnr lnr-bubble""></span>35</p>');
                items.push('<h4>' + course.price + ' Kredi' + '</h4>');
                items.push('</div>');
                items.push('</div>');

                if (course.isPurchased) {
                    items.push('<a disabled=""disabled"" class=""genric-btn primary squire"" style=""background-color:#666;margin-top:1%;width:100%"">Satın Alındı</a>');
                }
                else {
                    items.push('<a href=""javascript:buyCourse(' + course.id + ')"" class=""genric-btn primary squire"" style=""background-color:#666;margin-bottom:10px;width:100%"">Satın Al</a>');
                }
                items.push('<div class=""details"">');
                items.push('<a href=""javascript:goDetail(' + course.id + ')"">');
                items.push('<h4>');
                items.push(course.name + ' / ' + course.trainer);
                items.push('</h4>');
 ");
            WriteLiteral(@"               items.push('</a>');
                items.push('<p>');
                items.push(course.description);
                items.push('</p>');
                items.push('</div>');
                items.push('</div>');
            }
        }
        $(""#courses"").html(items.join(' '));
    }

    function getCourses() {
        var search = $('#searchbar').val();
        loadCourses(search);

    }
    function buyCourse(courseId) {
        location.href = '");
            EndContext();
            BeginContext(6919, 32, false);
#line 180 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\Home\CoursesUser.cshtml"
                    Write(Url.Action("Buy", "UserCourses"));

#line default
#line hidden
            EndContext();
            BeginContext(6951, 105, true);
            WriteLiteral("?CourseId=\' +courseId;\r\n    }\r\n\r\n\r\n    window.goDetail = function (courseId) {\r\n        location.href = \'");
            EndContext();
            BeginContext(7057, 32, false);
#line 185 "C:\Users\merto\Desktop\WebApp4\WebApp4\Views\Home\CoursesUser.cshtml"
                    Write(Url.Action("Details", "Courses"));

#line default
#line hidden
            EndContext();
            BeginContext(7089, 25, true);
            WriteLiteral("/\' + courseId;\r\n    }\r\n\r\n");
            EndContext();
            BeginContext(7176, 181, true);
            WriteLiteral("\r\n    //document.getElementById(\'searchbar\').addEventListener(\'input\', function (e) {\r\n\r\n    //    let s = e.target.value;\r\n    //    console.log(s);\r\n    //});\r\n</script>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(7973, 1, true);
            WriteLiteral("\t");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp4.Models.UsersAndCourses> Html { get; private set; }
    }
}
#pragma warning restore 1591