#pragma checksum "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5440235a549be5cda5474763201edff63e705683"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Index.cshtml", typeof(AspNetCore.Views_Contact_Index))]
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
#line 1 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Contact\Index.cshtml"
using MyCvProject.Models.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5440235a549be5cda5474763201edff63e705683", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd05c955600468869b5c2211f6d7a6c88bb8fc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(155, 29, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(184, 2437, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5440235a549be5cda5474763201edff63e7056834413", async() => {
                BeginContext(227, 458, true);
                WriteLiteral(@"
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3>Mesaj Görüntüleme Sayfası</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""tab-pane"" id=""timeline"">

                            <div class=""timeline timeline-inverse"">
");
                EndContext();
#line 25 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Contact\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
                BeginContext(782, 173, true);
                WriteLiteral("                                    <div class=\"time-label\">\r\n                                        <span class=\"bg-warning\">\r\n                                            ");
                EndContext();
                BeginContext(957, 45, false);
#line 29 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Contact\Index.cshtml"
                                        Write(((DateTime)item.Tarih).ToString("dd.MM.yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(1003, 100, true);
                WriteLiteral("\r\n                                        </span>\r\n                                        <span><u>");
                EndContext();
                BeginContext(1104, 19, false);
#line 31 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Contact\Index.cshtml"
                                            Write(item.Konu.ToUpper());

#line default
#line hidden
                EndContext();
                BeginContext(1123, 368, true);
                WriteLiteral(@"</u></span>
                                    </div>
                                    <div>
                                        <i class=""fas fa-file bg-primary""></i>
                                        <div class=""timeline-item"">
                                            <p class=""time"" style=""font-size: medium""><i class=""far fa-clock mr-1""></i>");
                EndContext();
                BeginContext(1493, 42, false);
#line 36 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Contact\Index.cshtml"
                                                                                                                   Write(((DateTime)item.Tarih).ToShortTimeString());

#line default
#line hidden
                EndContext();
                BeginContext(1536, 134, true);
                WriteLiteral(" </p>\r\n\r\n                                            <h2 class=\"timeline-header\">\r\n                                                <b>");
                EndContext();
                BeginContext(1671, 22, false);
#line 39 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Contact\Index.cshtml"
                                              Write(item.AdSoyad.ToUpper());

#line default
#line hidden
                EndContext();
                BeginContext(1693, 7, true);
                WriteLiteral("</b> / ");
                EndContext();
                BeginContext(1701, 9, false);
#line 39 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Contact\Index.cshtml"
                                                                            Write(item.Mail);

#line default
#line hidden
                EndContext();
                BeginContext(1710, 176, true);
                WriteLiteral("\r\n\r\n                                            </h2>\r\n                                            <div class=\"timeline-body\">\r\n                                                ");
                EndContext();
                BeginContext(1887, 10, false);
#line 43 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Contact\Index.cshtml"
                                           Write(item.Mesaj);

#line default
#line hidden
                EndContext();
                BeginContext(1897, 283, true);
                WriteLiteral(@"
                                            </div>
                                            <div class=""timeline-footer"">
                                                <a href=""#"" class=""btn btn-primary btn-sm"">Cevapla</a>
                                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2180, "\"", 2218, 2);
                WriteAttributeValue("", 2187, "/Contact/DeleteContact/", 2187, 23, true);
#line 47 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Contact\Index.cshtml"
WriteAttributeValue("", 2210, item.Id, 2210, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2219, 184, true);
                WriteLiteral(" class=\"btn btn-danger btn-sm\">Sil</a>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
                EndContext();
#line 51 "D:\masaüstü\Eğitimler\Udemy\Murat Yücedağ\Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi\MyCvProject\Views\Contact\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(2438, 176, true);
                WriteLiteral("                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </section>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2621, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591