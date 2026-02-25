namespace System.Net;

[Token(Token = "0x2000220")]
public class FtpWebResponse : WebResponse, IDisposable
{
	[Token(Token = "0x2000221")]
	public sealed class EmptyStream : MemoryStream
	{

		[Address(RVA = "0x17D2FA0", Offset = "0x17D21A0", Length = "0xA4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000DD2")]
		internal EmptyStream() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000896")]
	internal Stream _responseStream; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000897")]
	private long _contentLength; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000898")]
	private Uri _responseUri; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000899")]
	private FtpStatusCode _statusCode; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400089A")]
	private string _statusLine; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400089B")]
	private WebHeaderCollection _ftpRequestHeaders; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400089C")]
	private DateTime _lastModified; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400089D")]
	private string _bannerMessage; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400089E")]
	private string _welcomeMessage; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400089F")]
	private string _exitMessage; //Field offset: 0x68

	[Token(Token = "0x170002AE")]
	public virtual WebHeaderCollection Headers
	{
		[Address(RVA = "0x17DAA90", Offset = "0x17D9C90", Length = "0xEE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x6000DCF")]
		 get { } //Length: 238
	}

	[Token(Token = "0x170002AF")]
	public virtual Uri ResponseUri
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DD0")]
		 get { } //Length: 95
	}

	[Token(Token = "0x170002B0")]
	public FtpStatusCode StatusCode
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DD1")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x17DA930", Offset = "0x17D9B30", Length = "0x152")]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "EnsureFtpWebResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DCA")]
	internal FtpWebResponse(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	[Address(RVA = "0x17DA650", Offset = "0x17D9850", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DCE")]
	public virtual void Close() { }

	[Address(RVA = "0x17DAA90", Offset = "0x17D9C90", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000DCF")]
	public virtual WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DD0")]
	public virtual Uri get_ResponseUri() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DD1")]
	public FtpStatusCode get_StatusCode() { }

	[Address(RVA = "0x17DA740", Offset = "0x17D9940", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000DCC")]
	public virtual Stream GetResponseStream() { }

	[Address(RVA = "0x17DA850", Offset = "0x17D9A50", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000DCD")]
	internal void SetResponseStream(Stream stream) { }

	[Address(RVA = "0x17DA8F0", Offset = "0x17D9AF0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000DCB")]
	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

}

