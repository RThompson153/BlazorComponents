public class DragAndDropItem
{
	public int Id { get; set; }
	public string Title { get; set; }
	public bool IsDraggable { get; set; } = true;
	public bool IsDragging { get; set; } = false;
}
