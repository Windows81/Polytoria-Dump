namespace System.Net;

[Token(Token = "0x2000217")]
internal class FtpDataStream : Stream, ICloseEx
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000841")]
	private FtpWebRequest _request; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000842")]
	private NetworkStream _networkStream; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000843")]
	private bool _writeable; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000844")]
	private bool _readable; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4000845")]
	private bool _isFullyRead; //Field offset: 0x3A
	[FieldOffset(Offset = "0x3B")]
	[Token(Token = "0x4000846")]
	private bool _closing; //Field offset: 0x3B

	[Token(Token = "0x1700028B")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D72")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700028C")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x10AA150", Offset = "0x10A9350", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D73")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000290")]
	public virtual bool CanTimeout
	{
		[Address(RVA = "0x17D4220", Offset = "0x17D3420", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D82")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700028D")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D74")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700028E")]
	public virtual long Length
	{
		[Address(RVA = "0x1468A90", Offset = "0x1467C90", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D75")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700028F")]
	public virtual long Position
	{
		[Address(RVA = "0x1468AC0", Offset = "0x1467CC0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D76")]
		 get { } //Length: 42
		[Address(RVA = "0x13B2290", Offset = "0x13B1490", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D77")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000291")]
	public virtual int ReadTimeout
	{
		[Address(RVA = "0x17D4250", Offset = "0x17D3450", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D83")]
		 get { } //Length: 42
		[Address(RVA = "0x13B2440", Offset = "0x13B1640", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D84")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000292")]
	public virtual int WriteTimeout
	{
		[Address(RVA = "0x17D4280", Offset = "0x17D3480", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D85")]
		 get { } //Length: 42
		[Address(RVA = "0x13B2470", Offset = "0x13B1670", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D86")]
		 set { } //Length: 42
	}

	[Address(RVA = "0x17D4110", Offset = "0x17D3310", Length = "0x109")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D6E")]
	internal FtpDataStream(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly) { }

	[Address(RVA = "0x17D33B0", Offset = "0x17D25B0", Length = "0x17E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(LazyAsyncResult), Member = "ProtectedInvokeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000D7B")]
	private void AsyncReadCallback(IAsyncResult ar) { }

	[Address(RVA = "0x17D3530", Offset = "0x17D2730", Length = "0x175")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(AsyncCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D7C")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x17D36B0", Offset = "0x17D28B0", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D7E")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x17D3770", Offset = "0x17D2970", Length = "0x4B")]
	[CalledBy(Type = typeof(FtpDataStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D71")]
	private void CheckError() { }

	[Address(RVA = "0x17D37C0", Offset = "0x17D29C0", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000D6F")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x17D3880", Offset = "0x17D2A80", Length = "0x187")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LazyAsyncResult), Member = "WaitForCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1817CCAE0")]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000D7D")]
	public virtual int EndRead(IAsyncResult ar) { }

	[Address(RVA = "0x17D3A10", Offset = "0x17D2C10", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1817CCAE0")]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D7F")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x17D3AC0", Offset = "0x17D2CC0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D80")]
	public virtual void Flush() { }

	[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D72")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x10AA150", Offset = "0x10A9350", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D73")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x17D4220", Offset = "0x17D3420", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D82")]
	public virtual bool get_CanTimeout() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D74")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x1468A90", Offset = "0x1467C90", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D75")]
	public virtual long get_Length() { }

	[Address(RVA = "0x1468AC0", Offset = "0x1467CC0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D76")]
	public virtual long get_Position() { }

	[Address(RVA = "0x17D4250", Offset = "0x17D3450", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D83")]
	public virtual int get_ReadTimeout() { }

	[Address(RVA = "0x17D4280", Offset = "0x17D3480", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D85")]
	public virtual int get_WriteTimeout() { }

	[Address(RVA = "0x17D3AF0", Offset = "0x17D2CF0", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000D79")]
	public virtual int Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x17D3BC0", Offset = "0x17D2DC0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D78")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x13B2290", Offset = "0x13B1490", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D77")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x13B2440", Offset = "0x13B1640", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D84")]
	public virtual void set_ReadTimeout(int value) { }

	[Address(RVA = "0x13B2470", Offset = "0x13B1670", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D86")]
	public virtual void set_WriteTimeout(int value) { }

	[Address(RVA = "0x17D3C60", Offset = "0x17D2E60", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D81")]
	public virtual void SetLength(long value) { }

	[Address(RVA = "0x17D3C90", Offset = "0x17D2E90", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D87")]
	internal void SetSocketTimeoutOption(int timeout) { }

	[Address(RVA = "0x17D3CF0", Offset = "0x17D2EF0", Length = "0x37E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1817CD2A0")]
	[Calls(Type = typeof(NetworkStream), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(FormattableString))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D70")]
	private override void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	[Address(RVA = "0x17D4070", Offset = "0x17D3270", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D7A")]
	public virtual void Write(Byte[] buffer, int offset, int size) { }

}

