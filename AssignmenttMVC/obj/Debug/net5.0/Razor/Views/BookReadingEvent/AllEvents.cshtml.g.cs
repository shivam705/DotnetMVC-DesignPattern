#pragma checksum "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\AllEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "265c7839da25bc0b3b34aeb6cf6a68b509e1b2ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookReadingEvent_AllEvents), @"mvc.1.0.view", @"/Views/BookReadingEvent/AllEvents.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\_ViewImports.cshtml"
using AssignmenttMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\AllEvents.cshtml"
using AssignmenttMVC.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\AllEvents.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"265c7839da25bc0b3b34aeb6cf6a68b509e1b2ce", @"/Views/BookReadingEvent/AllEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"468ebaba5be9c787422b00e07353b748bbd8b636", @"/Views/_ViewImports.cshtml")]
    public class Views_BookReadingEvent_AllEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventsModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\AllEvents.cshtml"
  
    ViewData["Title"] = "AllEvents";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 style=\"text-align:center\">AllEvents</h2>\r\n\r\n<div class=\"container\">\r\n");
            WriteLiteral("        <ul>\r\n");
#nullable restore
#line 14 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\AllEvents.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 17 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\AllEvents.cshtml"
               Write(Html.ActionLink(item.Title, "ViewEvent", "BookReadingEvent", new { @item.UserId }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 18 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\AllEvents.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EventsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591