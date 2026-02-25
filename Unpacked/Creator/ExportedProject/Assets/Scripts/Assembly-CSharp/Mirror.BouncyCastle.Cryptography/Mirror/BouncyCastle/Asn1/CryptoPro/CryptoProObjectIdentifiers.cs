namespace Mirror.BouncyCastle.Asn1.CryptoPro;

[Token(Token = "0x2000266")]
public abstract class CryptoProObjectIdentifiers
{
	[Token(Token = "0x400077E")]
	public static readonly DerObjectIdentifier GOST_id; //Field offset: 0x0
	[Token(Token = "0x400077F")]
	public static readonly DerObjectIdentifier GostR3411; //Field offset: 0x8
	[Token(Token = "0x4000780")]
	public static readonly DerObjectIdentifier GostR3411Hmac; //Field offset: 0x10
	[Token(Token = "0x4000781")]
	public static readonly DerObjectIdentifier id_Gost28147_89_None_KeyWrap; //Field offset: 0x18
	[Token(Token = "0x4000782")]
	public static readonly DerObjectIdentifier id_Gost28147_89_CryptoPro_KeyWrap; //Field offset: 0x20
	[Token(Token = "0x4000783")]
	public static readonly DerObjectIdentifier GostR28147Gcfb; //Field offset: 0x28
	[Obsolete("Use 'GostR28147Gcfb' instead")]
	[Token(Token = "0x4000784")]
	public static readonly DerObjectIdentifier GostR28147Cbc; //Field offset: 0x30
	[Token(Token = "0x4000785")]
	public static readonly DerObjectIdentifier ID_Gost28147_89_CryptoPro_TestParamSet; //Field offset: 0x38
	[Token(Token = "0x4000786")]
	public static readonly DerObjectIdentifier ID_Gost28147_89_CryptoPro_A_ParamSet; //Field offset: 0x40
	[Token(Token = "0x4000787")]
	public static readonly DerObjectIdentifier ID_Gost28147_89_CryptoPro_B_ParamSet; //Field offset: 0x48
	[Token(Token = "0x4000788")]
	public static readonly DerObjectIdentifier ID_Gost28147_89_CryptoPro_C_ParamSet; //Field offset: 0x50
	[Token(Token = "0x4000789")]
	public static readonly DerObjectIdentifier ID_Gost28147_89_CryptoPro_D_ParamSet; //Field offset: 0x58
	[Token(Token = "0x400078A")]
	public static readonly DerObjectIdentifier GostR3410x94; //Field offset: 0x60
	[Token(Token = "0x400078B")]
	public static readonly DerObjectIdentifier GostR3410x2001; //Field offset: 0x68
	[Token(Token = "0x400078C")]
	public static readonly DerObjectIdentifier GostR3411x94WithGostR3410x94; //Field offset: 0x70
	[Token(Token = "0x400078D")]
	public static readonly DerObjectIdentifier GostR3411x94WithGostR3410x2001; //Field offset: 0x78
	[Token(Token = "0x400078E")]
	public static readonly DerObjectIdentifier GostR3411x94CryptoProParamSet; //Field offset: 0x80
	[Token(Token = "0x400078F")]
	public static readonly DerObjectIdentifier GostR3410x94CryptoProA; //Field offset: 0x88
	[Token(Token = "0x4000790")]
	public static readonly DerObjectIdentifier GostR3410x94CryptoProB; //Field offset: 0x90
	[Token(Token = "0x4000791")]
	public static readonly DerObjectIdentifier GostR3410x94CryptoProC; //Field offset: 0x98
	[Token(Token = "0x4000792")]
	public static readonly DerObjectIdentifier GostR3410x94CryptoProD; //Field offset: 0xA0
	[Token(Token = "0x4000793")]
	public static readonly DerObjectIdentifier GostR3410x94CryptoProXchA; //Field offset: 0xA8
	[Token(Token = "0x4000794")]
	public static readonly DerObjectIdentifier GostR3410x94CryptoProXchB; //Field offset: 0xB0
	[Token(Token = "0x4000795")]
	public static readonly DerObjectIdentifier GostR3410x94CryptoProXchC; //Field offset: 0xB8
	[Token(Token = "0x4000796")]
	public static readonly DerObjectIdentifier GostR3410x2001CryptoProA; //Field offset: 0xC0
	[Token(Token = "0x4000797")]
	public static readonly DerObjectIdentifier GostR3410x2001CryptoProB; //Field offset: 0xC8
	[Token(Token = "0x4000798")]
	public static readonly DerObjectIdentifier GostR3410x2001CryptoProC; //Field offset: 0xD0
	[Token(Token = "0x4000799")]
	public static readonly DerObjectIdentifier GostR3410x2001CryptoProXchA; //Field offset: 0xD8
	[Token(Token = "0x400079A")]
	public static readonly DerObjectIdentifier GostR3410x2001CryptoProXchB; //Field offset: 0xE0
	[Obsolete("Erroneous; will be removed")]
	[Token(Token = "0x400079B")]
	public static readonly DerObjectIdentifier GostElSgDH3410Default; //Field offset: 0xE8
	[Obsolete("Erroneous; will be removed")]
	[Token(Token = "0x400079C")]
	public static readonly DerObjectIdentifier GostElSgDH3410x1; //Field offset: 0xF0
	[Token(Token = "0x400079D")]
	public static readonly DerObjectIdentifier GostR3410x2001CryptoProESDH; //Field offset: 0xF8
	[Token(Token = "0x400079E")]
	public static readonly DerObjectIdentifier GostR3410x2001DH; //Field offset: 0x100

	[Address(RVA = "0x11205C0", Offset = "0x111F7C0", Length = "0xE18")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerObjectIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 31)]
	[Token(Token = "0x6001377")]
	private static CryptoProObjectIdentifiers() { }

}

