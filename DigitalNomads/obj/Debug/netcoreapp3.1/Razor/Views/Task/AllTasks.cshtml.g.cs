#pragma checksum "C:\Users\selma\Source\Repos\CtrlAltDefeat3\DigitalNomads\Views\Task\AllTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d68b6ea9df95476d1054a5ae667ef645afb9c73b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_AllTasks), @"mvc.1.0.view", @"/Views/Task/AllTasks.cshtml")]
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
#line 1 "C:\Users\selma\Source\Repos\CtrlAltDefeat3\DigitalNomads\Views\_ViewImports.cshtml"
using DigitalNomads;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selma\Source\Repos\CtrlAltDefeat3\DigitalNomads\Views\_ViewImports.cshtml"
using DigitalNomads.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68b6ea9df95476d1054a5ae667ef645afb9c73b", @"/Views/Task/AllTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c0834fe50ca908c52f16bd5fb96c153860deec5", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_AllTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d68b6ea9df95476d1054a5ae667ef645afb9c73b3249", async() => {
                WriteLiteral("\r\n    <style>\r\n        ");
                WriteLiteral("@import url(\'https://fonts.googleapis.com/css2?family=Josefin+Sans&display=swap\');\r\n        ");
                WriteLiteral(@"@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@300&display=swap');

        body {
            color: #2c3e50;
            background: #ecf0f1;
            padding: 0 1em 1em;
        }

        h1 {
            margin: 0;
            line-height: 2;
            text-align: center;
            font-family: Josefin Sans;
            font-size: 55px;
        }

        h2 {
            margin: 0 0 0.5em;
            font-weight: normal;
            font-family: Poppins;
        }

        input {
            position: absolute;
            opacity: 0;
            z-index: -1;
        }

        .row {
            display: -webkit-box;
            display: flex;
        }

        .row .col {
            -webkit-box-flex: 1;
            flex: 1;
        }

        .row .col:last-child {
            margin-left: 1em;
        }

        /* Accordion styles */
        .tabs {
            border-radius: 8px;
            overflow: hidden;
            b");
                WriteLiteral(@"ox-shadow: 0 4px 4px -2px rgba(0, 0, 0, 0.5);
        }

        .tab {
            width: 100%;
            color: white;
            overflow: hidden;
        }

        .tab-label {
            display: -webkit-box;
            display: flex;
            -webkit-box-pack: justify;
            justify-content: space-between;
            padding: 1em;
            background: #2c3e50;
            font-weight: bold;
            cursor: pointer;
            /* Icon */
        }

        .tab-label:hover {
            background: #1a252f;
        }

        .tab-label::after {
            content: ""\276F"";
            width: 1em;
            height: 1em;
            text-align: center;
            -webkit-transition: all 0.35s;
            transition: all 0.35s;
        }

        .tab-content {
            max-height: 0;
            padding: 0 1em;
            color: #2c3e50;
            background: white;
            -webkit-transition: all 0.35s;
            transition:");
                WriteLiteral(@" all 0.35s;
        }

        .tab-close {
            display: -webkit-box;
            display: flex;
            -webkit-box-pack: end;
            justify-content: flex-end;
            padding: 1em;
            font-size: 0.75em;
            background: #2c3e50;
            cursor: pointer;
        }

        .tab-close:hover {
            background: #1a252f;
        }

        input:checked+.tab-label {
            background: #1a252f;
        }

        input:checked+.tab-label::after {
            -webkit-transform: rotate(90deg);
            transform: rotate(90deg);
        }

        input:checked~.tab-content {
            max-height: 100vh;
            padding: 1em;
        }
    </style>
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d68b6ea9df95476d1054a5ae667ef645afb9c73b7276", async() => {
                WriteLiteral(@"
    <h1>Manage your tasks here.</h1>
    <div class=""row"">
        <div class=""col"">
            <h2>Unfinished</h2>
            <div class=""tabs"">
                <div class=""tab"">
                    <input type=""checkbox"" id=""chck1"">
                    <label class=""tab-label"" for=""chck1"">Item 1</label>
                    <div class=""tab-content"">
                        Lorem ipsum dolor sit amet consectetur, adipisicing elit. Ipsum, reiciendis!
                    </div>
                </div>
                <div class=""tab"">
                    <input type=""checkbox"" id=""chck2"">
                    <label class=""tab-label"" for=""chck2"">Item 2</label>
                    <div class=""tab-content"">
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. A, in!
                    </div>
                </div>
            </div>
        </div>
        <div class=""col"">
            <h2>Finished</h2>
            <div class=""tabs"">
                <div class");
                WriteLiteral(@"=""tab"">
                    <input type=""checkbox"" id=""chck3"">
                    <label class=""tab-label"" for=""chck3"">Item 1</label>
                    <div class=""tab-content"">
                        Lorem ipsum dolor sit amet consectetur, adipisicing elit. Ipsum, reiciendis!
                    </div>
                </div>
                <div class=""tab"">
                    <input type=""checkbox"" id=""chck4"">
                    <label class=""tab-label"" for=""chck4"">Item 2</label>
                    <div class=""tab-content"">
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. A, in!
                    </div>
                </div>
            </div>
        </div>
    </div>


");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
