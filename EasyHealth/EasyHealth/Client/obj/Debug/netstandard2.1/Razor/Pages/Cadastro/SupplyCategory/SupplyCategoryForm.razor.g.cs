#pragma checksum "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\SupplyCategoryForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9137bd977fa0e5ab86cf75217a40ee971514dcf3"
// <auto-generated/>
#pragma warning disable 1591
namespace EasyHealth.Client.Pages.Cadastro.SupplyCategory
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Shared.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Client.Shared.Buttons;

#line default
#line hidden
#nullable disable
    public partial class SupplyCategoryForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\SupplyCategoryForm.razor"
                  supplyCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\SupplyCategoryForm.razor"
                                                  OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "    \r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<label for=\"Name\">Nome<span class=\"text-danger\">*</span></label>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "id", "Name");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\SupplyCategoryForm.razor"
                                     supplyCategory.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplyCategory.Name = __value, supplyCategory.Name))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => supplyCategory.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __Blazor.EasyHealth.Client.Pages.Cadastro.SupplyCategory.SupplyCategoryForm.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#nullable restore
#line 7 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\SupplyCategoryForm.razor"
                                      () => supplyCategory.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.AddMarkupContent(28, "<label for=\"Description\">Descrição<span class=\"text-danger\">*</span></label>\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "id", "Description");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\SupplyCategoryForm.razor"
                                     supplyCategory.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplyCategory.Description = __value, supplyCategory.Description))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => supplyCategory.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __Blazor.EasyHealth.Client.Pages.Cadastro.SupplyCategory.SupplyCategoryForm.TypeInference.CreateValidationMessage_1(__builder2, 38, 39, 
#nullable restore
#line 14 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\SupplyCategoryForm.razor"
                                      () => supplyCategory.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "    \r\n    ");
                __builder2.OpenElement(43, "button");
                __builder2.AddAttribute(44, "class", "btn btn-success");
                __builder2.AddAttribute(45, "type", "submit");
                __builder2.AddEventStopPropagationAttribute(46, "onclick", true);
                __builder2.AddContent(47, 
#nullable restore
#line 17 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\SupplyCategoryForm.razor"
                                                                            ButtonTextSubmit

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "class", "btn btn-danger");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\SupplyCategoryForm.razor"
                                               () =>  navigator.NavigateTo("/SupplyCategory")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(52, 
#nullable restore
#line 18 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\SupplyCategoryForm.razor"
                                                                                                 ButtonTextCancel

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\SupplyCategoryForm.razor"
       

    [Inject]
    public NavigationManager navigator { get; set; }

    [Parameter]
    public SupplyCategory supplyCategory { get; set; } = new SupplyCategory();

    [Parameter]
    public string ButtonTextSubmit { get; set; } = "Salvar";

    [Parameter]
    public string ButtonTextCancel { get; set; } = "Cancelar";

    [Parameter]
    public EventCallback OnValidSubmit { get; set; }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.EasyHealth.Client.Pages.Cadastro.SupplyCategory.SupplyCategoryForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
