namespace Mono.Btls;

[Token(Token = "0x2000078")]
internal class MonoBtlsKey : MonoBtlsObject
{
	[Token(Token = "0x2000079")]
	public class BoringKeyHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x15ED8C0", Offset = "0x15ECAC0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E9")]
		internal BoringKeyHandle(IntPtr handle) { }

		[Address(RVA = "0x15ED8D0", Offset = "0x15ECAD0", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001EA")]
		protected virtual bool ReleaseHandle() { }

	}


	[Token(Token = "0x17000065")]
	internal BoringKeyHandle Handle
	{
		[Address(RVA = "0x15F6E20", Offset = "0x15F6020", Length = "0x75")]
		[CalledBy(Type = typeof(MonoBtlsKey), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(MonoBtlsKey), Member = "Copy", ReturnType = typeof(MonoBtlsKey))]
		[CalledBy(Type = typeof(MonoBtlsKey), Member = "CreateFromRSAPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(MonoBtlsKey))]
		[CalledBy(Type = typeof(MonoBtlsSsl), Member = "SetPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsKey)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60001E4")]
		internal get { } //Length: 117
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E5")]
	internal MonoBtlsKey(BoringKeyHandle handle) { }

	[Address(RVA = "0x15F6900", Offset = "0x15F5B00", Length = "0x143")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "Clone", ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsKey), Member = "get_Handle", ReturnType = typeof(BoringKeyHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001E7")]
	public MonoBtlsKey Copy() { }

	[Address(RVA = "0x15F6A50", Offset = "0x15F5C50", Length = "0x1F9")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "set_PrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PrivateKeyInfo), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBtlsKey), Member = "get_Handle", ReturnType = typeof(BoringKeyHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001E8")]
	public static MonoBtlsKey CreateFromRSAPrivateKey(RSA privateKey) { }

	[Address(RVA = "0x15F6E20", Offset = "0x15F6020", Length = "0x75")]
	[CalledBy(Type = typeof(MonoBtlsKey), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(MonoBtlsKey), Member = "Copy", ReturnType = typeof(MonoBtlsKey))]
	[CalledBy(Type = typeof(MonoBtlsKey), Member = "CreateFromRSAPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(MonoBtlsKey))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "SetPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsKey)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60001E4")]
	internal BoringKeyHandle get_Handle() { }

	[Address(RVA = "0x15F6C50", Offset = "0x15F5E50", Length = "0x1C3")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "GetRSAPrivateKey", ReturnType = typeof(RSA))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsKey), Member = "get_Handle", ReturnType = typeof(BoringKeyHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001E6")]
	public Byte[] GetBytes(bool include_private_bits) { }

	[Address(RVA = "0x15F6EA0", Offset = "0x15F60A0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E3")]
	private static int mono_btls_key_assign_rsa_private_key(IntPtr handle, Byte[] der, int der_length) { }

	[Address(RVA = "0x15F6F50", Offset = "0x15F6150", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E0")]
	private static void mono_btls_key_free(IntPtr handle) { }

	[Address(RVA = "0x15F6FD0", Offset = "0x15F61D0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E2")]
	private static int mono_btls_key_get_bytes(IntPtr handle, out IntPtr data, out int size, int include_private_bits) { }

	[Address(RVA = "0x15F7080", Offset = "0x15F6280", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DF")]
	private static IntPtr mono_btls_key_new() { }

	[Address(RVA = "0x15F70F0", Offset = "0x15F62F0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E1")]
	private static IntPtr mono_btls_key_up_ref(IntPtr handle) { }

}

