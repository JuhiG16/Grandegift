#pragma checksum "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\GrandeGift\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "458e6c385e685c917003898c9596879239091eab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
#line 1 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\GrandeGift\Views\_ViewImports.cshtml"
using GrandeGift.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"458e6c385e685c917003898c9596879239091eab", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e525b6a56ce12e207c7bf183553a0490af57352", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\GrandeGift\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 30, true);
            WriteLiteral("\r\n<h2>Account Page</h2>\r\n\r\n<p>");
            EndContext();
            BeginContext(74, 44, false);
#line 8 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\GrandeGift\Views\Account\Index.cshtml"
Write(Html.ActionLink("Login", "Login", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(118, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(128, 50, false);
#line 9 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\GrandeGift\Views\Account\Index.cshtml"
Write(Html.ActionLink("Sign Up!", "Register", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(178, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(188, 63, false);
#line 10 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\GrandeGift\Views\Account\Index.cshtml"
Write(Html.ActionLink("Forgot Password!", "ResetPassword", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(251, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(317, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
