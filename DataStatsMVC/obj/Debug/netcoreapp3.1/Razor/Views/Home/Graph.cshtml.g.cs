#pragma checksum "C:\Users\dghoo\source\repos\DataStats\DataStatsMVC\Views\Home\Graph.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfdc3e4de027cb0bdfcbc5171257ec5da69337f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Graph), @"mvc.1.0.view", @"/Views/Home/Graph.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfdc3e4de027cb0bdfcbc5171257ec5da69337f2", @"/Views/Home/Graph.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf699b23dae6ddeb68eb58f540b5510de276e662", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Graph : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<script src=""https://code.highcharts.com/highcharts.js"">

</script>
<script src=""https://code.highcharts.com/modules/exporting.js""></script>
<script src=""https://code.highcharts.com/modules/export-data.js""></script>
<script src=""https://code.highcharts.com/modules/accessibility.js""></script>


<figure class=""highcharts-figure"">
    <div id=""container"" class=""pt-4""></div>
    <p class=""highcharts-description"">
        This chart shows total calls handled each month for the selected date range and the associated
        AHT for those calls.
    </p>
</figure>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
