#pragma checksum "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d959bcd94dab25bb85630efa7727d74e728c4d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_GetFlights), @"mvc.1.0.view", @"/Views/Customer/GetFlights.cshtml")]
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
#line 1 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\_ViewImports.cshtml"
using finalmvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\_ViewImports.cshtml"
using finalmvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d959bcd94dab25bb85630efa7727d74e728c4d4", @"/Views/Customer/GetFlights.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f2bd0be20b0d23dc29daecddae42e18eef04080", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_GetFlights : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<finalmvc.Models.FlightD>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
  
    ViewData["Title"] = "GetFlights";
    Layout="CustomerLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
body{
    background-color:cadetblue;
}
a.custom link{
    color:black;
    font-weight:bold;
    text-decoration:none;
}

</style>

<h1>Flight Details</h1>
<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 24 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Fid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Fname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Departuretime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Arrivaltime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Totalcapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Costperseat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Departuretime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Arrivaltime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Totalcapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Costperseat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n            <ul>\r\n                ");
#nullable restore
#line 79 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
           Write(Html.ActionLink("Book", "Edit", new { id=item.Fid },new{@class="bookf btn btn-primary btn-sm"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </ul>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\l.g.lmb5\Desktop\new\finalmvc\Views\Customer\GetFlights.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<finalmvc.Models.FlightD>> Html { get; private set; }
    }
}
#pragma warning restore 1591
