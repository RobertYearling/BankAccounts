#pragma checksum "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/BankAcoounts/Views/Home/Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fffec7ffc3f5a32fae67eb376a49c21f5888b5b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Account), @"mvc.1.0.view", @"/Views/Home/Account.cshtml")]
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
#line 1 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/BankAcoounts/Views/_ViewImports.cshtml"
using BankAcoounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/BankAcoounts/Views/_ViewImports.cshtml"
using BankAcoounts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fffec7ffc3f5a32fae67eb376a49c21f5888b5b6", @"/Views/Home/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5cbd8a470dcfade3c633ab02b008c16ecff1767", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/BankAcoounts/Views/Home/Account.cshtml"
  
    ViewData["Title"] = "Account";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Welcome, ");
#nullable restore
#line 7 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/BankAcoounts/Views/Home/Account.cshtml"
        Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<p>Current Balance: </p>
<p>Deposit/Withdrawl </p>
<input type=""submit"" value=""Submit"">
<table>
    <thead>
        <tr>
            <th>Amount:</th>
            <th>Date:</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td></td>
            <td></td>
        </tr>
    </tbody>
</table>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591