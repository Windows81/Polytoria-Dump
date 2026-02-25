namespace System.Net;

[Token(Token = "0x200020D")]
internal class CommandStream : NetworkStreamWrapper
{
	[Token(Token = "0x2000210")]
	public class PipelineEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000816")]
		internal string Command; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000817")]
		internal PipelineEntryFlags Flags; //Field offset: 0x18

		[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D3F")]
		internal PipelineEntry(string command) { }

		[Address(RVA = "0x351B70", Offset = "0x350D70", Length = "0x42")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D40")]
		internal PipelineEntry(string command, PipelineEntryFlags flags) { }

		[Address(RVA = "0x17CB310", Offset = "0x17CA510", Length = "0x7")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D41")]
		internal bool HasFlag(PipelineEntryFlags flags) { }

	}

	[Flags]
	[Token(Token = "0x200020F")]
	public enum PipelineEntryFlags
	{
		UserCommand = 1,
		GiveDataStream = 2,
		CreateDataConnection = 4,
		DontLogParameter = 8,
	}

	[Token(Token = "0x200020E")]
	public enum PipelineInstruction
	{
		Abort = 0,
		Advance = 1,
		Pause = 2,
		Reread = 3,
		GiveStream = 4,
	}

	[Token(Token = "0x40007FC")]
	private static readonly AsyncCallback s_writeCallbackDelegate; //Field offset: 0x0
	[Token(Token = "0x40007FD")]
	private static readonly AsyncCallback s_readCallbackDelegate; //Field offset: 0x8
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007FE")]
	private bool _recoverableFailure; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007FF")]
	protected WebRequest _request; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000800")]
	protected bool _isAsync; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x4000801")]
	private bool _aborted; //Field offset: 0x49
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000802")]
	protected PipelineEntry[] _commands; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000803")]
	protected int _index; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000804")]
	private bool _doRead; //Field offset: 0x5C
	[FieldOffset(Offset = "0x5D")]
	[Token(Token = "0x4000805")]
	private bool _doSend; //Field offset: 0x5D
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000806")]
	private ResponseDescription _currentResponseDescription; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000807")]
	protected string _abortReason; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000808")]
	private string _buffer; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000809")]
	private Encoding _encoding; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400080A")]
	private Decoder _decoder; //Field offset: 0x80

	[Token(Token = "0x1700027E")]
	protected Encoding Encoding
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D39")]
		 get { } //Length: 5
		[Address(RVA = "0x17B2F70", Offset = "0x17B2170", Length = "0x52")]
		[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000D3A")]
		 set { } //Length: 82
	}

	[Token(Token = "0x1700027D")]
	internal bool RecoverableFailure
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D2A")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x17B2DE0", Offset = "0x17B1FE0", Length = "0xE4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D3E")]
	private static CommandStream() { }

	[Address(RVA = "0x17B2ED0", Offset = "0x17B20D0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(NetworkStreamWrapper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D26")]
	internal CommandStream(TcpClient client) { }

	[Address(RVA = "0x17B12C0", Offset = "0x17B04C0", Length = "0x1F3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkStreamWrapper), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandStream), Member = "InvokeRequestCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D27")]
	internal override void Abort(Exception e) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D2E")]
	protected override PipelineEntry[] BuildCommandsList(WebRequest request) { }

	[Address(RVA = "0x17B14C0", Offset = "0x17B06C0", Length = "0x40")]
	[CalledBy(Type = typeof(WaitForChangedResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WatcherChangeTypes), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "DataStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CloseExState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D32")]
	internal void CheckContinuePipeline() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D3B")]
	protected override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	[Address(RVA = "0x17B1500", Offset = "0x17B0700", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandStream), Member = "InitCommandPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(PipelineEntry[]), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000D2D")]
	protected override void ClearState() { }

	[Address(RVA = "0x17B1520", Offset = "0x17B0720", Length = "0x4DB")]
	[CalledBy(Type = typeof(CommandStream), Member = "SubmitRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(bool), typeof(bool)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(CommandStream), Member = "CheckContinuePipeline", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandStream), Member = "PostReadCommandProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CommandStream), Member = "WriteCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReceiveState), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpControlStream+<>c__DisplayClass31_0", Member = "<PipelineCallback>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "ConnectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "SSLHandshakeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CommandStream), Member = "PostSendCommandProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandStream), Member = "MarkAsRecoverableFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003AA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(FormattableString))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000D33")]
	protected Stream ContinueCommandPipeline() { }

	[Address(RVA = "0x17B1A00", Offset = "0x17B0C00", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FtpWebRequest), Member = "RequestCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D28")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x17B1BE0", Offset = "0x17B0DE0", Length = "0x7D")]
	[CalledBy(Type = typeof(CommandStream), Member = "PostReadCommandProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponse", ReturnType = typeof(ResponseDescription))]
	[CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReceiveState), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "GetPortCommandLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000D2F")]
	protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) { }

	[Address(RVA = "0x17B1B30", Offset = "0x17B0D30", Length = "0xA3")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetRes), Member = "GetWebStatusCodeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpStatusCode), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000D30")]
	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D39")]
	protected Encoding get_Encoding() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D2A")]
	internal bool get_RecoverableFailure() { }

	[Address(RVA = "0x17B1C60", Offset = "0x17B0E60", Length = "0x92")]
	[CalledBy(Type = typeof(CommandStream), Member = "SubmitRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(bool), typeof(bool)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(CommandStream), Member = "ClearState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "ClearState", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000D31")]
	protected void InitCommandPipeline(WebRequest request, PipelineEntry[] commands, bool isAsync) { }

	[Address(RVA = "0x17B1D00", Offset = "0x17B0F00", Length = "0x73")]
	[CalledBy(Type = typeof(CommandStream), Member = "Abort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandStream), Member = "PostReadCommandProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.FtpControlStream+<>c__DisplayClass31_0", Member = "<PipelineCallback>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "ConnectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "SSLHandshakeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FtpWebRequest), Member = "RequestCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000D29")]
	protected void InvokeRequestCallback(object obj) { }

	[Address(RVA = "0x17B1D80", Offset = "0x17B0F80", Length = "0xB")]
	[CalledBy(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(CommandStream), Member = "ReadCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandStream), Member = "WriteCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponse", ReturnType = typeof(ResponseDescription))]
	[CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReceiveState), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CallerCount(Count = 6)]
	[Token(Token = "0x6000D2B")]
	protected void MarkAsRecoverableFailure() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D36")]
	protected override PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	[Address(RVA = "0x17B1D90", Offset = "0x17B0F90", Length = "0x212")]
	[CalledBy(Type = typeof(CommandStream), Member = "PostSendCommandProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReceiveState), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus), typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002330")]
	[Calls(Type = typeof(CommandStream), Member = "InvokeRequestCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D35")]
	private bool PostReadCommandProcessing(ref Stream stream) { }

	[Address(RVA = "0x17B1FB0", Offset = "0x17B11B0", Length = "0xEF")]
	[CalledBy(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(CommandStream), Member = "WriteCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandStream), Member = "ReceiveCommandResponse", ReturnType = typeof(ResponseDescription))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandStream), Member = "PostReadCommandProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D34")]
	private bool PostSendCommandProcessing(ref Stream stream) { }

	[Address(RVA = "0x17B20A0", Offset = "0x17B12A0", Length = "0x1A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(NetworkStreamWrapper), Member = "CloseSocket", ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReceiveState), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CommandStream), Member = "MarkAsRecoverableFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000D37")]
	private static void ReadCallback(IAsyncResult asyncResult) { }

	[Address(RVA = "0x17B2870", Offset = "0x17B1A70", Length = "0x330")]
	[CalledBy(Type = typeof(CommandStream), Member = "PostSendCommandProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReceiveState), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandStream), Member = "MarkAsRecoverableFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus), typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkStreamWrapper), Member = "CloseSocket", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000D3C")]
	private ResponseDescription ReceiveCommandResponse() { }

	[Address(RVA = "0x17B2250", Offset = "0x17B1450", Length = "0x61C")]
	[CalledBy(Type = typeof(CommandStream), Member = "ReadCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponse", ReturnType = typeof(ResponseDescription))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(FormattableString))]
	[Calls(Type = typeof(CommandStream), Member = "MarkAsRecoverableFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus), typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NetworkStreamWrapper), Member = "CloseSocket", ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
	[Calls(Type = typeof(CommandStream), Member = "PostReadCommandProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000D3D")]
	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) { }

	[Address(RVA = "0x17B2F70", Offset = "0x17B2170", Length = "0x52")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D3A")]
	protected void set_Encoding(Encoding value) { }

	[Address(RVA = "0x17B2BB0", Offset = "0x17B1DB0", Length = "0x9B")]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "TimedSubmitRequestHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandStream), Member = "InitCommandPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(PipelineEntry[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000D2C")]
	internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) { }

	[Address(RVA = "0x17B2C50", Offset = "0x17B1E50", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CommandStream), Member = "PostSendCommandProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CommandStream), Member = "MarkAsRecoverableFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000D38")]
	private static void WriteCallback(IAsyncResult asyncResult) { }

}

