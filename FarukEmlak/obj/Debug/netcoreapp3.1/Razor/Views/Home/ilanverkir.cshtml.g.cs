#pragma checksum "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25230b21d4eb8aa74169cf9d99ea7c19c1b435a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ilanverkir), @"mvc.1.0.view", @"/Views/Home/ilanverkir.cshtml")]
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
#line 1 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\_ViewImports.cshtml"
using FarukEmlak;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\_ViewImports.cshtml"
using FarukEmlak.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25230b21d4eb8aa74169cf9d99ea7c19c1b435a6", @"/Views/Home/ilanverkir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0e337b94640b7c857f3c186fac02bdd0f9cbff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ilanverkir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FarukEmlak.Models.Kiralik>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
  
    ViewData["Title"] = "ilanverkir";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div style=""width: 600px; height: auto; margin-left: 300px; background-color: #8d6b6b"">
    <div style="" margin-left: 50px;margin-right:50px"">
        <br /><br />
        <h1 style=""margin-left:100px;color:white"">Yeni Kiralık İlan Ekle</h1>
        <br />
       
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25230b21d4eb8aa74169cf9d99ea7c19c1b435a64548", async() => {
                WriteLiteral("\r\n            <b style=\" color: white\">Ev Sahibi ID</b><br />\r\n            ");
#nullable restore
#line 17 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.MusteriID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <b style=\" color: white\">Kira</b><br />\r\n            ");
#nullable restore
#line 20 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.Kira, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <b style=\" color: white\">Oda Sayısı</b><br />\r\n            ");
#nullable restore
#line 23 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.Odasay, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <b style=\" color: white\">MetreKare</b><br />\r\n            ");
#nullable restore
#line 26 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.MetreKare, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <b style=\" color: white\">Bina Yaşı</b><br />\r\n            ");
#nullable restore
#line 29 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.Binayas, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <b style=\" color: white\">Bina Kat Sayısı</b><br />\r\n            ");
#nullable restore
#line 32 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.Binakat, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <b style=\" color: white\">Bulunduğu Kat</b><br />\r\n            ");
#nullable restore
#line 35 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.Bulunkat, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <b style=\" color: white\">Cephe</b><br />\r\n            ");
#nullable restore
#line 38 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.Cephe, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <b style=\" color: white\">İlan Tarihi</b><br />\r\n            ");
#nullable restore
#line 41 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.İlanTarih, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <b style=\" color: white\">Durum</b><br />\r\n            ");
#nullable restore
#line 44 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.Durum, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <b style=\" color: white\">Şehir</b><br />\r\n            ");
#nullable restore
#line 47 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.Sehir, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <b style=\" color: white\">Semt</b><br />\r\n            ");
#nullable restore
#line 50 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.Semt, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <b style=\" color: white\">Mahalle</b><br />\r\n            ");
#nullable restore
#line 53 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.Mahalle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <b style=\" color: white\">Adres</b><br />\r\n            ");
#nullable restore
#line 56 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.Adres, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <b style=\" color: white\">Başlık</b><br />\r\n            ");
#nullable restore
#line 59 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Home\ilanverkir.cshtml"
       Write(Html.TextBoxFor(x => x.Baslik, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <button class=\"btn btn-info\">ONAYLA</button><br /><br />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FarukEmlak.Models.Kiralik> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
