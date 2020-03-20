#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b3bcb8bd5a1ce7bb75dc56898c47f5e6d97282f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Index), @"mvc.1.0.view", @"/Views/Stylists/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Index.cshtml", typeof(AspNetCore.Views_Stylists_Index))]
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
#line 4 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3bcb8bd5a1ce7bb75dc56898c47f5e6d97282f", @"/Views/Stylists/Index.cshtml")]
    public class Views_Stylists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HairSalon.Models.Stylist>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(91, 42, true);
            WriteLiteral("\n<h1>Stylists</h1>\n\n<div class=\"content\">\n");
            EndContext();
#line 10 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
   if (@Model.Count == 0)
  {

#line default
#line hidden
            BeginContext(163, 46, true);
            WriteLiteral("    <h3>No stylists have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
  } 

#line default
#line hidden
            BeginContext(214, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
   foreach (Stylist stylist in Model)
  {

#line default
#line hidden
            BeginContext(257, 8, true);
            WriteLiteral("    <h4>");
            EndContext();
            BeginContext(266, 77, false);
#line 17 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
   Write(Html.ActionLink($"{stylist.Name}", "Details", new { id = stylist.StylistId }));

#line default
#line hidden
            EndContext();
            BeginContext(343, 6, true);
            WriteLiteral("</h4>\n");
            EndContext();
#line 18 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(353, 34, true);
            WriteLiteral("</div>\n\n\n<div class=\"links\">\n  <p>");
            EndContext();
            BeginContext(388, 44, false);
#line 23 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
Write(Html.ActionLink("Add new stylist", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(432, 10, true);
            WriteLiteral("</p>\n  <p>");
            EndContext();
            BeginContext(443, 40, false);
#line 24 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(483, 12, true);
            WriteLiteral("</p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HairSalon.Models.Stylist>> Html { get; private set; }
    }
}
#pragma warning restore 1591