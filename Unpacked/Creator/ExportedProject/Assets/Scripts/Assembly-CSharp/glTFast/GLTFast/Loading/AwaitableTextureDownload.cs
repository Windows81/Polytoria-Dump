namespace GLTFast.Loading;

[Token(Token = "0x20000E9")]
public class AwaitableTextureDownload : AwaitableDownload, ITextureDownload, IDownload, IDisposable
{

	[Token(Token = "0x1700008F")]
	public override Texture2D Texture
	{
		[Address(RVA = "0x1088330", Offset = "0x1087530", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60002BE")]
		 get { } //Length: 99
	}

	[Address(RVA = "0x10882B0", Offset = "0x10874B0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityWebRequestTexture), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002BB")]
	public AwaitableTextureDownload(Uri url, bool nonReadable) { }

	[Address(RVA = "0x1088240", Offset = "0x1087440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityWebRequestTexture), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(UnityWebRequest))]
	[Token(Token = "0x60002BC")]
	protected static UnityWebRequest CreateRequest(Uri url, bool nonReadable) { }

	[Address(RVA = "0x1088330", Offset = "0x1087530", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002BE")]
	public override Texture2D get_Texture() { }

	[Address(RVA = "0x1088250", Offset = "0x1087450", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityWebRequestTexture), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002BD")]
	private void Init(Uri url, bool nonReadable) { }

}

