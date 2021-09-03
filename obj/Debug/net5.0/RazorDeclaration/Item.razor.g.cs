// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SharedComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Home\Desktop\Projects\SharedComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class Item : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Home\Desktop\Projects\SharedComponents\Item.razor"
       
	[Parameter]
	public DraggableItem DraggableItem { get; set; }
	[Parameter]
	public EventCallback<DraggableItem> OnDrag { get; set; }
	[Parameter]
	public EventCallback<DraggableItem> OnDrop { get; set; }

	private string _class;
	private ElementReference _dropZone;

	protected override void OnParametersSet()
	{
		base.OnParametersSet();
	}

	private void onDragStart()
	{
	}

	private void dragOver()
	{
		_class = "bg-warning";
	}

	private void dragLeave()
	{
		_class = "";
	}

	private void onDrop()
	{
		OnDrop.InvokeAsync(DraggableItem);
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
