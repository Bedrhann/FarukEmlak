#pragma checksum "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\parcalistele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed6d7309cb857befedce6139cc5d93662835e9f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kiralik_parcalistele), @"mvc.1.0.view", @"/Views/Kiralik/parcalistele.cshtml")]
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
#line 1 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\parcalistele.cshtml"
using FarukEmlak.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\parcalistele.cshtml"
using FarukEmlak.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed6d7309cb857befedce6139cc5d93662835e9f4", @"/Views/Kiralik/parcalistele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0e337b94640b7c857f3c186fac02bdd0f9cbff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Kiralik_parcalistele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Kiralik>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"


    <div style=""margin-left:400px;width:1100px;height:1300px;"">
        <h1 style=""margin-left:300px"">KİRALIK EVLER </h1>
        <div style=""margin-left:30px;margin-right:30px"">
            <table class=""table table-bordered"" style=""background-color:#ccb5b5;"">
                <tr>
                    <th> BAŞLIK</th>
                    <th> ID</th>
                    <th> KİRA </th>
                    <th> ODA SAYISI</th>
                    <th> METRE KARE</th>
                    <th> BULUNDUĞU KAT</th>
                    <th> ŞEHİR</th>
                    <th> DETAYLAR</th>



                </tr>
                <tbody>
");
#nullable restore
#line 28 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\parcalistele.cshtml"
                     foreach (var kira in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 31 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\parcalistele.cshtml"
                           Write(kira.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\parcalistele.cshtml"
                           Write(kira.KiralikID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\parcalistele.cshtml"
                           Write(kira.Kira);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\parcalistele.cshtml"
                           Write(kira.Odasay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\parcalistele.cshtml"
                           Write(kira.MetreKare);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m2</td>\r\n                            <td>");
#nullable restore
#line 36 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\parcalistele.cshtml"
                           Write(kira.Bulunkat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\parcalistele.cshtml"
                           Write(kira.Sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1287, "\"", 1324, 2);
            WriteAttributeValue("", 1294, "/Kiralik/bilgi/", 1294, 15, true);
#nullable restore
#line 38 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\parcalistele.cshtml"
WriteAttributeValue("", 1309, kira.KiralikID, 1309, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" style=\"background-color:#b18282\">DETAYLAR</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 40 "D:\Yeni klasör\bedirhan\Dersler\DERS\Staj\FarukEmlak\Views\Kiralik\parcalistele.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
