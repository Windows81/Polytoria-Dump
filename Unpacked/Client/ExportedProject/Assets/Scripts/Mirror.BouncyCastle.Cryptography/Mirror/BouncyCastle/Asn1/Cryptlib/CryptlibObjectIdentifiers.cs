namespace Mirror.BouncyCastle.Asn1.Cryptlib;

[Token(Token = "0x2000272")]
internal static class CryptlibObjectIdentifiers
{
	[Token(Token = "0x40007B5")]
	internal static readonly DerObjectIdentifier cryptlib; //Field offset: 0x0
	[Token(Token = "0x40007B6")]
	internal static readonly DerObjectIdentifier ecc; //Field offset: 0x8
	[Token(Token = "0x40007B7")]
	internal static readonly DerObjectIdentifier curvey25519; //Field offset: 0x10

	[Address(RVA = "0x1120450", Offset = "0x111F650", Length = "0x161")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerObjectIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60013AB")]
	private static CryptlibObjectIdentifiers() { }

}

