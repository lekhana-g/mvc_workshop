#pragma checksum "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1941416e0da5574b6a6a7a211a069febe0e39191"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminF_getallFlights), @"mvc.1.0.view", @"/Views/AdminF/getallFlights.cshtml")]
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
#line 1 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\_ViewImports.cshtml"
using flightreservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\_ViewImports.cshtml"
using flightreservation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1941416e0da5574b6a6a7a211a069febe0e39191", @"/Views/AdminF/getallFlights.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"750545fca4c2829c8a723bb05b4c2a0134ee91f3", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminF_getallFlights : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<flightreservation.Models.FlightDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
  
    Layout="AdminLayout";
    ViewData["Title"] = "getallFlights";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Flight details</h1>\r\n\r\n<!--<p>\r\n    <a asp-action=\"Create\">Add New Flight</a>\r\n</p>-->\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Flightid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Flightname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Departuretime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Arrivaltime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Totalcapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Costperseat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Imagepath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Flightid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Flightname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Departuretime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Arrivaltime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Totalcapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Costperseat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 2161, "\"", 2195, 1);
#nullable restore
#line 74 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
WriteAttributeValue("", 2167, Url.Content(item.Imagepath), 2167, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"no data\" height=\"200\" width=\"200\"/>\r\n                ");
#nullable restore
#line 75 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Imagepath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.Flightid}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 79 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Flightid }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 82 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminF\getallFlights.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<flightreservation.Models.FlightDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
