#pragma checksum "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "362b49ef6d6a00c8696af1e42d5591f48f688221"
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
    public partial class GIInput : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
 if (Disabled)
{
    if (ShowLabel)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "        ");
            __builder.OpenElement(1, "label");
            __builder.AddAttribute(2, "class", 
#nullable restore
#line 5 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                       LabelClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                    LabelText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 6 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "id", 
#nullable restore
#line 7 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "type", 
#nullable restore
#line 7 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                           InputFieldType

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "class", "form-control" + " text-center" + " woocommerce-Input" + " woocommerce-Input--text" + " input-text" + " mt-" + (
#nullable restore
#line 7 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                    TopMargin

#line default
#line hidden
#nullable disable
            ) + " mb-" + (
#nullable restore
#line 7 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                  BottomMargin

#line default
#line hidden
#nullable disable
            ) + "  " + (
#nullable restore
#line 7 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                 CustomClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "style", "width:" + " " + (
#nullable restore
#line 7 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                             Width

#line default
#line hidden
#nullable disable
            ) + ";" + " " + (
#nullable restore
#line 7 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                     CustomStyle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "value", 
#nullable restore
#line 7 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                          Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "placeholder", 
#nullable restore
#line 7 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                               Placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                                                      OnValueChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 8 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
}
else
{
    if (ShowLabel)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "        ");
            __builder.OpenElement(17, "label");
            __builder.AddAttribute(18, "class", 
#nullable restore
#line 13 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                       LabelClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, 
#nullable restore
#line 13 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                    LabelText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 14 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "    ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "id", 
#nullable restore
#line 15 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "type", 
#nullable restore
#line 15 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                           InputFieldType

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "class", "form-control" + " text-center" + " woocommerce-Input" + " woocommerce-Input--text" + " input-text" + " mt-" + (
#nullable restore
#line 15 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                    TopMargin

#line default
#line hidden
#nullable disable
            ) + " mb-" + (
#nullable restore
#line 15 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                  BottomMargin

#line default
#line hidden
#nullable disable
            ) + "  " + (
#nullable restore
#line 15 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                 CustomClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "style", "width:" + " " + (
#nullable restore
#line 15 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                             Width

#line default
#line hidden
#nullable disable
            ) + ";" + " " + (
#nullable restore
#line 15 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                     CustomStyle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "value", 
#nullable restore
#line 15 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                          Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "placeholder", 
#nullable restore
#line 15 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                               Placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                                                      OnValueChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 16 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIInput.razor"
      
    [Parameter]
    public string LabelClass { get; set; } = "";

    [Parameter]
    public string InputFieldType { get; set; }

    [Parameter]
    public string CustomStyle { get; set; } = "";

    [Parameter]
    public string TopMargin { get; set; } = "3";

    [Parameter]
    public string BottomMargin { get; set; } = "3";

    [Parameter]
    public string Id { get; set; } = "";

    [Parameter]
    public bool Disabled { get; set; } = false;

    [Parameter]
    public string Placeholder { get; set; } = "";
    [Parameter]
    public Alignment Align { get; set; } = Alignment.Left;

    [Parameter]
    public string Width { get; set; }

    [Parameter]
    public string Value { get; set; } = "";

    [Parameter]
    public bool ShowLabel { get; set; } = false;
    [Parameter]
    public string LabelText { get; set; } = "";

    [Parameter]
    public string CustomClass { get; set; } = "";

    [Parameter]
    public EventCallback OnInputChanged { get; set; }


    public string GetValue()
    {
        return Value;
    }
    public void Clear()
    {
        Value = "";
    }
    private void OnValueChanged(ChangeEventArgs e)
    {
        if (!Disabled)
        {
            Value = e.Value.ToString();
            OnInputChanged.InvokeAsync(null);
        }
    }

    private string GetAlignnment()
    {
        switch (Align)
        {
            case Alignment.Left:
                return "float-left";
                break;
            case Alignment.Center:
                return "float-none";
                break;
            case Alignment.Right:
                return "float-right";
                break;

        }
        return "";
    }

    public enum Alignment
    {
        Center,
        Left,
        Right

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
