#pragma checksum "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dc2bd5fa53f89826aab727305f5799d7a9c18d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kiralik_Bilgi), @"mvc.1.0.view", @"/Views/Kiralik/Bilgi.cshtml")]
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
#line 1 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
using FarukEmlak.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
using FarukEmlak.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dc2bd5fa53f89826aab727305f5799d7a9c18d0", @"/Views/Kiralik/Bilgi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0e337b94640b7c857f3c186fac02bdd0f9cbff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Kiralik_Bilgi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Kiralik>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
  
    ViewData["Title"] = "bilgi";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <div style=""margin-left:30px;margin-right:30px"">
        <table class=""table table-bordered"" style=""background-color:#ccb5b5;"">
            <tr>
                <th> BAŞLIK</th>
                <th> KİRA </th>
                <th> ODA SAYISI</th>
                <th> METRE KARE</th>
                <th> BİNA YAŞI</th>
                <th> BİNA KAT SAYISI</th>
                <th> BULUNDUĞU KAT</th>
                <th> CEPHE</th>
                <th> İLAN TARİHİ</th>
                <th> ŞEHİR</th>
                <th> SEMT</th>
                <th> MAHALLE</th>
                <th> ADRES</th>



            </tr>
            <tbody>
");
#nullable restore
#line 32 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                 foreach (var x in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 35 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.Kira);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.Odasay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.MetreKare);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m2</td>\r\n                        <td>");
#nullable restore
#line 39 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.Binayas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.Binakat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 41 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.Bulunkat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.Cephe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.İlanTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.Sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.Semt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.Mahalle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 51 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </tbody>
        </table>
    </div>
    <div style=""width:600px;margin-left:300px"">
        <table class=""table table-bordered"" style=""background-color:#ccb5b5;"">
            <tr>
                <th> EV SAHİBİ</th>
                <th> YAŞ</th>
                <th> TELEFON</th>
            </tr>
            <tbody>
");
#nullable restore
#line 64 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                 foreach (var x in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 67 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.Musteri.AdSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 68 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.Musteri.Yas);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 69 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                       Write(x.Musteri.Telno);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    </tr>\r\n");
#nullable restore
#line 71 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\Bilgi.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Kiralik>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
