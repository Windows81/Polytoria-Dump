namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
[Token(Token = "0x200000C")]
public class UnityWebRequest : IDisposable
{
	[Token(Token = "0x2000010")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600008C")]
		public static IntPtr ConvertToNative(UnityWebRequest unityWebRequest) { }

	}

	[Token(Token = "0x200000F")]
	internal enum Result
	{
		InProgress = 0,
		Success = 1,
		ConnectionError = 2,
		ProtocolError = 3,
		DataProcessingError = 4,
	}

	[Token(Token = "0x200000E")]
	public enum UnityWebRequestError
	{
		OK = 0,
		OKCached = 1,
		Unknown = 2,
		SDKError = 3,
		UnsupportedProtocol = 4,
		MalformattedUrl = 5,
		CannotResolveProxy = 6,
		CannotResolveHost = 7,
		CannotConnectToHost = 8,
		AccessDenied = 9,
		GenericHttpError = 10,
		WriteError = 11,
		ReadError = 12,
		OutOfMemory = 13,
		Timeout = 14,
		HTTPPostError = 15,
		SSLCannotConnect = 16,
		Aborted = 17,
		TooManyRedirects = 18,
		ReceivedNoData = 19,
		SSLNotSupported = 20,
		FailedToSendData = 21,
		FailedToReceiveData = 22,
		SSLCertificateError = 23,
		SSLCipherNotAvailable = 24,
		SSLCACertError = 25,
		UnrecognizedContentEncoding = 26,
		LoginFailed = 27,
		SSLShutdownFailed = 28,
		RedirectLimitInvalid = 29,
		InvalidRedirect = 30,
		CannotModifyRequest = 31,
		HeaderNameContainsInvalidCharacters = 32,
		HeaderValueContainsInvalidCharacters = 33,
		CannotOverrideSystemHeaders = 34,
		AlreadySent = 35,
		InvalidMethod = 36,
		NotImplemented = 37,
		NoInternetConnection = 38,
		DataProcessingError = 39,
		InsecureConnectionNotAllowed = 40,
	}

	[Token(Token = "0x200000D")]
	public enum UnityWebRequestMethod
	{
		Get = 0,
		Post = 1,
		Put = 2,
		Head = 3,
		Custom = 4,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001D")]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001E")]
	internal DownloadHandler m_DownloadHandler; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001F")]
	internal UploadHandler m_UploadHandler; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000020")]
	internal CertificateHandler m_CertificateHandler; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000021")]
	internal Uri m_Uri; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000022")]
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000023")]
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4000024")]
	private bool <disposeUploadHandlerOnDispose>k__BackingField; //Field offset: 0x3A

	[Token(Token = "0x17000014")]
	public CertificateHandler certificateHandler
	{
		[Address(RVA = "0x1979DB0", Offset = "0x1978FB0", Length = "0x7")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000073")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000007")]
	public bool disposeCertificateHandlerOnDispose
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000047")]
		 get { } //Length: 5
		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000048")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000008")]
	public bool disposeDownloadHandlerOnDispose
	{
		[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000049")]
		 get { } //Length: 5
		[Address(RVA = "0x53B980", Offset = "0x53AB80", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600004A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000009")]
	public bool disposeUploadHandlerOnDispose
	{
		[Address(RVA = "0x53B950", Offset = "0x53AB50", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600004B")]
		 get { } //Length: 5
		[Address(RVA = "0x53B990", Offset = "0x53AB90", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600004C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000013")]
	public DownloadHandler downloadHandler
	{
		[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
		[CallerCount(Count = 73)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000071")]
		 get { } //Length: 7
		[Address(RVA = "0x1CFB290", Offset = "0x1CFA490", Length = "0x168")]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(WWWForm)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.HttpService+<DoRequest>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000072")]
		 set { } //Length: 360
	}

	[Token(Token = "0x1700000B")]
	public string error
	{
		[Address(RVA = "0x1CFAEB0", Offset = "0x1CFA0B0", Length = "0x197")]
		[CallerCount(Count = 32)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(UnityWebRequest), Member = "GetHTTPStatusString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6000061")]
		 get { } //Length: 407
	}

	[Token(Token = "0x17000010")]
	public bool isDone
	{
		[Address(RVA = "0x1CFB050", Offset = "0x1CFA250", Length = "0x56")]
		[CalledBy(Type = "GLTFast.Loading.AwaitableDownload", Member = "get_Success", ReturnType = typeof(bool))]
		[CalledBy(Type = "GLTFast.Loading.AwaitableDownload", Member = "get_IsBinary", ReturnType = "System.Nullable`1<Boolean>")]
		[CalledBy(Type = typeof(DownloadHandler), Member = "GetCheckedDownloader", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "T")]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000068")]
		 get { } //Length: 86
	}

	[Token(Token = "0x1700000F")]
	public bool isModifiable
	{
		[Address(RVA = "0x1CFB0F0", Offset = "0x1CFA2F0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("IsModifiable")]
		[Token(Token = "0x6000067")]
		 get { } //Length: 81
	}

	[Token(Token = "0x1700000A")]
	public string method
	{
		[Address(RVA = "0x1CFB400", Offset = "0x1CFA600", Length = "0x253")]
		[CalledBy(Type = "Polytoria.Datamodel.Services.HttpService+<DoRequest>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestMethod)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetCustomMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequestError))]
		[Calls(Type = typeof(string), Member = "ToUpper", ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600005F")]
		 set { } //Length: 595
	}

	[Token(Token = "0x1700000E")]
	public long responseCode
	{
		[Address(RVA = "0x1CFB190", Offset = "0x1CFA390", Length = "0x51")]
		[CalledBy(Type = "Edgegap.LobbyApi+<>c__DisplayClass18_0", Member = "<GetLobbyService>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "CheckErrorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), "System.Action`1<String>"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000066")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000011")]
	public Result result
	{
		[Address(RVA = "0x1CFB230", Offset = "0x1CFA430", Length = "0x51")]
		[CallerCount(Count = 45)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("GetResult")]
		[Token(Token = "0x6000069")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000012")]
	public UploadHandler uploadHandler
	{
		[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
		[CallerCount(Count = 69)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006E")]
		 get { } //Length: 7
		[Address(RVA = "0x1CFB660", Offset = "0x1CFA860", Length = "0x168")]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(WWWForm)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Edgegap.LobbyApi", Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.HttpService+<DoRequest>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600006F")]
		 set { } //Length: 360
	}

	[Token(Token = "0x1700000D")]
	public Uri uri
	{
		[Address(RVA = "0x1CFB7D0", Offset = "0x1CFA9D0", Length = "0xF2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(WebRequestUtils), Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000063")]
		 set { } //Length: 242
	}

	[Token(Token = "0x1700000C")]
	public string url
	{
		[Address(RVA = "0x1CFB8D0", Offset = "0x1CFAAD0", Length = "0x84")]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(WebRequestUtils), Member = "MakeInitialUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000062")]
		 set { } //Length: 132
	}

	[Address(RVA = "0x1CFAC50", Offset = "0x1CF9E50", Length = "0x178")]
	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequestTexture", Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebRequestUtils), Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000054")]
	public UnityWebRequest(Uri uri, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	[Address(RVA = "0x1CFABA0", Offset = "0x1CF9DA0", Length = "0xA4")]
	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequestMultimedia", Member = "GetAudioClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AudioType)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequestTexture", Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequestTexture", Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_url", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000053")]
	public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	[Address(RVA = "0x1CFAE30", Offset = "0x1CFA030", Length = "0x79")]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WWWForm)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_url", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000052")]
	public UnityWebRequest(string url, string method) { }

	[Address(RVA = "0x1CFADD0", Offset = "0x1CF9FD0", Length = "0x5E")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.HttpService+<DoRequest>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_url", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000051")]
	public UnityWebRequest(string url) { }

	[Address(RVA = "0x1CF8660", Offset = "0x1CF7860", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600005A")]
	public void Abort() { }

	[Address(RVA = "0x1CF8620", Offset = "0x1CF7820", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000080")]
	private static void Abort_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CF8700", Offset = "0x1CF7900", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AsyncOperation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000058")]
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	[Address(RVA = "0x1CF86C0", Offset = "0x1CF78C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007F")]
	private static IntPtr BeginWebRequest_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CF87B0", Offset = "0x1CF79B0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x600004D")]
	internal static IntPtr Create() { }

	[Address(RVA = "0x1CF8890", Offset = "0x1CF7A90", Length = "0x5D")]
	[CalledBy(Type = "GLTFast.Loading.AwaitableDownload", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityWebRequest), Member = "DisposeHandlers", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalDestroy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000056")]
	public override void Dispose() { }

	[Address(RVA = "0x1CF87E0", Offset = "0x1CF79E0", Length = "0xA3")]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000057")]
	private void DisposeHandlers() { }

	[Address(RVA = "0x1CF8A40", Offset = "0x1CF7C40", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WWWTranscoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(Byte[]), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600007B")]
	public static string EscapeURL(string s, Encoding e) { }

	[Address(RVA = "0x1CF88F0", Offset = "0x1CF7AF0", Length = "0x14E")]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<DoReloadToolbox>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WWWTranscoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(Byte[]), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600007A")]
	public static string EscapeURL(string s) { }

	[Address(RVA = "0x1CF8B90", Offset = "0x1CF7D90", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityWebRequest), Member = "DisposeHandlers", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalDestroy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000055")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1CF9100", Offset = "0x1CF8300", Length = "0x12A")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_url", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000074")]
	public static UnityWebRequest Get(string uri) { }

	[Address(RVA = "0x1CF9230", Offset = "0x1CF8430", Length = "0x1FE")]
	[CalledBy(Type = "GLTFast.Loading.DefaultDownloadProvider+<Request>d__0", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.Loading.AwaitableDownload", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.Loading.AwaitableDownload", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(WebRequestUtils), Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000075")]
	public static UnityWebRequest Get(Uri uri) { }

	[Address(RVA = "0x1979DB0", Offset = "0x1978FB0", Length = "0x7")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000073")]
	public CertificateHandler get_certificateHandler() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000047")]
	public bool get_disposeCertificateHandlerOnDispose() { }

	[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000049")]
	public bool get_disposeDownloadHandlerOnDispose() { }

	[Address(RVA = "0x53B950", Offset = "0x53AB50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600004B")]
	public bool get_disposeUploadHandlerOnDispose() { }

	[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
	[CallerCount(Count = 73)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000071")]
	public DownloadHandler get_downloadHandler() { }

	[Address(RVA = "0x1CFAEB0", Offset = "0x1CFA0B0", Length = "0x197")]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetHTTPStatusString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000061")]
	public string get_error() { }

	[Address(RVA = "0x1CFB050", Offset = "0x1CFA250", Length = "0x56")]
	[CalledBy(Type = "GLTFast.Loading.AwaitableDownload", Member = "get_Success", ReturnType = typeof(bool))]
	[CalledBy(Type = "GLTFast.Loading.AwaitableDownload", Member = "get_IsBinary", ReturnType = "System.Nullable`1<Boolean>")]
	[CalledBy(Type = typeof(DownloadHandler), Member = "GetCheckedDownloader", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "T")]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000068")]
	public bool get_isDone() { }

	[Address(RVA = "0x1CFB0F0", Offset = "0x1CFA2F0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("IsModifiable")]
	[Token(Token = "0x6000067")]
	public bool get_isModifiable() { }

	[Address(RVA = "0x1CFB0B0", Offset = "0x1CFA2B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000086")]
	private static bool get_isModifiable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CFB190", Offset = "0x1CFA390", Length = "0x51")]
	[CalledBy(Type = "Edgegap.LobbyApi+<>c__DisplayClass18_0", Member = "<GetLobbyService>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "CheckErrorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), "System.Action`1<String>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000066")]
	public long get_responseCode() { }

	[Address(RVA = "0x1CFB150", Offset = "0x1CFA350", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000085")]
	private static long get_responseCode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CFB230", Offset = "0x1CFA430", Length = "0x51")]
	[CallerCount(Count = 45)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("GetResult")]
	[Token(Token = "0x6000069")]
	public Result get_result() { }

	[Address(RVA = "0x1CFB1F0", Offset = "0x1CFA3F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000087")]
	private static Result get_result_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
	[CallerCount(Count = 69)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006E")]
	public UploadHandler get_uploadHandler() { }

	[Address(RVA = "0x1CF8C40", Offset = "0x1CF7E40", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000060")]
	private UnityWebRequestError GetError() { }

	[Address(RVA = "0x1CF8C00", Offset = "0x1CF7E00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000083")]
	private static UnityWebRequestError GetError_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CF8CF0", Offset = "0x1CF7EF0", Length = "0xAC")]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000046")]
	[VisibleToOtherModules]
	internal static string GetHTTPStatusString(long responseCode) { }

	[Address(RVA = "0x1CF8CA0", Offset = "0x1CF7EA0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007D")]
	private static void GetHTTPStatusString_Injected(long responseCode, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x1CF8E00", Offset = "0x1CF8000", Length = "0x204")]
	[CalledBy(Type = "GLTFast.Loading.AwaitableDownload", Member = "get_IsBinary", ReturnType = "System.Nullable`1<Boolean>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A170")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006C")]
	public string GetResponseHeader(string name) { }

	[Address(RVA = "0x1CF8DA0", Offset = "0x1CF7FA0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000089")]
	private static void GetResponseHeader_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x1CF9050", Offset = "0x1CF8250", Length = "0xAA")]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "InternalSetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "InternalSetCustomMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeConditional("ENABLE_UNITYWEBREQUEST")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000045")]
	private static string GetWebErrorString(UnityWebRequestError err) { }

	[Address(RVA = "0x1CF9010", Offset = "0x1CF8210", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007C")]
	private static void GetWebErrorString_Injected(UnityWebRequestError err, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x1CF9430", Offset = "0x1CF8630", Length = "0x87")]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600004F")]
	internal void InternalDestroy() { }

	[Address(RVA = "0x1CF94C0", Offset = "0x1CF86C0", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetCustomMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequestError))]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005E")]
	internal void InternalSetCustomMethod(string customMethodName) { }

	[Address(RVA = "0x1CF95D0", Offset = "0x1CF87D0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000050")]
	private void InternalSetDefaults() { }

	[Address(RVA = "0x1CF95E0", Offset = "0x1CF87E0", Length = "0x13D")]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600005C")]
	internal void InternalSetMethod(UnityWebRequestMethod methodType) { }

	[Address(RVA = "0x1CF9780", Offset = "0x1CF8980", Length = "0x2AD")]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("SetRequestHeader")]
	[Token(Token = "0x600006A")]
	internal UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	[Address(RVA = "0x1CF9720", Offset = "0x1CF8920", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000088")]
	private static UnityWebRequestError InternalSetRequestHeader_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x1CF9A30", Offset = "0x1CF8C30", Length = "0x10F")]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "set_url", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "set_uri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequestError))]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000065")]
	private void InternalSetUrl(string url) { }

	[Address(RVA = "0x1CF9CF0", Offset = "0x1CF8EF0", Length = "0x82")]
	[CalledBy(Type = "Polytoria.Controllers.AbuseReportController+<SubmitAbuseReport>d__6", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "PurchasesService+<DoProcessPurchase>d__18", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Networking.PTAuthenticator+<ValidateToken>d__5", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<LoadMetadata>d__205", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.AchievementService+<DoAward>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ChatService+<LogChatMessage>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.DataStoreService+<DoWriteToServer>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController+<DoPublishScreenshot>d__27", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<DoPublishModel>d__62", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<PublishLevelToID>d__81", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetupPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(WWWForm)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000078")]
	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	[Address(RVA = "0x1CF9B40", Offset = "0x1CF8D40", Length = "0x1AE")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager+<HeartbeatLoop>d__33", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(UploadHandlerRaw), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000076")]
	public static UnityWebRequest Post(string uri, string postData, string contentType) { }

	[Address(RVA = "0x1CF9DC0", Offset = "0x1CF8FC0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600004E")]
	private void Release() { }

	[Address(RVA = "0x1CF9D80", Offset = "0x1CF8F80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600007E")]
	private static void Release_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CF9E20", Offset = "0x1CF9020", Length = "0xC1")]
	[CallerCount(Count = 67)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AsyncOperation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000059")]
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000048")]
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[Address(RVA = "0x53B980", Offset = "0x53AB80", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600004A")]
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[Address(RVA = "0x53B990", Offset = "0x53AB90", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600004C")]
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	[Address(RVA = "0x1CFB290", Offset = "0x1CFA490", Length = "0x168")]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(WWWForm)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.HttpService+<DoRequest>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000072")]
	public void set_downloadHandler(DownloadHandler value) { }

	[Address(RVA = "0x1CFB400", Offset = "0x1CFA600", Length = "0x253")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.HttpService+<DoRequest>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "ToUpper", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetCustomMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequestError))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005F")]
	public void set_method(string value) { }

	[Address(RVA = "0x1CFB660", Offset = "0x1CFA860", Length = "0x168")]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(WWWForm)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.LobbyApi", Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.HttpService+<DoRequest>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600006F")]
	public void set_uploadHandler(UploadHandler value) { }

	[Address(RVA = "0x1CFB7D0", Offset = "0x1CFA9D0", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WebRequestUtils), Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000063")]
	public void set_uri(Uri value) { }

	[Address(RVA = "0x1CFB8D0", Offset = "0x1CFAAD0", Length = "0x84")]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WebRequestUtils), Member = "MakeInitialUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000062")]
	public void set_url(string value) { }

	[Address(RVA = "0x1CF9F40", Offset = "0x1CF9140", Length = "0x1AF")]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "InternalSetCustomMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005D")]
	private UnityWebRequestError SetCustomMethod(string customMethodName) { }

	[Address(RVA = "0x1CF9EF0", Offset = "0x1CF90F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000082")]
	private static UnityWebRequestError SetCustomMethod_Injected(IntPtr _unity_self, ref ManagedSpanWrapper customMethodName) { }

	[Address(RVA = "0x1CFA140", Offset = "0x1CF9340", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000070")]
	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	[Address(RVA = "0x1CFA0F0", Offset = "0x1CF92F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008B")]
	private static UnityWebRequestError SetDownloadHandler_Injected(IntPtr _unity_self, IntPtr dh) { }

	[Address(RVA = "0x1CFA200", Offset = "0x1CF9400", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005B")]
	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) { }

	[Address(RVA = "0x1CFA1C0", Offset = "0x1CF93C0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000081")]
	private static UnityWebRequestError SetMethod_Injected(IntPtr _unity_self, UnityWebRequestMethod methodType) { }

	[Address(RVA = "0x1CFA260", Offset = "0x1CF9460", Length = "0x1CF")]
	[CallerCount(Count = 91)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(UnityWebRequestError))]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006B")]
	public void SetRequestHeader(string name, string value) { }

	[Address(RVA = "0x1CFA480", Offset = "0x1CF9680", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006D")]
	private UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	[Address(RVA = "0x1CFA430", Offset = "0x1CF9630", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008A")]
	private static UnityWebRequestError SetUploadHandler_Injected(IntPtr _unity_self, IntPtr uh) { }

	[Address(RVA = "0x1CFA700", Offset = "0x1CF9900", Length = "0x320")]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WWWForm)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UploadHandlerRaw), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(WWWForm), Member = "get_data", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000079")]
	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

	[Address(RVA = "0x1CFAA30", Offset = "0x1CF9C30", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(UploadHandlerRaw), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000077")]
	private static void SetupPost(UnityWebRequest request, string postData, string contentType) { }

	[Address(RVA = "0x1CFA550", Offset = "0x1CF9750", Length = "0x1AF")]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000064")]
	private UnityWebRequestError SetUrl(string url) { }

	[Address(RVA = "0x1CFA500", Offset = "0x1CF9700", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000084")]
	private static UnityWebRequestError SetUrl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper url) { }

}

