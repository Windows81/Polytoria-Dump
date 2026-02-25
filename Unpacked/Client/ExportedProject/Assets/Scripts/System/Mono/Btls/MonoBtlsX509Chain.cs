namespace Mono.Btls;

[Token(Token = "0x2000090")]
internal class MonoBtlsX509Chain : MonoBtlsObject
{
	[Token(Token = "0x2000091")]
	public class BoringX509ChainHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x1732310", Offset = "0x1731510", Length = "0xB")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60002AC")]
		public BoringX509ChainHandle(IntPtr handle) { }

		[Address(RVA = "0x17323B0", Offset = "0x17315B0", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60002AD")]
		protected virtual bool ReleaseHandle() { }

	}


	[Token(Token = "0x17000078")]
	public int Count
	{
		[Address(RVA = "0x173C510", Offset = "0x173B710", Length = "0x91")]
		[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
		[CalledBy(Type = typeof(X509ChainImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509ChainImplBtls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Handle", ReturnType = typeof(BoringX509ChainHandle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60002A8")]
		 get { } //Length: 145
	}

	[Token(Token = "0x17000077")]
	internal BoringX509ChainHandle Handle
	{
		[Address(RVA = "0x173C5B0", Offset = "0x173B7B0", Length = "0x71")]
		[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "get_Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
		[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "Copy", ReturnType = typeof(MonoBtlsX509Chain))]
		[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509Chain)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509ChainImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600029F")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x173C440", Offset = "0x173B640", Length = "0xCA")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A6")]
	public MonoBtlsX509Chain() { }

	[Address(RVA = "0x928660", Offset = "0x927860", Length = "0x4C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002A7")]
	internal MonoBtlsX509Chain(BoringX509ChainHandle handle) { }

	[Address(RVA = "0x173C0C0", Offset = "0x173B2C0", Length = "0xB9")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "Verify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Handle", ReturnType = typeof(BoringX509ChainHandle))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002AA")]
	public void AddCertificate(MonoBtlsX509 x509) { }

	[Address(RVA = "0x173C180", Offset = "0x173B380", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Handle", ReturnType = typeof(BoringX509ChainHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002AB")]
	internal MonoBtlsX509Chain Copy() { }

	[Address(RVA = "0x173C510", Offset = "0x173B710", Length = "0x91")]
	[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Handle", ReturnType = typeof(BoringX509ChainHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A8")]
	public int get_Count() { }

	[Address(RVA = "0x173C5B0", Offset = "0x173B7B0", Length = "0x71")]
	[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
	[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "Copy", ReturnType = typeof(MonoBtlsX509Chain))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509Chain)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600029F")]
	internal BoringX509ChainHandle get_Handle() { }

	[Address(RVA = "0x173C2B0", Offset = "0x173B4B0", Length = "0x185")]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Handle", ReturnType = typeof(BoringX509ChainHandle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002A9")]
	public MonoBtlsX509 GetCertificate(int index) { }

	[Address(RVA = "0x173C630", Offset = "0x173B830", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A3")]
	private static int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509) { }

	[Address(RVA = "0x173C6C0", Offset = "0x173B8C0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A5")]
	private static void mono_btls_x509_chain_free(IntPtr handle) { }

	[Address(RVA = "0x173C740", Offset = "0x173B940", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A2")]
	private static IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index) { }

	[Address(RVA = "0x173C7D0", Offset = "0x173B9D0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A1")]
	private static int mono_btls_x509_chain_get_count(IntPtr handle) { }

	[Address(RVA = "0x173C850", Offset = "0x173BA50", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A0")]
	private static IntPtr mono_btls_x509_chain_new() { }

	[Address(RVA = "0x173C8C0", Offset = "0x173BAC0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A4")]
	private static IntPtr mono_btls_x509_chain_up_ref(IntPtr handle) { }

}

