namespace UnityEngine.UIElements;

[Token(Token = "0x20001E4")]
public interface IMouseEvent
{

	[Token(Token = "0x17000269")]
	public int button
	{
		[Token(Token = "0x6000D95")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000268")]
	public int clickCount
	{
		[Token(Token = "0x6000D94")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000266")]
	public Vector2 localMousePosition
	{
		[Token(Token = "0x6000D92")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000264")]
	public EventModifiers modifiers
	{
		[Token(Token = "0x6000D90")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000267")]
	public Vector2 mouseDelta
	{
		[Token(Token = "0x6000D93")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000265")]
	public Vector2 mousePosition
	{
		[Token(Token = "0x6000D91")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700026A")]
	public int pressedButtons
	{
		[Token(Token = "0x6000D96")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000D95")]
	public int get_button() { }

	[Token(Token = "0x6000D94")]
	public int get_clickCount() { }

	[Token(Token = "0x6000D92")]
	public Vector2 get_localMousePosition() { }

	[Token(Token = "0x6000D90")]
	public EventModifiers get_modifiers() { }

	[Token(Token = "0x6000D93")]
	public Vector2 get_mouseDelta() { }

	[Token(Token = "0x6000D91")]
	public Vector2 get_mousePosition() { }

	[Token(Token = "0x6000D96")]
	public int get_pressedButtons() { }

}

