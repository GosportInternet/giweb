#pragma checksum "C:\Users\Work\Documents\GIWeb\Pages\Maxicom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaab01b2f908a9192f7bab8c3cbb2e22d20caa17"
// <auto-generated/>
#pragma warning disable 1591
namespace GIWeb.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/maxicom")]
    public partial class Maxicom : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"canvas\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8 offset-lg-2\">\r\n                <h5 class=\"special-heading text-center\">Choose</h5>\r\n                <h1 class=\"text-center\">Package</h1>\r\n                <p class=\"text-center big\">Get ready for more potential, more opportunity and more of everything you expect from internet provider</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"divider-45 d-none d-lg-block\"></div>\r\n        <div class=\"row c-gutter-60\">\r\n            <div class=\"col-lg-4 col-12\">\r\n                <div class=\"pricing-plan hero-bg rounded\">\r\n                    <div class=\"plan-name text-uppercase bg-maincolor\">\r\n                        <h3>\r\n                            Platinum\r\n                        </h3>\r\n                    </div>\r\n                    <div class=\"plan-desc\">\r\n                        <div class=\"plan-content\">\r\n                            <h4 class=\"color-main\">350</h4>\r\n                            <p class=\"small-text text-left\">\r\n                                <i class=\"color-main fa fa-angle-down\" aria-hidden=\"true\"></i>\r\n                                mb/s\r\n                            </p>\r\n                            <h4 class=\"color-main2\">250</h4>\r\n                            <p class=\"small-text text-left\">\r\n                                <i class=\"color-main2 fa fa-angle-up\" aria-hidden=\"true\"></i>\r\n                                mb/s\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"price-icon\">\r\n                            <img src=\"images/price-icon01.png\" alt>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"plan-features\">\r\n                        <ul class=\"list-bordered\">\r\n                            <li>VOIP Service</li>\r\n                            <li>Online IPTV HD</li>\r\n                            <li>Giga Port</li>\r\n                            <li>24/7 Support</li>\r\n                            <li>Free TV Set Installation</li>\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"price-wrap d-flex\">\r\n                        <span class=\"plan-sign small-text\">usd</span>\r\n                        <span class=\"plan-price color-main2\">99</span>\r\n                        <span class=\"plan-decimals small-text\">/mo</span>\r\n                    </div>\r\n                    <div class=\"plan-button\">\r\n                        <a href=\"#\" class=\"btn btn-maincolor\"><span>Purchase</span></a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"divider-45 d-block d-lg-none\"></div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-12\">\r\n                <div class=\"pricing-plan hero-bg rounded\">\r\n                    <div class=\"plan-name text-uppercase bg-maincolor2\">\r\n                        <h3>\r\n                            Advanced\r\n                        </h3>\r\n                    </div>\r\n                    <div class=\"plan-desc\">\r\n                        <div class=\"plan-content\">\r\n                            <h4 class=\"color-main3\">200</h4>\r\n                            <p class=\"small-text\">\r\n                                <i class=\"color-main3 fa fa-angle-down\" aria-hidden=\"true\"></i>\r\n                                mb/s\r\n                            </p>\r\n                            <h4 class=\"color-main4\">150</h4>\r\n                            <p class=\"small-text\">\r\n                                <i class=\"color-main4 fa fa-angle-up\" aria-hidden=\"true\"></i>\r\n                                mb/s\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"price-icon\">\r\n                            <img src=\"images/price-icon02.png\" alt>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"plan-features\">\r\n                        <ul class=\"list-bordered\">\r\n                            <li>VOIP Service</li>\r\n                            <li>Online IPTV</li>\r\n                            <li>Giga Port</li>\r\n                            <li>24/7 Support</li>\r\n                            <li>Free TV Set Installation</li>\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"price-wrap d-flex\">\r\n                        <span class=\"plan-sign small-text\">usd</span>\r\n                        <span class=\"plan-price color-main3\">79</span>\r\n                        <span class=\"plan-decimals small-text\">/mo</span>\r\n                    </div>\r\n                    <div class=\"plan-button\">\r\n                        <a href=\"#\" class=\"btn btn-maincolor2\"><span>Purchase</span></a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"divider-20 d-block d-md-none\"></div>\r\n            <div class=\"col-lg-4 col-12 margin-auto\">\r\n                <div class=\"pricing-plan hero-bg rounded\">\r\n                    <div class=\"plan-name text-uppercase bg-maincolor3\">\r\n                        <h3>\r\n                            Starter\r\n                        </h3>\r\n                    </div>\r\n                    <div class=\"plan-desc\">\r\n                        <div class=\"plan-content\">\r\n                            <h4 class=\"color-main5\">100</h4>\r\n                            <p class=\"small-text\">\r\n                                <i class=\"color-main5 fa fa-angle-down\" aria-hidden=\"true\"></i>\r\n                                mb/s\r\n                            </p>\r\n                            <h4 class=\"color-main6\">50</h4>\r\n                            <p class=\"small-text\">\r\n                                <i class=\"color-main6 fa fa-angle-up\" aria-hidden=\"true\"></i>\r\n                                mb/s\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"price-icon\">\r\n                            <img src=\"images/price-icon03.png\" alt>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"plan-features\">\r\n                        <ul class=\"list-bordered\">\r\n                            <li>VOIP Service</li>\r\n                            <li>Online IPTV</li>\r\n                            <li>Giga Port</li>\r\n                            <li>24/7 Support</li>\r\n                            <li>Free TV Set Installation</li>\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"price-wrap d-flex\">\r\n                        <span class=\"plan-sign small-text\">usd</span>\r\n                        <span class=\"plan-price color-main5\">49</span>\r\n                        <span class=\"plan-decimals small-text\">/mo</span>\r\n                    </div>\r\n                    <div class=\"plan-button\">\r\n                        <a href=\"#\" class=\"btn btn-maincolor3\"><span>Purchase</span></a>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div style=\"height:100px;\"></div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
