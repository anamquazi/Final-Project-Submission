#pragma checksum "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f406535194af1d078898dd5d68a96d954be0d08c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_TopEmployees), @"mvc.1.0.view", @"/Views/Departments/TopEmployees.cshtml")]
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
#line 1 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\_ViewImports.cshtml"
using Perfomans;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
using Perfomans.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f406535194af1d078898dd5d68a96d954be0d08c", @"/Views/Departments/TopEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9040d319330686114fb437e0bf9041a8738d7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Departments_TopEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Perfomans.Models.Departments>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
  
    ViewData["Title"] = "Top workers";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Best workers of this group</h1>\n\n<table class=\"table_main\">\n    <thead>\n        <tr>\n            <th>Name</th>\n            <th>Surname</th>\n            <th>Perfomances</th>\n            <th>Result</th>\n        </tr>\n    </thead>\n    <tbody>\n\n");
#nullable restore
#line 20 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
         foreach (User user in ViewBag.topsort)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 24 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
               Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 27 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
               Write(user.SourName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 30 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
                     foreach (ParametersGroup parametersGroup in ViewBag.ParametersGroup)

                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
                         foreach (Evaluations evaluations in ViewBag.Evaluations)

                        {
                            if ((parametersGroup.GroupId == ViewBag.GroupId) & (parametersGroup.ParameterId == evaluations.ParameterId) & (evaluations.UserId == user.Id))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
                           Write(evaluations.Parameter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>-</span> ");
#nullable restore
#line 38 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
                                                                      Write(evaluations.Mark);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
                                                                                            

                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <br />\n");
#nullable restore
#line 43 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n                <td>\n");
#nullable restore
#line 46 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
                     if (user.result != 0)
                    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
                Write(user.result);

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 51 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n<div class=\"btn_create\">\n    ");
#nullable restore
#line 55 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\TopEmployees.cshtml"
Write(Html.ActionLink("Export data to excel", "Excel", "Departments"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Perfomans.Models.Departments> Html { get; private set; }
    }
}
#pragma warning restore 1591
