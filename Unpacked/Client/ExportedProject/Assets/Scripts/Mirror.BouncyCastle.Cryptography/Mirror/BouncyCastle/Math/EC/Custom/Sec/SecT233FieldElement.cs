namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

[Token(Token = "0x20000DE")]
internal class SecT233FieldElement : AbstractF2mFieldElement
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E1")]
	protected private readonly UInt64[] x; //Field offset: 0x10

	[Token(Token = "0x170000EF")]
	public virtual int FieldSize
	{
		[Address(RVA = "0x11B2100", Offset = "0x11B1300", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008F2")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000F0")]
	public virtual bool HasFastTrace
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008FF")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000ED")]
	public virtual bool IsOne
	{
		[Address(RVA = "0x11ABD50", Offset = "0x11AAF50", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat256), Member = "IsOne64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60008EE")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170000EE")]
	public virtual bool IsZero
	{
		[Address(RVA = "0x11ABD60", Offset = "0x11AAF60", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat256), Member = "IsZero64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60008EF")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x11B2040", Offset = "0x11B1240", Length = "0xB7")]
	[CalledBy(Type = typeof(SecT233K1Curve), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT233K1Curve), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT233R1Curve), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT233R1Curve), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(Nat), Member = "FromBigInteger64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BigInteger)}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008EC")]
	public SecT233FieldElement(BigInteger x) { }

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008ED")]
	protected private SecT233FieldElement(UInt64[] x) { }

	[Address(RVA = "0x11B14E0", Offset = "0x11B06E0", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008F3")]
	public virtual ECFieldElement Add(ECFieldElement b) { }

	[Address(RVA = "0x11B13F0", Offset = "0x11B05F0", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008F4")]
	public virtual ECFieldElement AddOne() { }

	[Address(RVA = "0x1145340", Offset = "0x1144540", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F9")]
	public virtual ECFieldElement Divide(ECFieldElement b) { }

	[Address(RVA = "0x11B1670", Offset = "0x11B0870", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000904")]
	public virtual bool Equals(ECFieldElement other) { }

	[Address(RVA = "0x11AB120", Offset = "0x11AA320", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat256), Member = "Eq64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000905")]
	public override bool Equals(SecT233FieldElement other) { }

	[Address(RVA = "0x11B1700", Offset = "0x11B0900", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000903")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11B2100", Offset = "0x11B1300", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F2")]
	public virtual int get_FieldSize() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008FF")]
	public virtual bool get_HasFastTrace() { }

	[Address(RVA = "0x11ABD50", Offset = "0x11AAF50", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat256), Member = "IsOne64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60008EE")]
	public virtual bool get_IsOne() { }

	[Address(RVA = "0x11ABD60", Offset = "0x11AAF60", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat256), Member = "IsZero64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60008EF")]
	public virtual bool get_IsZero() { }

	[Address(RVA = "0x11B1790", Offset = "0x11B0990", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000906")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x11B17F0", Offset = "0x11B09F0", Length = "0x199")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat256), Member = "Copy64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT233Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008FE")]
	public virtual ECFieldElement HalfTrace() { }

	[Address(RVA = "0x11B1990", Offset = "0x11B0B90", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT233Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000901")]
	public virtual ECFieldElement Invert() { }

	[Address(RVA = "0x11B1BC0", Offset = "0x11B0DC0", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT233Field), Member = "ImplMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT233Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008F6")]
	public virtual ECFieldElement Multiply(ECFieldElement b) { }

	[Address(RVA = "0x1145660", Offset = "0x1144860", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F7")]
	public virtual ECFieldElement MultiplyMinusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x11B1A10", Offset = "0x11B0C10", Length = "0x1A4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT233Field), Member = "MultiplyAddToExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT233Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008F8")]
	public virtual ECFieldElement MultiplyPlusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008FA")]
	public virtual ECFieldElement Negate() { }

	[Address(RVA = "0x11B1CC0", Offset = "0x11B0EC0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT233Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000902")]
	public virtual ECFieldElement Sqrt() { }

	[Address(RVA = "0x11B1F50", Offset = "0x11B1150", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT233Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008FB")]
	public virtual ECFieldElement Square() { }

	[Address(RVA = "0x11B1D40", Offset = "0x11B0F40", Length = "0x172")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT233Field), Member = "MultiplyAddToExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT233Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008FC")]
	public virtual ECFieldElement SquarePlusProduct(ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x11B1EC0", Offset = "0x11B10C0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT233Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008FD")]
	public virtual ECFieldElement SquarePow(int pow) { }

	[Address(RVA = "0x4AB370", Offset = "0x4AA570", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F5")]
	public virtual ECFieldElement Subtract(ECFieldElement b) { }

	[Address(RVA = "0x1197270", Offset = "0x1196470", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F0")]
	public virtual bool TestBitZero() { }

	[Address(RVA = "0x11ABC70", Offset = "0x11AAE70", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat256), Member = "ToBigInteger64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(BigInteger))]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F1")]
	public virtual BigInteger ToBigInteger() { }

	[Address(RVA = "0x11B2000", Offset = "0x11B1200", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000900")]
	public virtual int Trace() { }

}

