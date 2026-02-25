namespace Mirror.BouncyCastle.Asn1.TeleTrust;

[Token(Token = "0x2000232")]
public sealed class TeleTrusTObjectIdentifiers
{
	[Token(Token = "0x400057F")]
	public static readonly DerObjectIdentifier TeleTrusTAlgorithm; //Field offset: 0x0
	[Token(Token = "0x4000580")]
	public static readonly DerObjectIdentifier RipeMD160; //Field offset: 0x8
	[Token(Token = "0x4000581")]
	public static readonly DerObjectIdentifier RipeMD128; //Field offset: 0x10
	[Token(Token = "0x4000582")]
	public static readonly DerObjectIdentifier RipeMD256; //Field offset: 0x18
	[Token(Token = "0x4000583")]
	public static readonly DerObjectIdentifier TeleTrusTRsaSignatureAlgorithm; //Field offset: 0x20
	[Token(Token = "0x4000584")]
	public static readonly DerObjectIdentifier RsaSignatureWithRipeMD160; //Field offset: 0x28
	[Token(Token = "0x4000585")]
	public static readonly DerObjectIdentifier RsaSignatureWithRipeMD128; //Field offset: 0x30
	[Token(Token = "0x4000586")]
	public static readonly DerObjectIdentifier RsaSignatureWithRipeMD256; //Field offset: 0x38
	[Token(Token = "0x4000587")]
	public static readonly DerObjectIdentifier ECSign; //Field offset: 0x40
	[Token(Token = "0x4000588")]
	public static readonly DerObjectIdentifier ECSignWithSha1; //Field offset: 0x48
	[Token(Token = "0x4000589")]
	public static readonly DerObjectIdentifier ECSignWithRipeMD160; //Field offset: 0x50
	[Token(Token = "0x400058A")]
	public static readonly DerObjectIdentifier EccBrainpool; //Field offset: 0x58
	[Token(Token = "0x400058B")]
	public static readonly DerObjectIdentifier EllipticCurve; //Field offset: 0x60
	[Token(Token = "0x400058C")]
	public static readonly DerObjectIdentifier VersionOne; //Field offset: 0x68
	[Token(Token = "0x400058D")]
	public static readonly DerObjectIdentifier BrainpoolP160R1; //Field offset: 0x70
	[Token(Token = "0x400058E")]
	public static readonly DerObjectIdentifier BrainpoolP160T1; //Field offset: 0x78
	[Token(Token = "0x400058F")]
	public static readonly DerObjectIdentifier BrainpoolP192R1; //Field offset: 0x80
	[Token(Token = "0x4000590")]
	public static readonly DerObjectIdentifier BrainpoolP192T1; //Field offset: 0x88
	[Token(Token = "0x4000591")]
	public static readonly DerObjectIdentifier BrainpoolP224R1; //Field offset: 0x90
	[Token(Token = "0x4000592")]
	public static readonly DerObjectIdentifier BrainpoolP224T1; //Field offset: 0x98
	[Token(Token = "0x4000593")]
	public static readonly DerObjectIdentifier BrainpoolP256R1; //Field offset: 0xA0
	[Token(Token = "0x4000594")]
	public static readonly DerObjectIdentifier BrainpoolP256T1; //Field offset: 0xA8
	[Token(Token = "0x4000595")]
	public static readonly DerObjectIdentifier BrainpoolP320R1; //Field offset: 0xB0
	[Token(Token = "0x4000596")]
	public static readonly DerObjectIdentifier BrainpoolP320T1; //Field offset: 0xB8
	[Token(Token = "0x4000597")]
	public static readonly DerObjectIdentifier BrainpoolP384R1; //Field offset: 0xC0
	[Token(Token = "0x4000598")]
	public static readonly DerObjectIdentifier BrainpoolP384T1; //Field offset: 0xC8
	[Token(Token = "0x4000599")]
	public static readonly DerObjectIdentifier BrainpoolP512R1; //Field offset: 0xD0
	[Token(Token = "0x400059A")]
	public static readonly DerObjectIdentifier BrainpoolP512T1; //Field offset: 0xD8

	[Address(RVA = "0x1117590", Offset = "0x1116790", Length = "0x10AC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerObjectIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 27)]
	[Token(Token = "0x60012AB")]
	private static TeleTrusTObjectIdentifiers() { }

}

