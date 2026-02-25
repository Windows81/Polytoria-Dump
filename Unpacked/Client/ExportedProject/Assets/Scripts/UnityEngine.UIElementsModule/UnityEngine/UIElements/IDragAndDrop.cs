namespace UnityEngine.UIElements;

[Token(Token = "0x2000187")]
internal interface IDragAndDrop
{

	[Token(Token = "0x17000208")]
	public DragAndDropData data
	{
		[Token(Token = "0x6000BA0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000B9D")]
	public void AcceptDrag() { }

	[Token(Token = "0x6000B9E")]
	public void DragCleanup() { }

	[Token(Token = "0x6000BA0")]
	public DragAndDropData get_data() { }

	[Token(Token = "0x6000B9F")]
	public void SetVisualMode(DragVisualMode visualMode) { }

	[Token(Token = "0x6000B9B")]
	public void StartDrag(StartDragArgs args, Vector3 pointerPosition) { }

	[Token(Token = "0x6000B9C")]
	public void UpdateDrag(Vector3 pointerPosition) { }

}

