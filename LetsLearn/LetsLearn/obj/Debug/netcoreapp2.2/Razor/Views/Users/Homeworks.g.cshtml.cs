#pragma checksum "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e4bbbe7ecdf6c605529e8a3a06eba31ed99b7f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Homeworks), @"mvc.1.0.view", @"/Views/Users/Homeworks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Homeworks.cshtml", typeof(AspNetCore.Views_Users_Homeworks))]
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
#line 1 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
using System.Reflection.Metadata;

#line default
#line hidden
#line 2 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
using Microsoft.AspNetCore.Razor.Language.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e4bbbe7ecdf6c605529e8a3a06eba31ed99b7f7", @"/Views/Users/Homeworks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16cc8f899bbe9b580c146d1342b0f963af970e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Homeworks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LetsLearn.ViewModels.StudentHomeworksViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(145, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(170, 231, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e4bbbe7ecdf6c605529e8a3a06eba31ed99b7f74139", async() => {
                BeginContext(176, 218, true);
                WriteLiteral("\r\n    <link rel=\'stylesheet\' type=\'text/css\' href=\"/css/homeworks.css\" media=\"all\">\r\n    <link href=\"https://fonts.googleapis.com/css?family=Fontdiner+Swanky\" rel=\"stylesheet\">\r\n    <title>Detalii despre teme</title>\r\n");
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
            BeginContext(401, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(403, 3119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e4bbbe7ecdf6c605529e8a3a06eba31ed99b7f75557", async() => {
                BeginContext(409, 64, true);
                WriteLiteral("\r\n<div class=\"pagina\">\r\n    <h1 id=\"title\">Teme rezolvate</h1>\r\n");
                EndContext();
#line 14 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
             foreach (var item in Model.students)
            {

#line default
#line hidden
                BeginContext(539, 144, true);
                WriteLiteral("                <div class=\"student\">\r\n                <div class=\"seePointsTitle\">\r\n                    <h3>\r\n                        <strong> ");
                EndContext();
                BeginContext(684, 14, false);
#line 19 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                            Write(item.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(698, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(700, 13, false);
#line 19 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                                            Write(item.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(713, 88, true);
                WriteLiteral(" </strong>\r\n                    </h3>\r\n                </div>\r\n                <hr/>\r\n\r\n");
                EndContext();
#line 24 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                 foreach (var homework in @item.homeworks)
                {

#line default
#line hidden
                BeginContext(880, 93, true);
                WriteLiteral("                    <div class=\"exercice\"> \r\n                    <h4 class=\"homeworkTitle\">✪ ");
                EndContext();
                BeginContext(974, 22, false);
#line 27 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                                           Write(homework.HomeworkTitle);

#line default
#line hidden
                EndContext();
                BeginContext(996, 63, true);
                WriteLiteral(" </h4>\r\n                        <h5 class=\"homeworkContainer\"> ");
                EndContext();
                BeginContext(1060, 26, false);
#line 28 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                                                  Write(homework.HomeworkContainer);

#line default
#line hidden
                EndContext();
                BeginContext(1086, 185, true);
                WriteLiteral("</h5>\r\n                        <div class=\"notare\">\r\n                            <ul class=\"variante\">\r\n\r\n                                <li style=\"color:#f00;\">Răspunsul studentului: ");
                EndContext();
                BeginContext(1272, 22, false);
#line 32 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                                                                          Write(homework.StudentAnswer);

#line default
#line hidden
                EndContext();
                BeginContext(1294, 84, true);
                WriteLiteral("</li>\r\n                                <li style=\"color: #00ff00\">Răspunsul corect: ");
                EndContext();
                BeginContext(1379, 22, false);
#line 33 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                                                                        Write(homework.CorrectAnswer);

#line default
#line hidden
                EndContext();
                BeginContext(1401, 126, true);
                WriteLiteral("</li>\r\n\r\n                            </ul>\r\n                            <div class=\"adauga\">\r\n                                ");
                EndContext();
                BeginContext(1527, 689, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e4bbbe7ecdf6c605529e8a3a06eba31ed99b7f79820", async() => {
                    BeginContext(1533, 146, true);
                    WriteLiteral("\r\n                                    <p>Adaugă o notă</p>\r\n                                    <select>\r\n                                        ");
                    EndContext();
                    BeginContext(1679, 17, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e4bbbe7ecdf6c605529e8a3a06eba31ed99b7f710373", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1696, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 41 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                                         for (var i = 1; i < 11; i++)
                                        {

#line default
#line hidden
                    BeginContext(1812, 44, true);
                    WriteLiteral("                                            ");
                    EndContext();
                    BeginContext(1856, 19, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e4bbbe7ecdf6c605529e8a3a06eba31ed99b7f711970", async() => {
                        BeginContext(1865, 1, false);
#line 43 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                                               Write(i);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1875, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 44 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                                        }

#line default
#line hidden
                    BeginContext(1920, 143, true);
                    WriteLiteral("                                    </select>\r\n                                    <button class=\"butonAdaugaSubmit\" type=\"submit\" data-clasa=\"");
                    EndContext();
                    BeginContext(2064, 10, false);
#line 46 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                                                                                           Write(item.clasa);

#line default
#line hidden
                    EndContext();
                    BeginContext(2074, 18, true);
                    WriteLiteral("\" data-idstudent=\"");
                    EndContext();
                    BeginContext(2093, 7, false);
#line 46 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                                                                                                                        Write(item.Id);

#line default
#line hidden
                    EndContext();
                    BeginContext(2100, 19, true);
                    WriteLiteral("\" data-idhomework=\"");
                    EndContext();
                    BeginContext(2120, 11, false);
#line 46 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                                                                                                                                                   Write(homework.Id);

#line default
#line hidden
                    EndContext();
                    BeginContext(2131, 13, true);
                    WriteLiteral("\" data-week=\"");
                    EndContext();
                    BeginContext(2145, 13, false);
#line 46 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                                                                                                                                                                            Write(homework.Week);

#line default
#line hidden
                    EndContext();
                    BeginContext(2158, 51, true);
                    WriteLiteral("\">Adaugă</button>\r\n                                ");
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
                BeginContext(2216, 98, true);
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 51 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
                }

#line default
#line hidden
                BeginContext(2333, 24, true);
                WriteLiteral("                </div>\r\n");
                EndContext();
#line 53 "C:\Scoala\Licenta\LetsLearn\LetsLearn\LetsLearn\Views\Users\Homeworks.cshtml"
            }

#line default
#line hidden
                BeginContext(2372, 1143, true);
                WriteLiteral(@"
     

</div>

<script>
    var butoane = document.querySelectorAll("".butonAdaugaSubmit"");
    for (buton of butoane) {

        buton.addEventListener(""click"",
            (function(buton) {
                return function(e) {
                    console.log(buton.dataset.idstudent,
                        buton.dataset.week,
                        buton.dataset.idhomework);
                    var xhttp = new XMLHttpRequest();
                    xhttp.open(""POST"", buton.dataset.clasa, false)
                    xhttp.setRequestHeader(""Content-type"", ""application/x-www-form-urlencoded"");
                    var select = buton.parentElement.querySelector(""select"");
                    xhttp.send(""studentId="" +
                        buton.dataset.idstudent +
                        ""&homeworkId="" +
                        buton.dataset.idhomework +
                        ""&value="" +
                        select.options[select.selectedIndex].text +
                        ""&wee");
                WriteLiteral("k=\" +\r\n                        buton.dataset.week);\r\n                }\r\n            })(buton));\r\n\r\n    }\r\n</script>\r\n\r\n");
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
            BeginContext(3522, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LetsLearn.ViewModels.StudentHomeworksViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
