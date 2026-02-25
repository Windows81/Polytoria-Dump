namespace System.Collections;

[Obsolete("Please use IEqualityComparer instead.")]
[Token(Token = "0x20005BB")]
public interface IHashCodeProvider
{

	[Token(Token = "0x60029EB")]
	public int GetHashCode(object obj) { }

}

