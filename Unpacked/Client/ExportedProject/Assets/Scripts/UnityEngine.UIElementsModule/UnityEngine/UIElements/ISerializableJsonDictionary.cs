namespace UnityEngine.UIElements;

[Token(Token = "0x200028E")]
internal interface ISerializableJsonDictionary
{

	[Token(Token = "0x60011DB")]
	public bool ContainsKey(string key) { }

	[Token(Token = "0x60011D9")]
	public T Get(string key) { }

	[Token(Token = "0x60011DA")]
	public void Overwrite(object obj, string key) { }

	[Token(Token = "0x60011D8")]
	public void Set(string key, T value) { }

}

