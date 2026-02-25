namespace UnityEngine.UIElements;

[Token(Token = "0x2000491")]
public interface ITextSelection
{

	[Token(Token = "0x17000944")]
	public int cursorIndex
	{
		[Token(Token = "0x60022BF")]
		 get { } //Length: 0
		[Token(Token = "0x60022C0")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700094A")]
	public Vector2 cursorPosition
	{
		[Token(Token = "0x60022CE")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700094C")]
	internal float cursorWidth
	{
		[Token(Token = "0x60022D0")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000945")]
	public bool doubleClickSelectsWord
	{
		[Token(Token = "0x60022C1")]
		 get { } //Length: 0
		[Token(Token = "0x60022C2")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000943")]
	public bool isSelectable
	{
		[Token(Token = "0x60022BD")]
		 get { } //Length: 0
		[Token(Token = "0x60022BE")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700094B")]
	internal float lineHeightAtCursorPosition
	{
		[Token(Token = "0x60022CF")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000948")]
	public bool selectAllOnFocus
	{
		[Token(Token = "0x60022CA")]
		 get { } //Length: 0
		[Token(Token = "0x60022CB")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000949")]
	public bool selectAllOnMouseUp
	{
		[Token(Token = "0x60022CC")]
		 get { } //Length: 0
		[Token(Token = "0x60022CD")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000946")]
	public int selectIndex
	{
		[Token(Token = "0x60022C3")]
		 get { } //Length: 0
		[Token(Token = "0x60022C4")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000947")]
	public bool tripleClickSelectsLine
	{
		[Token(Token = "0x60022C5")]
		 get { } //Length: 0
		[Token(Token = "0x60022C6")]
		 set { } //Length: 0
	}

	[Token(Token = "0x60022BF")]
	public int get_cursorIndex() { }

	[Token(Token = "0x60022CE")]
	public Vector2 get_cursorPosition() { }

	[Token(Token = "0x60022D0")]
	internal float get_cursorWidth() { }

	[Token(Token = "0x60022C1")]
	public bool get_doubleClickSelectsWord() { }

	[Token(Token = "0x60022BD")]
	public bool get_isSelectable() { }

	[Token(Token = "0x60022CF")]
	internal float get_lineHeightAtCursorPosition() { }

	[Token(Token = "0x60022CA")]
	public bool get_selectAllOnFocus() { }

	[Token(Token = "0x60022CC")]
	public bool get_selectAllOnMouseUp() { }

	[Token(Token = "0x60022C3")]
	public int get_selectIndex() { }

	[Token(Token = "0x60022C5")]
	public bool get_tripleClickSelectsLine() { }

	[Token(Token = "0x60022C7")]
	public bool HasSelection() { }

	[Token(Token = "0x60022C8")]
	public void SelectAll() { }

	[Token(Token = "0x60022C9")]
	public void SelectNone() { }

	[Token(Token = "0x60022C0")]
	public void set_cursorIndex(int value) { }

	[Token(Token = "0x60022C2")]
	public void set_doubleClickSelectsWord(bool value) { }

	[Token(Token = "0x60022BE")]
	public void set_isSelectable(bool value) { }

	[Token(Token = "0x60022CB")]
	public void set_selectAllOnFocus(bool value) { }

	[Token(Token = "0x60022CD")]
	public void set_selectAllOnMouseUp(bool value) { }

	[Token(Token = "0x60022C4")]
	public void set_selectIndex(int value) { }

	[Token(Token = "0x60022C6")]
	public void set_tripleClickSelectsLine(bool value) { }

}

