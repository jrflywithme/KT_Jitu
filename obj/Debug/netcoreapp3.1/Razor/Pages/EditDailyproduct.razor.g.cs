#pragma checksum "D:\Sri\Pages\EditDailyproduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2689c176da82d6e12bc98f0bd4e5c6e4dee0c8f8"
// <auto-generated/>
#pragma warning disable 1591
namespace blalogin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Sri\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sri\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Sri\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Sri\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Sri\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Sri\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Sri\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Sri\_Imports.razor"
using blalogin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Sri\_Imports.razor"
using blalogin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Sri\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sri\Pages\EditDailyproduct.razor"
using blalogin.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditDailyproduct/{Id}")]
    public partial class EditDailyproduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit Product</h2>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-sm-6");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-group");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.AddMarkupContent(15, "<label for=\"MilklType\" class=\"control-label\">Shift</label>\r\n                    ");
            __builder.OpenElement(16, "select");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\Sri\Pages\EditDailyproduct.razor"
                                    obj.Shift

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Shift = __value, obj.Shift));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", true);
            __builder.AddContent(23, "Select Shift");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", "Morning");
            __builder.AddContent(27, "Morning");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", "Evening");
            __builder.AddContent(31, "Evening");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n                ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-group");
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.AddMarkupContent(38, "<label for=\"Name\" class=\"control-label\">Date</label>\r\n                    ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "date");
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.Date

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Date = __value, obj.Date, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n\r\n                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "form-group");
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.AddMarkupContent(49, "<label for=\"Name\" class=\"control-label\">SM NO</label>\r\n                    ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "form", "Name");
            __builder.AddAttribute(52, "class", "form-control");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.SmNo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.SmNo = __value, obj.SmNo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "form-group");
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.AddMarkupContent(60, "<label for=\"Name\" class=\"control-label\">Code</label>\r\n                    ");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "form", "Name");
            __builder.AddAttribute(63, "class", "form-control");
            __builder.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.Code

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Code = __value, obj.Code));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "form-group");
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.AddMarkupContent(71, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                    ");
            __builder.OpenElement(72, "input");
            __builder.AddAttribute(73, "form", "Name");
            __builder.AddAttribute(74, "class", "form-control");
            __builder.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.AgentName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.AgentName = __value, obj.AgentName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n                ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "form-group");
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.AddMarkupContent(82, "<label for=\"MilklType\" class=\"control-label\">BM/CM</label>\r\n                    ");
            __builder.OpenElement(83, "select");
            __builder.AddAttribute(84, "class", "form-control");
            __builder.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "D:\Sri\Pages\EditDailyproduct.razor"
                                    obj.BMCM

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.BMCM = __value, obj.BMCM));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(87, "\r\n                        ");
            __builder.OpenElement(88, "option");
            __builder.AddAttribute(89, "value", true);
            __builder.AddContent(90, "-Select MilklType");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                        ");
            __builder.OpenElement(92, "option");
            __builder.AddAttribute(93, "value", "Buffalo");
            __builder.AddContent(94, "Buffalo Milk");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                        ");
            __builder.OpenElement(96, "option");
            __builder.AddAttribute(97, "value", "Cow");
            __builder.AddContent(98, "Cow Milk");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "form-group");
            __builder.AddMarkupContent(104, "\r\n                    ");
            __builder.AddMarkupContent(105, "<label for=\"Name\" class=\"control-label\">Cans</label>\r\n                    ");
            __builder.OpenElement(106, "input");
            __builder.AddAttribute(107, "form", "Name");
            __builder.AddAttribute(108, "class", "form-control");
            __builder.AddAttribute(109, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.Cans

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Cans = __value, obj.Cans));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "form-group");
            __builder.AddMarkupContent(115, "\r\n                    ");
            __builder.AddMarkupContent(116, "<label for=\"Name\" class=\"control-label\">Kgs</label>\r\n                    ");
            __builder.OpenElement(117, "input");
            __builder.AddAttribute(118, "form", "Name");
            __builder.AddAttribute(119, "class", "form-control");
            __builder.AddAttribute(120, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.Kgs

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Kgs = __value, obj.Kgs));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "form-group");
            __builder.AddMarkupContent(126, "\r\n                    ");
            __builder.AddMarkupContent(127, "<label for=\"Name\" class=\"control-label\">Ltrs</label>\r\n                    ");
            __builder.OpenElement(128, "input");
            __builder.AddAttribute(129, "form", "Name");
            __builder.AddAttribute(130, "class", "form-control");
            __builder.AddAttribute(131, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.Ltrs

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(132, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Ltrs = __value, obj.Ltrs));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "form-group");
            __builder.AddMarkupContent(137, "\r\n                    ");
            __builder.AddMarkupContent(138, "<label for=\"Name\" class=\"control-label\">Fat</label>\r\n                    ");
            __builder.OpenElement(139, "input");
            __builder.AddAttribute(140, "form", "Name");
            __builder.AddAttribute(141, "class", "form-control");
            __builder.AddAttribute(142, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.Fat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(143, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Fat = __value, obj.Fat));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n            ");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "col-sm-6");
            __builder.AddMarkupContent(149, "\r\n                ");
            __builder.OpenElement(150, "div");
            __builder.AddAttribute(151, "class", "form-group");
            __builder.AddMarkupContent(152, "\r\n                    ");
            __builder.AddMarkupContent(153, "<label for=\"Name\" class=\"control-label\">CLR</label>\r\n                    ");
            __builder.OpenElement(154, "input");
            __builder.AddAttribute(155, "form", "Name");
            __builder.AddAttribute(156, "class", "form-control");
            __builder.AddAttribute(157, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.CLR

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(158, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.CLR = __value, obj.CLR));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n\r\n                ");
            __builder.OpenElement(161, "div");
            __builder.AddAttribute(162, "class", "form-group");
            __builder.AddMarkupContent(163, "\r\n                    ");
            __builder.AddMarkupContent(164, "<label for=\"Name\" class=\"control-label\">SNF</label>\r\n                    ");
            __builder.OpenElement(165, "input");
            __builder.AddAttribute(166, "form", "Name");
            __builder.AddAttribute(167, "class", "form-control");
            __builder.AddAttribute(168, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.SNF

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(169, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.SNF = __value, obj.SNF));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n\r\n                ");
            __builder.OpenElement(172, "div");
            __builder.AddAttribute(173, "class", "form-group");
            __builder.AddMarkupContent(174, "\r\n                    ");
            __builder.AddMarkupContent(175, "<label for=\"Name\" class=\"control-label\">FatKg</label>\r\n                    ");
            __builder.OpenElement(176, "input");
            __builder.AddAttribute(177, "form", "Name");
            __builder.AddAttribute(178, "class", "form-control");
            __builder.AddAttribute(179, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 80 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.FatKg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(180, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.FatKg = __value, obj.FatKg));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n                ");
            __builder.OpenElement(183, "div");
            __builder.AddAttribute(184, "class", "form-group");
            __builder.AddMarkupContent(185, "\r\n                    ");
            __builder.AddMarkupContent(186, "<label for=\"Name\" class=\"control-label\">SnfKg</label>\r\n                    ");
            __builder.OpenElement(187, "input");
            __builder.AddAttribute(188, "form", "Name");
            __builder.AddAttribute(189, "class", "form-control");
            __builder.AddAttribute(190, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 84 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.SnfKg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(191, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.SnfKg = __value, obj.SnfKg));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n                ");
            __builder.OpenElement(194, "div");
            __builder.AddAttribute(195, "class", "form-group");
            __builder.AddMarkupContent(196, "\r\n                    ");
            __builder.AddMarkupContent(197, "<label for=\"Name\" class=\"control-label\">Weighment</label>\r\n                    ");
            __builder.OpenElement(198, "input");
            __builder.AddAttribute(199, "form", "Name");
            __builder.AddAttribute(200, "class", "form-control");
            __builder.AddAttribute(201, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 88 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.Weighment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(202, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Weighment = __value, obj.Weighment));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(203, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(204, "\r\n                ");
            __builder.OpenElement(205, "div");
            __builder.AddAttribute(206, "class", "form-group");
            __builder.AddMarkupContent(207, "\r\n                    ");
            __builder.AddMarkupContent(208, "<label for=\"Name\" class=\"control-label\">Qc Entry</label>\r\n                    ");
            __builder.OpenElement(209, "input");
            __builder.AddAttribute(210, "form", "Name");
            __builder.AddAttribute(211, "class", "form-control");
            __builder.AddAttribute(212, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 92 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.QcEntry

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(213, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.QcEntry = __value, obj.QcEntry));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(214, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(215, "\r\n                ");
            __builder.OpenElement(216, "div");
            __builder.AddAttribute(217, "class", "form-group");
            __builder.AddMarkupContent(218, "\r\n                    ");
            __builder.AddMarkupContent(219, "<label for=\"Name\" class=\"control-label\">Qty(Org)</label>\r\n                    ");
            __builder.OpenElement(220, "input");
            __builder.AddAttribute(221, "form", "Name");
            __builder.AddAttribute(222, "class", "form-control");
            __builder.AddAttribute(223, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 96 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.QtyOrg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(224, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.QtyOrg = __value, obj.QtyOrg));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(225, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(226, "\r\n                ");
            __builder.OpenElement(227, "div");
            __builder.AddAttribute(228, "class", "form-group");
            __builder.AddMarkupContent(229, "\r\n                    ");
            __builder.AddMarkupContent(230, "<label for=\"Name\" class=\"control-label\">Fat(Org)</label>\r\n                    ");
            __builder.OpenElement(231, "input");
            __builder.AddAttribute(232, "form", "Name");
            __builder.AddAttribute(233, "class", "form-control");
            __builder.AddAttribute(234, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 100 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.FatOrg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(235, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.FatOrg = __value, obj.FatOrg));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(236, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(237, "\r\n                ");
            __builder.OpenElement(238, "div");
            __builder.AddAttribute(239, "class", "form-group");
            __builder.AddMarkupContent(240, "\r\n                    ");
            __builder.AddMarkupContent(241, "<label for=\"Name\" class=\"control-label\">Snf(Org)</label>\r\n                    ");
            __builder.OpenElement(242, "input");
            __builder.AddAttribute(243, "form", "Name");
            __builder.AddAttribute(244, "class", "form-control");
            __builder.AddAttribute(245, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 104 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                    obj.SnfOrg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(246, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.SnfOrg = __value, obj.SnfOrg));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(247, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(248, "\r\n\r\n                ");
            __builder.OpenElement(249, "div");
            __builder.AddAttribute(250, "class", "form-group");
            __builder.AddAttribute(251, "style", "margin-top:47px");
            __builder.AddMarkupContent(252, "\r\n                    ");
            __builder.OpenElement(253, "input");
            __builder.AddAttribute(254, "type", "button");
            __builder.AddAttribute(255, "class", "btn btn-primary");
            __builder.AddAttribute(256, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                            UpateProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(257, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(258, "\r\n                    ");
            __builder.OpenElement(259, "input");
            __builder.AddAttribute(260, "type", "button");
            __builder.AddAttribute(261, "class", "btn btn-primary");
            __builder.AddAttribute(262, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "D:\Sri\Pages\EditDailyproduct.razor"
                                                                            Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(263, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(264, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(265, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(266, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(267, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(268, "\r\n\r\n\r\n\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "D:\Sri\Pages\EditDailyproduct.razor"
        [Parameter]
    public string Id { get; set; }
    Dailyproduct obj = new Dailyproduct();
    protected override async Task OnInitializedAsync()
    {
        obj = await Task.Run(() => dailyproductService.GetdailyproductAsync(Convert.ToInt32(Id)));
    }
    protected async void UpateProduct()
    {
        await dailyproductService.UpdateDailyproduct(obj);
        NavigationManager.NavigateTo("Product");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Product");
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DailyproductService dailyproductService { get; set; }
    }
}
#pragma warning restore 1591
