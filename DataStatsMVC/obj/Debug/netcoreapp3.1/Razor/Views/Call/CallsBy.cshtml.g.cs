#pragma checksum "C:\Users\dghoo\source\repos\DataStats\DataStatsMVC\Views\Call\CallsBy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bc7d7c05bab3a6a6fa064cde130b8d3dd695e85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Call_CallsBy), @"mvc.1.0.view", @"/Views/Call/CallsBy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bc7d7c05bab3a6a6fa064cde130b8d3dd695e85", @"/Views/Call/CallsBy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf699b23dae6ddeb68eb58f540b5510de276e662", @"/Views/_ViewImports.cshtml")]
    public class Views_Call_CallsBy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h3 class=""m-2"">How would you like to view the call list?</h3>

    <button style=""width:auto"" class=""mt-2 mb-2 mx-auto btn btn-secondary"">
        By Department
    </button>

    <br />    

    <button style=""width:auto"" class=""mt-2 mb-2 mx-auto btn btn-secondary btn"">
        By Employee
    </button>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591