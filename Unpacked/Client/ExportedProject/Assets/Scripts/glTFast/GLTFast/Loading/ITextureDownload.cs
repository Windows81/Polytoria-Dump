namespace GLTFast.Loading;

[Token(Token = "0x20000EC")]
public interface ITextureDownload : IDownload, IDisposable
{

	[Token(Token = "0x17000095")]
	public Texture2D Texture
	{
		[Token(Token = "0x60002C6")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60002C6")]
	public Texture2D get_Texture() { }

}

