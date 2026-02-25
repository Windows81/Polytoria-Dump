namespace Mono.Btls;

[Token(Token = "0x200008C")]
internal class MonoBtlsStream : MobileAuthenticatedStream
{

	[Address(RVA = "0x173B770", Offset = "0x173A970", Length = "0x84")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "CreateSslStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), typeof(Stream), typeof(bool), typeof(MonoTlsSettings)}, ReturnType = typeof(MobileAuthenticatedStream))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(SslStream), typeof(MonoTlsSettings), typeof(MobileTlsProvider)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000286")]
	public MonoBtlsStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	[Address(RVA = "0x173B700", Offset = "0x173A900", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000287")]
	protected virtual MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

}

