namespace Mirror.BouncyCastle.Asn1.Misc;

[Token(Token = "0x200025F")]
public abstract class MiscObjectIdentifiers
{
	[Token(Token = "0x40006EC")]
	public static readonly DerObjectIdentifier Netscape; //Field offset: 0x0
	[Token(Token = "0x40006ED")]
	public static readonly DerObjectIdentifier NetscapeCertType; //Field offset: 0x8
	[Token(Token = "0x40006EE")]
	public static readonly DerObjectIdentifier NetscapeBaseUrl; //Field offset: 0x10
	[Token(Token = "0x40006EF")]
	public static readonly DerObjectIdentifier NetscapeRevocationUrl; //Field offset: 0x18
	[Token(Token = "0x40006F0")]
	public static readonly DerObjectIdentifier NetscapeCARevocationUrl; //Field offset: 0x20
	[Token(Token = "0x40006F1")]
	public static readonly DerObjectIdentifier NetscapeRenewalUrl; //Field offset: 0x28
	[Token(Token = "0x40006F2")]
	public static readonly DerObjectIdentifier NetscapeCAPolicyUrl; //Field offset: 0x30
	[Token(Token = "0x40006F3")]
	public static readonly DerObjectIdentifier NetscapeSslServerName; //Field offset: 0x38
	[Token(Token = "0x40006F4")]
	public static readonly DerObjectIdentifier NetscapeCertComment; //Field offset: 0x40
	[Token(Token = "0x40006F5")]
	public static readonly DerObjectIdentifier Verisign; //Field offset: 0x48
	[Token(Token = "0x40006F6")]
	public static readonly DerObjectIdentifier VerisignCzagExtension; //Field offset: 0x50
	[Token(Token = "0x40006F7")]
	public static readonly DerObjectIdentifier VerisignPrivate_6_9; //Field offset: 0x58
	[Token(Token = "0x40006F8")]
	public static readonly DerObjectIdentifier VerisignOnSiteJurisdictionHash; //Field offset: 0x60
	[Token(Token = "0x40006F9")]
	public static readonly DerObjectIdentifier VerisignBitString_6_13; //Field offset: 0x68
	[Token(Token = "0x40006FA")]
	public static readonly DerObjectIdentifier VerisignDnbDunsNumber; //Field offset: 0x70
	[Token(Token = "0x40006FB")]
	public static readonly DerObjectIdentifier VerisignIssStrongCrypto; //Field offset: 0x78
	[Token(Token = "0x40006FC")]
	public static readonly DerObjectIdentifier Novell; //Field offset: 0x80
	[Token(Token = "0x40006FD")]
	public static readonly DerObjectIdentifier NovellSecurityAttribs; //Field offset: 0x88
	[Token(Token = "0x40006FE")]
	public static readonly DerObjectIdentifier Entrust; //Field offset: 0x90
	[Token(Token = "0x40006FF")]
	public static readonly DerObjectIdentifier EntrustVersionExtension; //Field offset: 0x98
	[Token(Token = "0x4000700")]
	public static readonly DerObjectIdentifier cast5CBC; //Field offset: 0xA0
	[Token(Token = "0x4000701")]
	public static readonly DerObjectIdentifier HMAC_SHA1; //Field offset: 0xA8
	[Token(Token = "0x4000702")]
	public static readonly DerObjectIdentifier as_sys_sec_alg_ideaCBC; //Field offset: 0xB0
	[Token(Token = "0x4000703")]
	public static readonly DerObjectIdentifier cryptlib; //Field offset: 0xB8
	[Token(Token = "0x4000704")]
	public static readonly DerObjectIdentifier cryptlib_algorithm; //Field offset: 0xC0
	[Token(Token = "0x4000705")]
	public static readonly DerObjectIdentifier cryptlib_algorithm_blowfish_ECB; //Field offset: 0xC8
	[Token(Token = "0x4000706")]
	public static readonly DerObjectIdentifier cryptlib_algorithm_blowfish_CBC; //Field offset: 0xD0
	[Token(Token = "0x4000707")]
	public static readonly DerObjectIdentifier cryptlib_algorithm_blowfish_CFB; //Field offset: 0xD8
	[Token(Token = "0x4000708")]
	public static readonly DerObjectIdentifier cryptlib_algorithm_blowfish_OFB; //Field offset: 0xE0
	[Token(Token = "0x4000709")]
	public static readonly DerObjectIdentifier blake2; //Field offset: 0xE8
	[Token(Token = "0x400070A")]
	public static readonly DerObjectIdentifier id_blake2b160; //Field offset: 0xF0
	[Token(Token = "0x400070B")]
	public static readonly DerObjectIdentifier id_blake2b256; //Field offset: 0xF8
	[Token(Token = "0x400070C")]
	public static readonly DerObjectIdentifier id_blake2b384; //Field offset: 0x100
	[Token(Token = "0x400070D")]
	public static readonly DerObjectIdentifier id_blake2b512; //Field offset: 0x108
	[Token(Token = "0x400070E")]
	public static readonly DerObjectIdentifier id_blake2s128; //Field offset: 0x110
	[Token(Token = "0x400070F")]
	public static readonly DerObjectIdentifier id_blake2s160; //Field offset: 0x118
	[Token(Token = "0x4000710")]
	public static readonly DerObjectIdentifier id_blake2s224; //Field offset: 0x120
	[Token(Token = "0x4000711")]
	public static readonly DerObjectIdentifier id_blake2s256; //Field offset: 0x128
	[Token(Token = "0x4000712")]
	public static readonly DerObjectIdentifier blake3; //Field offset: 0x130
	[Token(Token = "0x4000713")]
	public static readonly DerObjectIdentifier blake3_256; //Field offset: 0x138
	[Token(Token = "0x4000714")]
	public static readonly DerObjectIdentifier id_scrypt; //Field offset: 0x140
	[Token(Token = "0x4000715")]
	public static readonly DerObjectIdentifier id_alg_composite; //Field offset: 0x148
	[Token(Token = "0x4000716")]
	public static readonly DerObjectIdentifier id_composite_key; //Field offset: 0x150
	[Token(Token = "0x4000717")]
	public static readonly DerObjectIdentifier id_oracle_pkcs12_trusted_key_usage; //Field offset: 0x158

	[Address(RVA = "0x1127D60", Offset = "0x1126F60", Length = "0x12B2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerObjectIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 32)]
	[Token(Token = "0x6001364")]
	private static MiscObjectIdentifiers() { }

}

