#pragma checksum "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1fc578cd1c4098210a7c9ea9cd1c51b8a44f3ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_Index), @"mvc.1.0.view", @"/Views/Question/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Question/Index.cshtml", typeof(AspNetCore.Views_Question_Index))]
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
#line 1 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\_ViewImports.cshtml"
using StackoverflowLight;

#line default
#line hidden
#line 2 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\_ViewImports.cshtml"
using StackoverflowLight.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1fc578cd1c4098210a7c9ea9cd1c51b8a44f3ad", @"/Views/Question/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08dd14e0e445170c0fb09a17ee1a99dd58786650", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StackoverflowLight.Domain.Question>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Question", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpvoteAsync", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownvoteAsync", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 74, true);
            WriteLiteral("\r\n<div class=\"card question\">\r\n    <h1 class=\"card-title margin darkText\">");
            EndContext();
            BeginContext(159, 11, false);
#line 7 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                                      Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(170, 49, true);
            WriteLiteral("</h1>\r\n    <p class=\"card-text margin darkText\"> ");
            EndContext();
            BeginContext(220, 17, false);
#line 8 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                                     Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(237, 55, true);
            WriteLiteral("</p>\r\n    <p class=\"card-text margin dark-grey-text\">~ ");
            EndContext();
            BeginContext(293, 14, false);
#line 9 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                                            Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(307, 181, true);
            WriteLiteral("</p>\r\n    <div class=\"questionBar card-body lightBackground\">\r\n        <div class=\"group\">\r\n            <i class=\"far fa-comment text-white\"></i>\r\n            <p class=\"text-white\">");
            EndContext();
            BeginContext(489, 20, false);
#line 13 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                             Write(Model.Comments.Count);

#line default
#line hidden
            EndContext();
            BeginContext(509, 87, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"group\" style=\"font-size:20px;\">\r\n            ");
            EndContext();
            BeginContext(596, 281, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1fc578cd1c4098210a7c9ea9cd1c51b8a44f3ad6850", async() => {
                BeginContext(673, 200, true);
                WriteLiteral("\r\n                <div class=\"titleButton\">\r\n                    <i class=\"fas fa-plus text-white\"></i>\r\n                    <p class=\"text-white\">Add comment</p>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                                                              WriteLiteral(Model.PostId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(877, 59, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"group\">\r\n            ");
            EndContext();
            BeginContext(936, 264, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1fc578cd1c4098210a7c9ea9cd1c51b8a44f3ad9689", async() => {
                BeginContext(1019, 20, true);
                WriteLiteral("\r\n                <i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1039, "\"", 1176, 3);
                WriteAttributeValue("", 1047, "far", 1047, 3, true);
                WriteAttributeValue(" ", 1050, "fa-arrow-alt-circle-up", 1051, 23, true);
#line 25 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
WriteAttributeValue(" ", 1073, Model.Upvotes.Select(user=>user.User.UserName).Contains(User.Identity.Name)?"darkText":"text-white", 1074, 102, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1177, 19, true);
                WriteLiteral("></i>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                                                                    WriteLiteral(Model.PostId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1200, 36, true);
            WriteLiteral("\r\n            <p class=\"text-white\">");
            EndContext();
            BeginContext(1237, 19, false);
#line 27 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                             Write(Model.Upvotes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1256, 18, true);
            WriteLiteral("</p>\r\n            ");
            EndContext();
            BeginContext(1274, 270, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1fc578cd1c4098210a7c9ea9cd1c51b8a44f3ad13383", async() => {
                BeginContext(1359, 20, true);
                WriteLiteral("\r\n                <i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1379, "\"", 1520, 3);
                WriteAttributeValue("", 1387, "far", 1387, 3, true);
                WriteAttributeValue(" ", 1390, "fa-arrow-alt-circle-down", 1391, 25, true);
#line 29 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
WriteAttributeValue(" ", 1415, Model.Downvotes.Select(user=>user.User.UserName).Contains(User.Identity.Name)?"darkText":"text-white", 1416, 104, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1521, 19, true);
                WriteLiteral("></i>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                                                                      WriteLiteral(Model.PostId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1544, 36, true);
            WriteLiteral("\r\n            <p class=\"text-white\">");
            EndContext();
            BeginContext(1581, 21, false);
#line 31 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                             Write(Model.Downvotes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1602, 44, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 36 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
 foreach (var comment in Model.Comments)
{

#line default
#line hidden
            BeginContext(1691, 137, true);
            WriteLiteral("    <div class=\"comment card\">\r\n        <h6 class=\"card-title margin darkText\">REPLY</h6>\r\n        <p class=\"card-text margin darkText\"> ");
            EndContext();
            BeginContext(1829, 19, false);
#line 40 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                                         Write(comment.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1848, 59, true);
            WriteLiteral("</p>\r\n        <p class=\"card-text margin dark-grey-text\">~ ");
            EndContext();
            BeginContext(1908, 16, false);
#line 41 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                                                Write(comment.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1924, 116, true);
            WriteLiteral("</p>\r\n        <div class=\"questionBar card-body lightBackground\">\r\n            <div class=\"group\">\r\n                ");
            EndContext();
            BeginContext(2040, 319, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1fc578cd1c4098210a7c9ea9cd1c51b8a44f3ad18470", async() => {
                BeginContext(2168, 24, true);
                WriteLiteral("\r\n                    <i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2192, "\"", 2331, 3);
                WriteAttributeValue("", 2200, "far", 2200, 3, true);
                WriteAttributeValue(" ", 2203, "fa-arrow-alt-circle-up", 2204, 23, true);
#line 45 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
WriteAttributeValue(" ", 2226, comment.Upvotes.Select(user=>user.User.UserName).Contains(User.Identity.Name)?"darkText":"text-white", 2227, 104, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2332, 23, true);
                WriteLiteral("></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-commentId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                                                                              WriteLiteral(comment.PostId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commentId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-commentId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commentId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 44 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                                                                                                                     WriteLiteral(Model.PostId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questionId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-questionId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questionId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2359, 40, true);
            WriteLiteral("\r\n                <p class=\"text-white\">");
            EndContext();
            BeginContext(2400, 21, false);
#line 47 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                                 Write(comment.Upvotes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2421, 22, true);
            WriteLiteral("</p>\r\n                ");
            EndContext();
            BeginContext(2443, 325, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1fc578cd1c4098210a7c9ea9cd1c51b8a44f3ad22998", async() => {
                BeginContext(2573, 24, true);
                WriteLiteral("\r\n                    <i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2597, "\"", 2740, 3);
                WriteAttributeValue("", 2605, "far", 2605, 3, true);
                WriteAttributeValue(" ", 2608, "fa-arrow-alt-circle-down", 2609, 25, true);
#line 49 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
WriteAttributeValue(" ", 2633, comment.Downvotes.Select(user=>user.User.UserName).Contains(User.Identity.Name)?"darkText":"text-white", 2634, 106, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2741, 23, true);
                WriteLiteral("></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-commentId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                                                                                WriteLiteral(comment.PostId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commentId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-commentId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commentId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 48 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                                                                                                                       WriteLiteral(Model.PostId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questionId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-questionId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questionId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2768, 40, true);
            WriteLiteral("\r\n                <p class=\"text-white\">");
            EndContext();
            BeginContext(2809, 23, false);
#line 51 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
                                 Write(comment.Downvotes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2832, 54, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 55 "D:\StageOpdracht\StackoverflowLight\StackoverflowLight\Views\Question\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2889, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StackoverflowLight.Domain.Question> Html { get; private set; }
    }
}
#pragma warning restore 1591
