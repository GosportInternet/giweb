#pragma checksum "C:\Users\Work\Documents\GIWeb\Shared\Components\GICarousel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f13b2d1116cdf63ee80ef13dda3ecd71e2cb004"
// <auto-generated/>
#pragma warning disable 1591
namespace GIWeb.Shared.Components
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
    public partial class GICarousel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", 
#nullable restore
#line 3 "C:\Users\Work\Documents\GIWeb\Shared\Components\GICarousel.razor"
          Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "class", "carousel slide");
            __builder.AddAttribute(3, "data-ride", "carousel");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "carousel-inner");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 5 "C:\Users\Work\Documents\GIWeb\Shared\Components\GICarousel.razor"
         foreach (var slide in Slides)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "carousel-item");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "class", "d-block w-100");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 8 "C:\Users\Work\Documents\GIWeb\Shared\Components\GICarousel.razor"
                                                 slide.Image_Source

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 10 "C:\Users\Work\Documents\GIWeb\Shared\Components\GICarousel.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Work\Documents\GIWeb\Shared\Components\GICarousel.razor"
 
    [Parameter]
    public List<Slide> Slides { get; set; }

    [Parameter]
    public string Id { get; set; }

    public class Slide
    {
        public string Image_Source { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
