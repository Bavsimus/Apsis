#pragma checksum "C:\Users\talib\source\repos\Apsis_190421\Views\Account\giris_hata.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1216640b400a7b1962f23d04f342977eab998feb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_giris_hata), @"mvc.1.0.view", @"/Views/Account/giris_hata.cshtml")]
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
#line 1 "C:\Users\talib\source\repos\Apsis_190421\Views\_ViewImports.cshtml"
using Apsis_190421;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\talib\source\repos\Apsis_190421\Views\_ViewImports.cshtml"
using Apsis_190421.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1216640b400a7b1962f23d04f342977eab998feb", @"/Views/Account/giris_hata.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83888dfe1614fb9e43c7513a5bc1277478aae2e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_giris_hata : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\talib\source\repos\Apsis_190421\Views\Account\giris_hata.cshtml"
  
    ViewData["Title"] = "Hata";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container col-md-8 text-center"">
    <div class=""align-items-center"">
        <div class=""bannerw3-content mt-lg-5 mt-4"">
            <span class=""title-small text-white-50"">Bir sorun var.</span>
            <h3 class=""mb-2 title text-white"">
                <span>
                    Lütfen, <br class=""text-white-50"">kayıtlı bir hesabınız olduğundan emin olun.
                </span>
            </h3>
            <p class=""mt-4 pr-lg-5 text-danger"">
                Şifreniz veya kullanıcı adınız
                <br />hatalı.
            </p>
        </div>
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
