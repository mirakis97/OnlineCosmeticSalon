#pragma checksum "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d88b6ffb8b30b307094f71ecd7e66f5743173e76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Salons_Details), @"mvc.1.0.view", @"/Views/Salons/Details.cshtml")]
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
#line 1 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\_ViewImports.cshtml"
using AspNetCoreTemplate.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\_ViewImports.cshtml"
using AspNetCoreTemplate.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d88b6ffb8b30b307094f71ecd7e66f5743173e76", @"/Views/Salons/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82bc5e49829c4a4d7ea5749c4439e0d5e66697ba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Salons_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetCoreTemplate.Web.ViewModels.Salons.SalonWithServicesViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Appointments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakeAnAppointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/rating-static.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
  
    this.ViewData["Title"] = "Salon: " + Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row row-eq-height\">\n    <!-- Info Box -->\n    <div class=\"col-lg-4 info_box_col\">\n        <div class=\"info_box\">\n            <div class=\"info_image\"><img");
            BeginWriteAttribute("src", " src=\"", 299, "\"", 320, 1);
#nullable restore
#line (10,47)-(10,62) 29 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
WriteAttributeValue("", 305, Model.ImageUrl, 305, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 321, "\"", 327, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\n            <div class=\"info_content\">\n                <div class=\"info_title\">");
#nullable restore
#line (12,42)-(12,52) 6 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                <div class=\"info_text\">Category: <strong>");
#nullable restore
#line (13,59)-(13,77) 6 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\n                <div class=\"info_text\">City: <strong>");
#nullable restore
#line (14,55)-(14,69) 6 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
Write(Model.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\n                <div class=\"info_text\">Address: <strong>");
#nullable restore
#line (15,58)-(15,71) 6 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></div>
                <div class=""info_text"">
                    Rating: &nbsp;&nbsp;
                    <span class=""star-rating"">
                        <span class=""fa fa-star-o"" data-rating=""1""></span>
                        <span class=""fa fa-star-o"" data-rating=""2""></span>
                        <span class=""fa fa-star-o"" data-rating=""3""></span>
                        <span class=""fa fa-star-o"" data-rating=""4""></span>
                        <span class=""fa fa-star-o"" data-rating=""5""></span>
                        <input type=""hidden"" name=""whatever1"" class=""rating-value""");
            BeginWriteAttribute("value", " value=\"", 1280, "\"", 1301, 1);
#nullable restore
#line (24,91)-(24,104) 30 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
WriteAttributeValue("", 1288, Model.Rating, 1288, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    </span>\n                    <span>&nbsp; ( ");
#nullable restore
#line (26,37)-(26,63) 6 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
Write(Model.Rating.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5.00 ) from ");
#nullable restore
#line (26,79)-(26,96) 6 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
Write(Model.RatersCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" votes</span>
                </div>
            </div>
        </div>
    </div>
    <!-- Panel -->
    <div class=""col-lg-7"">
        <h2>Services:</h2>
        <div class=""tab_panel active"">
            <div class=""tab_panel_content"">
                <div class=""tab_list"">
                    <ul>
");
#nullable restore
#line 38 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
                         foreach (var service in Model.Services.Where(x => x.Available == true))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\n                                <div class=\"tab_list_title\">");
#nullable restore
#line (41,62)-(41,81) 6 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
Write(service.ServiceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                <div class=\"tab_list_text\"><p>");
#nullable restore
#line (42,64)-(42,90) 6 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
Write(service.ServiceDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\n                                <div class=\"button info_button\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d88b6ffb8b30b307094f71ecd7e66f5743173e7610329", async() => {
                WriteLiteral("\n                                        <span>book now</span><span>book now</span>\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-salonId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line (45,60)-(45,75) 13 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
WriteLiteral(service.SalonId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["salonId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-salonId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["salonId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line (45,99)-(45,116) 13 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
WriteLiteral(service.ServiceId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["serviceId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-serviceId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["serviceId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n                            </li>\n");
#nullable restore
#line 50 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d88b6ffb8b30b307094f71ecd7e66f5743173e7614316", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 59 "C:\Miroslav Apps\Programing\ASP.NET-Core-Template-master\src\Web\AspNetCoreTemplate.Web\Views\Salons\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCoreTemplate.Web.ViewModels.Salons.SalonWithServicesViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591