#pragma checksum "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2351f339f75eeadb5c4d68c168cc3e5debdec43"
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
#nullable restore
#line 3 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
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
            __builder.AddMarkupContent(0, "<h2 class=\"text-center\">Categoria de insumos</h2>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "mb-2 row container col-md-auto");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<EasyHealth.Client.Shared.Buttons.AddButton>(6);
            __builder.AddAttribute(7, "Icon", "fas fa-plus");
            __builder.AddAttribute(8, "Name", "");
            __builder.AddAttribute(9, "Url", "SupplyCategory/Create");
            __builder.AddAttribute(10, "TabIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                                                    1

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-inline col-md-10");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddMarkupContent(16, "<label class=\"sr-only\" for=\"filter-name\">Filtro</label>\r\n        ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "name", "filter-name");
            __builder.AddAttribute(20, "class", "form-control mb-2 mr-sm-2 col-md-9");
            __builder.AddAttribute(21, "placeholder", "Filtrar Pelo nome");
            __builder.AddAttribute(22, "tabindex", "2");
            __builder.AddAttribute(23, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                                                            e => FilterKeyPress(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                       FilterName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FilterName = __value, FilterName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenComponent<EasyHealth.Client.Shared.Buttons.EditButton>(27);
            __builder.AddAttribute(28, "Name", "");
            __builder.AddAttribute(29, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 15 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                      Filter

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(30, "Css", "mr-sm-2 mb-2");
            __builder.AddAttribute(31, "Icon", "fas fa-search");
            __builder.AddAttribute(32, "TabIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                                                                3

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenComponent<EasyHealth.Client.Shared.Buttons.DeleteButton>(34);
            __builder.AddAttribute(35, "Name", "");
            __builder.AddAttribute(36, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 16 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                       FilterClean

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(37, "Css", "mb-2");
            __builder.AddAttribute(38, "Icon", "fas fa-eraser");
            __builder.AddAttribute(39, "TabIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                                                              4

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n");
#nullable restore
#line 20 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
 if (SupplyCategories == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "    ");
            __builder.AddMarkupContent(44, "<p><em>Carregando...</em></p>\r\n");
#nullable restore
#line 23 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
}
else if (SupplyCategories.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "    ");
            __builder.AddMarkupContent(46, "<p><em>Não existe categorias de insumos cadastradas!</em></p>\r\n");
#nullable restore
#line 27 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "    ");
            __builder.OpenElement(48, "table");
            __builder.AddAttribute(49, "class", "table table-hover");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.AddMarkupContent(51, "<thead>\r\n            <tr>\r\n                <th>Categoria</th>\r\n                <th>Descrição</th>\r\n                <th class=\"text-center\">Ação</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(52, "tbody");
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 39 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
             foreach (var supplyCategory in SupplyCategories)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "                ");
            __builder.OpenElement(55, "tr");
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 42 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                         supplyCategory.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 43 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                         supplyCategory.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "td");
            __builder.AddAttribute(64, "class", "text-center");
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenComponent<EasyHealth.Client.Shared.Buttons.EditButton>(66);
            __builder.AddAttribute(67, "Icon", "fas fa-edit");
            __builder.AddAttribute(68, "Name", "");
            __builder.AddAttribute(69, "Url", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                           "/SupplyCategory/Edit/" + supplyCategory.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "Css", "ml-2");
            __builder.CloseComponent();
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.OpenComponent<EasyHealth.Client.Shared.Buttons.DeleteButton>(72);
            __builder.AddAttribute(73, "Icon", "fas fa-trash-alt");
            __builder.AddAttribute(74, "Name", "");
            __builder.AddAttribute(75, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 48 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                 () => DeleteSupplyCategory(supplyCategory.Id)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 51 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n    ");
            __builder.OpenElement(82, "footer");
            __builder.AddAttribute(83, "class", "page-footer fixed-bottom");
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.OpenComponent<EasyHealth.Client.Shared.Pagination>(85);
            __builder.AddAttribute(86, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 55 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                       TotalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 55 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                                       CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "Range", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 55 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                                                           3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 55 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                                                                             SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(90, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 57 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(92, "\r\n");
            __builder.OpenComponent<EasyHealth.Client.Pages.ConfirmationForm>(93);
            __builder.AddAttribute(94, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 59 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                 CancelConfirm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(95, "OnConfirmation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 59 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
                                                                                 DeleteConfirm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(97, "\r\n    ");
                __builder2.AddMarkupContent(98, "<div>Deseja realmente excluir este item ?</div>\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(99, (__value) => {
#nullable restore
#line 59 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
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
#line 64 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\SupplyCategory\Index.razor"
       
    List<SupplyCategory> SupplyCategories { get; set; }
    ConfirmationForm Confirmation;
    int SupplyCategoryId;
    public int TotalAmountPages { get; set; }
    public int CurrentPage { get; set; }
    public int TotalAmountItems { get; set; }
    public string FilterName { get; set; } = string.Empty;

    private async Task Filter()
    {
        CurrentPage = 1;
        await LoadSupplyCategories();
    }

    private async Task FilterClean()
    {
        FilterName = string.Empty;
        CurrentPage = 1;
        await LoadSupplyCategories();
    }

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

        if (page <= 0)
        {
            page = 1;
        }

        var httpResponse = await http.GetAsync($"/api/supplyCategory/Get?page={page}&amountPerPage={amountPerPage}&name={FilterName}");

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

    private async Task FilterKeyPress(KeyboardEventArgs e)
    {
        if (ConsoleKey.Enter.ToString() == e.Key)
        {
            await Filter();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
