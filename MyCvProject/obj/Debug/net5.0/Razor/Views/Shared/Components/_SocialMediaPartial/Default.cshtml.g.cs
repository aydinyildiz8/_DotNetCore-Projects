#pragma checksum "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_SocialMediaPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1109ea7baeb82b00ae99396b6974405f979df377"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__SocialMediaPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_SocialMediaPartial/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/_SocialMediaPartial/Default.cshtml", typeof(AspNetCore.Views_Shared_Components__SocialMediaPartial_Default))]
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
#line 1 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
using MyCvProject.Models.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1109ea7baeb82b00ae99396b6974405f979df377", @"/Views/Shared/Components/_SocialMediaPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd05c955600468869b5c2211f6d7a6c88bb8fc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__SocialMediaPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 32, true);
            WriteLiteral("\r\n\r\n<div class=\"social-icons\">\r\n");
            EndContext();
#line 6 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(135, 30, true);
            WriteLiteral("        <a class=\"social-icon\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 165, "\"", 182, 1);
#line 8 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
WriteAttributeValue("", 172, item.Link, 172, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(183, 3, true);
            WriteLiteral("><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 186, "\"", 204, 1);
#line 8 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
WriteAttributeValue("", 194, item.Ikon, 194, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(205, 11, true);
            WriteLiteral("></i></a>\r\n");
            EndContext();
#line 9 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(223, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
