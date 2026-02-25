namespace UnityEngine.UIElements;

[Token(Token = "0x2000189")]
internal interface IListDragAndDropArgs
{

	[Token(Token = "0x1700020D")]
	public int childIndex
	{
		[Token(Token = "0x6000BA7")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700020E")]
	public DragAndDropData dragAndDropData
	{
		[Token(Token = "0x6000BA8")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700020F")]
	public DragAndDropPosition dragAndDropPosition
	{
		[Token(Token = "0x6000BA9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700020B")]
	public int insertAtIndex
	{
		[Token(Token = "0x6000BA5")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700020C")]
	public int parentId
	{
		[Token(Token = "0x6000BA6")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000BA7")]
	public int get_childIndex() { }

	[Token(Token = "0x6000BA8")]
	public DragAndDropData get_dragAndDropData() { }

	[Token(Token = "0x6000BA9")]
	public DragAndDropPosition get_dragAndDropPosition() { }

	[Token(Token = "0x6000BA5")]
	public int get_insertAtIndex() { }

	[Token(Token = "0x6000BA6")]
	public int get_parentId() { }

}

