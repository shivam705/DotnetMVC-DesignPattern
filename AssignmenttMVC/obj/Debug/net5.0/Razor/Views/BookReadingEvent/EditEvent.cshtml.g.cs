#pragma checksum "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdbdc17ddec3b823579721f677e1d05cdb62c0e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookReadingEvent_EditEvent), @"mvc.1.0.view", @"/Views/BookReadingEvent/EditEvent.cshtml")]
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
#line 1 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\_ViewImports.cshtml"
using AssignmenttMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\_ViewImports.cshtml"
using AssignmenttMVC.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdbdc17ddec3b823579721f677e1d05cdb62c0e2", @"/Views/BookReadingEvent/EditEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"468ebaba5be9c787422b00e07353b748bbd8b636", @"/Views/_ViewImports.cshtml")]
    public class Views_BookReadingEvent_EditEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssignmenttMVC.Model.EventsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
  
    ViewData["Title"] = "EditEvent";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-align:center\">EditEvent</h1>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
 using (Html.BeginForm("EditEvent", "BookReadingEvent", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n\r\n        <hr />\r\n        ");
#nullable restore
#line 19 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 20 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
   Write(Html.HiddenFor(model => model.EventId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
   Write(Html.HiddenFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 24 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
       Write(Html.LabelFor(model => model.Title, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 26 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.EditorFor(model => model.Title, new { htmlAttributes = new { @class = "form-control " } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 32 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
       Write(Html.LabelFor(model => model.Date, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 34 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.EditorFor(model => model.Date, new { htmlAttributes = new { @class = "form-control datepicker " } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 35 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.ValidationMessageFor(model => model.Date, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 41 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
       Write(Html.LabelFor(model => model.Location, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 43 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.EditorFor(model => model.Location, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 44 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.ValidationMessageFor(model => model.Location, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 49 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
       Write(Html.LabelFor(model => model.StartTime, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 51 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.EditorFor(model => model.StartTime, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 52 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.ValidationMessageFor(model => model.StartTime, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 57 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
       Write(Html.LabelFor(model => model.Duration, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 59 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.EditorFor(model => model.Duration, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 60 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.ValidationMessageFor(model => model.Duration, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 65 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 67 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 68 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 73 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
       Write(Html.LabelFor(model => model.OtherDetails, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 75 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.EditorFor(model => model.OtherDetails, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 76 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.ValidationMessageFor(model => model.OtherDetails, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 81 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
       Write(Html.LabelFor(model => model.InviteByEmail, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 83 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.EditorFor(model => model.InviteByEmail, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 84 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
           Write(Html.ValidationMessageFor(model => model.InviteByEmail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Create"" class=""btn btn-info w-25"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 94 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\EditEvent.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssignmenttMVC.Model.EventsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
