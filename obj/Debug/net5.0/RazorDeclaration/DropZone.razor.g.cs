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
    public partial class DropZone : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Home\Desktop\Projects\SharedComponents\DropZone.razor"
      
	[Parameter]
	public string Class { get; set; }
	[Parameter]
	public IEnumerable<DraggableItem> Items { get; set; }
	[Parameter]
	public EventCallback DragOver { get; set; }
	[Parameter]
	public EventCallback DragLeave { get; set; }
	[Parameter]
	public EventCallback Drop { get; set; }

	private ElementReference _dropZone;
	private IEnumerable<DraggableItem> _items;

	protected override void OnInitialized()
	{
		_items = Items;
	}

	private void dragOver()
	{
		DragOver.InvokeAsync();
	}

	private void dragLeave()
	{
		DragLeave.InvokeAsync();
	}

	private void drop()
	{
		Drop.InvokeAsync();
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
