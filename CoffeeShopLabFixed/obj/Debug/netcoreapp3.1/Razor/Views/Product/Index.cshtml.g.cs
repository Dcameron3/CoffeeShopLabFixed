#pragma checksum "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ad7efbe33bd4eb61d4a7759d82d32d2e26097b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ad7efbe33bd4eb61d4a7759d82d32d2e26097b6", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d91dd3b590f90e8761d83c6079110ddfd17bbab4", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "productspage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Here are our products:</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\Product\Index.cshtml"
 foreach (Product prod in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div><a");
            BeginWriteAttribute("href", " href=\"", 155, "\"", 196, 2);
            WriteAttributeValue("", 162, "/product/detail?pr=", 162, 19, true);
#nullable restore
#line 10 "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\Product\Index.cshtml"
WriteAttributeValue("", 181, prod.productID, 181, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\Product\Index.cshtml"
                                                 Write(prod.productID);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 10 "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\Product\Index.cshtml"
                                                                  Write(prod.productNAME);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $");
#nullable restore
#line 10 "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\Product\Index.cshtml"
                                                                                     Write(prod.productPRICE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
#nullable restore
#line 11 "C:\Devbuild\CoffeeShopLabFixed\CoffeeShopLabFixed\Views\Product\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
