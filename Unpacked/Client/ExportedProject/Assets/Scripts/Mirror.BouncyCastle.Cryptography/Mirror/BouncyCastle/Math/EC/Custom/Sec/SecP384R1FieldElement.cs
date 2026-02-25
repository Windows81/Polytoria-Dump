namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

[Token(Token = "0x20000B3")]
internal class SecP384R1FieldElement : AbstractFpFieldElement
{
	[Token(Token = "0x40001A3")]
	public static readonly BigInteger Q; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001A4")]
	protected private readonly UInt32[] x; //Field offset: 0x10

	[Token(Token = "0x170000A0")]
	public virtual int FieldSize
	{
		[Address(RVA = "0x118F4E0", Offset = "0x118E6E0", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60006ED")]
		 get { } //Length: 94
	}

	[Token(Token = "0x1700009F")]
	public virtual bool IsOne
	{
		[Address(RVA = "0x118F540", Offset = "0x118E740", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat), Member = "IsOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[])}, ReturnType = typeof(bool))]
		[Token(Token = "0x60006EA")]
		 get { } //Length: 17
	}

	[Token(Token = "0x1700009E")]
	public virtual bool IsZero
	{
		[Address(RVA = "0x118F560", Offset = "0x118E760", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat), Member = "IsZero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[])}, ReturnType = typeof(bool))]
		[Token(Token = "0x60006E9")]
		 get { } //Length: 17
	}

	[Address(RVA = "0x118F220", Offset = "0x118E420", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60006FB")]
	private static SecP384R1FieldElement() { }

	[Address(RVA = "0x118F2F0", Offset = "0x118E4F0", Length = "0x1E5")]
	[CalledBy(Type = typeof(SecP384R1Curve), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP384R1Curve), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Nat), Member = "Gte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Nat), Member = "SubFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Nat), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BigInteger)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006E7")]
	public SecP384R1FieldElement(BigInteger x) { }

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E8")]
	protected private SecP384R1FieldElement(UInt32[] x) { }

	[Address(RVA = "0x118E590", Offset = "0x118D790", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecP384R1Field), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006EE")]
	public virtual ECFieldElement Add(ECFieldElement b) { }

	[Address(RVA = "0x118E440", Offset = "0x118D640", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Nat), Member = "Inc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Nat), Member = "Gte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SecP384R1Field), Member = "AddPInvTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006EF")]
	public virtual ECFieldElement AddOne() { }

	[Address(RVA = "0x118E690", Offset = "0x118D890", Length = "0x10B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecP384R1Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecP384R1Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006F2")]
	public virtual ECFieldElement Divide(ECFieldElement b) { }

	[Address(RVA = "0x118E830", Offset = "0x118DA30", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat), Member = "Eq", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[Token(Token = "0x60006F9")]
	public override bool Equals(SecP384R1FieldElement other) { }

	[Address(RVA = "0x118E7A0", Offset = "0x118D9A0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006F8")]
	public virtual bool Equals(ECFieldElement other) { }

	[Address(RVA = "0x118E860", Offset = "0x118DA60", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006F7")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x118F4E0", Offset = "0x118E6E0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006ED")]
	public virtual int get_FieldSize() { }

	[Address(RVA = "0x118F540", Offset = "0x118E740", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat), Member = "IsOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[Token(Token = "0x60006EA")]
	public virtual bool get_IsOne() { }

	[Address(RVA = "0x118F560", Offset = "0x118E760", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat), Member = "IsZero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[Token(Token = "0x60006E9")]
	public virtual bool get_IsZero() { }

	[Address(RVA = "0x118E8F0", Offset = "0x118DAF0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006FA")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x118E9B0", Offset = "0x118DBB0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecP384R1Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006F5")]
	public virtual ECFieldElement Invert() { }

	[Address(RVA = "0x118EA60", Offset = "0x118DC60", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecP384R1Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006F1")]
	public virtual ECFieldElement Multiply(ECFieldElement b) { }

	[Address(RVA = "0x118EB60", Offset = "0x118DD60", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecP384R1Field), Member = "Negate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006F3")]
	public virtual ECFieldElement Negate() { }

	[Address(RVA = "0x118EC10", Offset = "0x118DE10", Length = "0x3C9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat), Member = "IsZero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nat), Member = "IsOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nat), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecP384R1Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecP384R1Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecP384R1Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat), Member = "Eq", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006F6")]
	public virtual ECFieldElement Sqrt() { }

	[Address(RVA = "0x118EFE0", Offset = "0x118E1E0", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Nat384), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecP384R1Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006F4")]
	public virtual ECFieldElement Square() { }

	[Address(RVA = "0x118F0E0", Offset = "0x118E2E0", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SecP384R1Field), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006F0")]
	public virtual ECFieldElement Subtract(ECFieldElement b) { }

	[Address(RVA = "0x118F1E0", Offset = "0x118E3E0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat), Member = "GetBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60006EB")]
	public virtual bool TestBitZero() { }

	[Address(RVA = "0x118F200", Offset = "0x118E400", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat), Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[])}, ReturnType = typeof(BigInteger))]
	[Token(Token = "0x60006EC")]
	public virtual BigInteger ToBigInteger() { }

}

