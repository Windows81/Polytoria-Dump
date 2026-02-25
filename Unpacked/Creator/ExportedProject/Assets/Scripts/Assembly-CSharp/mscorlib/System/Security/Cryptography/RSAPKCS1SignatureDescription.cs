namespace System.Security.Cryptography;

[Token(Token = "0x200030E")]
internal abstract class RSAPKCS1SignatureDescription : SignatureDescription
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D2E")]
	private string _hashAlgorithm; //Field offset: 0x30

	[Address(RVA = "0x134DA60", Offset = "0x134CC60", Length = "0xC1")]
	[CalledBy(Type = typeof(RSAPKCS1SHA1SignatureDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSAPKCS1SHA256SignatureDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSAPKCS1SHA384SignatureDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSAPKCS1SHA512SignatureDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60018A4")]
	protected RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm) { }

}

