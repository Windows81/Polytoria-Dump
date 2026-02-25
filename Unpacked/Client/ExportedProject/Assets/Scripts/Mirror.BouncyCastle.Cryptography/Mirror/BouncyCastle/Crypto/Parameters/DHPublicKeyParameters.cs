namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000125")]
public class DHPublicKeyParameters : DHKeyParameters
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000252")]
	private readonly BigInteger m_y; //Field offset: 0x28

	[Token(Token = "0x17000150")]
	public override BigInteger Y
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B88")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x11E0CF0", Offset = "0x11DFEF0", Length = "0xC6")]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubjectPublicKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DHPublicKeyParameters), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(DHParameters)}, ReturnType = typeof(BigInteger))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B86")]
	public DHPublicKeyParameters(BigInteger y, DHParameters parameters) { }

	[Address(RVA = "0x11E0C70", Offset = "0x11DFE70", Length = "0x7D")]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "ReadPkcsDHParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier), typeof(BigInteger), typeof(Asn1Sequence)}, ReturnType = typeof(DHPublicKeyParameters))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DHPublicKeyParameters), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(DHParameters)}, ReturnType = typeof(BigInteger))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B87")]
	public DHPublicKeyParameters(BigInteger y, DHParameters parameters, DerObjectIdentifier algorithmOid) { }

	[Address(RVA = "0x11E06D0", Offset = "0x11DF8D0", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B89")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11E0550", Offset = "0x11DF750", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B8A")]
	protected bool Equals(DHPublicKeyParameters other) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B88")]
	public override BigInteger get_Y() { }

	[Address(RVA = "0x11E05C0", Offset = "0x11DF7C0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B8B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x11E07A0", Offset = "0x11DF9A0", Length = "0x1FD")]
	[CalledBy(Type = typeof(DHPublicKeyParameters), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(DHParameters)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nat), Member = "ShiftDownWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Nat), Member = "IsOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nat), Member = "Sub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Nat), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Nat), Member = "ShiftDownBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(int), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Integers), Member = "NumberOfTrailingZeros", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Nat), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BigInteger)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(Nat), Member = "GetLengthForBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000B8C")]
	private static int Legendre(BigInteger a, BigInteger b) { }

	[Address(RVA = "0x11E09A0", Offset = "0x11DFBA0", Length = "0x2CA")]
	[CalledBy(Type = typeof(DHPublicKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(DHParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DHPublicKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(DHParameters), typeof(DerObjectIdentifier)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(BigInteger), Member = "ModPow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(DHPublicKeyParameters), Member = "Legendre", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "ShiftRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Token(Token = "0x6000B85")]
	private static BigInteger Validate(BigInteger y, DHParameters dhParams) { }

}

