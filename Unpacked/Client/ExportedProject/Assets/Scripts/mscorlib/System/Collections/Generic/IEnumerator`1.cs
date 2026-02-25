namespace System.Collections.Generic;

[Token(Token = "0x20005DB")]
public interface IEnumerator : IDisposable, IEnumerator
{

	[Token(Token = "0x170006BE")]
	public T Current
	{
		[Token(Token = "0x6002B06")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002B06")]
	public T get_Current() { }

}

