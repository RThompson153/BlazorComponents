namespace SharedComponents
{
	internal static class Service
	{
		internal static DragAndDropItem CurrentItem;

		internal static void SetCurrentItem(DragAndDropItem item) => CurrentItem = item;
	}
}
