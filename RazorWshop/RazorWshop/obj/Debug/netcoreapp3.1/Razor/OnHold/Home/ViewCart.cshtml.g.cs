#pragma checksum "C:\Users\tanfe\source\repos\gdipsa51_mvc_ca3\RazorWshop\RazorWshop\OnHold\Home\ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92f387480605a96144885ce7a03f629e5a34671e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.OnHold_Home_ViewCart), @"mvc.1.0.view", @"/OnHold/Home/ViewCart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92f387480605a96144885ce7a03f629e5a34671e", @"/OnHold/Home/ViewCart.cshtml")]
    public class OnHold_Home_ViewCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tanfe\source\repos\gdipsa51_mvc_ca3\RazorWshop\RazorWshop\OnHold\Home\ViewCart.cshtml"
  
    ViewData["Title"] = "Home Page";
    string[] images = (string[])ViewData["images"];
    string[] tags = (string[])ViewData["tags"];
    string[] product_name = (string[])ViewData["product_name"];
    double[] price = (double[])ViewData["price"];
    string[] description = (string[])ViewData["description"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #mainframe {
        margin: auto;
        width: 100%;
        border-collapse: separate;
        border-spacing: 30px ; 
    }

    #mainframe td {
        height: 200px;
        width: 30%;
        text-align: center;
        padding: 2% 2% 0% 2%;
        background-color: lightgrey;
    }

    .listing-box {
        border-color: grey;
        border-style: solid;
        border-width: 3px;
    }

    #image {
        height: 70%;
        width: 70%;
    }
    
    #pdt-name{
        font-weight: bold;
        margin: 1%;
    }

    #pdt-descr {
        text-align: justify;
        margin: 2%;
    }

    #add-button {
        position: relative;
        bottom: 0px;
        margin: 2%;
        text-align: center;
    }
    
    .price-and-quantity td{
        height: auto !important;
    }
</style>

<table id=""mainframe"">
");
#nullable restore
#line 60 "C:\Users\tanfe\source\repos\gdipsa51_mvc_ca3\RazorWshop\RazorWshop\OnHold\Home\ViewCart.cshtml"
     for (int i = 0; i < images.Length; i += 1)
    {
        int j;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 65 "C:\Users\tanfe\source\repos\gdipsa51_mvc_ca3\RazorWshop\RazorWshop\OnHold\Home\ViewCart.cshtml"
             for (j = 0; j < 1 && i + j < images.Length; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"listing-box\">\r\n");
#nullable restore
#line 68 "C:\Users\tanfe\source\repos\gdipsa51_mvc_ca3\RazorWshop\RazorWshop\OnHold\Home\ViewCart.cshtml"
                      
                        string url = ViewData["url_prefix"] +
                            images[i + j] + ViewData["url_postfix"];
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img id=\"image\"");
            BeginWriteAttribute("src", " src=", 1655, "", 1664, 1);
#nullable restore
#line 72 "C:\Users\tanfe\source\repos\gdipsa51_mvc_ca3\RazorWshop\RazorWshop\OnHold\Home\ViewCart.cshtml"
WriteAttributeValue("", 1660, url, 1660, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <div id=\"pdt-name\">");
#nullable restore
#line 73 "C:\Users\tanfe\source\repos\gdipsa51_mvc_ca3\RazorWshop\RazorWshop\OnHold\Home\ViewCart.cshtml"
                                      Write(product_name[i + j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"pdt-descr\">");
#nullable restore
#line 74 "C:\Users\tanfe\source\repos\gdipsa51_mvc_ca3\RazorWshop\RazorWshop\OnHold\Home\ViewCart.cshtml"
                                       Write(description[i + j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <input type=\"text\" id=\"add-button\" value=\"Download\">\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    <form>\r\n                        <table class=\"price-and-quantity\">\r\n                            <tr>\r\n                                <td>Price: </td>\r\n                                <td>$");
#nullable restore
#line 83 "C:\Users\tanfe\source\repos\gdipsa51_mvc_ca3\RazorWshop\RazorWshop\OnHold\Home\ViewCart.cshtml"
                                Write(price[i + j]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                            <tr>
                                <td>Quantity: </td>
                                <td><input type=""number"" name=""num"" min=""1"" max=""5""></td>
                            </tr>
                        </table>
                    </form>
                </td>
");
#nullable restore
#line 92 "C:\Users\tanfe\source\repos\gdipsa51_mvc_ca3\RazorWshop\RazorWshop\OnHold\Home\ViewCart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 94 "C:\Users\tanfe\source\repos\gdipsa51_mvc_ca3\RazorWshop\RazorWshop\OnHold\Home\ViewCart.cshtml"
             for (; j < 3; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td></td>\r\n");
#nullable restore
#line 97 "C:\Users\tanfe\source\repos\gdipsa51_mvc_ca3\RazorWshop\RazorWshop\OnHold\Home\ViewCart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 99 "C:\Users\tanfe\source\repos\gdipsa51_mvc_ca3\RazorWshop\RazorWshop\OnHold\Home\ViewCart.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
