#pragma checksum "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Certificate\UpdateCertificate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01972ab3daefd3a0046b99cc37a9295d54c003ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Certificate_UpdateCertificate), @"mvc.1.0.view", @"/Views/Certificate/UpdateCertificate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Certificate/UpdateCertificate.cshtml", typeof(AspNetCore.Views_Certificate_UpdateCertificate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01972ab3daefd3a0046b99cc37a9295d54c003ca", @"/Views/Certificate/UpdateCertificate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd05c955600468869b5c2211f6d7a6c88bb8fc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Certificate_UpdateCertificate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCvProject.Models.Entities.Certificate>
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
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Certificate\UpdateCertificate.cshtml"
  
    ViewData["Title"] = "UpdateCertificate";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(157, 52, true);
            WriteLiteral("\r\n\r\n<br />\r\n<h4>Yeni Sertifika Ekleme Sayfası</h4>\r\n");
            EndContext();
            BeginContext(209, 660, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01972ab3daefd3a0046b99cc37a9295d54c003ca4461", async() => {
                BeginContext(229, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(236, 16, false);
#line 13 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Certificate\UpdateCertificate.cshtml"
Write(Html.Label("ID"));

#line default
#line hidden
                EndContext();
                BeginContext(252, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(259, 57, false);
#line 14 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Certificate\UpdateCertificate.cshtml"
Write(Html.TextBoxFor(x => x.Id, new {@class = "form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(316, 20, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    ");
                EndContext();
                BeginContext(337, 27, false);
#line 17 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Certificate\UpdateCertificate.cshtml"
Write(Html.Label("Sertifika Adı"));

#line default
#line hidden
                EndContext();
                BeginContext(364, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(371, 67, false);
#line 18 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Certificate\UpdateCertificate.cshtml"
Write(Html.TextBoxFor(x => x.SertifikaAdı, new {@class = "form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(438, 20, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    ");
                EndContext();
                BeginContext(459, 27, false);
#line 21 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Certificate\UpdateCertificate.cshtml"
Write(Html.Label("Veren Kuruluş"));

#line default
#line hidden
                EndContext();
                BeginContext(486, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(493, 67, false);
#line 22 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Certificate\UpdateCertificate.cshtml"
Write(Html.TextBoxFor(x => x.VerenKurulus, new {@class = "form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(560, 20, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    ");
                EndContext();
                BeginContext(581, 22, false);
#line 25 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Certificate\UpdateCertificate.cshtml"
Write(Html.Label("Açıklama"));

#line default
#line hidden
                EndContext();
                BeginContext(603, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(610, 63, false);
#line 26 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Certificate\UpdateCertificate.cshtml"
Write(Html.TextBoxFor(x => x.Aciklama, new {@class = "form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(673, 20, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    ");
                EndContext();
                BeginContext(694, 19, false);
#line 29 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Certificate\UpdateCertificate.cshtml"
Write(Html.Label("Tarih"));

#line default
#line hidden
                EndContext();
                BeginContext(713, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(720, 60, false);
#line 30 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Certificate\UpdateCertificate.cshtml"
Write(Html.TextBoxFor(x => x.Tarih, new {@class = "form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(780, 82, true);
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
            BeginContext(869, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCvProject.Models.Entities.Certificate> Html { get; private set; }
    }
}
#pragma warning restore 1591