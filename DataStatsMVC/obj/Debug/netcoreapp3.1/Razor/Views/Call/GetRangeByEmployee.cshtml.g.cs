#pragma checksum "C:\Users\dghoo\source\repos\DataStats\DataStatsMVC\Views\Call\GetRangeByEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67f37e50a909b3d6b9324703c3c4c65315b063e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Call_GetRangeByEmployee), @"mvc.1.0.view", @"/Views/Call/GetRangeByEmployee.cshtml")]
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
#line 1 "C:\Users\dghoo\source\repos\DataStats\DataStatsMVC\Views\_ViewImports.cshtml"
using DataStatsMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dghoo\source\repos\DataStats\DataStatsMVC\Views\_ViewImports.cshtml"
using DataStatsMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dghoo\source\repos\DataStats\DataStatsMVC\Views\_ViewImports.cshtml"
using DataStatsMVC.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dghoo\source\repos\DataStats\DataStatsMVC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dghoo\source\repos\DataStats\DataStatsMVC\Views\_ViewImports.cshtml"
using DataStatsMVC.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67f37e50a909b3d6b9324703c3c4c65315b063e3", @"/Views/Call/GetRangeByEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf699b23dae6ddeb68eb58f540b5510de276e662", @"/Views/_ViewImports.cshtml")]
    public class Views_Call_GetRangeByEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Call>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table-secondary"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Deparment</th>
            <th scope=""col"">Date</th>
            <th scope=""col"">AHT</th>
            <th scope=""col"">Surname</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "C:\Users\dghoo\source\repos\DataStats\DataStatsMVC\Views\Call\GetRangeByEmployee.cshtml"
         foreach (var call in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">#</td>\r\n                <td scope=\"row\">");
#nullable restore
#line 18 "C:\Users\dghoo\source\repos\DataStats\DataStatsMVC\Views\Call\GetRangeByEmployee.cshtml"
                           Write(call.DepartmentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td scope=\"row\">");
#nullable restore
#line 19 "C:\Users\dghoo\source\repos\DataStats\DataStatsMVC\Views\Call\GetRangeByEmployee.cshtml"
                           Write(call.Start.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td scope=\"row\">");
#nullable restore
#line 20 "C:\Users\dghoo\source\repos\DataStats\DataStatsMVC\Views\Call\GetRangeByEmployee.cshtml"
                           Write(call.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td scope=\"row\">");
#nullable restore
#line 21 "C:\Users\dghoo\source\repos\DataStats\DataStatsMVC\Views\Call\GetRangeByEmployee.cshtml"
                           Write(call.Finish.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\dghoo\source\repos\DataStats\DataStatsMVC\Views\Call\GetRangeByEmployee.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Call>> Html { get; private set; }
    }
}
#pragma warning restore 1591