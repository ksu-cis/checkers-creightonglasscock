#pragma checksum "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39a9b8b5627409bc94e8241d1a1db892fd03bcdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TicTacToe.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(TicTacToe.Pages.Pages_Index), null)]
namespace TicTacToe.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\_ViewImports.cshtml"
using TicTacToe;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39a9b8b5627409bc94e8241d1a1db892fd03bcdb", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04aa22a18a99016e8f0da147a50843055bfbe387", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
#line 3 "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(66, 55, true);
            WriteLiteral("\n<h1>Checkers!</h1>\n\n<svg width=\"800\" , height=\"800\">\r\n");
            EndContext();
#line 10 "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\Index.cshtml"
     for (int y = 0; y < 8; y++)
    {
        

#line default
#line hidden
#line 12 "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\Index.cshtml"
         for (int x = 0; x < 8; x++)
        {

#line default
#line hidden
            BeginContext(211, 17, true);
            WriteLiteral("            <rect");
            EndContext();
            BeginWriteAttribute("x", " x=\"", 228, "\"", 240, 1);
#line 14 "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\Index.cshtml"
WriteAttributeValue("", 232, x*100, 232, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("y", " y=\"", 241, "\"", 253, 1);
#line 14 "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\Index.cshtml"
WriteAttributeValue("", 245, y*100, 245, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(254, 63, true);
            WriteLiteral("\r\n                  width=\"100\"\r\n                  height=\"100\"");
            EndContext();
            BeginWriteAttribute("fill", "\r\n                  fill=\"", 317, "\"", 377, 1);
#line 17 "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\Index.cshtml"
WriteAttributeValue("", 343, (x+y)%2 == 0 ? "black" : "red" , 343, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(378, 4, true);
            WriteLiteral("/>\r\n");
            EndContext();
#line 18 "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\Index.cshtml"
             if(Model.Game.Board[x,y] != null)
            {

#line default
#line hidden
            BeginContext(445, 23, true);
            WriteLiteral("                <circle");
            EndContext();
            BeginWriteAttribute("cx", " cx=\"", 468, "\"", 484, 1);
#line 20 "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\Index.cshtml"
WriteAttributeValue("", 473, x*100+50, 473, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("cy", "\r\n                        cy=\"", 485, "\"", 526, 1);
#line 21 "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\Index.cshtml"
WriteAttributeValue("", 515, y*100+50, 515, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(527, 32, true);
            WriteLiteral("\r\n                        r=\"40\"");
            EndContext();
            BeginWriteAttribute("fill", "\r\n                        fill=\"", 559, "\"", 619, 1);
#line 23 "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\Index.cshtml"
WriteAttributeValue("", 591, Model.Game.Board[x,y].Color, 591, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(620, 121, true);
            WriteLiteral("\r\n                        stroke-width=\"3\"\r\n                        stroke=\"gray\"\r\n\r\n                        ></circle>\r\n");
            EndContext();
#line 28 "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\Index.cshtml"
            }

#line default
#line hidden
#line 28 "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\Index.cshtml"
             
        }

#line default
#line hidden
#line 29 "C:\Users\creightong\Downloads\checkers-creightonglasscock-master\checkers-creightonglasscock-master\TicTacToe\Pages\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(774, 10, true);
            WriteLiteral("</svg>\r\n\r\n");
            EndContext();
            BeginContext(784, 242, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99685be6c5804786a8013be2046a2067", async() => {
                BeginContext(790, 229, true);
                WriteLiteral("\r\n    <input type=\"text\" id=\"cx\" name=\"cx\" />\r\n    <input type=\"text\" id=\"cy\" name=\"cy\" />\r\n    <input type=\"text\" id=\"sx\" name=\"sx\" />\r\n    <input type=\"text\" id=\"sy\" name=\"sy\" />\r\n    <input type=\"submit\" value=\"Make Move\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
