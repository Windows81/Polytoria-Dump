namespace System.Collections;

[Token(Token = "0x2000595")]
public interface IDictionaryEnumerator : IEnumerator
{

	[Token(Token = "0x17000623")]
	public DictionaryEntry Entry
	{
		[Token(Token = "0x6002889")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000621")]
	public object Key
	{
		[Token(Token = "0x6002887")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000622")]
	public object Value
	{
		[Token(Token = "0x6002888")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002889")]
	public DictionaryEntry get_Entry() { }

	[Token(Token = "0x6002887")]
	public object get_Key() { }

	[Token(Token = "0x6002888")]
	public object get_Value() { }

}

