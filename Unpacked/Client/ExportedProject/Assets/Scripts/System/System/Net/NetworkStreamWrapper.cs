namespace System.Net;

[Token(Token = "0x2000222")]
internal class NetworkStreamWrapper : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008A0")]
	private TcpClient _client; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008A1")]
	private NetworkStream _networkStream; //Field offset: 0x30

	[Token(Token = "0x170002B5")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x10AA0F0", Offset = "0x10A92F0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DD9")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170002B6")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x10AA150", Offset = "0x10A9350", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DDA")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170002B8")]
	public virtual bool CanTimeout
	{
		[Address(RVA = "0x17D4220", Offset = "0x17D3420", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DDC")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170002B7")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x1468940", Offset = "0x1467B40", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DDB")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170002BB")]
	public virtual long Length
	{
		[Address(RVA = "0x1468A90", Offset = "0x1467C90", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DE1")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170002B4")]
	internal NetworkStream NetworkStream
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DD7")]
		internal get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DD8")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002BC")]
	public virtual long Position
	{
		[Address(RVA = "0x1468AC0", Offset = "0x1467CC0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DE2")]
		 get { } //Length: 42
		[Address(RVA = "0x13B2290", Offset = "0x13B1490", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DE3")]
		 set { } //Length: 42
	}

	[Token(Token = "0x170002B9")]
	public virtual int ReadTimeout
	{
		[Address(RVA = "0x17D4250", Offset = "0x17D3450", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DDD")]
		 get { } //Length: 42
		[Address(RVA = "0x13B2440", Offset = "0x13B1640", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DDE")]
		 set { } //Length: 42
	}

	[Token(Token = "0x170002B2")]
	internal IPAddress ServerAddress
	{
		[Address(RVA = "0x17DF670", Offset = "0x17DE870", Length = "0x8A")]
		[CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest)}, ReturnType = typeof(PipelineEntry[]))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "GetPortCommandLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(string))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Socket), Member = "get_RemoteEndPoint", ReturnType = typeof(EndPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000DD5")]
		internal get { } //Length: 138
	}

	[Token(Token = "0x170002B3")]
	internal Socket Socket
	{
		[Address(RVA = "0x17DF700", Offset = "0x17DE900", Length = "0x1B")]
		[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000DD6")]
		internal get { } //Length: 27
	}

	[Token(Token = "0x170002B1")]
	protected bool UsingSecureStream
	{
		[Address(RVA = "0x17DF720", Offset = "0x17DE920", Length = "0x75")]
		[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest)}, ReturnType = typeof(PipelineEntry[]))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000DD4")]
		 get { } //Length: 117
	}

	[Token(Token = "0x170002BA")]
	public virtual int WriteTimeout
	{
		[Address(RVA = "0x17D4280", Offset = "0x17D3480", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DDF")]
		 get { } //Length: 42
		[Address(RVA = "0x13B2470", Offset = "0x13B1670", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DE0")]
		 set { } //Length: 42
	}

	[Address(RVA = "0x17DF5E0", Offset = "0x17DE7E0", Length = "0x89")]
	[CalledBy(Type = typeof(CommandStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DD3")]
	internal NetworkStreamWrapper(TcpClient client) { }

	[Address(RVA = "0x17DF2E0", Offset = "0x17DE4E0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DEA")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x17DF320", Offset = "0x17DE520", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DED")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x17DF3A0", Offset = "0x17DE5A0", Length = "0x34")]
	[CalledBy(Type = typeof(CommandStream), Member = "Abort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkStream), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DE9")]
	public void Close(int timeout) { }

	[Address(RVA = "0x17DF360", Offset = "0x17DE560", Length = "0x3F")]
	[CalledBy(Type = typeof(CommandStream), Member = "ReadCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponse", ReturnType = typeof(ResponseDescription))]
	[CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReceiveState), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpControlStream+<>c__DisplayClass31_0", Member = "<PipelineCallback>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "ConnectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "SSLHandshakeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "AttemptedRecovery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DE8")]
	internal void CloseSocket() { }

	[Address(RVA = "0x17DF3E0", Offset = "0x17DE5E0", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DE7")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x17DF490", Offset = "0x17DE690", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DEB")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x17DF4C0", Offset = "0x17DE6C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DEE")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x17D3AC0", Offset = "0x17D2CC0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF0")]
	public virtual void Flush() { }

	[Address(RVA = "0x10AA0F0", Offset = "0x10A92F0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DD9")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x10AA150", Offset = "0x10A9350", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DDA")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x17D4220", Offset = "0x17D3420", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DDC")]
	public virtual bool get_CanTimeout() { }

	[Address(RVA = "0x1468940", Offset = "0x1467B40", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DDB")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x1468A90", Offset = "0x1467C90", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE1")]
	public virtual long get_Length() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DD7")]
	internal NetworkStream get_NetworkStream() { }

	[Address(RVA = "0x1468AC0", Offset = "0x1467CC0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE2")]
	public virtual long get_Position() { }

	[Address(RVA = "0x17D4250", Offset = "0x17D3450", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DDD")]
	public virtual int get_ReadTimeout() { }

	[Address(RVA = "0x17DF670", Offset = "0x17DE870", Length = "0x8A")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest)}, ReturnType = typeof(PipelineEntry[]))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "GetPortCommandLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(string))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Socket), Member = "get_RemoteEndPoint", ReturnType = typeof(EndPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000DD5")]
	internal IPAddress get_ServerAddress() { }

	[Address(RVA = "0x17DF700", Offset = "0x17DE900", Length = "0x1B")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DD6")]
	internal Socket get_Socket() { }

	[Address(RVA = "0x17DF720", Offset = "0x17DE920", Length = "0x75")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest)}, ReturnType = typeof(PipelineEntry[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000DD4")]
	protected bool get_UsingSecureStream() { }

	[Address(RVA = "0x17D4280", Offset = "0x17D3480", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DDF")]
	public virtual int get_WriteTimeout() { }

	[Address(RVA = "0x17DF520", Offset = "0x17DE720", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DE5")]
	public virtual int Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x17DF4F0", Offset = "0x17DE6F0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DEC")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x17DF550", Offset = "0x17DE750", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DE4")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DD8")]
	internal void set_NetworkStream(NetworkStream value) { }

	[Address(RVA = "0x13B2290", Offset = "0x13B1490", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE3")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x13B2440", Offset = "0x13B1640", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DDE")]
	public virtual void set_ReadTimeout(int value) { }

	[Address(RVA = "0x13B2470", Offset = "0x13B1670", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE0")]
	public virtual void set_WriteTimeout(int value) { }

	[Address(RVA = "0x17D3C60", Offset = "0x17D2E60", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF1")]
	public virtual void SetLength(long value) { }

	[Address(RVA = "0x17D3C90", Offset = "0x17D2E90", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF2")]
	internal void SetSocketTimeoutOption(int timeout) { }

	[Address(RVA = "0x17DF5B0", Offset = "0x17DE7B0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DE6")]
	public virtual void Write(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x17DF580", Offset = "0x17DE780", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DEF")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

