namespace System.Collections.Generic;

[DefaultMember("Item")]
[Token(Token = "0x20005DF")]
public interface IReadOnlyDictionary : IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable
{

	[Token(Token = "0x170006C1")]
	public IEnumerable<TKey> Keys
	{
		[Token(Token = "0x6002B10")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170006C2")]
	public IEnumerable<TValue> Values
	{
		[Token(Token = "0x6002B11")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002B10")]
	public IEnumerable<TKey> get_Keys() { }

	[Token(Token = "0x6002B11")]
	public IEnumerable<TValue> get_Values() { }

	[Token(Token = "0x6002B0F")]
	public bool TryGetValue(TKey key, out TValue value) { }

}

