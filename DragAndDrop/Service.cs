namespace SharedComponents
{
	internal static class Service
	{
		internal static DraggableItem CurrentItem;

		internal static void SetCurrentItem(DraggableItem item) => CurrentItem = item;
	}
}
