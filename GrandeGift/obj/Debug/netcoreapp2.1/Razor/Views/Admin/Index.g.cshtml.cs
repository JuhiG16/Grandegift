#pragma checksum "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da4bf03a65a3c654a5a5bda664e3b656cd151605"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
#line 1 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\_ViewImports.cshtml"
using GrandeGift.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da4bf03a65a3c654a5a5bda664e3b656cd151605", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e525b6a56ce12e207c7bf183553a0490af57352", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 26, true);
            WriteLiteral("\r\n<h2>welcome Admin</h2>\r\n");
            EndContext();
            BeginContext(70, 47, false);
#line 7 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Admin\Index.cshtml"
Write(Html.ActionLink("Log out", "LogOut", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(117, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(120, 50, false);
#line 8 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Admin\Index.cshtml"
Write(Html.ActionLink("View Hampers", "Index", "Hamper"));

#line default
#line hidden
            EndContext();
            BeginContext(170, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(173, 50, false);
#line 9 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Admin\Index.cshtml"
Write(Html.ActionLink("Add Hampers", "Create", "Hamper"));

#line default
#line hidden
            EndContext();
            BeginContext(223, 4, true);
            WriteLiteral("\r\n\r\n");
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
