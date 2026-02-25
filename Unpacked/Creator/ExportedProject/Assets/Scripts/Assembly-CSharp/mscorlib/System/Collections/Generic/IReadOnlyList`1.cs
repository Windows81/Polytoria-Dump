namespace System.Collections.Generic;

[DefaultMember("Item")]
[Token(Token = "0x20005E0")]
public interface IReadOnlyList : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
{

	[Token(Token = "0x170006C3")]
	public T Item
	{
		[Token(Token = "0x6002B12")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002B12")]
	public T get_Item(int index) { }

}

