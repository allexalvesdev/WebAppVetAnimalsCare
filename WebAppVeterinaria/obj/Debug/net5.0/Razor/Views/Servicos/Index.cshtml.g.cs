#pragma checksum "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bd322c4be16fdb3979dae1cb5a15027869b1dd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servicos_Index), @"mvc.1.0.view", @"/Views/Servicos/Index.cshtml")]
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
#line 1 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\_ViewImports.cshtml"
using WebAppVeterinaria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\_ViewImports.cshtml"
using WebAppVeterinaria.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bd322c4be16fdb3979dae1cb5a15027869b1dd8", @"/Views/Servicos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8696af2e76fcfe31055f781a5a8bebe552b26035", @"/Views/_ViewImports.cshtml")]
    public class Views_Servicos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAppVeterinaria.Entity.Servico>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
  
    ViewData["Title"] = "Lista de Serviços";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section");
            BeginWriteAttribute("class", " class=\"", 119, "\"", 127, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"container\">\r\n\r\n        <h3 class=\"text-color-primary mt-1\">");
#nullable restore
#line 10 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n        <div class=\"col-md-4 p-0\">\r\n            <div class=\"mb-2\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bd322c4be16fdb3979dae1cb5a15027869b1dd84687", async() => {
                WriteLiteral("<i class=\"fas fa-hand-holding-medical\"></i> Novo Serviço");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
         if (TempData["createSuccess"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"msg_box\" class=\"alert alert-success\">");
#nullable restore
#line 19 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                                                     Write(TempData["createSuccess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 20 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
         if (TempData["error"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-error\">");
#nullable restore
#line 24 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                                      Write(TempData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 25 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
         if (TempData["updateSuccess"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"msg_box\" class=\"alert alert-success\">");
#nullable restore
#line 28 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                                                     Write(TempData["updateSuccess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 29 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
         if (TempData["deleteSuccess"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"msg_box\" class=\"alert alert-success\">");
#nullable restore
#line 32 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                                                     Write(TempData["deleteSuccess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 33 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <table class=\"table shadow p-3 rounded\">\r\n            <thead class=\"table-light bg-light rounded text-color-secondary\">\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 39 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 42 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                   Write(Html.DisplayName("Descição"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 45 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                   Write(Html.DisplayName("Preço"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody class=\"bg-light text-color-primary\">\r\n");
#nullable restore
#line 51 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 55 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 58 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 61 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 64 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                       Write(Html.ActionLink("", "Edit", new { item.Id }, new { @class = "btn btn-light bg-white fas fa-pen p-2 shadow-sm text-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 65 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                       Write(Html.ActionLink("", "Details", new { item.Id }, new { @class = "btn btn-light bg-white fas fa-search p-2 shadow-sm text-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 66 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                       Write(Html.ActionLink("", "Delete", new { item.Id }, new { @class = "btn btn-light bg-white fas fa-trash-alt p-2 shadow-sm text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 69 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Servicos\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAppVeterinaria.Entity.Servico>> Html { get; private set; }
    }
}
#pragma warning restore 1591
