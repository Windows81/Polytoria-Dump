namespace System.Collections.Generic;

[DefaultMember("Item")]
[Token(Token = "0x20005D6")]
public interface IDictionary : ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable
{

	[Token(Token = "0x170006BB")]
	public TValue Item
	{
		[Token(Token = "0x6002AFD")]
		 get { } //Length: 0
		[Token(Token = "0x6002AFE")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170006BC")]
	public ICollection<TKey> Keys
	{
		[Token(Token = "0x6002AFF")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170006BD")]
	public ICollection<TValue> Values
	{
		[Token(Token = "0x6002B00")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002B02")]
	public void Add(TKey key, TValue value) { }

	[Token(Token = "0x6002B01")]
	public bool ContainsKey(TKey key) { }

	[Token(Token = "0x6002AFD")]
	public TValue get_Item(TKey key) { }

	[Token(Token = "0x6002AFF")]
	public ICollection<TKey> get_Keys() { }

	[Token(Token = "0x6002B00")]
	public ICollection<TValue> get_Values() { }

	[Token(Token = "0x6002B03")]
	public bool Remove(TKey key) { }

	[Token(Token = "0x6002AFE")]
	public void set_Item(TKey key, TValue value) { }

	[Token(Token = "0x6002B04")]
	public bool TryGetValue(TKey key, out TValue value) { }

}

