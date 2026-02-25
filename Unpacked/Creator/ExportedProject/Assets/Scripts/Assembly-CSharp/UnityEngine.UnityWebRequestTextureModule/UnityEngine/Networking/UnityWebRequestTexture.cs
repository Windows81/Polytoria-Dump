namespace UnityEngine.Networking;

[Token(Token = "0x2000006")]
public static class UnityWebRequestTexture
{

	[Address(RVA = "0x1CFFBF0", Offset = "0x1CFEDF0", Length = "0xA5")]
	[CalledBy(Type = "PurchasesService+<ShowPurchaseModal>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.ImageSky+<LoadSkyboxImage>d__35", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ImageCacheController+<LoadImage>d__12", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<LoadThumbnail>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<LoadLeaderboardThumbnail>d__121", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<LoadThumbnail>d__134", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadThumbnailImage>d__77", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadThumbnailImages>d__75", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DownloadHandlerTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[Token(Token = "0x600000F")]
	public static UnityWebRequest GetTexture(string uri) { }

	[Address(RVA = "0x1CFFA90", Offset = "0x1CFEC90", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DownloadHandlerTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000010")]
	public static UnityWebRequest GetTexture(string uri, bool nonReadable) { }

	[Address(RVA = "0x1CFFB40", Offset = "0x1CFED40", Length = "0xAC")]
	[CalledBy(Type = "GLTFast.Loading.DefaultDownloadProvider+<RequestTexture>d__1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.Loading.AwaitableTextureDownload", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.Loading.AwaitableTextureDownload", Member = "CreateRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = "GLTFast.Loading.AwaitableTextureDownload", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DownloadHandlerTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000011")]
	public static UnityWebRequest GetTexture(Uri uri, bool nonReadable) { }

}

