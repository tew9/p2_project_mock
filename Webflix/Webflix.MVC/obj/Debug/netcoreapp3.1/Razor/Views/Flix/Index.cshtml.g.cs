#pragma checksum "/home/tango/revature/training-code/p2_project/Webflix/Webflix.MVC/Views/Flix/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a872decc17bf8236b452b70cd9209ce93ca2914"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flix_Index), @"mvc.1.0.view", @"/Views/Flix/Index.cshtml")]
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
#line 1 "/home/tango/revature/training-code/p2_project/Webflix/Webflix.MVC/Views/_ViewImports.cshtml"
using Webflix.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/tango/revature/training-code/p2_project/Webflix/Webflix.MVC/Views/_ViewImports.cshtml"
using Webflix.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a872decc17bf8236b452b70cd9209ce93ca2914", @"/Views/Flix/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37df65044af21d5643cf663fb20a40b256a2f6ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Flix_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Webflix.MVC.Models.FlixViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/tango/revature/training-code/p2_project/Webflix/Webflix.MVC/Views/Flix/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n  <ul>\n");
#nullable restore
#line 8 "/home/tango/revature/training-code/p2_project/Webflix/Webflix.MVC/Views/Flix/Index.cshtml"
     foreach (var item in @Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <li>");
#nullable restore
#line 10 "/home/tango/revature/training-code/p2_project/Webflix/Webflix.MVC/Views/Flix/Index.cshtml"
     Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> \n");
#nullable restore
#line 11 "/home/tango/revature/training-code/p2_project/Webflix/Webflix.MVC/Views/Flix/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Webflix.MVC.Models.FlixViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
