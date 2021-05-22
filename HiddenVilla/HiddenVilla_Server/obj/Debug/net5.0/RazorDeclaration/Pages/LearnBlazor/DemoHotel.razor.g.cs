// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages.LearnBlazor
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
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/demohotel")]
    public partial class DemoHotel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
      
    public int SelectedRooms { get; set; } = 0;
    public string SelectedAmenity { get; set; } = string.Empty;
    List<Room> RoomsList = new List<Room>();
    List<Amenity> AmenitiesList = new List<Amenity>();


    protected override void OnInitialized()
    {
        base.OnInitialized();

        RoomsList.Add(new Room()
        {
            RoomId = 201,
            Name = "Villa Suite One Bed Room",
            IsActive = true,
            Price = 399,
            RoomProperties = new List<RoomProperty>
            {
                new RoomProperty{RoomPropertyId = 1, Name="Sq Ft", Value="100"},
                new RoomProperty{RoomPropertyId = 2, Name="Occupancy", Value="4"}
            }
        });

        RoomsList.Add(new Room()
        {
            RoomId = 301,
            Name = "Villa Suite One Bed Room",
            IsActive = true,
            Price = 699,
            RoomProperties = new List<RoomProperty>
            {
                new RoomProperty{RoomPropertyId = 1, Name="Sq Ft", Value="150"},
                new RoomProperty{RoomPropertyId = 2, Name="Occupancy", Value="6"}
            }
        });

        AmenitiesList.Add(new Amenity
        {
            AmentityId = 111,
            Name = "Gym",
            Description = "24x7 gym room is available."
        });

        AmenitiesList.Add(new Amenity
        {
            AmentityId = 222,
            Name = "Swimming Pool",
            Description = "Pool room is open from 6am to 10pm."
        });

        AmenitiesList.Add(new Amenity
        {
            AmentityId = 333,
            Name = "Free Breakfast",
            Description = "Enjoy free breakfast at our hotel."
        });
    }


    protected void RoomSelectionCounterChanged(bool isRoomSelected)
    {
        if (isRoomSelected)
        {
            SelectedRooms++;
        }
        else
        {
            SelectedRooms--;
        }
    }

    protected void AmenitySelectionChanged(string amenity)
    {
        SelectedAmenity = amenity;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591