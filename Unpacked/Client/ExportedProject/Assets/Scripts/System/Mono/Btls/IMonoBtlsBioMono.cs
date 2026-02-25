namespace Mono.Btls;

[Token(Token = "0x200006F")]
internal interface IMonoBtlsBioMono
{

	[Token(Token = "0x60001A4")]
	public void Close() { }

	[Token(Token = "0x60001A3")]
	public void Flush() { }

	[Token(Token = "0x60001A1")]
	public int Read(Byte[] buffer, int offset, int size, out bool wantMore) { }

	[Token(Token = "0x60001A2")]
	public bool Write(Byte[] buffer, int offset, int size) { }

}

