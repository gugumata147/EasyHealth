#pragma checksum "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2ec764a3505c61ea76d57d491895b5f5526553d"
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
#line 3 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SupplyCategory")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Categoria de insumos</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div>\r\n    <a class=\"btn btn-success text-white mb-2\" href=\"SupplyCategory/Create\">Adicionar</a>\r\n</div>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
 if (SupplyCategories == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Carregando...</em></p>\r\n");
#nullable restore
#line 14 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
}
else if (SupplyCategories.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.AddMarkupContent(5, "<p><em>Não existe categorias de insumos cadastradas!</em></p>\r\n");
#nullable restore
#line 18 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<thead>\r\n            <tr>\r\n                <th>Categoria</th>\r\n                <th>Descrição</th>\r\n                <th>Edita</th>\r\n                <th>Deleta</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 31 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
             foreach (var supplyCategory in SupplyCategories)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 34 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                         supplyCategory.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 35 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                         supplyCategory.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "class", "btn btn-primary text-white");
            __builder.AddAttribute(26, "href", "/SupplyCategory/Edit/" + (
#nullable restore
#line 37 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                                                          supplyCategory.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "class", "btn btn-danger text-white");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                                         () => DeleteSupplyCategory(supplyCategory.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Deletar");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 43 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.AddContent(42, "    ");
            __builder.OpenComponent<EasyHealth.Client.Shared.Pagination>(43);
            __builder.AddAttribute(44, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                  TotalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                                 CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "Range", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                                                     3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 47 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                                                                      SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 49 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "\r\n");
            __builder.OpenComponent<EasyHealth.Client.Pages.ConfirmationForm>(50);
            __builder.AddAttribute(51, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 51 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                 CancelConfirm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(52, "OnConfirmation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 51 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                                                 DeleteConfirm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(54, "\r\n    ");
                __builder2.AddMarkupContent(55, "<div>Deseja realmente excluir este item ?</div>\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(56, (__value) => {
#nullable restore
#line 51 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                        Confirmation = (EasyHealth.Client.Pages.ConfirmationForm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
       
    List<SupplyCategory> SupplyCategories { get; set; }
    ConfirmationForm Confirmation;
    int SupplyCategoryId;
    public int TotalAmountPages { get; set; }
    public int CurrentPage { get; set; }
    public int TotalAmountItems { get; set; }

    private async Task SelectedPage(int page)
    {
        CurrentPage = page;
        await LoadSupplyCategories(page);
    }


    protected override async Task OnInitializedAsync()
    {
        await LoadSupplyCategories();
    }

    async Task LoadSupplyCategories(int page = 1, int amountPerPage = 5)
    {
        var httpResponse = await http.GetAsync($"/api/supplyCategory/Get?page={page}&amountPerPage={amountPerPage}");

        if (httpResponse.IsSuccessStatusCode)
        {
            TotalAmountPages = int.Parse(httpResponse.Headers.GetValues("totalPages").FirstOrDefault());
            TotalAmountItems = int.Parse(httpResponse.Headers.GetValues("totalAmount").FirstOrDefault());

            if (TotalAmountItems == 0)
            {
                SupplyCategories = new List<SupplyCategory>();
            } 
            else
            {
                if (TotalAmountPages < CurrentPage)
                {
                    httpResponse = await http.GetAsync($"/api/supplyCategory/Get?page={page - 1}&amountPerPage={amountPerPage}");
                    TotalAmountPages = int.Parse(httpResponse.Headers.GetValues("totalPages").FirstOrDefault());
                }

                var responseString = await httpResponse.Content.ReadAsStringAsync();

                SupplyCategories = JsonSerializer.Deserialize<List<SupplyCategory>>(responseString, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
            }


        }
    }

    void DeleteSupplyCategory(int id)
    {
        Confirmation.Display();
        SupplyCategoryId = id;
    }

    async Task DeleteConfirm()
    {
        await http.DeleteAsync($"/api/SupplyCategory/Delete/{SupplyCategoryId}");
        Confirmation.Hide();
        await SelectedPage(CurrentPage);
    }

    private void CancelConfirm()
    {
        Confirmation.Hide();
        SupplyCategoryId = 0;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
