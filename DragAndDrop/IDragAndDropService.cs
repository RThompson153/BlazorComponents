using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedComponents.DragAndDrop
{
	public interface IDragAndDropService
	{
		public DragAndDropItem CurrentItem { get; set; }
	}
}
