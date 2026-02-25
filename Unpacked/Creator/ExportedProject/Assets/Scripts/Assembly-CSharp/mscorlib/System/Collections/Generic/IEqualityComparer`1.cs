namespace System.Collections.Generic;

[Token(Token = "0x20005DC")]
public interface IEqualityComparer
{

	[Token(Token = "0x6002B07")]
	public bool Equals(T x, T y) { }

	[Token(Token = "0x6002B08")]
	public int GetHashCode(T obj) { }

}

