#pragma checksum "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3807617a4f0c0cfb31cbb186b7d2eb07b9f1cda8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#line 1 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\_ViewImports.cshtml"
using Asp.net_student;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\_ViewImports.cshtml"
using Asp.net_student.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3807617a4f0c0cfb31cbb186b7d2eb07b9f1cda8", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b916a39d23f8cf7c8396dc2665b89d865e23461d", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Asp.net_student.Models.Student>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3807617a4f0c0cfb31cbb186b7d2eb07b9f1cda83561", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 15 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Students</title>\r\n");
                WriteLiteral("   \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3807617a4f0c0cfb31cbb186b7d2eb07b9f1cda84951", async() => {
                WriteLiteral("\r\n\r\n    \r\n\r\n        <div class=\"btn\">\r\n            &nbsp;&nbsp;\r\n");
#nullable restore
#line 38 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
             using (Html.BeginForm("Index", "Students", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>\r\n                    search by: ");
#nullable restore
#line 41 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                          Write(Html.TextBox("search"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <input id=\"search\" name=\"search\" type=\"submit\" value=\"search\" />\r\n                </div>\r\n");
#nullable restore
#line 44 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n        </div>\r\n    <div class=\"table-container\">\r\n        <table class=\"table \">\r\n            <thead class=\"thead-light\">\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 54 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 57 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 60 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DepartmentId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 64 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 67 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 70 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 73 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 76 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.EnrollmentDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Action\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n");
#nullable restore
#line 83 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 88 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 91 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 94 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DepartmentId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 98 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 102 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 105 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 108 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 112 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td class=\"btns\">\r\n                        \r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3871, "\"", 3929, 1);
#nullable restore
#line 117 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
WriteAttributeValue("", 3878, Url.Action("Details","Students",new { id=item.Id}), 3878, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-sm btn-primary\"><i class=\"fa fa-eye\"></i></a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4019, "\"", 4074, 1);
#nullable restore
#line 118 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
WriteAttributeValue("", 4026, Url.Action("Edit","Students",new { id=item.Id}), 4026, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-sm btn-info\"><i class=\"fa fa-pencil-square\"></i></a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4171, "\"", 4228, 1);
#nullable restore
#line 119 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
WriteAttributeValue("", 4178, Url.Action("Delete","Students",new { id=item.Id}), 4178, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-sm btn-danger\"><i class=\"fa fa-trash-o\"></i></a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 122 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </table>\r\n        </div>\r\n        <div class=\"pagination\">\r\n\r\n            ");
#nullable restore
#line 128 "D:\Asp.netmvcnewup\Asp.netnewupdate\Asp.Net mvc crud\Views\Students\Index.cshtml"
       Write(await Html.PartialAsync("_Pagination", 5));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n        <script>\r\n            $(document).ready(function () {\r\n                $(\"#register\").hide();\r\n                $(\"#login\").hide();\r\n              \r\n            });\r\n        </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Asp.net_student.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
