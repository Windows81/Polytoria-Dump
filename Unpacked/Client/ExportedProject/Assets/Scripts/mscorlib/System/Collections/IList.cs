namespace System.Collections;

[DefaultMember("Item")]
[Token(Token = "0x2000599")]
public interface IList : ICollection, IEnumerable
{

	[Token(Token = "0x17000627")]
	public bool IsFixedSize
	{
		[Token(Token = "0x6002896")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000626")]
	public bool IsReadOnly
	{
		[Token(Token = "0x6002895")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000625")]
	public object Item
	{
		[Token(Token = "0x6002890")]
		 get { } //Length: 0
		[Token(Token = "0x6002891")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6002892")]
	public int Add(object value) { }

	[Token(Token = "0x6002894")]
	public void Clear() { }

	[Token(Token = "0x6002893")]
	public bool Contains(object value) { }

	[Token(Token = "0x6002896")]
	public bool get_IsFixedSize() { }

	[Token(Token = "0x6002895")]
	public bool get_IsReadOnly() { }

	[Token(Token = "0x6002890")]
	public object get_Item(int index) { }

	[Token(Token = "0x6002897")]
	public int IndexOf(object value) { }

	[Token(Token = "0x6002898")]
	public void Insert(int index, object value) { }

	[Token(Token = "0x6002899")]
	public void Remove(object value) { }

	[Token(Token = "0x600289A")]
	public void RemoveAt(int index) { }

	[Token(Token = "0x6002891")]
	public void set_Item(int index, object value) { }

}

