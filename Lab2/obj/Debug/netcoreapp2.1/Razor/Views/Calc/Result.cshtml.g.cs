#pragma checksum "D:\Учеба\6 семестр\Web\daniil.haibullin.931705-master\Lab2\Lab2\Views\Calc\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4f6064593149308429c791b9fa832bf097f1399"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_Result), @"mvc.1.0.view", @"/Views/Calc/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calc/Result.cshtml", typeof(AspNetCore.Views_Calc_Result))]
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
#line 1 "D:\Учеба\6 семестр\Web\daniil.haibullin.931705-master\Lab2\Lab2\Views\_ViewImports.cshtml"
using Lab2;

#line default
#line hidden
#line 2 "D:\Учеба\6 семестр\Web\daniil.haibullin.931705-master\Lab2\Lab2\Views\_ViewImports.cshtml"
using Lab2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f6064593149308429c791b9fa832bf097f1399", @"/Views/Calc/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c89765656c821c781e86e91f6556d3354219de22", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "D:\Учеба\6 семестр\Web\daniil.haibullin.931705-master\Lab2\Lab2\Views\Calc\Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
            BeginContext(40, 22, true);
            WriteLiteral("\n<h2>Result</h2>\n<div>");
            EndContext();
            BeginContext(63, 14, false);
#line 7 "D:\Учеба\6 семестр\Web\daniil.haibullin.931705-master\Lab2\Lab2\Views\Calc\Result.cshtml"
Write(ViewBag.input1);

#line default
#line hidden
            EndContext();
            BeginContext(77, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(79, 17, false);
#line 7 "D:\Учеба\6 семестр\Web\daniil.haibullin.931705-master\Lab2\Lab2\Views\Calc\Result.cshtml"
                Write(ViewBag.operation);

#line default
#line hidden
            EndContext();
            BeginContext(96, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(98, 14, false);
#line 7 "D:\Учеба\6 семестр\Web\daniil.haibullin.931705-master\Lab2\Lab2\Views\Calc\Result.cshtml"
                                   Write(ViewBag.input2);

#line default
#line hidden
            EndContext();
            BeginContext(112, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(116, 14, false);
#line 7 "D:\Учеба\6 семестр\Web\daniil.haibullin.931705-master\Lab2\Lab2\Views\Calc\Result.cshtml"
                                                     Write(ViewBag.result);

#line default
#line hidden
            EndContext();
            BeginContext(130, 7, true);
            WriteLiteral("</div>\n");
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
