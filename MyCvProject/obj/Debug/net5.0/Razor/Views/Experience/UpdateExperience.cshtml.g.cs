#pragma checksum "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Experience\UpdateExperience.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4404b9a0a8a0a5a68a13ca98d7c0a3d95e207af5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_UpdateExperience), @"mvc.1.0.view", @"/Views/Experience/UpdateExperience.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Experience/UpdateExperience.cshtml", typeof(AspNetCore.Views_Experience_UpdateExperience))]
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
#line 1 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\_ViewImports.cshtml"
using MyCvProject;

#line default
#line hidden
#line 2 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\_ViewImports.cshtml"
using MyCvProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4404b9a0a8a0a5a68a13ca98d7c0a3d95e207af5", @"/Views/Experience/UpdateExperience.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd05c955600468869b5c2211f6d7a6c88bb8fc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Experience_UpdateExperience : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCvProject.Models.Entities.Experience>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Experience\UpdateExperience.cshtml"
  
    ViewData["Title"] = "UpdateExperience";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(153, 47, true);
            WriteLiteral("\r\n<br />\r\n<h4>Deneyim Güncelleme Sayfası</h4>\r\n");
            EndContext();
            BeginContext(200, 630, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4404b9a0a8a0a5a68a13ca98d7c0a3d95e207af54432", async() => {
                BeginContext(220, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(227, 16, false);
#line 11 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Experience\UpdateExperience.cshtml"
Write(Html.Label("ID"));

#line default
#line hidden
                EndContext();
                BeginContext(243, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(250, 57, false);
#line 12 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Experience\UpdateExperience.cshtml"
Write(Html.TextBoxFor(x => x.Id, new {@class = "form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(307, 20, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    ");
                EndContext();
                BeginContext(328, 20, false);
#line 15 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Experience\UpdateExperience.cshtml"
Write(Html.Label("Meslek"));

#line default
#line hidden
                EndContext();
                BeginContext(348, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(355, 61, false);
#line 16 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Experience\UpdateExperience.cshtml"
Write(Html.TextBoxFor(x => x.Meslek, new {@class = "form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(416, 20, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    ");
                EndContext();
                BeginContext(437, 18, false);
#line 19 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Experience\UpdateExperience.cshtml"
Write(Html.Label("Alan"));

#line default
#line hidden
                EndContext();
                BeginContext(455, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(462, 59, false);
#line 20 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Experience\UpdateExperience.cshtml"
Write(Html.TextBoxFor(x => x.Alan, new {@class = "form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(521, 20, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    ");
                EndContext();
                BeginContext(542, 22, false);
#line 23 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Experience\UpdateExperience.cshtml"
Write(Html.Label("Açıklama"));

#line default
#line hidden
                EndContext();
                BeginContext(564, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(571, 63, false);
#line 24 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Experience\UpdateExperience.cshtml"
Write(Html.TextBoxFor(x => x.Aciklama, new {@class = "form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(634, 20, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    ");
                EndContext();
                BeginContext(655, 19, false);
#line 27 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Experience\UpdateExperience.cshtml"
Write(Html.Label("Tarih"));

#line default
#line hidden
                EndContext();
                BeginContext(674, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(681, 60, false);
#line 28 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Experience\UpdateExperience.cshtml"
Write(Html.TextBoxFor(x => x.Tarih, new {@class = "form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(741, 82, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    <button type=\"submit\" class=\"btn btn-info\">GÜNCELLE</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(830, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCvProject.Models.Entities.Experience> Html { get; private set; }
    }
}
#pragma warning restore 1591
