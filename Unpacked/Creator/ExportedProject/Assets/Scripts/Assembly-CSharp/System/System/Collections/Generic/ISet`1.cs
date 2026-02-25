namespace System.Collections.Generic;

[Token(Token = "0x20001DB")]
public interface ISet : ICollection<T>, IEnumerable<T>, IEnumerable
{

	[Token(Token = "0x6000C04")]
	public bool Add(T item) { }

	[Token(Token = "0x6000C08")]
	public bool IsProperSubsetOf(IEnumerable<T> other) { }

	[Token(Token = "0x6000C07")]
	public bool IsProperSupersetOf(IEnumerable<T> other) { }

	[Token(Token = "0x6000C05")]
	public bool IsSubsetOf(IEnumerable<T> other) { }

	[Token(Token = "0x6000C06")]
	public bool IsSupersetOf(IEnumerable<T> other) { }

	[Token(Token = "0x6000C09")]
	public bool Overlaps(IEnumerable<T> other) { }

	[Token(Token = "0x6000C0A")]
	public bool SetEquals(IEnumerable<T> other) { }

}

