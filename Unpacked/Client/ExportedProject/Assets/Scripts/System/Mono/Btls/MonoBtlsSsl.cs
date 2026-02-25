namespace Mono.Btls;

[Token(Token = "0x2000082")]
internal class MonoBtlsSsl : MonoBtlsObject
{
	[Token(Token = "0x2000083")]
	public class BoringSslHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x1732310", Offset = "0x1731510", Length = "0xB")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600025D")]
		public BoringSslHandle(IntPtr handle) { }

		[Address(RVA = "0x1732320", Offset = "0x1731520", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600025E")]
		protected virtual bool ReleaseHandle() { }

	}

	[Token(Token = "0x2000084")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class PrintErrorsCallbackFunc : MulticastDelegate
	{

		[Address(RVA = "0x397000", Offset = "0x396200", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600025F")]
		public PrintErrorsCallbackFunc(object object, IntPtr method) { }

		[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000260")]
		public override int Invoke(IntPtr str, IntPtr len, IntPtr ctx) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400014D")]
	private MonoBtlsBio bio; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400014E")]
	private PrintErrorsCallbackFunc printErrorsFunc; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400014F")]
	private IntPtr printErrorsFuncPtr; //Field offset: 0x30

	[Token(Token = "0x17000073")]
	internal BoringSslHandle Handle
	{
		[Address(RVA = "0x173AA30", Offset = "0x1739C30", Length = "0x71")]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000244")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x173A7D0", Offset = "0x17399D0", Length = "0x252")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "StartHandshake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000243")]
	public MonoBtlsSsl(MonoBtlsSslCtx ctx) { }

	[Address(RVA = "0x1739000", Offset = "0x1738200", Length = "0xB1")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "DoProcessHandshake", ReturnType = typeof(MonoBtlsSslError))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600024B")]
	public MonoBtlsSslError Accept() { }

	[Address(RVA = "0x17390C0", Offset = "0x17382C0", Length = "0xF3")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "ThrowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600024A")]
	public void AddIntermediateCertificate(MonoBtlsX509 x509) { }

	[Address(RVA = "0x17391C0", Offset = "0x17383C0", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600025A")]
	protected virtual void Close() { }

	[Address(RVA = "0x1739280", Offset = "0x1738480", Length = "0xB1")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "DoProcessHandshake", ReturnType = typeof(MonoBtlsSslError))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600024C")]
	public MonoBtlsSslError Connect() { }

	[Address(RVA = "0x1739340", Offset = "0x1738540", Length = "0x127")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000242")]
	private static BoringSslHandle Create_internal(MonoBtlsSslCtx ctx) { }

	[Address(RVA = "0x173AA30", Offset = "0x1739C30", Length = "0x71")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000244")]
	internal BoringSslHandle get_Handle() { }

	[Address(RVA = "0x1739470", Offset = "0x1738670", Length = "0xDF")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeSession", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000254")]
	public int GetCipher() { }

	[Address(RVA = "0x1739550", Offset = "0x1738750", Length = "0x79")]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Accept", ReturnType = typeof(MonoBtlsSslError))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Connect", ReturnType = typeof(MonoBtlsSslError))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Handshake", ReturnType = typeof(MonoBtlsSslError))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Int32&)}, ReturnType = typeof(MonoBtlsSslError))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckLastError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "mono_btls_ssl_get_error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000247")]
	private MonoBtlsSslError GetError(int ret_code) { }

	[Address(RVA = "0x17395D0", Offset = "0x17387D0", Length = "0x18B")]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "ThrowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "PrintErrors", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600024F")]
	public string GetErrors() { }

	[Address(RVA = "0x1739760", Offset = "0x1738960", Length = "0x11E")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "GetPeerCertificate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000255")]
	public MonoBtlsX509 GetPeerCertificate() { }

	[Address(RVA = "0x1739880", Offset = "0x1738A80", Length = "0xE6")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ServerNameCallback", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeSession", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "PtrToStringAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000257")]
	public string GetServerName() { }

	[Address(RVA = "0x1739970", Offset = "0x1738B70", Length = "0x97")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeSession", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000253")]
	public int GetVersion() { }

	[Address(RVA = "0x1739A10", Offset = "0x1738C10", Length = "0xB1")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "DoProcessHandshake", ReturnType = typeof(MonoBtlsSslError))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600024D")]
	public MonoBtlsSslError Handshake() { }

	[Address(RVA = "0x173AAB0", Offset = "0x1739CB0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000230")]
	private static int mono_btls_ssl_accept(IntPtr handle) { }

	[Address(RVA = "0x173AB30", Offset = "0x1739D30", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022F")]
	private static int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509) { }

	[Address(RVA = "0x173ABC0", Offset = "0x1739DC0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000233")]
	private static void mono_btls_ssl_close(IntPtr handle) { }

	[Address(RVA = "0x173AC40", Offset = "0x1739E40", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000231")]
	private static int mono_btls_ssl_connect(IntPtr handle) { }

	[Address(RVA = "0x173ACC0", Offset = "0x1739EC0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022B")]
	private static void mono_btls_ssl_destroy(IntPtr handle) { }

	[Address(RVA = "0x173AD40", Offset = "0x1739F40", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600023B")]
	private static int mono_btls_ssl_get_cipher(IntPtr handle) { }

	[Address(RVA = "0x173ADC0", Offset = "0x1739FC0", Length = "0x85")]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "GetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsSslError))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Int32&)}, ReturnType = typeof(MonoBtlsSslError))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000239")]
	private static int mono_btls_ssl_get_error(IntPtr handle, int ret_code) { }

	[Address(RVA = "0x173AE50", Offset = "0x173A050", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600023C")]
	private static IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle) { }

	[Address(RVA = "0x173AED0", Offset = "0x173A0D0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600023F")]
	private static IntPtr mono_btls_ssl_get_server_name(IntPtr handle) { }

	[Address(RVA = "0x173AF50", Offset = "0x173A150", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600023A")]
	private static int mono_btls_ssl_get_version(IntPtr handle) { }

	[Address(RVA = "0x173AFD0", Offset = "0x173A1D0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000232")]
	private static int mono_btls_ssl_handshake(IntPtr handle) { }

	[Address(RVA = "0x173B050", Offset = "0x173A250", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022C")]
	private static IntPtr mono_btls_ssl_new(IntPtr handle) { }

	[Address(RVA = "0x173B0D0", Offset = "0x173A2D0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600023D")]
	private static void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx) { }

	[Address(RVA = "0x173B160", Offset = "0x173A360", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000237")]
	private static int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len) { }

	[Address(RVA = "0x173B200", Offset = "0x173A400", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000241")]
	private static int mono_btls_ssl_renegotiate_pending(IntPtr handle) { }

	[Address(RVA = "0x173B280", Offset = "0x173A480", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000236")]
	private static void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio) { }

	[Address(RVA = "0x173B310", Offset = "0x173A510", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000235")]
	private static void mono_btls_ssl_set_quiet_shutdown(IntPtr handle, int mode) { }

	[Address(RVA = "0x173B3A0", Offset = "0x173A5A0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000240")]
	private static void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode) { }

	[Address(RVA = "0x173B430", Offset = "0x173A630", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600023E")]
	private static int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name) { }

	[Address(RVA = "0x173B4C0", Offset = "0x173A6C0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000234")]
	private static int mono_btls_ssl_shutdown(IntPtr handle) { }

	[Address(RVA = "0x173B540", Offset = "0x173A740", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022D")]
	private static int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509) { }

	[Address(RVA = "0x173B5D0", Offset = "0x173A7D0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022E")]
	private static int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key) { }

	[Address(RVA = "0x173B660", Offset = "0x173A860", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000238")]
	private static int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len) { }

	[Address(RVA = "0x1739C10", Offset = "0x1738E10", Length = "0xC4")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetErrors", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000250")]
	public void PrintErrors() { }

	[Address(RVA = "0x1739AD0", Offset = "0x1738CD0", Length = "0x13C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "PtrToStringAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[MonoPInvokeCallback(typeof(PrintErrorsCallbackFunc))]
	[Token(Token = "0x600024E")]
	private static int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx) { }

	[Address(RVA = "0x1739CE0", Offset = "0x1738EE0", Length = "0xFE")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Boolean>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000251")]
	public MonoBtlsSslError Read(IntPtr data, ref int dataSize) { }

	[Address(RVA = "0x1739DE0", Offset = "0x1738FE0", Length = "0x9A")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "PendingRenegotiation", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600025C")]
	public bool RenegotiatePending() { }

	[Address(RVA = "0x1739E80", Offset = "0x1739080", Length = "0xE4")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "StartHandshake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsBio), Member = "get_Handle", ReturnType = typeof(BoringBioHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000245")]
	public void SetBio(MonoBtlsBio bio) { }

	[Address(RVA = "0x1739F70", Offset = "0x1739170", Length = "0xF3")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "ThrowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000248")]
	public void SetCertificate(MonoBtlsX509 x509) { }

	[Address(RVA = "0x173A070", Offset = "0x1739270", Length = "0xF3")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsKey), Member = "get_Handle", ReturnType = typeof(BoringKeyHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "ThrowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000249")]
	public void SetPrivateKey(MonoBtlsKey key) { }

	[Address(RVA = "0x173A170", Offset = "0x1739370", Length = "0x9C")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000259")]
	public void SetQuietShutdown() { }

	[Address(RVA = "0x173A210", Offset = "0x1739410", Length = "0xA4")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "StartHandshake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600025B")]
	public void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode) { }

	[Address(RVA = "0x173A2C0", Offset = "0x17394C0", Length = "0x18F")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "StartHandshake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StringToHGlobalAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1817320D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000256")]
	public void SetServerName(string name) { }

	[Address(RVA = "0x173A450", Offset = "0x1739650", Length = "0xC4")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "ThrowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000258")]
	public void Shutdown() { }

	[Address(RVA = "0x173A520", Offset = "0x1739720", Length = "0x19F")]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "SetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "SetPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsKey)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "AddIntermediateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetErrors", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000246")]
	private Exception ThrowError(string callerName = null) { }

	[Address(RVA = "0x173A6C0", Offset = "0x17398C0", Length = "0x101")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Boolean>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "mono_btls_ssl_get_error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000252")]
	public MonoBtlsSslError Write(IntPtr data, ref int dataSize) { }

}

