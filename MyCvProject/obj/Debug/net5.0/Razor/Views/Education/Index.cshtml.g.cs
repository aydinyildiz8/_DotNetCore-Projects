#pragma checksum "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Education\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43b24cf78143968f567c8991bdb15828e862db79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Education_Index), @"mvc.1.0.view", @"/Views/Education/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Education/Index.cshtml", typeof(AspNetCore.Views_Education_Index))]
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
#line 1 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Education\Index.cshtml"
using MyCvProject.Models.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43b24cf78143968f567c8991bdb15828e862db79", @"/Views/Education/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd05c955600468869b5c2211f6d7a6c88bb8fc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Education_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Education>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Education\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(157, 291, true);
            WriteLiteral(@"

<br />
<h1>Eğitim Sayfası</h1>

<table class=""table table-bordered"">

    <tr>
        <th>Okul</th>
        <th>Fakülte</th>
        <th>Bölüm</th>
        <th>Genel Not Ort.</th>
        <th>Mezuniyet Tarihi</th>
        <th>Sil</th>
        <th>Düzenle</th>
    </tr>

");
            EndContext();
#line 26 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Education\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(489, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(520, 9, false);
#line 29 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Education\Index.cshtml"
           Write(item.Okul);

#line default
#line hidden
            EndContext();
            BeginContext(529, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(553, 12, false);
#line 30 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Education\Index.cshtml"
           Write(item.Fakülte);

#line default
#line hidden
            EndContext();
            BeginContext(565, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(589, 10, false);
#line 31 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Education\Index.cshtml"
           Write(item.Bölüm);

#line default
#line hidden
            EndContext();
            BeginContext(599, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(623, 8, false);
#line 32 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Education\Index.cshtml"
           Write(item.Gno);

#line default
#line hidden
            EndContext();
            BeginContext(631, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(655, 20, false);
#line 33 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Education\Index.cshtml"
           Write(item.MezuniyetTarihi);

#line default
#line hidden
            EndContext();
            BeginContext(675, 25, true);
            WriteLiteral("</td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 700, "\"", 742, 2);
            WriteAttributeValue("", 707, "/Education/DeleteEducation/", 707, 27, true);
#line 34 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Education\Index.cshtml"
WriteAttributeValue("", 734, item.Id, 734, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(743, 56, true);
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 799, "\"", 841, 2);
            WriteAttributeValue("", 806, "/Education/UpdateEducation/", 806, 27, true);
#line 35 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Education\Index.cshtml"
WriteAttributeValue("", 833, item.Id, 833, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(842, 59, true);
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n        </tr>\r\n");
            EndContext();
#line 37 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Education\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(908, 91, true);
            WriteLiteral("\r\n</table>\r\n<a href=\"/Education/AddEducation\" class=\"btn btn-primary\">Yeni Deneyim Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Education>> Html { get; private set; }
    }
}
#pragma warning restore 1591
