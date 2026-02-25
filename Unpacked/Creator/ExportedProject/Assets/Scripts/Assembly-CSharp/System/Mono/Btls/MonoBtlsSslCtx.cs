namespace Mono.Btls;

[Token(Token = "0x2000085")]
internal class MonoBtlsSslCtx : MonoBtlsObject
{
	[Token(Token = "0x2000086")]
	public class BoringSslCtxHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x1732310", Offset = "0x1731510", Length = "0xB")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600027E")]
		public BoringSslCtxHandle(IntPtr handle) { }

		[Address(RVA = "0x1732290", Offset = "0x1731490", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600027F")]
		protected virtual bool ReleaseHandle() { }

	}

	[Token(Token = "0x2000088")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class NativeSelectFunc : MulticastDelegate
	{

		[Address(RVA = "0x1743630", Offset = "0x1742830", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000282")]
		public NativeSelectFunc(object object, IntPtr method) { }

		[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000283")]
		public override int Invoke(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

	}

	[Token(Token = "0x2000089")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class NativeServerNameFunc : MulticastDelegate
	{

		[Address(RVA = "0x395EA0", Offset = "0x3950A0", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000284")]
		public NativeServerNameFunc(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000285")]
		public override int Invoke(IntPtr instance) { }

	}

	[Token(Token = "0x2000087")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class NativeVerifyFunc : MulticastDelegate
	{

		[Address(RVA = "0x391E10", Offset = "0x391010", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000280")]
		public NativeVerifyFunc(object object, IntPtr method) { }

		[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000281")]
		public override int Invoke(IntPtr instance, int preverify_ok, IntPtr ctx) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000150")]
	private NativeVerifyFunc verifyFunc; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000151")]
	private NativeSelectFunc selectFunc; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000152")]
	private NativeServerNameFunc serverNameFunc; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000153")]
	private IntPtr verifyFuncPtr; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000154")]
	private IntPtr selectFuncPtr; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000155")]
	private IntPtr serverNameFuncPtr; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000156")]
	private MonoBtlsVerifyCallback verifyCallback; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000157")]
	private MonoBtlsSelectCallback selectCallback; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000158")]
	private MonoBtlsServerNameCallback serverNameCallback; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000159")]
	private MonoBtlsX509Store store; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400015A")]
	private GCHandle instance; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400015B")]
	private IntPtr instancePtr; //Field offset: 0x78

	[Token(Token = "0x17000075")]
	public MonoBtlsX509Store CertificateStore
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000074")]
	internal BoringSslCtxHandle Handle
	{
		[Address(RVA = "0x1738950", Offset = "0x1737B50", Length = "0x71")]
		[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Create_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslCtx)}, ReturnType = typeof(BoringSslHandle))]
		[CalledBy(Type = typeof(MonoBtlsSsl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslCtx)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoringSslCtxHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetVerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsVerifyCallback), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetSelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSelectCallback)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetMinVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetMaxVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetCiphers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetServerNameCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsServerNameCallback)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000261")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x1738480", Offset = "0x1737680", Length = "0x4C7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
	[Calls(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600026E")]
	internal MonoBtlsSslCtx(BoringSslCtxHandle handle) { }

	[Address(RVA = "0x17383B0", Offset = "0x17375B0", Length = "0xCA")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600026D")]
	public MonoBtlsSslCtx() { }

	[Address(RVA = "0x1736DB0", Offset = "0x1735FB0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600027D")]
	protected virtual void Close() { }

	[Address(RVA = "0x1736E00", Offset = "0x1736000", Length = "0x42C")]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "NativeSelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBtlsUtils), Member = "FormatName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Name), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000273")]
	private static String[] CopyIssuers(int count, IntPtr sizesPtr, IntPtr dataPtr) { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026F")]
	public MonoBtlsX509Store get_CertificateStore() { }

	[Address(RVA = "0x1738950", Offset = "0x1737B50", Length = "0x71")]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Create_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslCtx)}, ReturnType = typeof(BoringSslHandle))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslCtx)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoringSslCtxHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetVerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsVerifyCallback), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetSelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSelectCallback)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetMinVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetMaxVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetCiphers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetServerNameCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsServerNameCallback)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000261")]
	internal BoringSslCtxHandle get_Handle() { }

	[Address(RVA = "0x17389D0", Offset = "0x1737BD0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000263")]
	private static int mono_btls_ssl_ctx_free(IntPtr handle) { }

	[Address(RVA = "0x1738A50", Offset = "0x1737C50", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000264")]
	private static void mono_btls_ssl_ctx_initialize(IntPtr handle, IntPtr instance) { }

	[Address(RVA = "0x1738AE0", Offset = "0x1737CE0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000262")]
	private static IntPtr mono_btls_ssl_ctx_new() { }

	[Address(RVA = "0x1738B50", Offset = "0x1737D50", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000266")]
	private static void mono_btls_ssl_ctx_set_cert_select_callback(IntPtr handle, IntPtr func) { }

	[Address(RVA = "0x1738BE0", Offset = "0x1737DE0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000265")]
	private static void mono_btls_ssl_ctx_set_cert_verify_callback(IntPtr handle, IntPtr func, int cert_required) { }

	[Address(RVA = "0x1738C80", Offset = "0x1737E80", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000269")]
	private static int mono_btls_ssl_ctx_set_ciphers(IntPtr handle, int count, IntPtr data, int allow_unsupported) { }

	[Address(RVA = "0x1738D20", Offset = "0x1737F20", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600026B")]
	private static int mono_btls_ssl_ctx_set_client_ca_list(IntPtr handle, int count, IntPtr sizes, IntPtr data) { }

	[Address(RVA = "0x1738DC0", Offset = "0x1737FC0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000268")]
	private static void mono_btls_ssl_ctx_set_max_version(IntPtr handle, int version) { }

	[Address(RVA = "0x1738E50", Offset = "0x1738050", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000267")]
	private static void mono_btls_ssl_ctx_set_min_version(IntPtr handle, int version) { }

	[Address(RVA = "0x1738EE0", Offset = "0x17380E0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600026C")]
	private static void mono_btls_ssl_ctx_set_server_name_callback(IntPtr handle, IntPtr func) { }

	[Address(RVA = "0x1738F70", Offset = "0x1738170", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600026A")]
	private static int mono_btls_ssl_ctx_set_verify_param(IntPtr handle, IntPtr param) { }

	[Address(RVA = "0x1737230", Offset = "0x1736430", Length = "0x177")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "CopyIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(NativeSelectFunc))]
	[Token(Token = "0x6000272")]
	private static int NativeSelectCallback(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

	[Address(RVA = "0x17373B0", Offset = "0x17365B0", Length = "0x13B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(NativeServerNameFunc))]
	[Token(Token = "0x600027C")]
	private static int NativeServerNameCallback(IntPtr instance) { }

	[Address(RVA = "0x17374F0", Offset = "0x17366F0", Length = "0x35C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[MonoPInvokeCallback(typeof(NativeVerifyFunc))]
	[Token(Token = "0x6000271")]
	private static int NativeVerifyCallback(IntPtr instance, int preverify_ok, IntPtr store_ctx) { }

	[Address(RVA = "0x1737850", Offset = "0x1736A50", Length = "0x200")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16[]), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000278")]
	public void SetCiphers(Int16[] ciphers, bool allow_unsupported) { }

	[Address(RVA = "0x1737A60", Offset = "0x1736C60", Length = "0x445")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181732180")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr[]), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X500DistinguishedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600027A")]
	public void SetClientCertificateIssuers(String[] acceptableIssuers) { }

	[Address(RVA = "0x1737EB0", Offset = "0x17370B0", Length = "0xA4")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000277")]
	public void SetMaxVersion(int version) { }

	[Address(RVA = "0x1737F60", Offset = "0x1737160", Length = "0xA4")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000276")]
	public void SetMinVersion(int version) { }

	[Address(RVA = "0x1738010", Offset = "0x1737210", Length = "0xBA")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000275")]
	public void SetSelectCallback(MonoBtlsSelectCallback callback) { }

	[Address(RVA = "0x17380D0", Offset = "0x17372D0", Length = "0xBA")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600027B")]
	public void SetServerNameCallback(MonoBtlsServerNameCallback callback) { }

	[Address(RVA = "0x1738190", Offset = "0x1737390", Length = "0xD1")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000274")]
	public void SetVerifyCallback(MonoBtlsVerifyCallback callback, bool client_cert_required) { }

	[Address(RVA = "0x1738270", Offset = "0x1737470", Length = "0x106")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000279")]
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	[Address(RVA = "0x1738380", Offset = "0x1737580", Length = "0x23")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000270")]
	private int VerifyCallback(bool preverify_ok, MonoBtlsX509StoreCtx ctx) { }

}

