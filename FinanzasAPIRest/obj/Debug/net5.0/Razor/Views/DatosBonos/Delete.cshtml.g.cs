#pragma checksum "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5336eafa5520a33c430456f04857dd65e5f2f3c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DatosBonos_Delete), @"mvc.1.0.view", @"/Views/DatosBonos/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5336eafa5520a33c430456f04857dd65e5f2f3c2", @"/Views/DatosBonos/Delete.cshtml")]
    public class Views_DatosBonos_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinanzasAPIRest.Models.DatosBono>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>DatosBono</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorNominal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ValorNominal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ValorComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Plazo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Plazo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TasaInteresMercado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TasaInteresMercado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimaRedencion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrimaRedencion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Estructuracion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Estructuracion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Colocacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Colocacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Flotacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Flotacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cavali));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cavali));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GastosAdicionales));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GastosAdicionales));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InflacionAnual));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InflacionAnual));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Usuario.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Frecuencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\Usuario\source\repos\FinanzasAPIRest\FinanzasAPIRest\Views\DatosBonos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Frecuencia.NombreUnidad));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd class>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""IdOperacion"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinanzasAPIRest.Models.DatosBono> Html { get; private set; }
    }
}
#pragma warning restore 1591
