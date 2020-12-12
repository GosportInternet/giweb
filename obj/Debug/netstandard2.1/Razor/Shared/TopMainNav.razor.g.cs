#pragma checksum "C:\Users\Work\Documents\GIWeb\Shared\TopMainNav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ec1711e5364e7eea19ba7ce24424f3c7ad526b8"
// <auto-generated/>
#pragma warning disable 1591
namespace GIWeb.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using GIWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Work\Documents\GIWeb\_Imports.razor"
using GIWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Work\Documents\GIWeb\Shared\TopMainNav.razor"
using GIWeb.Shared.Components;

#line default
#line hidden
#nullable disable
    public partial class TopMainNav : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "header_wrapper");
            __builder.AddAttribute(2, "style", "height: 118px;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "header");
            __builder.AddAttribute(5, "class", "page_header header_logo_center ls header-layout2");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container-fluid");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row align-items-center");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(13);
            __builder.AddAttribute(14, "Width", "1");
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.AddMarkupContent(17, @"<ul class=""top-includes"">
                        <li>
                            <span class=""social-icons"">
                                <a href=""#"" class=""fa fa-facebook "" title=""facebook""></a>
                                <a href=""#"" class=""fa fa-twitter "" title=""twitter""></a>
                                <a href=""#"" class=""fa fa-google "" title=""google""></a>
                            </span>
                        </li>
                    </ul>
                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(19);
            __builder.AddAttribute(20, "Width", "3");
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n                    \r\n                    ");
                __builder2.AddMarkupContent(23, @"<nav class=""nav float-right"">
                        <ul class=""sf-menu"">
                            <li>
                                <a href=""/"">Home</a><span></span>
                            </li>
                            <li>
                                <a href=""/internet"">Internet</a><span></span>
                                <ul margin-top: 5px;"">

                                    <li>
                                        <a href=""/internet/packages"">Packages</a>
                                    </li>
                                    <li>
                                        <a href=""/internet/avaliability"">Avaliability</a>
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <a href=""/hosting"">Hosting</a><span class=""menu-item-mobile-toggler""></span>
                                <ul margin-top: 5px;"">
                                    <li>
                                        <a href=""/hosting/prices"">Prices</a>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                    </nav>
                    
                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(25);
            __builder.AddAttribute(26, "Width", "4");
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.AddMarkupContent(29, "<div class=\"logo_wrapper\">\r\n                        <a href=\"/\" class=\"logo\">\r\n                            <span class=\"logo-text py-20\"><strong>Gosport</strong>Internet</span>\r\n                        </a>\r\n                    </div>\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(31);
            __builder.AddAttribute(32, "Width", "3");
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.AddMarkupContent(35, @"<nav class=""nav"" style=""left: 300px;"">
                        <ul class=""sf-menu"">
                            <li class=""menu-item"">
                                <a href=""/aboutus"">About Us</a><span class=""menu-item""></span>
                                <ul margin-top: 5px;>
                                    <li>
                                        <a href=""/contactus"">Contact Us</a>
                                    </li>
                                    <li>
                                        <a href=""/ourteam"">Our Team</a>
                                    </li>
                                    <li>
                                        <a href=""/tos"">Terms Of Service</a>
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <a href=""/support"">Support</a><span class=""menu-item""></span>
                            </li>
                            <li>
                                <a href=""http://webdesign-finder.com/html/maxicom/"" target=""_blank"">Max</a><span></span>
                            </li>
                        </ul>
                    </nav>
                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(37);
            __builder.AddAttribute(38, "Width", "1");
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.AddMarkupContent(41, @"<ul class=""top-includes"">
                        <li>
                            <span class=""icon-inline"">
                                <span class=""icon-styled color-main2 mb-2 fs-14"">
                                    <i class=""fa fa-user""></i>
                                </span>
                                <span class=""small-text"">
                                    <a href=""/login"">Login in</a>
                                    <label>/</label>
                                    <a href=""/register"">sign up</a>
                                </span>
                            </span>
                        </li>
                    </ul>
                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
