namespace Mono.Security.Cryptography;

[Token(Token = "0x2000069")]
internal sealed class PKCS1
{
	[Token(Token = "0x40001F7")]
	private static Byte[] emptySHA1; //Field offset: 0x0
	[Token(Token = "0x40001F8")]
	private static Byte[] emptySHA256; //Field offset: 0x8
	[Token(Token = "0x40001F9")]
	private static Byte[] emptySHA384; //Field offset: 0x10
	[Token(Token = "0x40001FA")]
	private static Byte[] emptySHA512; //Field offset: 0x18

	[Address(RVA = "0x12F7450", Offset = "0x12F6650", Length = "0x1A6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600018D")]
	private static PKCS1() { }

	[Address(RVA = "0x12CDC60", Offset = "0x12CCE60", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000184")]
	private static bool Compare(Byte[] array1, Byte[] array2) { }

	[Address(RVA = "0x12F63E0", Offset = "0x12F55E0", Length = "0x6A0")]
	[CalledBy(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA), typeof(string), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MD5), Member = "Create", ReturnType = typeof(MD5))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE620")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
	[Calls(Type = typeof(RIPEMD160), Member = "Create", ReturnType = typeof(RIPEMD160))]
	[Calls(Type = typeof(SHA256), Member = "Create", ReturnType = typeof(SHA256))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SHA384), Member = "Create", ReturnType = typeof(SHA384))]
	[Calls(Type = typeof(SHA512), Member = "Create", ReturnType = typeof(SHA512))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600018C")]
	internal static HashAlgorithm CreateFromName(string name) { }

	[Address(RVA = "0x12F6A90", Offset = "0x12F5C90", Length = "0x348")]
	[CalledBy(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA), typeof(HashAlgorithm), typeof(Byte[]), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptoConfig), Member = "EncodeOID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptoConfig), Member = "MapNameToOID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600018B")]
	public static Byte[] Encode_v15(HashAlgorithm hash, Byte[] hashValue, int emLength) { }

	[Address(RVA = "0x12F6DE0", Offset = "0x12F5FE0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000185")]
	public static Byte[] I2OSP(Byte[] x, int size) { }

	[Address(RVA = "0x12F6E60", Offset = "0x12F6060", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000186")]
	public static Byte[] OS2IP(Byte[] x) { }

	[Address(RVA = "0x12CEB20", Offset = "0x12CDD20", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000187")]
	public static Byte[] RSAVP1(RSA rsa, Byte[] s) { }

	[Address(RVA = "0x12F73C0", Offset = "0x12F65C0", Length = "0x85")]
	[CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA), typeof(HashAlgorithm), typeof(Byte[]), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000188")]
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, Byte[] hashValue, Byte[] signature) { }

	[Address(RVA = "0x12F72A0", Offset = "0x12F64A0", Length = "0x117")]
	[CalledBy(Type = typeof(RSAPKCS1SignatureDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[Calls(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA), typeof(HashAlgorithm), typeof(Byte[]), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000189")]
	internal static bool Verify_v15(RSA rsa, string hashName, Byte[] hashValue, Byte[] signature) { }

	[Address(RVA = "0x12F6F30", Offset = "0x12F6130", Length = "0x36A")]
	[CalledBy(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA), typeof(HashAlgorithm), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA), typeof(string), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PKCS1), Member = "Encode_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashAlgorithm), typeof(Byte[]), typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600018A")]
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, Byte[] hashValue, Byte[] signature, bool tryNonStandardEncoding) { }

}

