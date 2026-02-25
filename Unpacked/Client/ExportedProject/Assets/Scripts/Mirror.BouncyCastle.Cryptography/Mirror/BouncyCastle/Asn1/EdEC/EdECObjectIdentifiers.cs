namespace Mirror.BouncyCastle.Asn1.EdEC;

[Token(Token = "0x2000265")]
public abstract class EdECObjectIdentifiers
{
	[Token(Token = "0x4000779")]
	public static readonly DerObjectIdentifier id_edwards_curve_algs; //Field offset: 0x0
	[Token(Token = "0x400077A")]
	public static readonly DerObjectIdentifier id_X25519; //Field offset: 0x8
	[Token(Token = "0x400077B")]
	public static readonly DerObjectIdentifier id_X448; //Field offset: 0x10
	[Token(Token = "0x400077C")]
	public static readonly DerObjectIdentifier id_Ed25519; //Field offset: 0x18
	[Token(Token = "0x400077D")]
	public static readonly DerObjectIdentifier id_Ed448; //Field offset: 0x20

	[Address(RVA = "0x1122270", Offset = "0x1121470", Length = "0x238")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerObjectIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6001376")]
	private static EdECObjectIdentifiers() { }

}

