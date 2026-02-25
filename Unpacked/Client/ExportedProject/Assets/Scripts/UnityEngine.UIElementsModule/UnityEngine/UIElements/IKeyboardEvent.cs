namespace UnityEngine.UIElements;

[Token(Token = "0x20001DB")]
public interface IKeyboardEvent
{

	[Token(Token = "0x17000256")]
	public char character
	{
		[Token(Token = "0x6000D5F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000257")]
	public KeyCode keyCode
	{
		[Token(Token = "0x6000D60")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000255")]
	public EventModifiers modifiers
	{
		[Token(Token = "0x6000D5E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000D5F")]
	public char get_character() { }

	[Token(Token = "0x6000D60")]
	public KeyCode get_keyCode() { }

	[Token(Token = "0x6000D5E")]
	public EventModifiers get_modifiers() { }

}

