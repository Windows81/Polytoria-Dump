namespace System.Collections;

[Token(Token = "0x2000597")]
public interface IEnumerator
{

	[Token(Token = "0x17000624")]
	public object Current
	{
		[Token(Token = "0x600288C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600288C")]
	public object get_Current() { }

	[Token(Token = "0x600288B")]
	public bool MoveNext() { }

	[Token(Token = "0x600288D")]
	public void Reset() { }

}

