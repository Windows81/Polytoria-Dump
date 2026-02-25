namespace System.Collections.Generic;

[Token(Token = "0x20005D3")]
public interface ICollection : IEnumerable<T>, IEnumerable
{

	[Token(Token = "0x170006B9")]
	public int Count
	{
		[Token(Token = "0x6002AF5")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170006BA")]
	public bool IsReadOnly
	{
		[Token(Token = "0x6002AF6")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002AF7")]
	public void Add(T item) { }

	[Token(Token = "0x6002AF8")]
	public void Clear() { }

	[Token(Token = "0x6002AF9")]
	public bool Contains(T item) { }

	[Token(Token = "0x6002AFA")]
	public void CopyTo(T[] array, int arrayIndex) { }

	[Token(Token = "0x6002AF5")]
	public int get_Count() { }

	[Token(Token = "0x6002AF6")]
	public bool get_IsReadOnly() { }

	[Token(Token = "0x6002AFB")]
	public bool Remove(T item) { }

}

