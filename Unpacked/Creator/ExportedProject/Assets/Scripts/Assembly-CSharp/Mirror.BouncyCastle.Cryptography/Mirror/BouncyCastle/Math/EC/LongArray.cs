namespace Mirror.BouncyCastle.Math.EC;

[Token(Token = "0x2000050")]
internal struct LongArray
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B5")]
	private UInt64[] m_data; //Field offset: 0x0

	[Address(RVA = "0x1154130", Offset = "0x1153330", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600033B")]
	internal LongArray(int intLen) { }

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600033C")]
	internal LongArray(UInt64[] data) { }

	[Address(RVA = "0x1154080", Offset = "0x1153280", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600033D")]
	internal LongArray(UInt64[] data, int off, int len) { }

	[Address(RVA = "0x1153E30", Offset = "0x1153030", Length = "0x248")]
	[CalledBy(Type = typeof(F2mCurve), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "ToByteArray", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600033E")]
	internal LongArray(BigInteger bigInt) { }

	[Address(RVA = "0x1150960", Offset = "0x114FB60", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat), Member = "XorTo64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600034F")]
	private static void Add(UInt64[] x, int xOff, UInt64[] y, int yOff, int count) { }

	[Address(RVA = "0x1150920", Offset = "0x114FB20", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat), Member = "Xor64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000350")]
	private static void Add(UInt64[] x, int xOff, UInt64[] y, int yOff, UInt64[] z, int zOff, int count) { }

	[Address(RVA = "0x11503A0", Offset = "0x114F5A0", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000351")]
	private static void AddBoth(UInt64[] x, int xOff, UInt64[] y1, int y1Off, UInt64[] y2, int y2Off, int count) { }

	[Address(RVA = "0x1150480", Offset = "0x114F680", Length = "0xFF")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "AddOne", ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "GetUsedLengthFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LongArray), Member = "ResizedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600034A")]
	internal LongArray AddOne() { }

	[Address(RVA = "0x1150580", Offset = "0x114F780", Length = "0x144")]
	[CalledBy(Type = typeof(LongArray), Member = "ModInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Nat), Member = "XorTo64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600034B")]
	private void AddShiftedByBitsSafe(LongArray other, int otherDegree, int bits) { }

	[Address(RVA = "0x11506D0", Offset = "0x114F8D0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LongArray), Member = "GetUsedLengthFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LongArray), Member = "ResizedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Nat), Member = "XorTo64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600034E")]
	internal void AddShiftedByWords(LongArray other, int words) { }

	[Address(RVA = "0x1150770", Offset = "0x114F970", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600034D")]
	private static ulong AddShiftedDown(UInt64[] x, int xOff, UInt64[] y, int yOff, int count, int shift) { }

	[Address(RVA = "0x1150840", Offset = "0x114FA40", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600034C")]
	private static ulong AddShiftedUp(UInt64[] x, int xOff, UInt64[] y, int yOff, int count, int shift) { }

	[Address(RVA = "0x1150990", Offset = "0x114FB90", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600033A")]
	internal static bool AreAliased(ref LongArray a, ref LongArray b) { }

	[Address(RVA = "0x11509A0", Offset = "0x114FBA0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Longs), Member = "NumberOfLeadingZeros", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000346")]
	private static int BitLength(ulong w) { }

	[Address(RVA = "0x1150A40", Offset = "0x114FC40", Length = "0x64")]
	[CalledBy(Type = typeof(LongArray), Member = "ModInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000369")]
	public LongArray Copy() { }

	[Address(RVA = "0x1150A00", Offset = "0x114FC00", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600033F")]
	internal void CopyTo(UInt64[] z, int zOff) { }

	[Address(RVA = "0x1150B60", Offset = "0x114FD60", Length = "0xA0")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "get_BitLength", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LongArray), Member = "ModMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CalledBy(Type = typeof(LongArray), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CalledBy(Type = typeof(LongArray), Member = "ModInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Longs), Member = "NumberOfLeadingZeros", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000344")]
	internal int Degree() { }

	[Address(RVA = "0x1150AB0", Offset = "0x114FCB0", Length = "0xA0")]
	[CalledBy(Type = typeof(LongArray), Member = "ModInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Longs), Member = "NumberOfLeadingZeros", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000345")]
	private int DegreeFrom(int limit) { }

	[Address(RVA = "0x1150CE0", Offset = "0x114FEE0", Length = "0x90")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(F2mFieldElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(LongArray), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongArray&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000366")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1150C10", Offset = "0x114FE10", Length = "0xC1")]
	[CalledBy(Type = typeof(LongArray), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LongArray), Member = "GetUsedLengthFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000367")]
	internal bool Equals(ref LongArray other) { }

	[Address(RVA = "0x1150D80", Offset = "0x114FF80", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000355")]
	private static void FlipBit(UInt64[] buf, int off, int n) { }

	[Address(RVA = "0x1150DC0", Offset = "0x114FFC0", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat), Member = "XorTo64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000361")]
	private static void FlipVector(UInt64[] x, int xOff, UInt64[] y, int yOff, int yLen, int bits) { }

	[Address(RVA = "0x1150F10", Offset = "0x1150110", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000352")]
	private static void FlipWord(UInt64[] buf, int off, int bit, ulong word) { }

	[Address(RVA = "0x1150FA0", Offset = "0x11501A0", Length = "0x75")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "GetUsedLengthFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000368")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x11510F0", Offset = "0x11502F0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LongArray), Member = "GetUsedLengthFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000342")]
	internal int GetUsedLength() { }

	[Address(RVA = "0x1151020", Offset = "0x1150220", Length = "0xCE")]
	[CalledBy(Type = typeof(LongArray), Member = "ModSquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CalledBy(Type = typeof(LongArray), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(LongArray), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LongArray), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongArray&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LongArray), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CalledBy(Type = typeof(LongArray), Member = "ModSquare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CalledBy(Type = typeof(LongArray), Member = "AddShiftedByWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongArray), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LongArray), Member = "ToBigInteger", ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(LongArray), Member = "GetUsedLength", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(LongArray), Member = "AddOne", ReturnType = typeof(LongArray))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000343")]
	internal int GetUsedLengthFrom(int from) { }

	[Address(RVA = "0x1151120", Offset = "0x1150320", Length = "0x6A")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000340")]
	internal bool IsOne() { }

	[Address(RVA = "0x1151190", Offset = "0x1150390", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000341")]
	internal bool IsZero() { }

	[Address(RVA = "0x11511E0", Offset = "0x11503E0", Length = "0x4E1")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "Invert", ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(LongArray), Member = "DegreeFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LongArray), Member = "AddShiftedByBitsSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongArray), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(LongArray), Member = "Copy", ReturnType = typeof(LongArray))]
	[Calls(Type = typeof(LongArray), Member = "Degree", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "ReduceBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000365")]
	internal LongArray ModInverse(int m, Int32[] ks) { }

	[Address(RVA = "0x11516D0", Offset = "0x11508D0", Length = "0x772")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "Degree", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat), Member = "Xor64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LongArray), Member = "ReduceInPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Nat), Member = "XorTo64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LongArray), Member = "ReduceResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000357")]
	internal LongArray ModMultiply(LongArray other, int m, Int32[] ks) { }

	[Address(RVA = "0x1151FF0", Offset = "0x11511F0", Length = "0x15F")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "Square", ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "GetUsedLengthFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LongArray), Member = "ReduceInPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000362")]
	internal LongArray ModSquare(int m, Int32[] ks) { }

	[Address(RVA = "0x1151E50", Offset = "0x1151050", Length = "0x199")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "SquarePow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "GetUsedLengthFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LongArray), Member = "ReduceInPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000363")]
	internal LongArray ModSquareN(int n, int m, Int32[] ks) { }

	[Address(RVA = "0x11522F0", Offset = "0x11514F0", Length = "0x791")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "Degree", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat), Member = "Xor64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Nat), Member = "XorTo64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000358")]
	internal LongArray Multiply(LongArray other, int m, Int32[] ks) { }

	[Address(RVA = "0x1152150", Offset = "0x1151350", Length = "0x194")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat), Member = "XorTo64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000356")]
	private static void MultiplyWord(ulong a, UInt64[] b, int bLen, UInt64[] c, int cOff) { }

	[Address(RVA = "0x11535D0", Offset = "0x11527D0", Length = "0xB9")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "ReduceInPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000359")]
	internal void Reduce(int m, Int32[] ks) { }

	[Address(RVA = "0x1152B30", Offset = "0x1151D30", Length = "0xD8")]
	[CalledBy(Type = typeof(LongArray), Member = "ReduceInPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LongArray), Member = "ReduceBitWise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LongArray), Member = "ModInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600035D")]
	private static void ReduceBit(UInt64[] buf, int off, int bit, int m, Int32[] ks) { }

	[Address(RVA = "0x1152A90", Offset = "0x1151C90", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LongArray), Member = "ReduceBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600035C")]
	private static void ReduceBitWise(UInt64[] buf, int off, int BitLength, int m, Int32[] ks) { }

	[Address(RVA = "0x1152C10", Offset = "0x1151E10", Length = "0x341")]
	[CalledBy(Type = typeof(LongArray), Member = "ModMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CalledBy(Type = typeof(LongArray), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LongArray), Member = "ReduceResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CalledBy(Type = typeof(LongArray), Member = "ModSquare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CalledBy(Type = typeof(LongArray), Member = "ModSquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "ReduceBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LongArray), Member = "ReduceWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(ulong), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LongArray), Member = "ReduceVectorWise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x600035B")]
	private static int ReduceInPlace(UInt64[] buf, int off, int len, int m, Int32[] ks) { }

	[Address(RVA = "0x1152F60", Offset = "0x1152160", Length = "0xC5")]
	[CalledBy(Type = typeof(LongArray), Member = "ModMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(LongArray))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LongArray), Member = "ReduceInPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600035A")]
	private static LongArray ReduceResult(UInt64[] buf, int off, int len, int m, Int32[] ks) { }

	[Address(RVA = "0x1153030", Offset = "0x1152230", Length = "0x2D3")]
	[CalledBy(Type = typeof(LongArray), Member = "ReduceInPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nat), Member = "XorTo64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000360")]
	private static void ReduceVectorWise(UInt64[] buf, int off, int len, int words, int m, Int32[] ks) { }

	[Address(RVA = "0x1153460", Offset = "0x1152660", Length = "0x160")]
	[CalledBy(Type = typeof(LongArray), Member = "ReduceInPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LongArray), Member = "ReduceWordWise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600035F")]
	private static void ReduceWord(UInt64[] buf, int off, int bit, ulong word, int m, Int32[] ks) { }

	[Address(RVA = "0x1153310", Offset = "0x1152510", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LongArray), Member = "ReduceWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(ulong), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600035E")]
	private static void ReduceWordWise(UInt64[] buf, int off, int len, int toBit, int m, Int32[] ks) { }

	[Address(RVA = "0x1153690", Offset = "0x1152890", Length = "0xB6")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(LongArray), Member = "AddOne", ReturnType = typeof(LongArray))]
	[CalledBy(Type = typeof(LongArray), Member = "AddShiftedByWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongArray), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000347")]
	private UInt64[] ResizedData(int newLen) { }

	[Address(RVA = "0x1153750", Offset = "0x1152950", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000349")]
	private static ulong ShiftUp(UInt64[] x, int xOff, UInt64[] z, int zOff, int count, int shift) { }

	[Address(RVA = "0x1153840", Offset = "0x1152A40", Length = "0x134")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "GetUsedLengthFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000364")]
	internal LongArray Square(int m, Int32[] ks) { }

	[Address(RVA = "0x11539C0", Offset = "0x1152BC0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000354")]
	private static bool TestBit(UInt64[] buf, int off, int n) { }

	[Address(RVA = "0x1153980", Offset = "0x1152B80", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000353")]
	internal bool TestBitZero() { }

	[Address(RVA = "0x1153A10", Offset = "0x1152C10", Length = "0x249")]
	[CalledBy(Type = typeof(F2mFieldElement), Member = "ToBigInteger", ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "GetUsedLengthFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000348")]
	internal BigInteger ToBigInteger() { }

	[Address(RVA = "0x1153C60", Offset = "0x1152E60", Length = "0x1C7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongArray), Member = "GetUsedLengthFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600036A")]
	public virtual string ToString() { }

}

