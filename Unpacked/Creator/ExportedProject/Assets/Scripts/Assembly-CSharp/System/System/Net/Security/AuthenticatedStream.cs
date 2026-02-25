namespace System.Net.Security;

[Token(Token = "0x2000312")]
public abstract class AuthenticatedStream : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E60")]
	private Stream _InnerStream; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E61")]
	private bool _LeaveStreamOpen; //Field offset: 0x30

	[Token(Token = "0x1700042E")]
	protected Stream InnerStream
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013E5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700042F")]
	public abstract bool IsAuthenticated
	{
		[Token(Token = "0x60013E7")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x1716C60", Offset = "0x1715E60", Length = "0x1B1")]
	[CalledBy(Type = typeof(UnityTlsProvider), Member = "CreateSslStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), typeof(Stream), typeof(bool), typeof(MonoTlsSettings)}, ReturnType = typeof(MobileAuthenticatedStream))]
	[CalledBy(Type = typeof(UnityTlsStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(SslStream), typeof(MonoTlsSettings), typeof(MobileTlsProvider)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MobileAuthenticatedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(SslStream), typeof(MonoTlsSettings), typeof(MobileTlsProvider)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback), typeof(LocalCertificateSelectionCallback)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(MonoTlsProvider), typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60013E4")]
	protected AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen) { }

	[Address(RVA = "0x1716B90", Offset = "0x1715D90", Length = "0xC9")]
	[CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SslStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60013E6")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013E5")]
	protected Stream get_InnerStream() { }

	[Token(Token = "0x60013E7")]
	public abstract bool get_IsAuthenticated() { }

}

