namespace GLTFast.Loading;

[Token(Token = "0x20000EB")]
public interface IDownload : IDisposable
{

	[Token(Token = "0x17000092")]
	public Byte[] Data
	{
		[Token(Token = "0x60002C3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000091")]
	public string Error
	{
		[Token(Token = "0x60002C2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000094")]
	public Nullable<Boolean> IsBinary
	{
		[Token(Token = "0x60002C5")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000090")]
	public bool Success
	{
		[Token(Token = "0x60002C1")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000093")]
	public string Text
	{
		[Token(Token = "0x60002C4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60002C3")]
	public Byte[] get_Data() { }

	[Token(Token = "0x60002C2")]
	public string get_Error() { }

	[Token(Token = "0x60002C5")]
	public Nullable<Boolean> get_IsBinary() { }

	[Token(Token = "0x60002C1")]
	public bool get_Success() { }

	[Token(Token = "0x60002C4")]
	public string get_Text() { }

}

