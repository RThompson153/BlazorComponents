A Blazor .wasm library of common components used in front end development.

# Why?
Since Blazor is so new, there aren't many of these common components available, yet.  Because of this, most dev shops are sticking with existing Javascript libraries, or resolving to build their own custom libraries.  I wanted to create a set of components that does the expected job and allows the end user to have complete control over the visual aspect of the component, and allow the user to have an abstract level of control over additional functionality.

# Current Version
* 1.1.1

# Change Log

# Completed
* Base Drag and drop functionality

# Description and code example
The drag and drop component is a simple drag and drop tool built in C#.  It works as advertized, you drag items onto a drop zone and the dropped items populate the drop zone.  There are two public facing components, the **DropZone** component and the **DropItem** component.  Each component contains parameters that can be passed in to allow the end user more control over how it looks and behaves.  The Drag and drop service is an interal class that basically works as a state container 

## DropZone component structure
| Parameter | Purpose | Requirement |
| --- | --- | --- |
| Class		| User defined css classes | Optional |
| Text		| User defined text to display in the dropzone | Optional |
| Items		| User defined parameter for items in the drop zone | Optional |
| DragOver	| User defined callback for the dragover event.  A DraggableItem can optionally be sent to the handler | Optional |
| DragLeave | User defined callback for the drag leave event | Optional |
| Drop		| User defined callback for the drop event | Optional |

## DropItem component structure
| Parameter   | Purpose | Requirement |
| --- | ---   | --- |
| Class		  | User defined css classes | Optional |
| Item		  | Item to be dragged | Required |
| IsDraggable | User defined parameter that sets the element to draggable.  Defaults to true | Optional |
| OnDragStart | User defined callback for the drag start event.  A DraggableItem can optionally be sent to the handler | Optional |

## Input component structure
| Parameter   | Purpose | Requirement |
| --- | ---   | --- |
| Label		  | Label for the input component | Optional |
| Type		  | Type of input component.  Defaults to text input | Optional |
| Name		  | Name of the input component. | Required |
| Value		  | Value of the input component | Required |
| MaxLength   | Maximum value length of the input component | Optional |
| Content	  | Content to add to the component. | Optional |
| Callback	  | User defined callback. | Optional |

# Install
Package Manager - ```Install-Package BlazorSharedComponents -Version 1.1.0```

.NET CLI - ```dotnet add package BlazorSharedComponents --version 1.1.0```

Package Reference - ```<PackageReference Include="BlazorSharedComponents" Version="1.1.0" />```

Direct Download - https://www.nuget.org/api/v2/package/BlazorSharedComponents/1.1.0

# To-do
* Nested Drag and drop
* Input
* Filterable table
