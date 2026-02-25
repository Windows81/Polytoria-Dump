namespace Mono.Security.Cryptography;

[Token(Token = "0x200004D")]
public sealed class PKCS1
{
	[Token(Token = "0x4000218")]
	private static Byte[] emptySHA1; //Field offset: 0x0
	[Token(Token = "0x4000219")]
	private static Byte[] emptySHA256; //Field offset: 0x8
	[Token(Token = "0x400021A")]
	private static Byte[] emptySHA384; //Field offset: 0x10
	[Token(Token = "0x400021B")]
	private static Byte[] emptySHA512; //Field offset: 0x18

	[Address(RVA = "0x12CEEC0", Offset = "0x12CE0C0", Length = "0x1A6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001A5")]
	private static PKCS1() { }

	[Address(RVA = "0x12CDC60", Offset = "0x12CCE60", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600019C")]
	private static bool Compare(Byte[] array1, Byte[] array2) { }

	[Address(RVA = "0x12CDCF0", Offset = "0x12CCEF0", Length = "0x555")]
	[CalledBy(Type = typeof(DeriveBytes), Member = "Derive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "get_Hash", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(PKCS1), Member = "CreateFromOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SHA256), Member = "Create", ReturnType = typeof(SHA256))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE620")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
	[Calls(Type = typeof(RIPEMD160), Member = "Create", ReturnType = typeof(RIPEMD160))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SHA384), Member = "Create", ReturnType = typeof(SHA384))]
	[Calls(Type = typeof(SHA512), Member = "Create", ReturnType = typeof(SHA512))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MD5), Member = "Create", ReturnType = typeof(MD5))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A4")]
	internal static HashAlgorithm CreateFromName(string name) { }

	[Address(RVA = "0x12CE250", Offset = "0x12CD450", Length = "0x56")]
	[CalledBy(Type = typeof(X509Crl), Member = "get_Hash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PKCS1), Member = "HashNameFromOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[Token(Token = "0x60001A3")]
	internal static HashAlgorithm CreateFromOid(string oid) { }

	[Address(RVA = "0x12CE2B0", Offset = "0x12CD4B0", Length = "0x348")]
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
	[Token(Token = "0x60001A1")]
	public static Byte[] Encode_v15(HashAlgorithm hash, Byte[] hashValue, int emLength) { }

	[Address(RVA = "0x12CE600", Offset = "0x12CD800", Length = "0x3CC")]
	[CalledBy(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Certificate), Member = "get_Hash", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PKCS1), Member = "CreateFromOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Token(Token = "0x60001A2")]
	internal static string HashNameFromOid(string oid, bool throwOnError = true) { }

	[Address(RVA = "0x12CE9D0", Offset = "0x12CDBD0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600019D")]
	public static Byte[] I2OSP(Byte[] x, int size) { }

	[Address(RVA = "0x12CEA50", Offset = "0x12CDC50", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600019E")]
	public static Byte[] OS2IP(Byte[] x) { }

	[Address(RVA = "0x12CEB20", Offset = "0x12CDD20", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600019F")]
	public static Byte[] RSAVP1(RSA rsa, Byte[] s) { }

	[Address(RVA = "0x12CEB50", Offset = "0x12CDD50", Length = "0x36A")]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PKCS1), Member = "Encode_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashAlgorithm), typeof(Byte[]), typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001A0")]
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, Byte[] hashValue, Byte[] signature, bool tryNonStandardEncoding) { }

}

