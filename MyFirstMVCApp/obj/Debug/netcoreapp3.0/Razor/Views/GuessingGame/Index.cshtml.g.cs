#pragma checksum "C:\Users\Arwa\Desktop\MyFirstMVCApp\MyFirstMVCApp\Views\GuessingGame\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dcf9b28bf12437a38961a504749f3b5ea521f83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GuessingGame_Index), @"mvc.1.0.view", @"/Views/GuessingGame/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dcf9b28bf12437a38961a504749f3b5ea521f83", @"/Views/GuessingGame/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1291ba3cba921beceb44c9c35198eea1bb6edfe0", @"/Views/_ViewImports.cshtml")]
    public class Views_GuessingGame_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyFirstMVCApp.Models.InputNum>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GuessingGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuessNumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Arwa\Desktop\MyFirstMVCApp\MyFirstMVCApp\Views\GuessingGame\Index.cshtml"
  
    ViewData["Title"] = "GuessingGame";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"display-4 text-center\">\r\n\r\n        <h1>Guessing Game</h1>\r\n");
            WriteLiteral("\r\n       \r\n    <h5> You are logged in as:    ");
#nullable restore
#line 11 "C:\Users\Arwa\Desktop\MyFirstMVCApp\MyFirstMVCApp\Views\GuessingGame\Index.cshtml"
                             Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    </div>\r\n\r\n       \r\n<br />\r\n<br />\r\n\r\n<div class=\"text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dcf9b28bf12437a38961a504749f3b5ea521f834922", async() => {
                WriteLiteral("\r\n\r\n       \r\n        <span>Enter Number (you are allowed 5 guesses) : </span> <input id=\"Text1\" type=\"text\" name=\"txtFirst\" /> <br /><br />\r\n       \r\n        <input id=\"Submit1\" type=\"submit\" value=\"Guess\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <h4>\r\n        ");
#nullable restore
#line 28 "C:\Users\Arwa\Desktop\MyFirstMVCApp\MyFirstMVCApp\Views\GuessingGame\Index.cshtml"
   Write(ViewBag.SumResult);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        ");
#nullable restore
#line 29 "C:\Users\Arwa\Desktop\MyFirstMVCApp\MyFirstMVCApp\Views\GuessingGame\Index.cshtml"
   Write(ViewBag.SumResult1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        ");
#nullable restore
#line 30 "C:\Users\Arwa\Desktop\MyFirstMVCApp\MyFirstMVCApp\Views\GuessingGame\Index.cshtml"
   Write(ViewBag.SumResult3);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
            WriteLiteral("\r\n\r\n    </h4>\r\n    \r\n\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyFirstMVCApp.Models.InputNum> Html { get; private set; }
    }
}
#pragma warning restore 1591
