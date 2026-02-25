namespace Mirror.BouncyCastle.Asn1.X509;

[Token(Token = "0x2000221")]
public abstract class X509ObjectIdentifiers
{
	[Token(Token = "0x4000533")]
	public static readonly DerObjectIdentifier CommonName; //Field offset: 0x0
	[Token(Token = "0x4000534")]
	public static readonly DerObjectIdentifier CountryName; //Field offset: 0x8
	[Token(Token = "0x4000535")]
	public static readonly DerObjectIdentifier LocalityName; //Field offset: 0x10
	[Token(Token = "0x4000536")]
	public static readonly DerObjectIdentifier StateOrProvinceName; //Field offset: 0x18
	[Token(Token = "0x4000537")]
	public static readonly DerObjectIdentifier Organization; //Field offset: 0x20
	[Token(Token = "0x4000538")]
	public static readonly DerObjectIdentifier OrganizationalUnitName; //Field offset: 0x28
	[Token(Token = "0x4000539")]
	public static readonly DerObjectIdentifier id_at_telephoneNumber; //Field offset: 0x30
	[Token(Token = "0x400053A")]
	public static readonly DerObjectIdentifier id_at_name; //Field offset: 0x38
	[Token(Token = "0x400053B")]
	public static readonly DerObjectIdentifier id_at_organizationIdentifier; //Field offset: 0x40
	[Token(Token = "0x400053C")]
	public static readonly DerObjectIdentifier IdSha1; //Field offset: 0x48
	[Token(Token = "0x400053D")]
	public static readonly DerObjectIdentifier RipeMD160; //Field offset: 0x50
	[Token(Token = "0x400053E")]
	public static readonly DerObjectIdentifier RipeMD160WithRsaEncryption; //Field offset: 0x58
	[Token(Token = "0x400053F")]
	public static readonly DerObjectIdentifier IdEARsa; //Field offset: 0x60
	[Token(Token = "0x4000540")]
	public static readonly DerObjectIdentifier IdPkix; //Field offset: 0x68
	[Token(Token = "0x4000541")]
	public static readonly DerObjectIdentifier IdPE; //Field offset: 0x70
	[Token(Token = "0x4000542")]
	public static readonly DerObjectIdentifier IdAD; //Field offset: 0x78
	[Token(Token = "0x4000543")]
	public static readonly DerObjectIdentifier IdADCAIssuers; //Field offset: 0x80
	[Token(Token = "0x4000544")]
	public static readonly DerObjectIdentifier IdADOcsp; //Field offset: 0x88
	[Token(Token = "0x4000545")]
	public static readonly DerObjectIdentifier OcspAccessMethod; //Field offset: 0x90
	[Token(Token = "0x4000546")]
	public static readonly DerObjectIdentifier CrlAccessMethod; //Field offset: 0x98

	[Address(RVA = "0x1119830", Offset = "0x1118A30", Length = "0x7F0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerObjectIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600126A")]
	private static X509ObjectIdentifiers() { }

}

