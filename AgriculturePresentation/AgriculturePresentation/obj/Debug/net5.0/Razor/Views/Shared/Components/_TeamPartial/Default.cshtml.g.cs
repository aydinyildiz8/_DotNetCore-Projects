#pragma checksum "D:\masaüstü\Kaynaklar\Udemy\Murat Yücedağ\C# ile OOP Temelleri Adım Adım Katmanlı Mimari\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a1b0f7b7f49ded6335b3f2d9f68d9ab4194830c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__TeamPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_TeamPartial/Default.cshtml")]
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
#nullable restore
#line 1 "D:\masaüstü\Kaynaklar\Udemy\Murat Yücedağ\C# ile OOP Temelleri Adım Adım Katmanlı Mimari\AgriculturePresentation\AgriculturePresentation\Views\_ViewImports.cshtml"
using AgriculturePresentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\masaüstü\Kaynaklar\Udemy\Murat Yücedağ\C# ile OOP Temelleri Adım Adım Katmanlı Mimari\AgriculturePresentation\AgriculturePresentation\Views\_ViewImports.cshtml"
using AgriculturePresentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\masaüstü\Kaynaklar\Udemy\Murat Yücedağ\C# ile OOP Temelleri Adım Adım Katmanlı Mimari\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a1b0f7b7f49ded6335b3f2d9f68d9ab4194830c", @"/Views/Shared/Components/_TeamPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daa27564c578f8bd032750b8d5a0983009bfabfa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__TeamPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Team>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""team"" id=""team"">
        <div class=""container"">
            <h3 class=""tittle"">Takım Arkadaşlarımız</h3>
            <p class=""heading-btm-w3ls"">Suspendisse fringilla pellentesque risus sit amet bibendum.</p>

       
            <div class=""wthree_team_grids"">
");
#nullable restore
#line 12 "D:\masaüstü\Kaynaklar\Udemy\Murat Yücedağ\C# ile OOP Temelleri Adım Adım Katmanlı Mimari\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
                  foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 wthree_team_grid\">\r\n               \r\n                    <div class=\"hovereffect\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 548, "\"", 568, 1);
#nullable restore
#line 17 "D:\masaüstü\Kaynaklar\Udemy\Murat Yücedağ\C# ile OOP Temelleri Adım Adım Katmanlı Mimari\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
WriteAttributeValue("", 554, item.ImageUrl, 554, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt="" "" class=""img-responsive"" />
                        <div class=""overlay"">
                            <h6>Sosyal Medya</h6>
                            <div class=""rotate"">
                                <p class=""group1"">
                                    <a href=""#"">
                                        <i class=""fa fa-twitter""></i>
                                    </a>
                                    <a href=""#"">
                                        <i class=""fa fa-facebook""></i>
                                    </a>
                                </p>
                                    <hr>
                                    <hr>
                                <p class=""group2"">
                                    <a href=""#"">
                                        <i class=""fa fa-instagram""></i>
                                    </a>
                                    <a href=""#"">
                                        <i class=""fa fa-dribbble""></i>
");
            WriteLiteral("                                    </a>\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <h4>");
#nullable restore
#line 42 "D:\masaüstü\Kaynaklar\Udemy\Murat Yücedağ\C# ile OOP Temelleri Adım Adım Katmanlı Mimari\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
                   Write(item.PersonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>");
#nullable restore
#line 43 "D:\masaüstü\Kaynaklar\Udemy\Murat Yücedağ\C# ile OOP Temelleri Adım Adım Katmanlı Mimari\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                \r\n                </div>\r\n");
#nullable restore
#line 46 "D:\masaüstü\Kaynaklar\Udemy\Murat Yücedağ\C# ile OOP Temelleri Adım Adım Katmanlı Mimari\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"clearfix\"> </div>\r\n            \r\n            </div>\r\n        \r\n        </div>\r\n    </div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Team>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591