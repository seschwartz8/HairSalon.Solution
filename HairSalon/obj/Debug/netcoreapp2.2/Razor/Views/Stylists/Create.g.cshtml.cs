#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ee8499b467cb480ffc0b463172366e2a252e665"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Create), @"mvc.1.0.view", @"/Views/Stylists/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Create.cshtml", typeof(AspNetCore.Views_Stylists_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee8499b467cb480ffc0b463172366e2a252e665", @"/Views/Stylists/Create.cshtml")]
    public class Views_Stylists_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(59, 51, true);
            WriteLiteral("\n<h1>Add a new stylist</h1>\n\n<div class=\"content\">\n");
            EndContext();
#line 9 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
   using (Html.BeginForm())
  {
      

#line default
#line hidden
            BeginContext(149, 34, false);
#line 11 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
 Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(191, 36, false);
#line 12 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
 Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(236, 39, false);
#line 14 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
 Write(Html.LabelFor(model => model.Specialty));

#line default
#line hidden
            EndContext();
            BeginContext(283, 41, false);
#line 15 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
 Write(Html.TextBoxFor(model => model.Specialty));

#line default
#line hidden
            EndContext();
            BeginContext(333, 34, false);
#line 17 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
 Write(Html.LabelFor(model => model.Rate));

#line default
#line hidden
            EndContext();
            BeginContext(375, 36, false);
#line 18 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
 Write(Html.TextBoxFor(model => model.Rate));

#line default
#line hidden
            EndContext();
            BeginContext(412, 65, true);
            WriteLiteral("      <input type=\"submit\" value=\"Add new stylist\" class=\"btn\"/>\n");
            EndContext();
#line 20 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
  }

#line default
#line hidden
            BeginContext(481, 33, true);
            WriteLiteral("</div>\n\n<div class=\"links\">\n  <p>");
            EndContext();
            BeginContext(515, 45, false);
#line 24 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.ActionLink("Show all stylists", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(560, 12, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591