namespace System.Collections;

[DefaultMember("Item")]
[Token(Token = "0x2000594")]
public interface IDictionary : ICollection, IEnumerable
{

	[Token(Token = "0x17000620")]
	public object Item
	{
		[Token(Token = "0x6002882")]
		 get { } //Length: 0
		[Token(Token = "0x6002883")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6002884")]
	public void Add(object key, object value) { }

	[Token(Token = "0x6002882")]
	public object get_Item(object key) { }

	[Token(Token = "0x6002885")]
	public IDictionaryEnumerator GetEnumerator() { }

	[Token(Token = "0x6002886")]
	public void Remove(object key) { }

	[Token(Token = "0x6002883")]
	public void set_Item(object key, object value) { }

}

