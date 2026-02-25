namespace Mirror.BouncyCastle.Math.EC.Endo;

[Token(Token = "0x200007F")]
public class ScalarSplitParameters
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400012A")]
	protected readonly BigInteger m_v1A; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400012B")]
	protected readonly BigInteger m_v1B; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400012C")]
	protected readonly BigInteger m_v2A; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400012D")]
	protected readonly BigInteger m_v2B; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400012E")]
	protected readonly BigInteger m_g1; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400012F")]
	protected readonly BigInteger m_g2; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000130")]
	protected readonly int m_bits; //Field offset: 0x40

	[Token(Token = "0x17000061")]
	public override int Bits
	{
		[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000474")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700005F")]
	public override BigInteger G1
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000472")]
		 get { } //Length: 95
	}

	[Token(Token = "0x17000060")]
	public override BigInteger G2
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000473")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005B")]
	public override BigInteger V1A
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600046E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005C")]
	public override BigInteger V1B
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600046F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005D")]
	public override BigInteger V2A
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000470")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005E")]
	public override BigInteger V2B
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000471")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x115D520", Offset = "0x115C720", Length = "0x1FB")]
	[CalledBy(Type = typeof(Secp256k1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Secp192k1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Secp160k1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(SecP256K1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Secp224k1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(SecP192K1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(SecP160K1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(SecP224K1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600046D")]
	public ScalarSplitParameters(BigInteger[] v1, BigInteger[] v2, BigInteger g1, BigInteger g2, int bits) { }

	[Address(RVA = "0x115D4A0", Offset = "0x115C6A0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600046C")]
	private static void CheckVector(BigInteger[] v, string name) { }

	[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000474")]
	public override int get_Bits() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000472")]
	public override BigInteger get_G1() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000473")]
	public override BigInteger get_G2() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600046E")]
	public override BigInteger get_V1A() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600046F")]
	public override BigInteger get_V1B() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000470")]
	public override BigInteger get_V2A() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000471")]
	public override BigInteger get_V2B() { }

}

