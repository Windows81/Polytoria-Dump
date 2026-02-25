namespace System.Collections.Generic;

[DefaultMember("Item")]
[Token(Token = "0x20005DD")]
public interface IList : ICollection<T>, IEnumerable<T>, IEnumerable
{

	[Token(Token = "0x170006BF")]
	public T Item
	{
		[Token(Token = "0x6002B09")]
		 get { } //Length: 0
		[Token(Token = "0x6002B0A")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6002B09")]
	public T get_Item(int index) { }

	[Token(Token = "0x6002B0B")]
	public int IndexOf(T item) { }

	[Token(Token = "0x6002B0C")]
	public void Insert(int index, T item) { }

	[Token(Token = "0x6002B0D")]
	public void RemoveAt(int index) { }

	[Token(Token = "0x6002B0A")]
	public void set_Item(int index, T value) { }

}

