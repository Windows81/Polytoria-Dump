namespace System.Collections;

[Token(Token = "0x200059B")]
public interface IStructuralEquatable
{

	[Token(Token = "0x600289C")]
	public bool Equals(object other, IEqualityComparer comparer) { }

	[Token(Token = "0x600289D")]
	public int GetHashCode(IEqualityComparer comparer) { }

}

