namespace System.Resources;

[Token(Token = "0x20004A5")]
public interface IResourceReader : IEnumerable, IDisposable
{

	[Token(Token = "0x60020DB")]
	public void Close() { }

	[Token(Token = "0x60020DC")]
	public IDictionaryEnumerator GetEnumerator() { }

}

