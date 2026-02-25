namespace UnityEngine.UIElements;

[Token(Token = "0x2000407")]
public interface IStyleValue
{

	[Token(Token = "0x17000887")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001F02")]
		 get { } //Length: 0
		[Token(Token = "0x6001F03")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000886")]
	public T value
	{
		[Token(Token = "0x6001F00")]
		 get { } //Length: 0
		[Token(Token = "0x6001F01")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6001F02")]
	public StyleKeyword get_keyword() { }

	[Token(Token = "0x6001F00")]
	public T get_value() { }

	[Token(Token = "0x6001F03")]
	public void set_keyword(StyleKeyword value) { }

	[Token(Token = "0x6001F01")]
	public void set_value(T value) { }

}

