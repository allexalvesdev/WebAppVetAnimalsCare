#pragma checksum "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2067a71e86ab10ea2cc0ade22d9917a9bc24e47e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animais_Delete), @"mvc.1.0.view", @"/Views/Animais/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2067a71e86ab10ea2cc0ade22d9917a9bc24e47e", @"/Views/Animais/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8696af2e76fcfe31055f781a5a8bebe552b26035", @"/Views/_ViewImports.cshtml")]
    public class Views_Animais_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppVeterinaria.Entity.Animal>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
  
    ViewData["Title"] = "Excluir";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section");
            BeginWriteAttribute("class", " class=\"", 95, "\"", 103, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""container"">

        <div style=""background-color:white; width:100%; display:flex; padding:40px; flex-wrap:wrap;"" class=""shadow-sm mt-5"">
            <h1>Excluir</h1>

            <div class=""col-md-12"">
                <h3 class=""alert-danger"">Você tem certeza que deseja excluir este animal?</h3>
            </div>

            <div>
                <hr />
                <dl class=""row"">
                    <dt class=""col-sm-2"">
                        ");
#nullable restore
#line 21 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 24 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayName("Raça"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 30 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Raca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Idade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 36 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Idade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 39 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 42 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 45 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayName("Observação"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 48 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 51 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayName("Sexo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 54 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.TipoSexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 57 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayName("Espécie"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 60 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.TipoEspecie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 63 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayName("Pelagem"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 66 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.TipoPelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 69 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 72 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 75 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayName("Cliente"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 78 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Cliente.NomeCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2067a71e86ab10ea2cc0ade22d9917a9bc24e47e13164", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2067a71e86ab10ea2cc0ade22d9917a9bc24e47e13443", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 83 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Animais\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Excluir\" class=\"btn btn-danger\" />\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2067a71e86ab10ea2cc0ade22d9917a9bc24e47e15265", async() => {
                    WriteLiteral("Voltar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppVeterinaria.Entity.Animal> Html { get; private set; }
    }
}
#pragma warning restore 1591
