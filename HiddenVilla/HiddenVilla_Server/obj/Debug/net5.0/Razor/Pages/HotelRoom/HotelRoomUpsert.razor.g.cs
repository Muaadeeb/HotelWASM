#pragma checksum "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a1405d6ef02b4b142fab79d3ca5587f58e868fe"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.HotelRoom
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/edit/{Id:int}")]
    public partial class HotelRoomUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-2 mb-5");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "card-title text-info mb-3 ml-3");
            __builder.AddContent(4, 
#nullable restore
#line 12 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " Hotel Room");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                 HotelRoomDto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                              HandleHotelRoomUpsert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label>Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                HotelRoomDto.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomDto.Name = __value, HotelRoomDto.Name))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomDto.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 22 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                ()=> HotelRoomDto.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label>Occupancy</label>\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateInputNumber_1(__builder2, 34, 35, "form-control", 36, 
#nullable restore
#line 26 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                  HotelRoomDto.Occupancy

#line default
#line hidden
#nullable disable
                , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomDto.Occupancy = __value, HotelRoomDto.Occupancy)), 38, () => HotelRoomDto.Occupancy);
                __builder2.AddMarkupContent(39, "\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_2(__builder2, 40, 41, 
#nullable restore
#line 27 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                ()=> HotelRoomDto.Occupancy

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label>Rate</label>\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateInputNumber_3(__builder2, 46, 47, "form-control", 48, 
#nullable restore
#line 31 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                  HotelRoomDto.RegularRate

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomDto.RegularRate = __value, HotelRoomDto.RegularRate)), 50, () => HotelRoomDto.RegularRate);
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_4(__builder2, 52, 53, 
#nullable restore
#line 32 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                ()=> HotelRoomDto.RegularRate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "<label>Sq Ft</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                HotelRoomDto.SqFt

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomDto.SqFt = __value, HotelRoomDto.SqFt))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomDto.SqFt));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                    ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddAttribute(66, "style", "height: 250px;");
                __builder2.AddMarkupContent(67, "<label>Details</label>\r\n                        ");
                __builder2.OpenComponent<Blazored.TextEditor.BlazoredTextEditor>(68);
                __builder2.AddAttribute(69, "Placeholder", "Please enter room details");
                __builder2.AddAttribute(70, "ToolbarContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(71, "select");
                    __builder3.AddAttribute(72, "class", "ql-header");
                    __builder3.OpenElement(73, "option");
                    __builder3.AddAttribute(74, "selected");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\r\n                                    ");
                    __builder3.OpenElement(76, "option");
                    __builder3.AddAttribute(77, "value", "1");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(78, "\r\n                                    ");
                    __builder3.OpenElement(79, "option");
                    __builder3.AddAttribute(80, "value", "2");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\r\n                                    ");
                    __builder3.OpenElement(82, "option");
                    __builder3.AddAttribute(83, "value", "3");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(84, "\r\n                                    ");
                    __builder3.OpenElement(85, "option");
                    __builder3.AddAttribute(86, "value", "4");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\r\n                                    ");
                    __builder3.OpenElement(88, "option");
                    __builder3.AddAttribute(89, "value", "5");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\r\n                                ");
                    __builder3.AddMarkupContent(91, @"<span class=""ql-formats""><button class=""ql-bold""></button>
                                    <button class=""ql-italic""></button>
                                    <button class=""ql-underline""></button>
                                    <button class=""ql-strike""></button></span>
                                ");
                    __builder3.AddMarkupContent(92, "<span class=\"ql-formats\"><select class=\"ql-color\"></select>\r\n                                    <select class=\"ql-background\"></select></span>\r\n                                ");
                    __builder3.AddMarkupContent(93, "<span class=\"ql-formats\"><button class=\"ql-list\" value=\"ordered\"></button>\r\n                                    <button class=\"ql-list\" value=\"bullet\"></button></span>\r\n                                ");
                    __builder3.AddMarkupContent(94, "<span class=\"ql-formats\"><button class=\"ql-link\"></button></span>");
                }
                ));
                __builder2.AddAttribute(95, "EditorContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                }
                ));
                __builder2.AddComponentReferenceCapture(96, (__value) => {
#nullable restore
#line 41 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                   QuillHtml = (Blazored.TextEditor.BlazoredTextEditor)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n\r\n                    ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "form-group");
                __builder2.AddAttribute(100, "style", "padding-top: 70px;");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(101);
                __builder2.AddAttribute(102, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                             HandleImageUpload

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(103, "multiple", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n                        ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "row");
#nullable restore
#line 79 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                             if (IsImageUploadProcessStarted)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(107, "<div class=\"col-md-12\"><span><i class=\"fa fa-spin fa-spinner\"></i>&nbsp; Please wait... Images are uploading...</span></div>");
#nullable restore
#line 84 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                             if (HotelRoomDto.ImagesUrls != null && HotelRoomDto.ImagesUrls.Count > 0)
                            {
                                int roomImageNumber = 1;
                                foreach (var roomImage in HotelRoomDto.ImagesUrls)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "col-md-2 mt-3");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "room-image");
                __builder2.AddAttribute(112, "style", "background:" + " url(\'" + (
#nullable restore
#line 92 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                                                 roomImage

#line default
#line hidden
#nullable disable
                ) + "\')" + " 50%" + " 50%;");
                __builder2.OpenElement(113, "span");
                __builder2.AddAttribute(114, "class", "room-image-title");
                __builder2.AddContent(115, 
#nullable restore
#line 93 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                                    roomImageNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n                                ");
                __builder2.OpenElement(117, "button");
                __builder2.AddAttribute(118, "type", "button");
                __builder2.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                                ()=>DeletePhoto(roomImage)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(120, "class", "btn btn-outline-danger btn-block mt-4");
                __builder2.AddMarkupContent(121, "\r\n                                    Delete\r\n                                ");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 99 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                    roomImageNumber++;
                                }
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n\r\n\r\n                    ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "form-group");
                __builder2.OpenElement(125, "button");
                __builder2.AddAttribute(126, "class", "btn btn-primary");
                __builder2.AddContent(127, 
#nullable restore
#line 108 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                         Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(128, " Room ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(130);
                __builder2.AddAttribute(131, "href", "hotel-room");
                __builder2.AddAttribute(132, "class", "btn btn-secondary");
                __builder2.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(134, "Back to Index");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "C:\Users\Owner\source\repos\Blazor_Complete_WASM_BhrugenPatel\HotelWASM\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
       

        [Parameter]
        public int? Id { get; set; }

        private HotelRoomDTO HotelRoomDto { get; set; } = new HotelRoomDTO();
        private string Title { get; set; } = "Create";

        private HotelRoomImageDTO RoomImage { get; set; } = new HotelRoomImageDTO();
        private List<string> DeletedImageNames { get; set; } = new List<string>();

        private bool IsImageUploadProcessStarted { get; set; } = false;

        public BlazoredTextEditor QuillHtml { get; set; } = new BlazoredTextEditor();


        protected async override Task OnInitializedAsync()
        {
            if (Id != null)
            {
                Title = "Update";
                HotelRoomDto = await _hotelRoomRepository.GetHotelRoom(Id.Value);

                if (HotelRoomDto?.HotelRoomImages != null)
                {
                    HotelRoomDto.ImagesUrls = HotelRoomDto.HotelRoomImages.Select(x => x.RoomImageUrl).ToList();
                }
            }
            else
            {
                Title = "Create";
                HotelRoomDto = new HotelRoomDTO();
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!firstRender)
            {
                return;
            }

            bool loading = true;
            while (loading)
            {
                try
                {
                    if (!string.IsNullOrEmpty(HotelRoomDto.Details))
                    {
                        await QuillHtml.LoadHTMLContent(HotelRoomDto.Details);
                    }

                    loading = false;
                }
                catch
                {
                    await Task.Delay(10);
                    loading = true;
                    await _jsRunTime.ToastrError("Possible issue with loading html text content - worry if you keep seeing this popup.");
                }
            }
        }

        private async Task HandleHotelRoomUpsert()
        {
            try
            {
                var roomDetailsByName = await _hotelRoomRepository.IsRoomUnique(HotelRoomDto.Name, HotelRoomDto.Id);

                if (roomDetailsByName != null)
                {
                    await _jsRunTime.ToastrError("Room name already exists.");
                    return;
                }

                HotelRoomDto.Details = await QuillHtml.GetHTML();
                if (HotelRoomDto.Id != 0 && Title == "Update")
                {
                    var updateResult = await _hotelRoomRepository.UpdateHotelRoom(HotelRoomDto, HotelRoomDto.Id);

                    if (HotelRoomDto.ImagesUrls != null && HotelRoomDto.ImagesUrls.Any() ||
                        DeletedImageNames != null && DeletedImageNames.Any())
                    {
                        if (DeletedImageNames != null && DeletedImageNames.Any())
                        {
                            foreach(var deletedImageName in DeletedImageNames)
                            {
                                var imageName = deletedImageName.Replace($"{_navigationManager.BaseUri}RoomImages/", "");
                                var result = _fileUpload.DeleteFile(imageName);
                                await _hotelImageRepository.DeleteHotelRoomImageByImageUrl(deletedImageName);
                            }
                        }

                        await AddHotelRoomImage(updateResult);
                    }

                    await _jsRunTime.ToastrSuccess("Hotel room updated successfully.");
                }
                else
                {
                    var createdResult = await _hotelRoomRepository.CreateHotelRoom(HotelRoomDto);
                    await AddHotelRoomImage(createdResult);
                    await _jsRunTime.ToastrSuccess("Hotel room created successfully.");
                }
            }
            catch(Exception ex)
            {
                // log exception
            }

            _navigationManager.NavigateTo("hotel-room");
        }

        private async Task HandleImageUpload(InputFileChangeEventArgs e)
        {
            IsImageUploadProcessStarted = true;

            try
            {
                var images = new List<string>();
                if (e.GetMultipleFiles().Count > 0)
                {
                    foreach(var file in e.GetMultipleFiles())
                    {
                        System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.Name);
                        if (fileInfo.Extension.ToLower() == ".jpg" ||
                            fileInfo.Extension.ToLower() == ".png" ||
                            fileInfo.Extension.ToLower() == ".jpeg")
                        {
                            var uploadedImagePath = await _fileUpload.UploadFile(file);
                            images.Add(uploadedImagePath);
                        }
                        else
                        {
                            await _jsRunTime.ToastrError("Please select .jpg/.jpeg/.png files only");
                            return;
                        }
                    };

                    if (images.Any())
                    {
                        if(HotelRoomDto.ImagesUrls != null && HotelRoomDto.ImagesUrls.Any())
                        {
                            HotelRoomDto.ImagesUrls.AddRange(images);
                        }
                        else
                        {
                            HotelRoomDto.ImagesUrls = new List<string>();
                            HotelRoomDto.ImagesUrls.AddRange(images);
                        }
                    }
                    else
                    {
                        await _jsRunTime.ToastrError("Image uploading failed.");
                        return;
                    }
                }
            }
            catch(Exception ex)
            {
                await _jsRunTime.ToastrError("Something happened while uploading images." + ex.Message);
                return;
            }
            finally
            {
                IsImageUploadProcessStarted = false;
            }
        }

        private async Task AddHotelRoomImage(HotelRoomDTO roomdetails)
        {
            if (HotelRoomDto.ImagesUrls != null)
            {
                foreach (var imageUrl in HotelRoomDto.ImagesUrls)
                {
                    if (HotelRoomDto.HotelRoomImages == null || HotelRoomDto.HotelRoomImages.Where(x => x.RoomImageUrl == imageUrl).Count() == 0)
                    {
                        RoomImage = new HotelRoomImageDTO()
                        {
                            RoomId = roomdetails.Id,
                            RoomImageUrl = imageUrl
                        };
                        await _hotelImageRepository.CreateHotelRoomImage(RoomImage);
                    }
                }
            }
        }

        internal async Task DeletePhoto(string imageUrl)
        {
            var showMessageText = string.Empty;
            try
            {
                var imageIndex = HotelRoomDto.ImagesUrls.FindIndex(x => x == imageUrl);
                var imageName = imageUrl.Replace($"{_navigationManager.BaseUri}RoomImages/", "");

            if (HotelRoomDto.Id == 0 && Title == "Create")
            {
                var result = _fileUpload.DeleteFile(imageName);
            }
            else
            {
                DeletedImageNames ??= new List<string>();
                DeletedImageNames.Add(imageUrl);
            }

            HotelRoomDto.ImagesUrls.RemoveAt(imageIndex);
        }
        catch (Exception ex)
        {
            await _jsRunTime.ToastrError(ex.Message);
    }
}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload _fileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRunTime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelImageRepository _hotelImageRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository _hotelRoomRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
namespace __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
