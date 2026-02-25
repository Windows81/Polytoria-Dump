namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

[Token(Token = "0x20000CB")]
internal class SecT163FieldElement : AbstractF2mFieldElement
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C6")]
	protected private readonly UInt64[] x; //Field offset: 0x10

	[Token(Token = "0x170000C9")]
	public virtual int FieldSize
	{
		[Address(RVA = "0x11A4CE0", Offset = "0x11A3EE0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000819")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000CA")]
	public virtual bool HasFastTrace
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000826")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000C7")]
	public virtual bool IsOne
	{
		[Address(RVA = "0x119D450", Offset = "0x119C650", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat192), Member = "IsOne64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000815")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170000C8")]
	public virtual bool IsZero
	{
		[Address(RVA = "0x119D460", Offset = "0x119C660", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat192), Member = "IsZero64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000816")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x11A4BF0", Offset = "0x11A3DF0", Length = "0xE5")]
	[CalledBy(Type = typeof(SecT163K1Curve), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT163K1Curve), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT163R1Curve), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT163R1Curve), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT163R2Curve), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT163R2Curve), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SecT163Field), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000813")]
	public SecT163FieldElement(BigInteger x) { }

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000814")]
	protected private SecT163FieldElement(UInt64[] x) { }

	[Address(RVA = "0x11A41B0", Offset = "0x11A33B0", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat192), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600081A")]
	public virtual ECFieldElement Add(ECFieldElement b) { }

	[Address(RVA = "0x11A4110", Offset = "0x11A3310", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat192), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600081B")]
	public virtual ECFieldElement AddOne() { }

	[Address(RVA = "0x1145340", Offset = "0x1144540", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000820")]
	public virtual ECFieldElement Divide(ECFieldElement b) { }

	[Address(RVA = "0x11A4340", Offset = "0x11A3540", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600082B")]
	public virtual bool Equals(ECFieldElement other) { }

	[Address(RVA = "0x119C710", Offset = "0x119B910", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat192), Member = "Eq64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x600082C")]
	public override bool Equals(SecT163FieldElement other) { }

	[Address(RVA = "0x11A42B0", Offset = "0x11A34B0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600082A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11A4CE0", Offset = "0x11A3EE0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000819")]
	public virtual int get_FieldSize() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000826")]
	public virtual bool get_HasFastTrace() { }

	[Address(RVA = "0x119D450", Offset = "0x119C650", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat192), Member = "IsOne64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000815")]
	public virtual bool get_IsOne() { }

	[Address(RVA = "0x119D460", Offset = "0x119C660", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat192), Member = "IsZero64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000816")]
	public virtual bool get_IsZero() { }

	[Address(RVA = "0x11A43D0", Offset = "0x11A35D0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x600082D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x11A4430", Offset = "0x11A3630", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat192), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecT163Field), Member = "HalfTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000825")]
	public virtual ECFieldElement HalfTrace() { }

	[Address(RVA = "0x11A44D0", Offset = "0x11A36D0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat192), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecT163Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000828")]
	public virtual ECFieldElement Invert() { }

	[Address(RVA = "0x11A4730", Offset = "0x11A3930", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat192), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecT163Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600081D")]
	public virtual ECFieldElement Multiply(ECFieldElement b) { }

	[Address(RVA = "0x1145660", Offset = "0x1144860", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600081E")]
	public virtual ECFieldElement MultiplyMinusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x11A4570", Offset = "0x11A3770", Length = "0x1BE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat192), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecT163Field), Member = "MultiplyAddToExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat192), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT163Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600081F")]
	public virtual ECFieldElement MultiplyPlusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000821")]
	public virtual ECFieldElement Negate() { }

	[Address(RVA = "0x11A4830", Offset = "0x11A3A30", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat192), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecT163Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000829")]
	public virtual ECFieldElement Sqrt() { }

	[Address(RVA = "0x11A4B00", Offset = "0x11A3D00", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat192), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecT163Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000822")]
	public virtual ECFieldElement Square() { }

	[Address(RVA = "0x11A48D0", Offset = "0x11A3AD0", Length = "0x170")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat192), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecT163Field), Member = "SquareExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT163Field), Member = "MultiplyAddToExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat192), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT163Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000823")]
	public virtual ECFieldElement SquarePlusProduct(ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x11A4A50", Offset = "0x11A3C50", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat192), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecT163Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000824")]
	public virtual ECFieldElement SquarePow(int pow) { }

	[Address(RVA = "0x4AB370", Offset = "0x4AA570", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600081C")]
	public virtual ECFieldElement Subtract(ECFieldElement b) { }

	[Address(RVA = "0x1197270", Offset = "0x1196470", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000817")]
	public virtual bool TestBitZero() { }

	[Address(RVA = "0x119D2C0", Offset = "0x119C4C0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat192), Member = "ToBigInteger64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(BigInteger))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000818")]
	public virtual BigInteger ToBigInteger() { }

	[Address(RVA = "0x11A4BA0", Offset = "0x11A3DA0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecT163Field), Member = "Trace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(uint))]
	[Token(Token = "0x6000827")]
	public virtual int Trace() { }

}

