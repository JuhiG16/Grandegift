#pragma checksum "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Hamper\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "320bb29642aa2430a2bff86de1d86817b707d7c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hamper_Index), @"mvc.1.0.view", @"/Views/Hamper/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Hamper/Index.cshtml", typeof(AspNetCore.Views_Hamper_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"320bb29642aa2430a2bff86de1d86817b707d7c2", @"/Views/Hamper/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e525b6a56ce12e207c7bf183553a0490af57352", @"/Views/_ViewImports.cshtml")]
    public class Views_Hamper_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HamperIndexViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 315, true);
            WriteLiteral(@"
<table class=""table table-primary mt-4"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Details</th>
            <th>Price</th>
            <th>Category</th>
            <th>Details</th>
            <th>Update</th>

        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 17 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Hamper\Index.cshtml"
         foreach (var hamp in Model)
        {

#line default
#line hidden
            BeginContext(406, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(437, 7, false);
#line 20 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Hamper\Index.cshtml"
           Write(hamp.Id);

#line default
#line hidden
            EndContext();
            BeginContext(444, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(468, 9, false);
#line 21 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Hamper\Index.cshtml"
           Write(hamp.Name);

#line default
#line hidden
            EndContext();
            BeginContext(477, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(501, 12, false);
#line 22 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Hamper\Index.cshtml"
           Write(hamp.Details);

#line default
#line hidden
            EndContext();
            BeginContext(513, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(537, 10, false);
#line 23 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Hamper\Index.cshtml"
           Write(hamp.Price);

#line default
#line hidden
            EndContext();
            BeginContext(547, 54, true);
            WriteLiteral("</td>\r\n            <td>Category</td>\r\n            <td>");
            EndContext();
            BeginContext(602, 74, false);
#line 25 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Hamper\Index.cshtml"
           Write(Html.ActionLink("View Details", "Details", "Hamper", new { id = hamp.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(676, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(700, 67, false);
#line 26 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Hamper\Index.cshtml"
           Write(Html.ActionLink("Update", "Update", "Hamper", new { id = hamp.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(767, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Hamper\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(800, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(827, 49, false);
#line 32 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Hamper\Index.cshtml"
Write(Html.ActionLink("Back to home", "Index", "Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(876, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HamperIndexViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
