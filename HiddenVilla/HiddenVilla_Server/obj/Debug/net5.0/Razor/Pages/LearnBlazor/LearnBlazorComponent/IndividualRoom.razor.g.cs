#pragma checksum "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9555bdc532f71d04b0c0e20c6dd94a61183f588c"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.ModelsUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
    public partial class IndividualRoom : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bi-light border p-2 col-5 offset-1");
            __builder.OpenElement(2, "h4");
            __builder.AddAttribute(3, "class", "text-secondary");
            __builder.AddContent(4, "Room - ");
            __builder.AddContent(5, 
#nullable restore
#line 2 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                                       Room.RoomId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "checkbox");
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                                      RoomCheckBoxSelectionChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n\r\n    ");
            __builder.AddContent(11, 
#nullable restore
#line 7 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
     Room.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, " <br>\r\n    ");
            __builder.AddContent(13, 
#nullable restore
#line 8 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
     Room.Price.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "<br>\r\n    ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "checkbox");
            __builder.AddAttribute(17, "checked", 
#nullable restore
#line 9 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                                                                  Room.IsActive?"checked":null

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                                        Room.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Room.IsActive = __value, Room.IsActive));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, " &nbsp; Is Active<br>\r\n    ");
            __builder.OpenElement(21, "span");
            __builder.AddContent(22, "This room is ");
            __builder.AddContent(23, 
#nullable restore
#line 10 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                         Room.IsActive?"Active":"Inactive"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
     if (Room.IsActive)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
         foreach (var prop in Room.RoomProperties)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "p");
            __builder.AddContent(25, 
#nullable restore
#line 16 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                prop.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, " - ");
            __builder.AddContent(27, 
#nullable restore
#line 16 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                             prop.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent.EditDeleteButton>(28);
            __builder.AddAttribute(29, "IsAdmin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                               false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
       

    [Parameter]
    public Room Room { get; set; }

    [Parameter]
    public EventCallback<bool> OnRoomCheckBoxSelection { get; set; }

    //RoomSelectionCounterChanged

    protected async Task RoomCheckBoxSelectionChanged(ChangeEventArgs e)
    {
        await OnRoomCheckBoxSelection.InvokeAsync((bool)e.Value);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
