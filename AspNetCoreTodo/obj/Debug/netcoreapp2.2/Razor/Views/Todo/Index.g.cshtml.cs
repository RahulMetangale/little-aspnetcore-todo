#pragma checksum "D:\RahulMetangale-D\Rahul Study\NET CORE\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75d62480b008c29bc8e7655e96a33f3c1a421525"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/Index.cshtml", typeof(AspNetCore.Views_Todo_Index))]
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
#line 1 "D:\RahulMetangale-D\Rahul Study\NET CORE\AspNetCoreTodo\AspNetCoreTodo\Views\_ViewImports.cshtml"
using AspNetCoreTodo;

#line default
#line hidden
#line 2 "D:\RahulMetangale-D\Rahul Study\NET CORE\AspNetCoreTodo\AspNetCoreTodo\Views\_ViewImports.cshtml"
using AspNetCoreTodo.Models;

#line default
#line hidden
#line 2 "D:\RahulMetangale-D\Rahul Study\NET CORE\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d62480b008c29bc8e7655e96a33f3c1a421525", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63823eaa5b73e495aebe7447edc96790f50c299d", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkDone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\RahulMetangale-D\Rahul Study\NET CORE\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
  
    ViewData["Title"]="Manage your todo list";

#line default
#line hidden
            BeginContext(95, 79, true);
            WriteLiteral("\r\n<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(175, 17, false);
#line 8 "D:\RahulMetangale-D\Rahul Study\NET CORE\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(192, 215, true);
            WriteLiteral("</div>\r\n    <table class=\"table table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <td>&#x2714;</td>\r\n                <td>Item</td>\r\n                <td>Due</td>\r\n            </tr>\r\n        </thead>\r\n");
            EndContext();
#line 17 "D:\RahulMetangale-D\Rahul Study\NET CORE\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
            BeginContext(462, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(522, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75d62480b008c29bc8e7655e96a33f3c1a4215255362", async() => {
                BeginContext(564, 127, true);
                WriteLiteral("\r\n                        <input type=\"checkbox\" class=\"done-checkbox\">\r\n                        <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 691, "\"", 707, 1);
#line 23 "D:\RahulMetangale-D\Rahul Study\NET CORE\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
WriteAttributeValue("", 699, item.Id, 699, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(708, 23, true);
                WriteLiteral(">\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(738, 45, true);
            WriteLiteral("\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(784, 10, false);
#line 26 "D:\RahulMetangale-D\Rahul Study\NET CORE\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(794, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(822, 21, false);
#line 27 "D:\RahulMetangale-D\Rahul Study\NET CORE\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
               Write(item.DueAt.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(843, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 29 "D:\RahulMetangale-D\Rahul Study\NET CORE\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(880, 60, true);
            WriteLiteral("    </table>\r\n<div class=\"panel-footer add-item-form\">\r\n    ");
            EndContext();
            BeginContext(941, 57, false);
#line 32 "D:\RahulMetangale-D\Rahul Study\NET CORE\AspNetCoreTodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
Write(await Html.PartialAsync("AddItemPartial", new TodoItem()));

#line default
#line hidden
            EndContext();
            BeginContext(998, 16, true);
            WriteLiteral("\r\n</div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591