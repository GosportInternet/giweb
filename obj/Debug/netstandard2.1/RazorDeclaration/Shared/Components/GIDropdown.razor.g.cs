#pragma checksum "C:\Users\Work\Documents\GIWeb\Shared\Components\GIDropdown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa718e029e156da2eac248a67fc0cd9de62e0bb7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class GIDropdown : ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Work\Documents\GIWeb\Shared\Components\GIDropdown.razor"
      

    [Parameter]
    public EventCallback OnClickEvent { get; set; }
    [Parameter]
    public string Width { get; set; } = "100px";

    [Parameter]
    public string TopMargin { get; set; } = "3";

    [Parameter]
    public string SelectedValue { get; set; }

    [Parameter]
    public string LabelClass { get; set; }

    [Parameter]
    public bool ShowLabel { get; set; } = false;

    [Parameter]
    public string LabelText { get; set; } = "";

    [Parameter]
    public string Id { get; set; } = "";

    [Parameter]
    public List<SelectItem> ItemList { get; set; }

    public void OnChange(ChangeEventArgs e)
    {
        SelectedValue = e.Value.ToString();
    }

    public string GetSelectedValue()
    {
        return SelectedValue;
    }

    private void AddItems(List<SelectItem> items)
    {
        foreach (var item in items)
        {
            ItemList.Add(item);
        }
    }

    public void Clear()
    {
        SelectedValue = "";
    }

    public class SelectItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
