#pragma checksum "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\CompanyInformation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4718a0a5bbb704b3493c7901f836d516bba18a08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CompanyInformation_Index), @"mvc.1.0.view", @"/Views/CompanyInformation/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CompanyInformation/Index.cshtml", typeof(AspNetCore.Views_CompanyInformation_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4718a0a5bbb704b3493c7901f836d516bba18a08", @"/Views/CompanyInformation/Index.cshtml")]
    public class Views_CompanyInformation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BuggyBits.ViewModels.ContactViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\CompanyInformation\Index.cshtml"
  
    ViewData["Title"] = "Company Information";

#line default
#line hidden
            BeginContext(98, 394, true);
            WriteLiteral(@"
<h2>Company Information</h2>
<p>Buggy Bits was established in 1994 as a one-man company delivering really buggy software and t-shirts noone would ever wear.</p>
<p>
    Since then it has grown into a large organization with over 1754 employees and the main focus for the
    company today is to sell worthless products at horribly high
    prices.
</p>
<p></p>
<p><b>Send us a mesasge</b></p>
");
            EndContext();
#line 16 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\CompanyInformation\Index.cshtml"
 using (Html.BeginForm("Contact", "CompanyInformation", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(573, 31, false);
#line 18 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\CompanyInformation\Index.cshtml"
Write(Html.TextBoxFor(m => m.Message));

#line default
#line hidden
            EndContext();
            BeginContext(606, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Send\" />\n");
            EndContext();
#line 21 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\CompanyInformation\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BuggyBits.ViewModels.ContactViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
