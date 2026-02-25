namespace System.Net;

[Token(Token = "0x200023B")]
public class WebException : InvalidOperationException, ISerializable
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000921")]
	private WebExceptionStatus m_Status; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000922")]
	private WebResponse m_Response; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000923")]
	private WebExceptionInternalStatus m_InternalStatus; //Field offset: 0xA0

	[Token(Token = "0x170002D5")]
	public WebResponse Response
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E4B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170002D4")]
	public WebExceptionStatus Status
	{
		[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E4A")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x17E3560", Offset = "0x17E2760", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000E3E")]
	public WebException() { }

	[Address(RVA = "0x17E3A00", Offset = "0x17E2C00", Length = "0x15")]
	[CalledBy(Type = typeof(CommandStream), Member = "PostReadCommandProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest)}, ReturnType = typeof(PipelineEntry[]))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000E3F")]
	public WebException(string message) { }

	[Address(RVA = "0x17E3750", Offset = "0x17E2950", Length = "0x12")]
	[CalledBy(Type = typeof(FileWebRequest), Member = "GetRequestStreamCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "GetResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000E40")]
	public WebException(string message, Exception innerException) { }

	[Address(RVA = "0x17E3580", Offset = "0x17E2780", Length = "0x20")]
	[CalledBy(Type = "System.Net.HttpWebRequest+<RunWithTimeoutWorker>d__241`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "Abort", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
	[CalledBy(Type = typeof(WebConnection), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception)}, ReturnType = typeof(WebException))]
	[CalledBy(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionDispatchInfo&)}, ReturnType = typeof(System.ValueTuple`2<System.Runtime.ExceptionServices.ExceptionDispatchInfo, System.Boolean>))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception), typeof(string)}, ReturnType = typeof(WebException))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000E41")]
	public WebException(string message, WebExceptionStatus status) { }

	[Address(RVA = "0x17E35D0", Offset = "0x17E27D0", Length = "0xBD")]
	[CalledBy(Type = typeof(WebConnection), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception)}, ReturnType = typeof(WebException))]
	[CalledBy(Type = "System.Net.WebRequestStream+<SetHeadersAsync>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequestStream), Member = "Close_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus), typeof(Exception), typeof(string)}, ReturnType = typeof(WebException))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E42")]
	internal WebException(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	[Address(RVA = "0x17E3770", Offset = "0x17E2970", Length = "0xB3")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoChunkStream), Member = "ThrowExpectingChunkTrailer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoChunkParser), Member = "ThrowProtocolViolation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse)}, ReturnType = typeof(System.ValueTuple`4<System.Boolean, System.Boolean, System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetRewriteHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse), typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>, System.Net.WebException>))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(WebException))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteRequestAsync>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileWebRequest), typeof(Uri), typeof(FileAccess), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "TranslateConnectException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpStatusCode), typeof(string), typeof(Exception)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus), typeof(Exception)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000E43")]
	public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	[Address(RVA = "0x17E3830", Offset = "0x17E2A30", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E44")]
	internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	[Address(RVA = "0x17E3690", Offset = "0x17E2890", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E45")]
	internal WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	[Address(RVA = "0x17E3910", Offset = "0x17E2B10", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E46")]
	internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	[Address(RVA = "0x17E35A0", Offset = "0x17E27A0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E47")]
	protected WebException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E4B")]
	public WebResponse get_Response() { }

	[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E4A")]
	public WebExceptionStatus get_Status() { }

	[Address(RVA = "0x1747B40", Offset = "0x1746D40", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E49")]
	public virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x17E3530", Offset = "0x17E2730", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E48")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

