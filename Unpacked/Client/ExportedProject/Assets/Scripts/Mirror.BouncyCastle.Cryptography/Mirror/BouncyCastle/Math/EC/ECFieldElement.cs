namespace Mirror.BouncyCastle.Math.EC;

[Token(Token = "0x2000042")]
public abstract class ECFieldElement
{

	[Token(Token = "0x17000030")]
	public override int BitLength
	{
		[Address(RVA = "0x113DD00", Offset = "0x113CF00", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000299")]
		 get { } //Length: 47
	}

	[Token(Token = "0x1700002F")]
	public abstract int FieldSize
	{
		[Token(Token = "0x600028F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000031")]
	public override bool IsOne
	{
		[Address(RVA = "0x113DD30", Offset = "0x113CF30", Length = "0x22")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600029A")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000032")]
	public override bool IsZero
	{
		[Address(RVA = "0x113DD60", Offset = "0x113CF60", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600029B")]
		 get { } //Length: 45
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002A8")]
	protected ECFieldElement() { }

	[Token(Token = "0x6000290")]
	public abstract ECFieldElement Add(ECFieldElement b) { }

	[Token(Token = "0x6000291")]
	public abstract ECFieldElement AddOne() { }

	[Token(Token = "0x6000294")]
	public abstract ECFieldElement Divide(ECFieldElement b) { }

	[Address(RVA = "0x113D7F0", Offset = "0x113C9F0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigIntegers), Member = "AsUnsignedByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002A7")]
	public override void EncodeTo(Byte[] buf, int off) { }

	[Address(RVA = "0x113D930", Offset = "0x113CB30", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002A2")]
	public override bool Equals(ECFieldElement other) { }

	[Address(RVA = "0x113D8A0", Offset = "0x113CAA0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A1")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x113DD00", Offset = "0x113CF00", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000299")]
	public override int get_BitLength() { }

	[Token(Token = "0x600028F")]
	public abstract int get_FieldSize() { }

	[Address(RVA = "0x113DD30", Offset = "0x113CF30", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600029A")]
	public override bool get_IsOne() { }

	[Address(RVA = "0x113DD60", Offset = "0x113CF60", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600029B")]
	public override bool get_IsZero() { }

	[Address(RVA = "0x113D9E0", Offset = "0x113CBE0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigIntegers), Member = "AsUnsignedByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BigInteger)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002A5")]
	public override Byte[] GetEncoded() { }

	[Address(RVA = "0x113D9B0", Offset = "0x113CBB0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A6")]
	public override int GetEncodedLength() { }

	[Address(RVA = "0x113DA70", Offset = "0x113CC70", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002A3")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x6000297")]
	public abstract ECFieldElement Invert() { }

	[Token(Token = "0x6000293")]
	public abstract ECFieldElement Multiply(ECFieldElement b) { }

	[Address(RVA = "0x113DAB0", Offset = "0x113CCB0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600029C")]
	public override ECFieldElement MultiplyMinusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x113DB30", Offset = "0x113CD30", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600029D")]
	public override ECFieldElement MultiplyPlusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y) { }

	[Token(Token = "0x6000295")]
	public abstract ECFieldElement Negate() { }

	[Token(Token = "0x6000298")]
	public abstract ECFieldElement Sqrt() { }

	[Token(Token = "0x6000296")]
	public abstract ECFieldElement Square() { }

	[Address(RVA = "0x113DBB0", Offset = "0x113CDB0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600029E")]
	public override ECFieldElement SquarePlusProduct(ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x113DC30", Offset = "0x113CE30", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600029F")]
	public override ECFieldElement SquarePow(int pow) { }

	[Token(Token = "0x6000292")]
	public abstract ECFieldElement Subtract(ECFieldElement b) { }

	[Address(RVA = "0x113DC80", Offset = "0x113CE80", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A0")]
	public override bool TestBitZero() { }

	[Token(Token = "0x600028E")]
	public abstract BigInteger ToBigInteger() { }

	[Address(RVA = "0x113DCC0", Offset = "0x113CEC0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A4")]
	public virtual string ToString() { }

}

