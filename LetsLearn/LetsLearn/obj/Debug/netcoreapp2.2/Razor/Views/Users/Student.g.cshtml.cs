#pragma checksum "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "540b2ea9f074d1c63bf33e74add8dc87ec036581"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Student), @"mvc.1.0.view", @"/Views/Users/Student.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Student.cshtml", typeof(AspNetCore.Views_Users_Student))]
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
#line 1 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\_ViewImports.cshtml"
using LetsLearn;

#line default
#line hidden
#line 2 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\_ViewImports.cshtml"
using LetsLearn.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"540b2ea9f074d1c63bf33e74add8dc87ec036581", @"/Views/Users/Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d83dd6348bd11769228ed07a5f04ea9d332a3a8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LetsLearn.ViewModels.StudentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml"
  
    ViewData["Title"] = "Student";

#line default
#line hidden
            BeginContext(89, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(118, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "540b2ea9f074d1c63bf33e74add8dc87ec0365814614", async() => {
                BeginContext(124, 113, true);
                WriteLiteral("\r\n    <title>Student</title>\r\n    <link rel=\'stylesheet\' type=\'text/css\' href=\"/css/profile.css\" media=\"all\">\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(244, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(246, 1580, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "540b2ea9f074d1c63bf33e74add8dc87ec0365815923", async() => {
                BeginContext(252, 21, true);
                WriteLiteral("\r\n<h1>Bine ai venit, ");
                EndContext();
                BeginContext(274, 15, false);
#line 15 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml"
              Write(ViewBag.student);

#line default
#line hidden
                EndContext();
                BeginContext(289, 58, true);
                WriteLiteral("</h1>\r\n<hr />  \r\n\r\n\r\n<div id=\"continut\">    \r\n\r\n\r\n    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 347, "\"", 399, 1);
#line 22 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml"
WriteAttributeValue("", 353, Html.DisplayFor(model => model.student.Image), 353, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(400, 113, true);
                WriteLiteral(" />\r\n    <table id=\"Profile\">\r\n\r\n\r\n        <tr>\r\n            <th id=\"Left\">Nume</th>\r\n            <td id=\"Right\">");
                EndContext();
                BeginContext(514, 48, false);
#line 28 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml"
                      Write(Html.DisplayFor(model => model.student.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(562, 103, true);
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th id=\"Left\">Prenume</th>\r\n            <td id=\"Right\">");
                EndContext();
                BeginContext(666, 49, false);
#line 32 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml"
                      Write(Html.DisplayFor(model => model.student.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(715, 104, true);
                WriteLiteral("</td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <th id=\"Left\">Email</th>\r\n            <td id=\"Right\"> ");
                EndContext();
                BeginContext(820, 52, false);
#line 37 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml"
                       Write(Html.DisplayFor(model => model.student.EmailAddress));

#line default
#line hidden
                EndContext();
                BeginContext(872, 119, true);
                WriteLiteral(" </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <th id=\"Left\"> Nume de utilizator</th>\r\n            <td id=\"Right\"> ");
                EndContext();
                BeginContext(992, 48, false);
#line 42 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml"
                       Write(Html.DisplayFor(model => model.student.UserName));

#line default
#line hidden
                EndContext();
                BeginContext(1040, 63, true);
                WriteLiteral(" </td>\r\n        </tr>\r\n\r\n\r\n    </table>\r\n    \r\n </div>   \r\n    ");
                EndContext();
                BeginContext(1103, 122, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "540b2ea9f074d1c63bf33e74add8dc87ec0365819322", async() => {
                    BeginContext(1204, 17, true);
                    WriteLiteral("Editeaza profilul");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 49 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml"
                                                  WriteLiteral(Html.ViewData.Model.student.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1225, 273, true);
                WriteLiteral(@" 
<hr/>
    
<div>

    
    <details>
    <summary>Verifica situatia</summary>
    <table class=""table table-bordered"">
        <tr>
            <th>Saptamana</th>
            <th>Data</th>
            <th>Nota</th>
            <th>Tema?</th>
        </tr>
");
                EndContext();
#line 64 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml"
         foreach (var item in Model.grades)
        {

#line default
#line hidden
                BeginContext(1554, 39, true);
                WriteLiteral("            <tr>\r\n                <td> ");
                EndContext();
                BeginContext(1594, 9, false);
#line 67 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml"
                Write(item.Week);

#line default
#line hidden
                EndContext();
                BeginContext(1603, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1631, 9, false);
#line 68 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml"
               Write(item.Date);

#line default
#line hidden
                EndContext();
                BeginContext(1640, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1668, 10, false);
#line 69 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml"
               Write(item.Value);

#line default
#line hidden
                EndContext();
                BeginContext(1678, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1706, 13, false);
#line 70 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml"
               Write(item.Homework);

#line default
#line hidden
                EndContext();
                BeginContext(1719, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 72 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Student.cshtml"
        }

#line default
#line hidden
                BeginContext(1756, 63, true);
                WriteLiteral("\r\n           \r\n    </table>\r\n    </details>\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n");
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
            BeginContext(1826, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LetsLearn.ViewModels.StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
