#pragma checksum "D:\SrikantSir\KT\Pages\Routes\EditRoute.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d22a53845127a5a6067f8a2596741ceb4895a597"
// <auto-generated/>
#pragma warning disable 1591
namespace blalogin.Pages.Routes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\SrikantSir\KT\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SrikantSir\KT\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SrikantSir\KT\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SrikantSir\KT\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SrikantSir\KT\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SrikantSir\KT\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SrikantSir\KT\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SrikantSir\KT\_Imports.razor"
using blalogin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SrikantSir\KT\_Imports.razor"
using blalogin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\SrikantSir\KT\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SrikantSir\KT\Pages\Routes\EditRoute.razor"
using blalogin.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Routes/EditRoute/{Id}")]
    public partial class EditRoute : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit Route</h2>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "form", "Name");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\SrikantSir\KT\Pages\Routes\EditRoute.razor"
                                                                obj.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Id = __value, obj.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.AddMarkupContent(22, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "form", "Name");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\SrikantSir\KT\Pages\Routes\EditRoute.razor"
                                                                obj.Routename

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Routename = __value, obj.Routename));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.AddMarkupContent(33, "<label for=\"Gender\" class=\"control-label\">Billdays</label>\r\n                ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "form", "Designation");
            __builder.AddAttribute(36, "class", "form-control");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\SrikantSir\KT\Pages\Routes\EditRoute.razor"
                                                                       obj.Billdays

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Billdays = __value, obj.Billdays));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.AddMarkupContent(44, "<label for=\"Designation\" class=\"control-label\">Designation</label>\r\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "form", "Designation");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "D:\SrikantSir\KT\Pages\Routes\EditRoute.razor"
                                                                       obj.Supervisorname

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Supervisorname = __value, obj.Supervisorname));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form-group");
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.AddMarkupContent(55, "<label for=\"City\" class=\"control-label\">City</label>\r\n                ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "form", "City");
            __builder.AddAttribute(58, "class", "form-control");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\SrikantSir\KT\Pages\Routes\EditRoute.razor"
                                                                obj.Code

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Code = __value, obj.Code));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "row");
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-md-4");
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "form-group");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "button");
            __builder.AddAttribute(76, "class", "btn btn-primary");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\SrikantSir\KT\Pages\Routes\EditRoute.razor"
                                                                        UpdateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "button");
            __builder.AddAttribute(82, "class", "btn btn-primary");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\SrikantSir\KT\Pages\Routes\EditRoute.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "D:\SrikantSir\KT\Pages\Routes\EditRoute.razor"
        [Parameter]
    public string Id { get; set; }
    Route obj = new Route();
    protected override async Task OnInitializedAsync()
    {
        obj = await Task.Run(() => routeService.GetRouteAsync(Convert.ToInt32(Id)));
    }
    protected async void UpdateEmployee()
    {
        await routeService.UpdateRouteAsync(obj);
        NavigationManager.NavigateTo("/Routes/Routes");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("/Routes/Routes");
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RouteService routeService { get; set; }
    }
}
#pragma warning restore 1591
