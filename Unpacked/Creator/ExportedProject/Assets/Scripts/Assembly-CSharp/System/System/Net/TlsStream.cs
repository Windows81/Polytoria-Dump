namespace System.Net;

[Token(Token = "0x2000206")]
internal class TlsStream : NetworkStream
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400079E")]
	private SslStream _sslStream; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400079F")]
	private string _host; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40007A0")]
	private X509CertificateCollection _clientCertificates; //Field offset: 0x58

	[Address(RVA = "0x17CC470", Offset = "0x17CB670", Length = "0xF0")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ServicePointManager), Member = "get_ServerCertificateValidationCallback", ReturnType = typeof(RemoteCertificateValidationCallback))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000CE5")]
	public TlsStream(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) { }

	[Address(RVA = "0x17CC050", Offset = "0x17CB250", Length = "0x12D")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CE6")]
	public void AuthenticateAsClient() { }

	[Address(RVA = "0x17CC180", Offset = "0x17CB380", Length = "0x13B")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&)}, ReturnType = typeof(PipelineInstruction))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CE7")]
	public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) { }

	[Address(RVA = "0x17CC2C0", Offset = "0x17CB4C0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CED")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x17CC300", Offset = "0x17CB500", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CE9")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x17CC340", Offset = "0x17CB540", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stream), Member = "Close", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CEF")]
	public virtual void Close() { }

	[Address(RVA = "0x17CC380", Offset = "0x17CB580", Length = "0x2A")]
	[CalledBy(Type = "System.Net.FtpControlStream+<>c__DisplayClass31_0", Member = "<PipelineCallback>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CE8")]
	public void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	[Address(RVA = "0x17CC3B0", Offset = "0x17CB5B0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CEE")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x17CC3E0", Offset = "0x17CB5E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CEA")]
	public virtual void EndWrite(IAsyncResult result) { }

	[Address(RVA = "0x17CC410", Offset = "0x17CB610", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CEC")]
	public virtual int Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x17CC440", Offset = "0x17CB640", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000CEB")]
	public virtual void Write(Byte[] buffer, int offset, int size) { }

}

