#pragma checksum "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_CertificatePartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f447ef7bb4ccee5a53a7e278f08ff3a54e680080"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__CertificatePartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_CertificatePartial/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/_CertificatePartial/Default.cshtml", typeof(AspNetCore.Views_Shared_Components__CertificatePartial_Default))]
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
#line 1 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_CertificatePartial\Default.cshtml"
using MyCvProject.Models.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f447ef7bb4ccee5a53a7e278f08ff3a54e680080", @"/Views/Shared/Components/_CertificatePartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd05c955600468869b5c2211f6d7a6c88bb8fc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__CertificatePartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Certificate>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 138, true);
            WriteLiteral("\r\n<section class=\"resume-section\" id=\"awards\">\r\n    <div class=\"resume-section-content\">\r\n        <h2 class=\"mb-5\">Certifications</h2>\r\n\r\n");
            EndContext();
#line 8 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_CertificatePartial\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(249, 170, true);
            WriteLiteral("            <ul class=\"fa-ul mb-0\">\r\n                <li>\r\n                    <span class=\"fa-li\"><i class=\"fas fa-trophy text-warning\"></i></span>\r\n                    ");
            EndContext();
            BeginContext(420, 17, false);
#line 13 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_CertificatePartial\Default.cshtml"
               Write(item.SertifikaAdı);

#line default
#line hidden
            EndContext();
            BeginContext(437, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(441, 17, false);
#line 13 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_CertificatePartial\Default.cshtml"
                                    Write(item.VerenKurulus);

#line default
#line hidden
            EndContext();
            BeginContext(458, 25, true);
            WriteLiteral("\r\n                    <p>");
            EndContext();
            BeginContext(484, 13, false);
#line 14 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_CertificatePartial\Default.cshtml"
                  Write(item.Aciklama);

#line default
#line hidden
            EndContext();
            BeginContext(497, 76, true);
            WriteLiteral("</p>\r\n                    <hr />\r\n                </li>\r\n            </ul>\r\n");
            EndContext();
#line 18 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_CertificatePartial\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(584, 22, true);
            WriteLiteral("    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Certificate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
