#pragma checksum "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9338e20bfb52b362d447c6857b9cde7c952ce43e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\_ViewImports.cshtml"
using CoffeeShopLabFixed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\_ViewImports.cshtml"
using CoffeeShopLabFixed.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9338e20bfb52b362d447c6857b9cde7c952ce43e", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d91dd3b590f90e8761d83c6079110ddfd17bbab4", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Your selected product details:</h3>\r\n\r\n");
#nullable restore
#line 8 "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\Product\Detail.cshtml"
Write(Model.productNAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\Product\Detail.cshtml"
Write(Model.productDESCRIPTION);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n$");
#nullable restore
#line 12 "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\Product\Detail.cshtml"
Write(Model.productPRICE);

#line default
#line hidden
#nullable disable
            WriteLiteral(" per drink\r\n<br />\r\nCategory: ");
#nullable restore
#line 14 "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\Product\Detail.cshtml"
     Write(Model.productCATEGORY);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
