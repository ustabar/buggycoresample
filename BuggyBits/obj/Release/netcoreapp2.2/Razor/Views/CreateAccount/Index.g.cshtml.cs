#pragma checksum "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\CreateAccount\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ab06ea9a8b44db6aec5860c56876619d1cc452c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CreateAccount_Index), @"mvc.1.0.view", @"/Views/CreateAccount/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CreateAccount/Index.cshtml", typeof(AspNetCore.Views_CreateAccount_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ab06ea9a8b44db6aec5860c56876619d1cc452c", @"/Views/CreateAccount/Index.cshtml")]
    public class Views_CreateAccount_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BuggyBits.ViewModels.CreateAccountViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\CreateAccount\Index.cshtml"
  
    ViewData["Title"] = "Create User Account";

#line default
#line hidden
            BeginContext(104, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 7 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\CreateAccount\Index.cshtml"
 using (Html.BeginForm("Index", "CreateAccount", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(174, 75, true);
            WriteLiteral("<h2>Create a new user account</h2>\n<table>\n    <tr><td>First Name:</td><td>");
            EndContext();
            BeginContext(250, 33, false);
#line 11 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\CreateAccount\Index.cshtml"
                           Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(283, 42, true);
            WriteLiteral("</td></tr>\n    <tr><td>Last Name:</td><td>");
            EndContext();
            BeginContext(326, 32, false);
#line 12 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\CreateAccount\Index.cshtml"
                          Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(358, 42, true);
            WriteLiteral("</td></tr>\n    <tr><td>User Name:</td><td>");
            EndContext();
            BeginContext(401, 32, false);
#line 13 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\CreateAccount\Index.cshtml"
                          Write(Html.TextBoxFor(m => m.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(433, 86, true);
            WriteLiteral("</td></tr>\n    <tr><td></td><td><input type=\"submit\" value=\"OK\" /></td></tr>\n</table>\n");
            EndContext();
#line 16 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\CreateAccount\Index.cshtml"
}

#line default
#line hidden
            BeginContext(521, 21, true);
            WriteLiteral("<br />\n<br />\n<br />\n");
            EndContext();
            BeginContext(543, 18, false);
#line 20 "C:\Analiz\Ziraat\CoreBuggy\buggy-bits-core-master\src\BuggyBits\Views\CreateAccount\Index.cshtml"
Write(ViewData["Result"]);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BuggyBits.ViewModels.CreateAccountViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
