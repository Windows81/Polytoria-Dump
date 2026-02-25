namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

[Token(Token = "0x20000E6")]
internal class SecT239FieldElement : AbstractF2mFieldElement
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001EC")]
	protected private readonly UInt64[] x; //Field offset: 0x10

	[Token(Token = "0x170000FF")]
	public virtual int FieldSize
	{
		[Address(RVA = "0x11B92C0", Offset = "0x11B84C0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000952")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000100")]
	public virtual bool HasFastTrace
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600095F")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000FD")]
	public virtual bool IsOne
	{
		[Address(RVA = "0x11ABD50", Offset = "0x11AAF50", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat256), Member = "IsOne64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x600094E")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170000FE")]
	public virtual bool IsZero
	{
		[Address(RVA = "0x11ABD60", Offset = "0x11AAF60", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat256), Member = "IsZero64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x600094F")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x11B9200", Offset = "0x11B8400", Length = "0xB7")]
	[CalledBy(Type = typeof(SecT239K1Curve), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT239K1Curve), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(Nat), Member = "FromBigInteger64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BigInteger)}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600094C")]
	public SecT239FieldElement(BigInteger x) { }

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600094D")]
	protected private SecT239FieldElement(UInt64[] x) { }

	[Address(RVA = "0x11B8690", Offset = "0x11B7890", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000953")]
	public virtual ECFieldElement Add(ECFieldElement b) { }

	[Address(RVA = "0x11B85A0", Offset = "0x11B77A0", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000954")]
	public virtual ECFieldElement AddOne() { }

	[Address(RVA = "0x1145340", Offset = "0x1144540", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000959")]
	public virtual ECFieldElement Divide(ECFieldElement b) { }

	[Address(RVA = "0x11B88B0", Offset = "0x11B7AB0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000964")]
	public virtual bool Equals(ECFieldElement other) { }

	[Address(RVA = "0x11AB120", Offset = "0x11AA320", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat256), Member = "Eq64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000965")]
	public override bool Equals(SecT239FieldElement other) { }

	[Address(RVA = "0x11B8820", Offset = "0x11B7A20", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000963")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11B92C0", Offset = "0x11B84C0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000952")]
	public virtual int get_FieldSize() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600095F")]
	public virtual bool get_HasFastTrace() { }

	[Address(RVA = "0x11ABD50", Offset = "0x11AAF50", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat256), Member = "IsOne64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x600094E")]
	public virtual bool get_IsOne() { }

	[Address(RVA = "0x11ABD60", Offset = "0x11AAF60", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat256), Member = "IsZero64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x600094F")]
	public virtual bool get_IsZero() { }

	[Address(RVA = "0x11B8940", Offset = "0x11B7B40", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000966")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x11B89A0", Offset = "0x11B7BA0", Length = "0x199")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat256), Member = "Copy64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT239Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600095E")]
	public virtual ECFieldElement HalfTrace() { }

	[Address(RVA = "0x11B8B40", Offset = "0x11B7D40", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT239Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000961")]
	public virtual ECFieldElement Invert() { }

	[Address(RVA = "0x11B8D70", Offset = "0x11B7F70", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT239Field), Member = "ImplMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT239Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000956")]
	public virtual ECFieldElement Multiply(ECFieldElement b) { }

	[Address(RVA = "0x1145660", Offset = "0x1144860", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000957")]
	public virtual ECFieldElement MultiplyMinusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x11B8BC0", Offset = "0x11B7DC0", Length = "0x1A4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT239Field), Member = "MultiplyAddToExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT239Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000958")]
	public virtual ECFieldElement MultiplyPlusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x600095A")]
	public virtual ECFieldElement Negate() { }

	[Address(RVA = "0x11B8E70", Offset = "0x11B8070", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT239Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000962")]
	public virtual ECFieldElement Sqrt() { }

	[Address(RVA = "0x11B9100", Offset = "0x11B8300", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT239Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600095B")]
	public virtual ECFieldElement Square() { }

	[Address(RVA = "0x11B8EF0", Offset = "0x11B80F0", Length = "0x172")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT239Field), Member = "MultiplyAddToExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT239Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600095C")]
	public virtual ECFieldElement SquarePlusProduct(ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x11B9070", Offset = "0x11B8270", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT239Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600095D")]
	public virtual ECFieldElement SquarePow(int pow) { }

	[Address(RVA = "0x4AB370", Offset = "0x4AA570", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000955")]
	public virtual ECFieldElement Subtract(ECFieldElement b) { }

	[Address(RVA = "0x1197270", Offset = "0x1196470", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000950")]
	public virtual bool TestBitZero() { }

	[Address(RVA = "0x11ABC70", Offset = "0x11AAE70", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat256), Member = "ToBigInteger64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(BigInteger))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000951")]
	public virtual BigInteger ToBigInteger() { }

	[Address(RVA = "0x11B91B0", Offset = "0x11B83B0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000960")]
	public virtual int Trace() { }

}

