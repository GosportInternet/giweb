#pragma checksum "C:\Users\Work\Documents\GIWeb\Pages\PasswordReset.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72950d27ebe4793ec94927532b98e6e67435bb84"
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
#nullable restore
#line 2 "C:\Users\Work\Documents\GIWeb\Pages\PasswordReset.razor"
using GIWeb.Shared.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/resetpassword")]
    public partial class PasswordReset : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridRow>(3);
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(6);
                __builder2.AddAttribute(7, "Width", "3");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(9);
                __builder2.AddAttribute(10, "CustomClass", "text-center");
                __builder2.AddAttribute(11, "Width", "6");
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIInput>(14);
                    __builder3.AddAttribute(15, "Placeholder", "Email address.");
                    __builder3.AddAttribute(16, "CustomClass", "mb-1");
                    __builder3.AddComponentReferenceCapture(17, (__value) => {
#nullable restore
#line 9 "C:\Users\Work\Documents\GIWeb\Pages\PasswordReset.razor"
                           Email = (GIWeb.Shared.Components.GIInput)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n            ");
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIButton>(19);
                    __builder3.AddAttribute(20, "ButtonText", "Reset");
                    __builder3.AddAttribute(21, "CustomClass", "mt-2 mb-2");
                    __builder3.AddAttribute(22, "Width", "150px;");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n            ");
                    __builder3.AddMarkupContent(24, "<div>\r\n                <a href=\"/login\" style=\"width:150px;\" class=\"woocommerce-Button btn btn-maincolor3 mt-2\" role=\"button\"><span>Back</span></a>\r\n            </div>\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(26);
                __builder2.AddAttribute(27, "Width", "3");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n<div style=\"height:100px;\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Work\Documents\GIWeb\Pages\PasswordReset.razor"
       

    GIInput Firstname, Surname, Email, ComfirmEmail, Password, ComfirmPassword;
    GiCheckbox TermsOfService;

    public void AttemptRegister()
    {
        Console.WriteLine("Attempting to signin with credienials: Email= " + Email.GetValue() + " - Password= " + Password.GetValue());
    }

    public void ButtonClick()
    {
        Console.WriteLine("DONG!!");
    }

    public void PrintOnChange(string text)
    {
        Console.WriteLine(text.ToString());
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
