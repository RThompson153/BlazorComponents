using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedComponents
{
	public static class DragAndDropState
	{
		public static DraggableItem CurrentItem;

		public static void DragStart(DraggableItem item) => CurrentItem = item;
	}
}
