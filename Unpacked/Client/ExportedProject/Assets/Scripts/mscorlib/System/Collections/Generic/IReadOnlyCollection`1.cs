namespace System.Collections.Generic;

[Token(Token = "0x20005DE")]
public interface IReadOnlyCollection : IEnumerable<T>, IEnumerable
{

	[Token(Token = "0x170006C0")]
	public int Count
	{
		[Token(Token = "0x6002B0E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002B0E")]
	public int get_Count() { }

}

