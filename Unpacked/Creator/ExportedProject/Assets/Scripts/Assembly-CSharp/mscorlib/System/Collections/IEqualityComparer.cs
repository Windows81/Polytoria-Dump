namespace System.Collections;

[Token(Token = "0x2000598")]
public interface IEqualityComparer
{

	[Token(Token = "0x600288E")]
	public bool Equals(object x, object y) { }

	[Token(Token = "0x600288F")]
	public int GetHashCode(object obj) { }

}

