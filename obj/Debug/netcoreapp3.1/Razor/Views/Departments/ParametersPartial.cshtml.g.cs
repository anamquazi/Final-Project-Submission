#pragma checksum "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1b0870a22bafe369f3f0f7f241d3bda1ca9c71c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_ParametersPartial), @"mvc.1.0.view", @"/Views/Departments/ParametersPartial.cshtml")]
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
#line 2 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
using Perfomans.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1b0870a22bafe369f3f0f7f241d3bda1ca9c71c", @"/Views/Departments/ParametersPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9040d319330686114fb437e0bf9041a8738d7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Departments_ParametersPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Perfomans.Models.Departments>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
  
    ViewData["Title"] = "Parameter";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table_main\">\n    <caption>Parameters</caption>\n    <thead>\n        <tr>\n            <th>Name</th>\n            <th>Mark</th>\n            <th>Actions</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 18 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
         foreach (DepartmentParameters deparameters in Model.DepartmentParameters)
        {
            if (deparameters.DepartmentId == Model.Id)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n");
#nullable restore
#line 23 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
                     foreach (Parameters parameters in ViewBag.Parameters)
                    {
                        if (deparameters.ParameterId == parameters.Id)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 27 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
                           Write(parameters.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 28 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"

                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\n                        ");
#nullable restore
#line 32 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
                   Write(deparameters.mark);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n");
#nullable restore
#line 35 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
                         using (Html.BeginForm("Delete", "DepParam", FormMethod.Get))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"hidden\" id=\"DepartmentId\" name=\"DepartmentId\"");
            BeginWriteAttribute("value", " value=\"", 1107, "\"", 1141, 1);
#nullable restore
#line 37 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
WriteAttributeValue("", 1115, deparameters.DepartmentId, 1115, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                            <input type=\"hidden\" id=\"ParameterId\" name=\"ParameterId\"");
            BeginWriteAttribute("value", " value=\"", 1230, "\"", 1263, 1);
#nullable restore
#line 38 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
WriteAttributeValue("", 1238, deparameters.ParameterId, 1238, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                            <button type=\"submit\" class=\"btn_danger\">Delete</button>\n");
#nullable restore
#line 40 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 42 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
                         using (Html.BeginForm("Edit", "DepParam", FormMethod.Get))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"hidden\" id=\"DepartmentId\" name=\"DepartmentId\"");
            BeginWriteAttribute("value", " value=\"", 1576, "\"", 1610, 1);
#nullable restore
#line 44 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
WriteAttributeValue("", 1584, deparameters.DepartmentId, 1584, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                            <input type=\"hidden\" id=\"ParameterId\" name=\"ParameterId\"");
            BeginWriteAttribute("value", " value=\"", 1699, "\"", 1732, 1);
#nullable restore
#line 45 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
WriteAttributeValue("", 1707, deparameters.ParameterId, 1707, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                            <button type=\"submit\" class=\"btn_edit\">Edit</button>\n");
#nullable restore
#line 47 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                </tr>\n");
#nullable restore
#line 50 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n    <tfoot class=\"full-width\">\n        <tr>\n            <th colspan=\"4\">\n                <div class=\"ui right floated small\">\n");
#nullable restore
#line 58 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
                     using (Html.BeginForm("Create", "DepParam", FormMethod.Get))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"hidden\" Id=\"depId\" name=\"depId\"");
            BeginWriteAttribute("value", " value=\"", 2228, "\"", 2245, 1);
#nullable restore
#line 60 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
WriteAttributeValue("", 2236, Model.Id, 2236, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <button type=\"submit\" class=\"btn_create\">Create New</button>\n");
#nullable restore
#line 62 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\ParametersPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n\n            </th>\n        </tr>\n    </tfoot>\n</table>");
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
