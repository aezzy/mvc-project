#pragma checksum "C:\Users\Arwa\Desktop\MyFirstMVCApp\MyFirstMVCApp\Views\Fever\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae7eff40a56bf199f94330e2704388d66e020cb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fever_Index), @"mvc.1.0.view", @"/Views/Fever/Index.cshtml")]
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
#line 1 "C:\Users\Arwa\Desktop\MyFirstMVCApp\MyFirstMVCApp\Views\_ViewImports.cshtml"
using MyFirstMVCApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arwa\Desktop\MyFirstMVCApp\MyFirstMVCApp\Views\_ViewImports.cshtml"
using MyFirstMVCApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae7eff40a56bf199f94330e2704388d66e020cb2", @"/Views/Fever/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1291ba3cba921beceb44c9c35198eea1bb6edfe0", @"/Views/_ViewImports.cshtml")]
    public class Views_Fever_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyFirstMVCApp.Models.Temperature>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Arwa\Desktop\MyFirstMVCApp\MyFirstMVCApp\Views\Fever\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Arwa\Desktop\MyFirstMVCApp\MyFirstMVCApp\Views\Fever\Index.cshtml"
 using (Html.BeginForm("Index", "Fever", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>\r\n        Check your fever\r\n    </h1>\r\n");
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\Arwa\Desktop\MyFirstMVCApp\MyFirstMVCApp\Views\Fever\Index.cshtml"
Write(Html.EditorFor(m => m.TNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "C:\Users\Arwa\Desktop\MyFirstMVCApp\MyFirstMVCApp\Views\Fever\Index.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"check\" />\r\n    <button type=\"reset\" class=\"btn btn-danger\">Reset</button>\r\n");
#nullable restore
#line 24 "C:\Users\Arwa\Desktop\MyFirstMVCApp\MyFirstMVCApp\Views\Fever\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyFirstMVCApp.Models.Temperature> Html { get; private set; }
    }
}
#pragma warning restore 1591
