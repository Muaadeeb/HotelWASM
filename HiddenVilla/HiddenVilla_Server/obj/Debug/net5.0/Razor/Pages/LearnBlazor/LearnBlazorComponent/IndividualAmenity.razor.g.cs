#pragma checksum "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d56d8cf68eeaebb3e74b60acf85ad08dd07752"
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
    public partial class IndividualAmenity : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bi-light border p-2 col-5 offset-1");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenity.razor"
                                                          (args)=>AmenitySelectionChanged(args, Amenity.Name)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(3, "h4");
            __builder.AddAttribute(4, "class", "text-secondary");
            __builder.AddContent(5, "Amenities - ");
            __builder.AddContent(6, 
#nullable restore
#line 4 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenity.razor"
                                                Amenity.AmentityId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.AddContent(8, 
#nullable restore
#line 6 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenity.razor"
         Amenity.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "<br>\r\n        ");
            __builder.AddContent(10, 
#nullable restore
#line 7 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenity.razor"
         Amenity.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "<br>\r\n        RF from Parent - ");
            __builder.AddContent(12, 
#nullable restore
#line 8 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenity.razor"
                          FirstFragment

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " ");
            __builder.AddContent(14, 
#nullable restore
#line 8 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenity.razor"
                                         SecondFragment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualAmenity.razor"
           

        [Parameter]
        public Amenity Amenity { get; set; }

        [Parameter]
        public EventCallback<string> OnAmenitySelection { get; set; }

        [Parameter]
        public RenderFragment FirstFragment { get; set; }

        [Parameter]
        public RenderFragment SecondFragment { get; set; }

        protected async Task AmenitySelectionChanged(MouseEventArgs e, string name)
        {
            // Note we are not using MouseEventArgs - is this here to represent a pattern for the future?  On line 1 - we could remove the lamba and just pass in Amenity.Name... fyi
            await OnAmenitySelection.InvokeAsync(name);
        }

        // TJI #1
        //protected async Task AmenitySelectionChanged()
        //{   // Alternate way to do this.
        //    await OnAmenitySelection.InvokeAsync(Amenity.Name);
        //}


    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
