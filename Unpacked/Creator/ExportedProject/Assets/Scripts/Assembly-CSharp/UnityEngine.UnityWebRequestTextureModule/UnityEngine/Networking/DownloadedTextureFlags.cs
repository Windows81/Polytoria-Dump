namespace UnityEngine.Networking;

[Flags]
[Token(Token = "0x2000002")]
public enum DownloadedTextureFlags
{
	None = 0,
	Readable = 1,
	MipmapChain = 2,
	LinearColorSpace = 4,
}

