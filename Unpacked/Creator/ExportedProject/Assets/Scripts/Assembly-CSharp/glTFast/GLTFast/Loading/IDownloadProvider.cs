namespace GLTFast.Loading;

[Token(Token = "0x20000EA")]
public interface IDownloadProvider
{

	[Token(Token = "0x60002BF")]
	public Task<IDownload> Request(Uri url) { }

	[Token(Token = "0x60002C0")]
	public Task<ITextureDownload> RequestTexture(Uri url, bool nonReadable) { }

}

