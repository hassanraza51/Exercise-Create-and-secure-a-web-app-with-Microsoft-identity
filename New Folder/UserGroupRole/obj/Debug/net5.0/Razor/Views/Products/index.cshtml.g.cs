#pragma checksum "F:\Microtechx Data\Exercise-Create-and-secure-a-web-app-with-Microsoft-identity\New Folder\UserGroupRole\Views\Products\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c311705bbe3b2f0856e1a108c2d5d731016f5a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_index), @"mvc.1.0.view", @"/Views/Products/index.cshtml")]
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
#line 1 "F:\Microtechx Data\Exercise-Create-and-secure-a-web-app-with-Microsoft-identity\New Folder\UserGroupRole\Views\_ViewImports.cshtml"
using UserGroupRole;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Microtechx Data\Exercise-Create-and-secure-a-web-app-with-Microsoft-identity\New Folder\UserGroupRole\Views\_ViewImports.cshtml"
using UserGroupRole.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c311705bbe3b2f0856e1a108c2d5d731016f5a0", @"/Views/Products/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2efbea151fc0132b9ff2153bd56462ca31822a3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserGroupRole.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\Microtechx Data\Exercise-Create-and-secure-a-web-app-with-Microsoft-identity\New Folder\UserGroupRole\Views\Products\index.cshtml"
  
  ViewData["Title"] = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Products</h1>\r\n");
#nullable restore
#line 8 "F:\Microtechx Data\Exercise-Create-and-secure-a-web-app-with-Microsoft-identity\New Folder\UserGroupRole\Views\Products\index.cshtml"
 if (User.IsInRole("ProductAdministrators"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c311705bbe3b2f0856e1a108c2d5d731016f5a04185", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 13 "F:\Microtechx Data\Exercise-Create-and-secure-a-web-app-with-Microsoft-identity\New Folder\UserGroupRole\Views\Products\index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n  <thead>\r\n    <tr>\r\n      <th>\r\n        ");
#nullable restore
#line 18 "F:\Microtechx Data\Exercise-Create-and-secure-a-web-app-with-Microsoft-identity\New Folder\UserGroupRole\Views\Products\index.cshtml"
   Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </th>\r\n      <th>\r\n        ");
#nullable restore
#line 21 "F:\Microtechx Data\Exercise-Create-and-secure-a-web-app-with-Microsoft-identity\New Folder\UserGroupRole\Views\Products\index.cshtml"
   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </th>\r\n      <th>\r\n        ");
#nullable restore
#line 24 "F:\Microtechx Data\Exercise-Create-and-secure-a-web-app-with-Microsoft-identity\New Folder\UserGroupRole\Views\Products\index.cshtml"
   Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
#nullable restore
#line 29 "F:\Microtechx Data\Exercise-Create-and-secure-a-web-app-with-Microsoft-identity\New Folder\UserGroupRole\Views\Products\index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <td>\r\n        ");
#nullable restore
#line 32 "F:\Microtechx Data\Exercise-Create-and-secure-a-web-app-with-Microsoft-identity\New Folder\UserGroupRole\Views\Products\index.cshtml"
   Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </td>\r\n      <td>\r\n        ");
#nullable restore
#line 35 "F:\Microtechx Data\Exercise-Create-and-secure-a-web-app-with-Microsoft-identity\New Folder\UserGroupRole\Views\Products\index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </td>\r\n      <td>\r\n        ");
#nullable restore
#line 38 "F:\Microtechx Data\Exercise-Create-and-secure-a-web-app-with-Microsoft-identity\New Folder\UserGroupRole\Views\Products\index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </td>\r\n    </tr>\r\n");
#nullable restore
#line 41 "F:\Microtechx Data\Exercise-Create-and-secure-a-web-app-with-Microsoft-identity\New Folder\UserGroupRole\Views\Products\index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserGroupRole.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
