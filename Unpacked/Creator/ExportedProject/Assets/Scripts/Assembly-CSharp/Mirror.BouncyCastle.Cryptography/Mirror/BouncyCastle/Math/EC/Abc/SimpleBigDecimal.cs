namespace Mirror.BouncyCastle.Math.EC.Abc;

[Token(Token = "0x2000107")]
internal class SimpleBigDecimal
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000221")]
	private readonly BigInteger bigInt; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000222")]
	private readonly int scale; //Field offset: 0x18

	[Token(Token = "0x1700013D")]
	public int Scale
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF1")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x11D7000", Offset = "0x11D6200", Length = "0x8E")]
	[CalledBy(Type = typeof(SimpleBigDecimal), Member = "AdjustScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SimpleBigDecimal))]
	[CalledBy(Type = typeof(SimpleBigDecimal), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleBigDecimal)}, ReturnType = typeof(SimpleBigDecimal))]
	[CalledBy(Type = typeof(SimpleBigDecimal), Member = "Negate", ReturnType = typeof(SimpleBigDecimal))]
	[CalledBy(Type = typeof(SimpleBigDecimal), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleBigDecimal)}, ReturnType = typeof(SimpleBigDecimal))]
	[CalledBy(Type = typeof(SimpleBigDecimal), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(SimpleBigDecimal))]
	[CalledBy(Type = typeof(SimpleBigDecimal), Member = "Round", ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Tnaf), Member = "ApproximateDivisionByN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(sbyte), typeof(int), typeof(int)}, ReturnType = typeof(SimpleBigDecimal))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AE7")]
	public SimpleBigDecimal(BigInteger bigInt, int scale) { }

	[Address(RVA = "0x11D65C0", Offset = "0x11D57C0", Length = "0xDA")]
	[CalledBy(Type = typeof(SimpleBigDecimal), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleBigDecimal)}, ReturnType = typeof(SimpleBigDecimal))]
	[CalledBy(Type = typeof(SimpleBigDecimal), Member = "Round", ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Tnaf), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleBigDecimal), typeof(SimpleBigDecimal), typeof(sbyte)}, ReturnType = typeof(ZTauElement))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SimpleBigDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000AEA")]
	public SimpleBigDecimal Add(SimpleBigDecimal b) { }

	[Address(RVA = "0x11D66A0", Offset = "0x11D58A0", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SimpleBigDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AE9")]
	public SimpleBigDecimal AdjustScale(int newScale) { }

	[Address(RVA = "0x11D6790", Offset = "0x11D5990", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AE8")]
	private void CheckScale(SimpleBigDecimal b) { }

	[Address(RVA = "0x11D6800", Offset = "0x11D5A00", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AEE")]
	public int CompareTo(BigInteger val) { }

	[Address(RVA = "0x11D6840", Offset = "0x11D5A40", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AF3")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11D68F0", Offset = "0x11D5AF0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "ShiftRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AEF")]
	public BigInteger Floor() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF1")]
	public int get_Scale() { }

	[Address(RVA = "0x11D6920", Offset = "0x11D5B20", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x11D6960", Offset = "0x11D5B60", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "Negate", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SimpleBigDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AEB")]
	public SimpleBigDecimal Negate() { }

	[Address(RVA = "0x11D69E0", Offset = "0x11D5BE0", Length = "0x187")]
	[CalledBy(Type = typeof(Tnaf), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleBigDecimal), typeof(SimpleBigDecimal), typeof(sbyte)}, ReturnType = typeof(ZTauElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SimpleBigDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleBigDecimal), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleBigDecimal)}, ReturnType = typeof(SimpleBigDecimal))]
	[Calls(Type = typeof(BigInteger), Member = "ShiftRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AF0")]
	public BigInteger Round() { }

	[Address(RVA = "0x11D6B70", Offset = "0x11D5D70", Length = "0x98")]
	[CalledBy(Type = typeof(Tnaf), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleBigDecimal), typeof(SimpleBigDecimal), typeof(sbyte)}, ReturnType = typeof(ZTauElement))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "Negate", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SimpleBigDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleBigDecimal), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleBigDecimal)}, ReturnType = typeof(SimpleBigDecimal))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AEC")]
	public SimpleBigDecimal Subtract(SimpleBigDecimal b) { }

	[Address(RVA = "0x11D6C10", Offset = "0x11D5E10", Length = "0x99")]
	[CalledBy(Type = typeof(Tnaf), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleBigDecimal), typeof(SimpleBigDecimal), typeof(sbyte)}, ReturnType = typeof(ZTauElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SimpleBigDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AED")]
	public SimpleBigDecimal Subtract(BigInteger b) { }

	[Address(RVA = "0x11D6CB0", Offset = "0x11D5EB0", Length = "0x348")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "ShiftRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000AF2")]
	public virtual string ToString() { }

}

