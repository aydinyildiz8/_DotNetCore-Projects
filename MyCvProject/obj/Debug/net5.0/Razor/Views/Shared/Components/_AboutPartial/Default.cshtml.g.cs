#pragma checksum "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_AboutPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bce1751d366752503f7e13cf4c98b24ad24666f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__AboutPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_AboutPartial/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/_AboutPartial/Default.cshtml", typeof(AspNetCore.Views_Shared_Components__AboutPartial_Default))]
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
#line 1 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_AboutPartial\Default.cshtml"
using MyCvProject.Models.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bce1751d366752503f7e13cf4c98b24ad24666f", @"/Views/Shared/Components/_AboutPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd05c955600468869b5c2211f6d7a6c88bb8fc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__AboutPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 89, true);
            WriteLiteral("\r\n<section class=\"resume-section\" id=\"about\">\r\n    <div class=\"resume-section-content\">\r\n");
            EndContext();
#line 6 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_AboutPartial\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(194, 47, true);
            WriteLiteral("            <h1 class=\"mb-0\">\r\n                ");
            EndContext();
            BeginContext(242, 7, false);
#line 9 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_AboutPartial\Default.cshtml"
           Write(item.Ad);

#line default
#line hidden
            EndContext();
            BeginContext(249, 45, true);
            WriteLiteral("\r\n                <span class=\"text-primary\">");
            EndContext();
            BeginContext(295, 10, false);
#line 10 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_AboutPartial\Default.cshtml"
                                      Write(item.Soyad);

#line default
#line hidden
            EndContext();
            BeginContext(305, 102, true);
            WriteLiteral("</span>\r\n            </h1>\r\n            <h4 class=\"mb-0\">\r\n                <span class=\"text-primary\">");
            EndContext();
            BeginContext(408, 11, false);
#line 13 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_AboutPartial\Default.cshtml"
                                      Write(item.Meslek);

#line default
#line hidden
            EndContext();
            BeginContext(419, 87, true);
            WriteLiteral("</span>\r\n            </h4>\r\n            <div class=\"subheading mb-5\">\r\n                ");
            EndContext();
            BeginContext(507, 10, false);
#line 16 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_AboutPartial\Default.cshtml"
           Write(item.Adres);

#line default
#line hidden
            EndContext();
            BeginContext(517, 3, true);
            WriteLiteral(" · ");
            EndContext();
            BeginContext(521, 12, false);
#line 16 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_AboutPartial\Default.cshtml"
                         Write(item.Telefon);

#line default
#line hidden
            EndContext();
            BeginContext(533, 22, true);
            WriteLiteral(" ·\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 555, "\"", 572, 1);
#line 17 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_AboutPartial\Default.cshtml"
WriteAttributeValue("", 562, item.Mail, 562, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(573, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(575, 9, false);
#line 17 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_AboutPartial\Default.cshtml"
                                Write(item.Mail);

#line default
#line hidden
            EndContext();
            BeginContext(584, 59, true);
            WriteLiteral("</a>\r\n            </div>\r\n            <p class=\"lead mb-5\">");
            EndContext();
            BeginContext(644, 13, false);
#line 19 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_AboutPartial\Default.cshtml"
                            Write(item.Aciklama);

#line default
#line hidden
            EndContext();
            BeginContext(657, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(678, 50, false);
#line 21 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_AboutPartial\Default.cshtml"
       Write(await Component.InvokeAsync("_SocialMediaPartial"));

#line default
#line hidden
            EndContext();
#line 21 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_AboutPartial\Default.cshtml"
                                                               
        }

#line default
#line hidden
            BeginContext(741, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; }
    }
}
#pragma warning restore 1591
