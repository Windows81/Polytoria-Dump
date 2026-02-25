namespace Mirror.BouncyCastle.Asn1.Oiw;

[Token(Token = "0x200025D")]
public abstract class OiwObjectIdentifiers
{
	[Token(Token = "0x400069C")]
	public static readonly DerObjectIdentifier MD4WithRsa; //Field offset: 0x0
	[Token(Token = "0x400069D")]
	public static readonly DerObjectIdentifier MD5WithRsa; //Field offset: 0x8
	[Token(Token = "0x400069E")]
	public static readonly DerObjectIdentifier MD4WithRsaEncryption; //Field offset: 0x10
	[Token(Token = "0x400069F")]
	public static readonly DerObjectIdentifier DesEcb; //Field offset: 0x18
	[Token(Token = "0x40006A0")]
	public static readonly DerObjectIdentifier DesCbc; //Field offset: 0x20
	[Token(Token = "0x40006A1")]
	public static readonly DerObjectIdentifier DesOfb; //Field offset: 0x28
	[Token(Token = "0x40006A2")]
	public static readonly DerObjectIdentifier DesCfb; //Field offset: 0x30
	[Token(Token = "0x40006A3")]
	public static readonly DerObjectIdentifier DesEde; //Field offset: 0x38
	[Token(Token = "0x40006A4")]
	public static readonly DerObjectIdentifier IdSha1; //Field offset: 0x40
	[Token(Token = "0x40006A5")]
	public static readonly DerObjectIdentifier DsaWithSha1; //Field offset: 0x48
	[Token(Token = "0x40006A6")]
	public static readonly DerObjectIdentifier Sha1WithRsa; //Field offset: 0x50
	[Token(Token = "0x40006A7")]
	public static readonly DerObjectIdentifier ElGamalAlgorithm; //Field offset: 0x58

	[Address(RVA = "0x112AD60", Offset = "0x1129F60", Length = "0x45E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerObjectIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001362")]
	private static OiwObjectIdentifiers() { }

}

