#pragma checksum "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a9130d4e79a937ff8d56d742a3054b3282d62e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Details), @"mvc.1.0.view", @"/Views/Produtos/Details.cshtml")]
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
#line 1 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a9130d4e79a937ff8d56d742a3054b3282d62e5", @"/Views/Produtos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83123ee4d6c0cf5ade552e3914bbd88cb8468f21", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevIO.App.ViewModels.ProdutoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px; height:428px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
  
    ViewData["Title"] = "Detalhes do Produto - " + Model.Nome;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h4 style=\"padding-top:50px\">");
#nullable restore
#line 7 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
                            Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4a9130d4e79a937ff8d56d742a3054b3282d62e54245", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 270, "~/imagens/", 270, 10, true);
#nullable restore
#line 12 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
AddHtmlAttributeValue("", 280, Model.Imagem, 280, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
AddHtmlAttributeValue("", 300, Model.Imagem, 300, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-md-6\">\r\n            <dl>\r\n                <dt>\r\n                    ");
#nullable restore
#line 18 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd >\r\n                    ");
#nullable restore
#line 21 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt >\r\n                    ");
#nullable restore
#line 24 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd >\r\n                    ");
#nullable restore
#line 27 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt >\r\n                    ");
#nullable restore
#line 30 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Imagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd >\r\n                    ");
#nullable restore
#line 33 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Imagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt >\r\n                    ");
#nullable restore
#line 36 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd >\r\n                    ");
#nullable restore
#line 39 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
               Write(Model.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt >\r\n                    ");
#nullable restore
#line 42 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd >\r\n                    ");
#nullable restore
#line 45 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt >\r\n                    ");
#nullable restore
#line 48 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Fornecedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd >\r\n                    ");
#nullable restore
#line 51 "C:\Users\wataliba\labs\mvc_completo\MinhaMvcAppCompleta\src\DevIO.App\Views\Produtos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Fornecedor.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </dd>
            </dl>

            <div>
                <input type=""submit"" value=""Editar"" class=""btn btn-dark"" />
                <a class=""btn btn-info"" href=""javascript:window.history.back();"">Voltar</a>
            </div>
        </div>
</div>  
    
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevIO.App.ViewModels.ProdutoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
