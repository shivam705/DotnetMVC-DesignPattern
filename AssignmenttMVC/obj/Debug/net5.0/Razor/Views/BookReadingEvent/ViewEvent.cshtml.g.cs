#pragma checksum "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7a10098a2b21f7377aeb7d1153b7a13acc4e364"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookReadingEvent_ViewEvent), @"mvc.1.0.view", @"/Views/BookReadingEvent/ViewEvent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7a10098a2b21f7377aeb7d1153b7a13acc4e364", @"/Views/BookReadingEvent/ViewEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"468ebaba5be9c787422b00e07353b748bbd8b636", @"/Views/_ViewImports.cshtml")]
    public class Views_BookReadingEvent_ViewEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssignmenttMVC.Model.EventsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
  
    ViewData["Title"] = "ViewEvent";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h2 style=\"text-align:center\">ViewEvent</h2>\r\n<div>\r\n\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 16 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 20 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 25 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 29 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 34 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 38 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 42 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 47 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 52 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 57 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 62 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.OtherDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 66 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayFor(model => model.OtherDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 70 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 75 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayFor(model => model.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 80 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 85 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n\r\n    </dl>\r\n    <div>\r\n");
#nullable restore
#line 91 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
         if (User.Identity.IsAuthenticated)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.ActionLink("Edit", "EditEvent"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
                                                 
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
         if (User.IsInRole("Admin"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.ActionLink("Delete", "DeleteEvent", "BookReadingEvent"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
                                                                         
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n");
#nullable restore
#line 102 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
     using (Html.BeginForm("AddCommentsPost", "BookReadingEvent", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal\">\r\n            <h4>CommentModel</h4>\r\n            <hr>\r\n            ");
#nullable restore
#line 109 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.HiddenFor(model => model.EventId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 111 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 113 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
           Write(Html.LabelFor(model => model.CommentAdded, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 115 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
               Write(Html.EditorFor(model => model.CommentAdded, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
            </div>

            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" value=""Post"" class=""btn btn-info w-25"" />
                </div>
            </div>
        </div>
");
#nullable restore
#line 126 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 130 "C:\Users\shivamkushwaha\source\repos\AssignmenttMVC\AssignmenttMVC\Views\BookReadingEvent\ViewEvent.cshtml"
   Write(Html.ActionLink("Comment", "Comments", new { Model.UserId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
