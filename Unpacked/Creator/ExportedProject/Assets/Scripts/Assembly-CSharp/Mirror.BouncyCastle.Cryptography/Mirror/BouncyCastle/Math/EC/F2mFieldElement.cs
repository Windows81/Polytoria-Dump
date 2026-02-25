namespace Mirror.BouncyCastle.Math.EC;

[Token(Token = "0x2000046")]
public class F2mFieldElement : AbstractF2mFieldElement
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A8")]
	private int representation; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000A9")]
	private int m; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000AA")]
	private Int32[] ks; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000AB")]
	internal LongArray x; //Field offset: 0x20

	[Token(Token = "0x17000035")]
	public virtual int BitLength
	{
		[Address(RVA = "0x1145FF0", Offset = "0x11451F0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LongArray), Member = "Degree", ReturnType = typeof(int))]
		[Token(Token = "0x60002CB")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000038")]
	public virtual int FieldSize
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D0")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000036")]
	public virtual bool IsOne
	{
		[Address(RVA = "0x1146000", Offset = "0x1145200", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60002CC")]
		 get { } //Length: 114
	}

	[Token(Token = "0x17000037")]
	public virtual bool IsZero
	{
		[Address(RVA = "0x1146080", Offset = "0x1145280", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60002CD")]
		 get { } //Length: 83
	}

	[Address(RVA = "0x1145F70", Offset = "0x1145170", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002CA")]
	internal F2mFieldElement(int m, Int32[] ks, LongArray x) { }

	[Address(RVA = "0x1144F30", Offset = "0x1144130", Length = "0x1C6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LongArray), Member = "GetUsedLengthFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LongArray), Member = "ResizedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat), Member = "XorTo64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002D2")]
	public virtual ECFieldElement Add(ECFieldElement b) { }

	[Address(RVA = "0x1144E70", Offset = "0x1144070", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "AddOne", ReturnType = typeof(LongArray))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002D3")]
	public virtual ECFieldElement AddOne() { }

	[Address(RVA = "0x1145100", Offset = "0x1144300", Length = "0x23B")]
	[CalledBy(Type = typeof(F2mCurve), Member = "CreateRawPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(F2mPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(F2mPoint), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(F2mPoint), Member = "Twice", ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(F2mPoint), Member = "TwicePlus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(F2mPoint), Member = "Negate", ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Arrays), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(bool))]
	[Token(Token = "0x60002D1")]
	public static void CheckFieldElements(ECFieldElement a, ECFieldElement b) { }

	[Address(RVA = "0x1145340", Offset = "0x1144540", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D8")]
	public virtual ECFieldElement Divide(ECFieldElement b) { }

	[Address(RVA = "0x1145390", Offset = "0x1144590", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002DF")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1145420", Offset = "0x1144620", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(LongArray), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002E0")]
	public override bool Equals(F2mFieldElement other) { }

	[Address(RVA = "0x1145FF0", Offset = "0x11451F0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LongArray), Member = "Degree", ReturnType = typeof(int))]
	[Token(Token = "0x60002CB")]
	public virtual int get_BitLength() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D0")]
	public virtual int get_FieldSize() { }

	[Address(RVA = "0x1146000", Offset = "0x1145200", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60002CC")]
	public virtual bool get_IsOne() { }

	[Address(RVA = "0x1146080", Offset = "0x1145280", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60002CD")]
	public virtual bool get_IsZero() { }

	[Address(RVA = "0x1145520", Offset = "0x1144720", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(int))]
	[Token(Token = "0x60002E1")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x11455A0", Offset = "0x11447A0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "ModInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002DD")]
	public virtual ECFieldElement Invert() { }

	[Address(RVA = "0x1145960", Offset = "0x1144B60", Length = "0x118")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "ModMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002D5")]
	public virtual ECFieldElement Multiply(ECFieldElement b) { }

	[Address(RVA = "0x1145660", Offset = "0x1144860", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D6")]
	public virtual ECFieldElement MultiplyMinusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x1145680", Offset = "0x1144880", Length = "0x2D2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(LongArray), Member = "GetUsedLengthFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LongArray), Member = "ResizedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat), Member = "XorTo64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LongArray), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002D7")]
	public virtual ECFieldElement MultiplyPlusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D9")]
	public virtual ECFieldElement Negate() { }

	[Address(RVA = "0x1145A80", Offset = "0x1144C80", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LongArray), Member = "IsOne", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002DE")]
	public virtual ECFieldElement Sqrt() { }

	[Address(RVA = "0x1145E60", Offset = "0x1145060", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "ModSquare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002DA")]
	public virtual ECFieldElement Square() { }

	[Address(RVA = "0x1145B00", Offset = "0x1144D00", Length = "0x26E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[Calls(Type = typeof(LongArray), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LongArray), Member = "GetUsedLengthFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LongArray), Member = "ResizedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat), Member = "XorTo64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LongArray), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002DB")]
	public virtual ECFieldElement SquarePlusProduct(ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x1145D70", Offset = "0x1144F70", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "ModSquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002DC")]
	public virtual ECFieldElement SquarePow(int pow) { }

	[Address(RVA = "0x4AB370", Offset = "0x4AA570", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D4")]
	public virtual ECFieldElement Subtract(ECFieldElement b) { }

	[Address(RVA = "0x1145F20", Offset = "0x1145120", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002CE")]
	public virtual bool TestBitZero() { }

	[Address(RVA = "0x1145F60", Offset = "0x1145160", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LongArray), Member = "ToBigInteger", ReturnType = typeof(BigInteger))]
	[Token(Token = "0x60002CF")]
	public virtual BigInteger ToBigInteger() { }

}

