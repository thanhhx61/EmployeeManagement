#pragma checksum "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b758508a3acd4efbd33e6024e9ca083cb48d0d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmpUser_EmpIndex), @"mvc.1.0.view", @"/Views/EmpUser/EmpIndex.cshtml")]
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
#line 1 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models.Employee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models.Offices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b758508a3acd4efbd33e6024e9ca083cb48d0d6", @"/Views/EmpUser/EmpIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e56ec363e3706f3ce3e53e0f55a3c203c9f593a", @"/Views/_ViewImports.cshtml")]
    public class Views_EmpUser_EmpIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListEmployee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light px-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Offices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-bar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EmpUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EmpIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light px-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "View", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/jquery.simpleLoadMore.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
   ViewBag.Title = Model.Offices.OfficeName;
    string FormatCurrency(double number)
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        return number.ToString("#,###", cul.NumberFormat);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"main-grid\">\r\n    <div class=\"col-lg-15\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <div class=\"card-title\">\r\n                    ");
#nullable restore
#line 15 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
               Write(Model.Offices.OfficeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"float-right\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b758508a3acd4efbd33e6024e9ca083cb48d0d69302", async() => {
                WriteLiteral("<i></i> << Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n                <hr>\r\n                <div class=\"form-group\">\r\n                    <label for=\"input-1\"> Search  </label>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b758508a3acd4efbd33e6024e9ca083cb48d0d610971", async() => {
                WriteLiteral(@"
                        <input style=""color : white"" type=""text"" name=""keyword"" placeholder=""Search"">
                        <button class=""btn btn-small"" style=""background-color: gray"" type=""submit""><i class=""fa fa-search"" aria-hidden=""true""></i></button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-offiId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
                                                                                                  WriteLiteral(Model.Offices.OfficeId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["offiId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-offiId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["offiId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""w-100 mb-3"">                        
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-12 col-lg-12"">
            <div class=""card"">
                <div class=""table-responsive"">

                    <table class=""table align-items-center table-flush table-borderless"" id=""ticketLinesTable"">
                        <thead>
                            <tr>
                                <th style=""width: 5%"">
                                    #
                                </th>
                                <th style=""width: 10%"" class=""text-center"">
                                    Photo
                                </th>
                                <th style=""width: 25%"" class=""text-center"">
                                    Name
                                </th>
                                <th style=""width: 20%"" class=""text-center"">");
            WriteLiteral(@"
                                    Street
                                </th>
                                <th style=""width: 5%"" class=""text-center"">
                                    Status
                                </th>
                                <th style=""width: 20%"">
                                    Action
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 62 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
                             foreach (Employees emp in Model.Offices.Employees)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 65 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
                                   Write(emp.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n                                    <td class=\"text-center\">\r\n                                        <img style=\"width: 80px; height:80px;object-fit:cover\" class=\"img-fluid img-thumbnail img-lg\"");
            BeginWriteAttribute("src", " src=", 3190, "", 3218, 1);
#nullable restore
#line 67 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
WriteAttributeValue("", 3195, Url.Content(emp.Photo), 3195, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3218, "\"", 3241, 1);
#nullable restore
#line 67 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
WriteAttributeValue("", 3224, emp.EmployeeName, 3224, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 69 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
                                   Write(emp.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td style=\"text-overflow:ellipsis\" class=\"text-center\">\r\n                                        ");
#nullable restore
#line 71 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
                                   Write(emp.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"project-state text-center\">\r\n");
#nullable restore
#line 74 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
                                         if (emp.IsDeleted)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span style=\"color : red\">Unemployment</span> ");
#nullable restore
#line 76 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
                                                                                          }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span style=\"color : red\">Worrking</span>");
#nullable restore
#line 79 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
                                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td class=\"project-actions \">\r\n");
#nullable restore
#line 82 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
                                         if (!emp.IsDeleted)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b758508a3acd4efbd33e6024e9ca083cb48d0d619973", async() => {
                WriteLiteral("<i class=\"zmdi zmdi-accounts\"></i> View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-employeeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
                                                                                                                                WriteLiteral(emp.EmployeeId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["employeeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-employeeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["employeeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\r\n");
#nullable restore
#line 85 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 88 "D:\Project_Mini\Project\EmployeeManagement\EmployeeManagement\Views\EmpUser\EmpIndex.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                    <div class=""go-top"">
                        <p class=""go-top-text""><strong>BACK</strong></p>
                    </div>
                    <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js'></script>
                    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"" integrity=""sha512-uto9mlQzrs59VwILcLiRYeLKPPbS/bT71da/OEBYEwcdNUk8jYIy+D176RYoop1Da+f9mvkYrmj5MCLZWEtQuA=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b758508a3acd4efbd33e6024e9ca083cb48d0d623796", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <script>
                        window.console = window.console || function (t) { };
                    </script>
                    <script>
                        if (document.location.search.match(/type=embed/gi)) {
                            window.parent.postMessage(""resize"", ""*"");
                        }
                    </script>
                    <script src=""https://cpwebassets.codepen.io/assets/common/stopExecutionOnTimeout-1b93190375e9ccc259df3a57c1abc0e64599724ae30d7ea4c6877eb615f89387.js""></script>
                    <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.2.2/jquery.min.js'></script>
                    <script id=""rendered-js"">
                        $(function () {
                            /* initial variables */
                            var numRows = $('#ticketLinesTable').find('tr').length;
                            var SHOWN = 5;
                            var MORE = 5;
                            /* get how m");
            WriteLiteral(@"any more can be shown */
                            var getNumMore = function (ns) {
                                var more = MORE;
                                var leftOver = numRows - ns;
                                if (leftOver < more) {
                                    more = leftOver;
                                }
                                return more;
                            };
                            /* how many are shown */
                            var getInitialNumShown = function () {
                                var shown = SHOWN;
                                if (numRows < shown) {
                                    shown = numRows;
                                }
                                return shown;
                            };
                            /* set how many are initially shown */
                            var numShown = getInitialNumShown();

                            /* set the numMore if less than 20 */
");
            WriteLiteral(@"                            var numMore = getNumMore(numShown);

                            /* set more html */
                            if (numMore > 0) {
                                var more_html = '<p><button id=""more"">Show <span style=""font-weight: bold;"">' + numMore + '</span> More...</button></p>';
                                $('#ticketLinesTable').find('tr:gt(' + (numShown - 1) + ')').hide().end().after(more_html);
                            }
                            $('#more').click(function () {
                                /* determine how much more we should update */
                                numMore = getNumMore(numShown);
                                /* update num shown */
                                numShown = numShown + numMore;
                                $('#ticketLinesTable').find('tr:lt(' + numShown + ')').show();

                                /* determine if to show more and how much left over */
                                numMor");
            WriteLiteral(@"e = getNumMore(numShown);
                                if (numMore > 0) {
                                    $('#more span').html(numMore);
                                } else {
                                    $('#more').remove();
                                }
                            });
                        });
                    </script>
");
            WriteLiteral(@"                    <script src=""https://cpwebassets.codepen.io/assets/common/stopExecutionOnTimeout-1b93190375e9ccc259df3a57c1abc0e64599724ae30d7ea4c6877eb615f89387.js""></script>

                    <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
                    <script id=""rendered-js"">
                        $(function () {
                            //Scroll event
                            $(window).scroll(function () {
                                var scrolled = $(window).scrollTop();
                                if (scrolled > 200) $('.go-top').fadeIn('slow');
                                if (scrolled < 200) $('.go-top').fadeOut('slow');
                            });

                            //Click event
                            $('.go-top').click(function () {
                                $(""html, body"").animate({ scrollTop: ""0"" }, 500);
                            });
                        });
                 ");
            WriteLiteral("   </script>\r\n                   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListEmployee> Html { get; private set; }
    }
}
#pragma warning restore 1591
