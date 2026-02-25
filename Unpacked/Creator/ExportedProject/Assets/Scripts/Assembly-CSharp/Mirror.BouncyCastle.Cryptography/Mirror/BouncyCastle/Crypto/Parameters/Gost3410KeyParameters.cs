namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x200013C")]
public abstract class Gost3410KeyParameters : AsymmetricKeyParameter
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000282")]
	private readonly Gost3410Parameters parameters; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000283")]
	private readonly DerObjectIdentifier publicKeyParamSet; //Field offset: 0x20

	[Token(Token = "0x1700016C")]
	public Gost3410Parameters Parameters
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C10")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700016D")]
	public DerObjectIdentifier PublicKeyParamSet
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C11")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x11ED3D0", Offset = "0x11EC5D0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gost3410KeyParameters), Member = "LookupParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(Gost3410Parameters))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C0F")]
	protected Gost3410KeyParameters(bool isPrivate, DerObjectIdentifier publicKeyParamSet) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C10")]
	public Gost3410Parameters get_Parameters() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C11")]
	public DerObjectIdentifier get_PublicKeyParamSet() { }

	[Address(RVA = "0x11ED120", Offset = "0x11EC320", Length = "0x2A8")]
	[CalledBy(Type = typeof(Gost3410KeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DerObjectIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3410PrivateKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(DerObjectIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3410PublicKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(DerObjectIdentifier)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Gost3410NamedParameters), Member = "GetByOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(Gost3410ParamSetParameters))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3410ParamSetParameters), Member = "get_Q", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(Gost3410ParamSetParameters), Member = "get_A", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000C12")]
	private static Gost3410Parameters LookupParameters(DerObjectIdentifier publicKeyParamSet) { }

}

