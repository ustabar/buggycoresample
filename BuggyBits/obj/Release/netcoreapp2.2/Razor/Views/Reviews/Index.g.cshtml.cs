#pragma checksum "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\Reviews\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc8c6a9d6b512a60201ae312a268ec871196bd60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_Index), @"mvc.1.0.view", @"/Views/Reviews/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reviews/Index.cshtml", typeof(AspNetCore.Views_Reviews_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc8c6a9d6b512a60201ae312a268ec871196bd60", @"/Views/Reviews/Index.cshtml")]
    public class Views_Reviews_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BuggyBits.ViewModels.ReviewsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\Reviews\Index.cshtml"
  
    ViewData["Title"] = "Reviews";

#line default
#line hidden
            BeginContext(86, 18, true);
            WriteLiteral("\n<h2>Reviews</h2>\n");
            EndContext();
            BeginContext(105, 13, false);
#line 8 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\Reviews\Index.cshtml"
Write(Model.Review1);

#line default
#line hidden
            EndContext();
            BeginContext(118, 8, true);
            WriteLiteral("\n<br />\n");
            EndContext();
            BeginContext(127, 13, false);
#line 10 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\Reviews\Index.cshtml"
Write(Model.Source1);

#line default
#line hidden
            EndContext();
            BeginContext(140, 15, true);
            WriteLiteral("\n<br />\n<br />\n");
            EndContext();
            BeginContext(156, 13, false);
#line 13 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\Reviews\Index.cshtml"
Write(Model.Review2);

#line default
#line hidden
            EndContext();
            BeginContext(169, 8, true);
            WriteLiteral("\n<br />\n");
            EndContext();
            BeginContext(178, 13, false);
#line 15 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\Reviews\Index.cshtml"
Write(Model.Source2);

#line default
#line hidden
            EndContext();
            BeginContext(191, 55, true);
            WriteLiteral("\n<br />\n<br />\n&nbsp;\n<a href=\"?refresh=1\">Refresh</a>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BuggyBits.ViewModels.ReviewsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
