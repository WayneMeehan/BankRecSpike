#pragma checksum "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\Pages\Components\BankTransaction.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0886f7e2daa3fa9f08bf7655a07ed2ec03f1b0c3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\_Imports.razor"
using BlazorApp1.Pages.Components;

#line default
#line hidden
#nullable disable
    public partial class BankTransaction : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\Pages\Components\BankTransaction.razor"
 if (TransactionData != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "tr");
            __builder.AddAttribute(2, "class", 
#nullable restore
#line 3 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\Pages\Components\BankTransaction.razor"
                backgroundClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 4 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\Pages\Components\BankTransaction.razor"
         if (ViewModel.SelectedTransaction != null && !TransactionData.IsReconciled)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "            ");
            __builder.OpenElement(5, "td");
            __builder.AddAttribute(6, "class", "mdc-data-table__cell mdc-data-table__cell--checkbox");
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "mdc-checkbox mdc-data-table__row-checkbox");
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "checkbox");
            __builder.AddAttribute(13, "class", "mdc-checkbox__native-control");
            __builder.AddAttribute(14, "aria-labelledby", "u0");
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\Pages\Components\BankTransaction.razor"
                                      (e) => {var selected = (bool)e.Value; SelectClick(selected); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, @"<div class=""mdc-checkbox__background"">
                        <svg class=""mdc-checkbox__checkmark"" viewBox=""0 0 24 24"">
                            <path class=""mdc-checkbox__checkmark-path"" fill=""none"" d=""M1.73,12.91 8.1,19.28 22.79,4.59""></path>
                        </svg>
                        <div class=""mdc-checkbox__mixedmark""></div>
                    </div>
                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 18 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\Pages\Components\BankTransaction.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "            <td class=\"mdc-data-table__cell\"></td>\r\n");
#nullable restore
#line 22 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\Pages\Components\BankTransaction.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "        ");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "class", "mdc-data-table__cell");
            __builder.AddContent(24, 
#nullable restore
#line 23 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\Pages\Components\BankTransaction.razor"
                                          TransactionData.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "class", "mdc-data-table__cell");
            __builder.AddContent(28, 
#nullable restore
#line 24 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\Pages\Components\BankTransaction.razor"
                                          TransactionData.Date.ToString("dd MMM")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "class", "mdc-data-table__cell");
            __builder.AddContent(32, 
#nullable restore
#line 25 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\Pages\Components\BankTransaction.razor"
                                          TransactionData.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "class", "mdc-data-table__cell");
            __builder.AddContent(36, 
#nullable restore
#line 26 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\Pages\Components\BankTransaction.razor"
                                          TransactionData.Reference

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "class", "mdc-data-table__cell mdc-data-table__cell--numeric");
            __builder.AddContent(40, 
#nullable restore
#line 27 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\Pages\Components\BankTransaction.razor"
                                                                        TransactionData.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 29 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\Pages\Components\BankTransaction.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\wayne\source\repos\BankRecSpike1\BlazorApp1\Pages\Components\BankTransaction.razor"
       
    [Parameter]
    public BlazorApp1.Models.Transaction TransactionData { get; set; }

    [Parameter]
    public BlazorApp1.Models.ReconcileViewModel ViewModel { get; set; }

    private string backgroundClass => TransactionData.IsReconciled ? "reconciled-transaction" : "";

    private void SelectClick(bool selected)
    {
        if (selected)
        {
            ViewModel.AddSelectedBankTransaction(TransactionData);
        }
        else
        {
            ViewModel.RemoveSelectedBankTransaction(TransactionData);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591