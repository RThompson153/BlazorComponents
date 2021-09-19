A Blazor .wasm library of common components used in front end development.

# Why?
I started this project after building some in-house Blazor custom components for the company I was working for.  Since Blazor is so new, there aren't many of these components available, yet.  Because of this, most dev shops are sticking with existing Javascript libraries, understandable, or making their own components, like we did.  For the components that do exist, they're very niched, and often times, don't really fit the end user's needs.  I wanted to create a set of components that does the desired job, but allow the end user to have more control. 

# In Progress
* Drag and drop

# Completed
* Base Drag and drop functionality

# Description and code example
The drag and drop component is a simple drag and drop tool built in C#.  It works as advertized, you drag items onto a drop zone and the dropped items populate the drop zone.  There are two public facing components, the **DropZone** component and the **DropItem** component.  Each component contains parameters that can be passed in to allow the end user more control over how it looks and behaves.  The Drag and drop service is an interal class that basically works as a state container 

## DropZone component structure
| Parameter | Purpose | Requirement |
| --- | --- | --- |
| Class		| User defined css classes | Optional |
| Items		| User defined parameter for items in the drop zone | Optional |
| DragOver	| User defined callback for the dragover event.  A DraggableItem can optionally be sent to the handler | Optional |
| Drop		| User defined callback for the drop event | Optional |

## DropItem component structure
| Parameter   | Purpose | Requirement |
| --- | ---   | --- |
| Class		  | User defined css classes | Optional |
| Item		  | Item to be dragged | Required |
| IsDraggable | User defined parameter that sets the element to draggable.  Defaults to true | Optional |
| OnDragStart | User defined callback for the drag start event.  A DraggableItem can optionally be sent to the handler | Optional |

## Example and usage
**Application** *page.razor*
```
<div>
	@foreach(var item in items)
	{
		<DropItem Item="@item" />
	}
</div>
<div>
	<DropZone />
</div>

@code{
	IEnumerable<DraggableItem> items;

	protected override *LifecycleMethod()*
	{
		*Set list of items to be used.*
	}
}
```

# To-do
* Nested Drag and drop
* Drop down
* Searchable drop down
* Multi-select drop down
* Filterable table
