#pragma checksum "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Customer\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41857567c9bc7d13c37521be93b52ae0b0e8f981"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Profile), @"mvc.1.0.view", @"/Views/Customer/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Profile.cshtml", typeof(AspNetCore.Views_Customer_Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41857567c9bc7d13c37521be93b52ae0b0e8f981", @"/Views/Customer/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e525b6a56ce12e207c7bf183553a0490af57352", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerProflieViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Customer\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(78, 68, true);
            WriteLiteral("\r\n<h2>Profile</h2>\r\n\r\n<div>\r\n    <h4>CustomerProflieViewModel</h4>\r\n");
            EndContext();
            BeginContext(187, 18, true);
            WriteLiteral("    <p>User Name: ");
            EndContext();
            BeginContext(206, 14, false);
#line 12 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Customer\Profile.cshtml"
             Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(220, 25, true);
            WriteLiteral("</p>\r\n    <p>First Name: ");
            EndContext();
            BeginContext(246, 15, false);
#line 13 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Customer\Profile.cshtml"
              Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(261, 24, true);
            WriteLiteral("</p>\r\n    <p>Last Name: ");
            EndContext();
            BeginContext(286, 14, false);
#line 14 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Customer\Profile.cshtml"
             Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(300, 20, true);
            WriteLiteral("</p>\r\n    <p>Email: ");
            EndContext();
            BeginContext(321, 11, false);
#line 15 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Customer\Profile.cshtml"
         Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(332, 20, true);
            WriteLiteral("</p>\r\n    <p>Phone: ");
            EndContext();
            BeginContext(353, 11, false);
#line 16 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Customer\Profile.cshtml"
         Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(364, 18, true);
            WriteLiteral("</p>\r\n    <p>DOB: ");
            EndContext();
            BeginContext(383, 9, false);
#line 17 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Customer\Profile.cshtml"
       Write(Model.DOB);

#line default
#line hidden
            EndContext();
            BeginContext(392, 21, true);
            WriteLiteral("</p>\r\n    <p>Gender: ");
            EndContext();
            BeginContext(414, 12, false);
#line 18 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Customer\Profile.cshtml"
          Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(426, 30, true);
            WriteLiteral("</p>\r\n    <p>Default Address: ");
            EndContext();
            BeginContext(457, 13, false);
#line 19 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Customer\Profile.cshtml"
                   Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(470, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(484, 67, false);
#line 20 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Customer\Profile.cshtml"
  Write(Html.ActionLink("View all favourite addresses", "Index", "Address"));

#line default
#line hidden
            EndContext();
            BeginContext(551, 25, true);
            WriteLiteral("</p>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(577, 88, false);
#line 23 "C:\Users\Jw Villawood\Desktop\GrandeGift\GrandeGift\Views\Customer\Profile.cshtml"
Write(Html.ActionLink("Update", "UpdateProfile","Customer", new { Username = Model.Username }));

#line default
#line hidden
            EndContext();
            BeginContext(665, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(668, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c440c18502049d48da21f55786c5761", async() => {
                BeginContext(690, 12, true);
                WriteLiteral("Back to Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(706, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerProflieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
