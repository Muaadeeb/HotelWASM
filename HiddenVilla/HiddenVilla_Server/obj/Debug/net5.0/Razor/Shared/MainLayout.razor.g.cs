#pragma checksum "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "265c6a609be006d438133cd5f326e7d95757e9a1"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-sd4odr08ss");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-sd4odr08ss");
            __builder.OpenComponent<HiddenVilla_Server.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-sd4odr08ss");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-sd4odr08ss");
            __builder.OpenComponent<HiddenVilla_Server.Shared.LoginDisplay>(14);
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.AddMarkupContent(16, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-sd4odr08ss>About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "content px-4");
            __builder.AddAttribute(20, "b-sd4odr08ss");
            __builder.AddContent(21, 
#nullable restore
#line 15 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
