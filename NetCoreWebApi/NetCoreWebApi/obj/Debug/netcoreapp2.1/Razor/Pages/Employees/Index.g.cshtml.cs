#pragma checksum "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db369fac27d4af83a9d12d584dc4878202deec69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Employees_Index), @"mvc.1.0.razor-page", @"/Pages/Employees/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Employees/Index.cshtml", typeof(AspNetCore.Pages_Employees_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db369fac27d4af83a9d12d584dc4878202deec69", @"/Pages/Employees/Index.cshtml")]
    public class Pages_Employees_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(83, 156, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(240, 57, false);
#line 17 "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employee[0].FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(297, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(353, 58, false);
#line 20 "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employee[0].MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(411, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(467, 59, false);
#line 23 "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employee[0].JoiningDate));

#line default
#line hidden
            EndContext();
            BeginContext(526, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(582, 54, false);
#line 26 "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employee[0].Salary));

#line default
#line hidden
            EndContext();
            BeginContext(636, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml"
 foreach (var item in Model.Employee) {

#line default
#line hidden
            BeginContext(763, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(812, 44, false);
#line 35 "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(856, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(912, 45, false);
#line 38 "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(957, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1013, 46, false);
#line 41 "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JoiningDate));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1115, 41, false);
#line 44 "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-page=\"./Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1231, "\"", 1254, 1);
#line 47 "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml"
WriteAttributeValue("", 1246, item.ID, 1246, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1255, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-page=\"./Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1307, "\"", 1330, 1);
#line 48 "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml"
WriteAttributeValue("", 1322, item.ID, 1322, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1331, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-page=\"./Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1385, "\"", 1408, 1);
#line 49 "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml"
WriteAttributeValue("", 1400, item.ID, 1400, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1409, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Rose\source\repos\NetCoreWebApi\NetCoreWebApi\Pages\Employees\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1459, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCoreWebApi.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NetCoreWebApi.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NetCoreWebApi.IndexModel>)PageContext?.ViewData;
        public NetCoreWebApi.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
