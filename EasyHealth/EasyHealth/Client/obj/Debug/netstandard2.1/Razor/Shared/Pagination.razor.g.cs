#pragma checksum "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Shared\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95743d0e6f69bede13fccb5de0f06b521de6489c"
// <auto-generated/>
#pragma warning disable 1591
namespace EasyHealth.Client.Shared
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
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Pagination");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pagination justify-content-center");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 3 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Shared\Pagination.razor"
         foreach (var link in links)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Shared\Pagination.razor"
                            () => SelectedPageLink(link)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "page-item" + " " + (
#nullable restore
#line 5 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Shared\Pagination.razor"
                                                                              link.Enable ? null : "disabled"

#line default
#line hidden
#nullable disable
            ) + " \r\n                " + (
#nullable restore
#line 6 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Shared\Pagination.razor"
                  link.Active ? "active" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "style", "cursor:pointer");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "page-link");
            __builder.AddAttribute(14, "href", "#");
            __builder.AddContent(15, 
#nullable restore
#line 7 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Shared\Pagination.razor"
                                                  link.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 9 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Shared\Pagination.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Shared\Pagination.razor"
       
    [Parameter] public int CurrentPage { get; set; } = 1;
    [Parameter] public int TotalAmountPages { get; set; }
    [Parameter] public int Range { get; set; } = 3;
    [Parameter] public EventCallback<int> SelectedPage { get; set; }

    List<LinkModel> links;


    private async Task SelectedPageLink(LinkModel linkModel)
    {
        if (linkModel.Page == CurrentPage)
        {
            return;
        }

        if (!linkModel.Enable)
        {
            return;
        }

        CurrentPage = linkModel.Page;
        await SelectedPage.InvokeAsync(linkModel.Page);
    }

    class LinkModel
    {
        public LinkModel(int page) : this(page, true)
        {

        }

        public LinkModel(int page, bool enable) : this(page, enable, page.ToString())
        {

        }

        public LinkModel(int page, bool enable, string text)
        {
            this.Page = page;
            this.Enable = enable;
            this.Text = text;
        }

        public string Text { get; set; }
        public int Page { get; set; }
        public bool Enable { get; set; }
        public bool Active { get; set; }
    }

    protected override void OnParametersSet()
    {
        LoadingPages();
    }

    private void LoadingPages()
    {
        links = new List<LinkModel>();

        CurrentPage = CurrentPage == 0 ? 1 : CurrentPage;
  
        //Aqui estou tratando o link da página anterior
        var isPreviousPageLinkEnable = CurrentPage > 1;

        if (TotalAmountPages == 1)
        {
            isPreviousPageLinkEnable = false;
        }

        var previousPage = CurrentPage - 1;

        links.Add(new LinkModel(previousPage, isPreviousPageLinkEnable, "Anterior"));

        //Aqui trato o link de todas as páginas exceto a anterior e a última página

        for (int x = 1; x <= TotalAmountPages; x++)
        {
            //Vejo se a página está dentro do raio
            if (x >= CurrentPage - Range && x <= CurrentPage + Range)
            {
                links.Add(new LinkModel(x)
                {
                    Active = CurrentPage == x
                });
            }
        }

        var isNextPageLinkEnable = CurrentPage != TotalAmountPages;

        if (TotalAmountPages == 1)
        {
            isNextPageLinkEnable = false;
        }

        //Aqui estou tratando o link da última página
        var nextPage = CurrentPage + 1;
        links.Add(new LinkModel(nextPage, isNextPageLinkEnable, "Próximo"));

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
