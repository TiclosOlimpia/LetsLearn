#pragma checksum "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Class\Clasa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fd7b3877c4606140698f9aa45960dae8cbe3087"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Class_Clasa), @"mvc.1.0.view", @"/Views/Class/Clasa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Class/Clasa.cshtml", typeof(AspNetCore.Views_Class_Clasa))]
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
#line 1 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Class\Clasa.cshtml"
using Microsoft.AspNetCore.Razor.Language.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fd7b3877c4606140698f9aa45960dae8cbe3087", @"/Views/Class/Clasa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16cc8f899bbe9b580c146d1342b0f963af970e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Class_Clasa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClasaModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddHomework", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Class", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Class"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(85, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Class\Clasa.cshtml"
  
    ViewData["Title"] = "Clasa";

#line default
#line hidden
            BeginContext(124, 26, true);
            WriteLiteral("\n\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(150, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fd7b3877c4606140698f9aa45960dae8cbe30875161", async() => {
                BeginContext(156, 113, true);
                WriteLiteral("\r\n    <title>Clasa</title>\r\n    <link rel=\'stylesheet\' type=\'text/css\' href=\"/css/clasaDetail.css\" media=\"all\">\r\n");
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
            BeginContext(276, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(277, 707, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fd7b3877c4606140698f9aa45960dae8cbe30876465", async() => {
                BeginContext(283, 34, true);
                WriteLiteral("\n\n<div class=\"container\">\n    <h1>");
                EndContext();
                BeginContext(318, 13, false);
#line 19 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Class\Clasa.cshtml"
   Write(ViewBag.clasa);

#line default
#line hidden
                EndContext();
                BeginContext(331, 143, true);
                WriteLiteral("</h1>\n    <div>\r\n        <div class=\"titlu\">\r\n            <p>Nume</p>\r\n            <p>Medie</p>\r\n            <p>Detalii</p>\r\n        </div>\r\n\r\n");
                EndContext();
#line 27 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Class\Clasa.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
                BeginContext(523, 75, true);
                WriteLiteral("            <div class=\"continut\">\n                <p>\n                    ");
                EndContext();
                BeginContext(599, 13, false);
#line 31 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Class\Clasa.cshtml"
               Write(item.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(612, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(614, 14, false);
#line 31 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Class\Clasa.cshtml"
                              Write(item.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(628, 62, true);
                WriteLiteral("\n                </p>\n                <p>\n                    ");
                EndContext();
                BeginContext(691, 10, false);
#line 34 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Class\Clasa.cshtml"
               Write(item.Medie);

#line default
#line hidden
                EndContext();
                BeginContext(701, 41, true);
                WriteLiteral("\n                </p>\n                <p>");
                EndContext();
                BeginContext(742, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fd7b3877c4606140698f9aa45960dae8cbe30878884", async() => {
                    BeginContext(796, 2, true);
                    WriteLiteral("🔍");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 36 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Class\Clasa.cshtml"
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
                BeginContext(802, 25, true);
                WriteLiteral("</p>\n             </div>\n");
                EndContext();
#line 38 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Class\Clasa.cshtml"
         }

#line default
#line hidden
                BeginContext(839, 23, true);
                WriteLiteral("     </div>\n  \n</div>\n\n");
                EndContext();
                BeginContext(862, 109, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fd7b3877c4606140698f9aa45960dae8cbe308711622", async() => {
                    BeginContext(954, 13, true);
                    WriteLiteral("Adauga o tema");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 43 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Class\Clasa.cshtml"
                                                     WriteLiteral(ViewBag.clasa);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(971, 6, true);
                WriteLiteral(" \n\n\n \n");
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
            BeginContext(984, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClasaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
