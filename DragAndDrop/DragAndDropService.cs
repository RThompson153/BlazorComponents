namespace SharedComponents.DragAndDrop
{
	public class DragAndDropService : IDragAndDropService
	{
		private DragAndDropItem _currentItem;
		public DragAndDropItem CurrentItem
		{
			get => _currentItem ??= null;
			set => _currentItem = value;
		}
	}
}
