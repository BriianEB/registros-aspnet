#pragma checksum "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Alumnos/Ver.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b2f51884c1c99a8426829444598094e5149d43f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alumnos_Ver), @"mvc.1.0.view", @"/Views/Alumnos/Ver.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Alumnos/Ver.cshtml", typeof(AspNetCore.Views_Alumnos_Ver))]
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
#line 1 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/_ViewImports.cshtml"
using RegistroAlumnosYProfesores;

#line default
#line hidden
#line 2 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/_ViewImports.cshtml"
using RegistroAlumnosYProfesores.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b2f51884c1c99a8426829444598094e5149d43f", @"/Views/Alumnos/Ver.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a85c8396a612d724d75465ee406e96598841a6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Alumnos_Ver : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegistroAlumnosYProfesores.Models.AlumnoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Alumnos/Ver.cshtml"
  
    ViewData["Title"] = "Ver alumno";

#line default
#line hidden
            BeginContext(102, 276, true);
            WriteLiteral(@"
<div class=""alumnos-section"">
    <h2>Detalles del alumno</h2>
    <table class=""tabla-detalles"">
        <thead>
            <tr>
                <th>Detalles del alumno</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>");
            EndContext();
            BeginContext(379, 15, false);
#line 17 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Alumnos/Ver.cshtml"
               Write(Model.Matricula);

#line default
#line hidden
            EndContext();
            BeginContext(394, 64, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(459, 12, false);
#line 20 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Alumnos/Ver.cshtml"
               Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(471, 64, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(536, 13, false);
#line 23 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Alumnos/Ver.cshtml"
               Write(Model.Carrera);

#line default
#line hidden
            EndContext();
            BeginContext(549, 64, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(614, 11, false);
#line 26 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Alumnos/Ver.cshtml"
               Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(625, 64, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(690, 14, false);
#line 29 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Alumnos/Ver.cshtml"
               Write(Model.Telefono);

#line default
#line hidden
            EndContext();
            BeginContext(704, 64, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegistroAlumnosYProfesores.Models.AlumnoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591