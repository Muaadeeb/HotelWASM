// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HiddenVilla\HiddenVilla_Server\Pages\Index.razor"
      

    private string SelectedRoomProperties = "";
    List<Room> RoomsList = new List<Room>();


    Room Room = new Room()
    {
        RoomId = 101,
        Name = "Villa Suite",
        IsActive = true,
        Price = 499,
        RoomProperties = new List<RoomProperties>
        {
            new RoomProperties{RoomPropertiesId = 1, Name="Sq Ft", Value="100"},
            new RoomProperties{RoomPropertiesId = 2, Name="Occupancy", Value="3"}
        }

    };

    protected override void OnInitialized()
    {
        base.OnInitialized();

        RoomsList.Add(new Room()
        {
            RoomId = 201,
            Name = "Villa Suite One Bed Room",
            IsActive = true,
            Price = 399,
            RoomProperties = new List<RoomProperties>
            {
                new RoomProperties{RoomPropertiesId = 1, Name="Sq Ft", Value="100"},
                new RoomProperties{RoomPropertiesId = 2, Name="Occupancy", Value="4"}
            }
        });

        RoomsList.Add(new Room()
        {
            RoomId = 301,
            Name = "Villa Suite One Bed Room",
            IsActive = true,
            Price = 699,
            RoomProperties = new List<RoomProperties>
            {
                new RoomProperties{RoomPropertiesId = 1, Name="Sq Ft", Value="150"},
                new RoomProperties{RoomPropertiesId = 2, Name="Occupancy", Value="6"}
            }
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
