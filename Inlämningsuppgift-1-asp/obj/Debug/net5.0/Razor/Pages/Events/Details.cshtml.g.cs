#pragma checksum "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da6cbb5ac606646455c8aa234abd465f78151a35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Inlämningsuppgift_1_asp.Pages.Events.Pages_Events_Details), @"mvc.1.0.razor-page", @"/Pages/Events/Details.cshtml")]
namespace Inlämningsuppgift_1_asp.Pages.Events
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
#line 1 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\_ViewImports.cshtml"
using Inlämningsuppgift_1_asp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da6cbb5ac606646455c8aa234abd465f78151a35", @"/Pages/Events/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c2c0c674d17805be972386baf01ac0b3424ae31", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Events_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
Write(Html.DisplayFor(model => model.Event.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Event.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.Event.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Event.Organizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.Event.Organizer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Event.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.Event.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Event.Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.Event.Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Event.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.Event.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Event.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.Event.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Event.Spots_available));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "D:\Repos\Inlämningsuppgift-1-asp\Inlämningsuppgift-1-asp\Pages\Events\Details.cshtml"
       Write(Html.DisplayFor(model => model.Event.Spots_available));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <button type=\"button\" class=\"btn btn-primary\">Join this Event</button>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da6cbb5ac606646455c8aa234abd465f78151a358923", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inlämningsuppgift_1_asp.Pages.Events.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Inlämningsuppgift_1_asp.Pages.Events.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Inlämningsuppgift_1_asp.Pages.Events.DetailsModel>)PageContext?.ViewData;
        public Inlämningsuppgift_1_asp.Pages.Events.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
