#pragma checksum "/Users/Kirsten/Documents/codingDojo/cSharp/EntityLinqFramework/CRUDelicious/Views/Home/ViewDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33b6f207995d6887901075ccbe50c9d0caa8a22f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewDish), @"mvc.1.0.view", @"/Views/Home/ViewDish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewDish.cshtml", typeof(AspNetCore.Views_Home_ViewDish))]
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
#line 1 "/Users/Kirsten/Documents/codingDojo/cSharp/EntityLinqFramework/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "/Users/Kirsten/Documents/codingDojo/cSharp/EntityLinqFramework/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33b6f207995d6887901075ccbe50c9d0caa8a22f", @"/Views/Home/ViewDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Kirsten/Documents/codingDojo/cSharp/EntityLinqFramework/CRUDelicious/Views/Home/ViewDish.cshtml"
  
    ViewData["Title"] = "View Dish Page";

#line default
#line hidden
            BeginContext(47, 243, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-8 offset-2\">\n        <div class=\"card text-center\">\n        <div class=\"card-header\">\n            Recipes by CRUDelicious\n        </div>\n        <div class=\"card-body\">\n            <h2 class=\"card-title\">");
            EndContext();
            BeginContext(291, 10, false);
#line 12 "/Users/Kirsten/Documents/codingDojo/cSharp/EntityLinqFramework/CRUDelicious/Views/Home/ViewDish.cshtml"
                              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(301, 39, true);
            WriteLiteral("</h2>\n            <p class=\"card-text\">");
            EndContext();
            BeginContext(341, 17, false);
#line 13 "/Users/Kirsten/Documents/codingDojo/cSharp/EntityLinqFramework/CRUDelicious/Views/Home/ViewDish.cshtml"
                            Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(358, 31, true);
            WriteLiteral("</p>\n            <p>Calories : ");
            EndContext();
            BeginContext(390, 14, false);
#line 14 "/Users/Kirsten/Documents/codingDojo/cSharp/EntityLinqFramework/CRUDelicious/Views/Home/ViewDish.cshtml"
                     Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(404, 19, true);
            WriteLiteral("</p>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 423, "\"", 458, 2);
            WriteAttributeValue("", 430, "/Home/EditDish/", 430, 15, true);
#line 15 "/Users/Kirsten/Documents/codingDojo/cSharp/EntityLinqFramework/CRUDelicious/Views/Home/ViewDish.cshtml"
WriteAttributeValue("", 445, Model.DishId, 445, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(459, 120, true);
            WriteLiteral(" class=\"btn btn-outline-danger\">Edit</a>\n        </div>\n        <div class=\"card-footer text-muted\">\n            Stars: ");
            EndContext();
            BeginContext(580, 15, false);
#line 18 "/Users/Kirsten/Documents/codingDojo/cSharp/EntityLinqFramework/CRUDelicious/Views/Home/ViewDish.cshtml"
              Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(595, 44, true);
            WriteLiteral("\n        </div>\n    </div>\n    </div>\n</div>");
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
