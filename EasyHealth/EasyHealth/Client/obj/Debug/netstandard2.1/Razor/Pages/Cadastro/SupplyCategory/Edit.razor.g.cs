#pragma checksum "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff227bfc6202bdf1c5620a77fd4d0295d0c4dfbe"
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
#line 1 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Shared.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Client.Shared.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SupplyCategory/Edit/{supplyCategoryId:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<EasyHealth.Client.Pages.Cadastro.SupplyCategory.SupplyCategoryForm>(0);
            __builder.AddAttribute(1, "supplyCategory", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<EasyHealth.Shared.Model.SupplyCategory>(
#nullable restore
#line 5 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Edit.razor"
                                     supplyCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Edit.razor"
                                                                     UpdateSupplyCategory

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ButtonTextCancel", "Cancelar");
            __builder.AddAttribute(4, "ButtonTextSubmit", "Atualizar");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Edit.razor"
       
    [Parameter]
    public int supplyCategoryId { get; set; }
    public SupplyCategory supplyCategory { get; set; } = new SupplyCategory();

    protected async override Task OnParametersSetAsync()
    {
        supplyCategory = await http.GetJsonAsync<SupplyCategory>($"/api/SupplyCategory/Get/{supplyCategoryId}");
    }

    async Task UpdateSupplyCategory()
    {
        supplyCategory = await http.PutJsonAsync<SupplyCategory>($"/api/SupplyCategory/Update", supplyCategory);
        navigator.NavigateTo("/SupplyCategory");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
