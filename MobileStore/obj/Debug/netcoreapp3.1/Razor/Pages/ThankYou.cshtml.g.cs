#pragma checksum "C:\Users\Avishka\source\repos\MobileStore\MobileStore\Pages\ThankYou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01b48cf16a925be1ae9a297c41f9df18063b2994"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MobileStore.Pages.Pages_ThankYou), @"mvc.1.0.razor-page", @"/Pages/ThankYou.cshtml")]
namespace MobileStore.Pages
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
#line 1 "C:\Users\Avishka\source\repos\MobileStore\MobileStore\Pages\_ViewImports.cshtml"
using MobileStore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01b48cf16a925be1ae9a297c41f9df18063b2994", @"/Pages/ThankYou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dfc67e25789d5f9dfadbf14b649dee5f9819e97", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ThankYou : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Avishka\source\repos\MobileStore\MobileStore\Pages\ThankYou.cshtml"
  
    var imagePath="./images/"+(Model.ImageName+".png");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2>Thank You For Ordering..!</h2>\r\n    <br />\r\n\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 211, "\"", 227, 1);
#nullable restore
#line 14 "C:\Users\Avishka\source\repos\MobileStore\MobileStore\Pages\ThankYou.cshtml"
WriteAttributeValue("", 217, imagePath, 217, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-25\"/>\r\n    <h4>Customer Name : ");
#nullable restore
#line 15 "C:\Users\Avishka\source\repos\MobileStore\MobileStore\Pages\ThankYou.cshtml"
                   Write(Model.MobileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h5>Mobile : ");
#nullable restore
#line 16 "C:\Users\Avishka\source\repos\MobileStore\MobileStore\Pages\ThankYou.cshtml"
            Write(Model.ImageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MobileStore.Pages.ThankYouModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MobileStore.Pages.ThankYouModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MobileStore.Pages.ThankYouModel>)PageContext?.ViewData;
        public MobileStore.Pages.ThankYouModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591