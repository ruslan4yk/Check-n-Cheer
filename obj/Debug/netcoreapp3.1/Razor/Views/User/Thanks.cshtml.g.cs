#pragma checksum "C:\Users\User\source\repos\Check-n-Cheer\Check-n-Cheer\Views\User\Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2a7d54e7789039e4325b1d04b4c01da84176fda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Thanks), @"mvc.1.0.view", @"/Views/User/Thanks.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Check-n-Cheer\Check-n-Cheer\Views\_ViewImports.cshtml"
using Check_n_Cheer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Check-n-Cheer\Check-n-Cheer\Views\_ViewImports.cshtml"
using Check_n_Cheer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2a7d54e7789039e4325b1d04b4c01da84176fda", @"/Views/User/Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"043111b0a253fe5d6b8ca17107fbc3066f2666cf", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Check_n_Cheer.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\Check-n-Cheer\Check-n-Cheer\Views\User\Thanks.cshtml"
  
    ViewData["Title"] = "Thanks";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Thanks for ");
#nullable restore
#line 6 "C:\Users\User\source\repos\Check-n-Cheer\Check-n-Cheer\Views\User\Thanks.cshtml"
          Write(ViewData["Type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p>Email: ");
#nullable restore
#line 7 "C:\Users\User\source\repos\Check-n-Cheer\Check-n-Cheer\Views\User\Thanks.cshtml"
     Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Password: ");
#nullable restore
#line 8 "C:\Users\User\source\repos\Check-n-Cheer\Check-n-Cheer\Views\User\Thanks.cshtml"
        Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Check_n_Cheer.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
