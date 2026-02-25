namespace Mirror.BouncyCastle.Math.Raw;

[Token(Token = "0x2000028")]
internal static class Nat192
{

	[Address(RVA = "0x10CB770", Offset = "0x10CA970", Length = "0x14D")]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1FieldElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP192R1Field), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000196")]
	public static uint Add(UInt32[] x, UInt32[] y, UInt32[] z) { }

	[Address(RVA = "0x10CB250", Offset = "0x10CA450", Length = "0x180")]
	[CalledBy(Type = typeof(SecP192K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecP192K1Point), Member = "Twice", ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecP192R1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecP192R1Point), Member = "Twice", ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000197")]
	public static uint AddBothTo(UInt32[] x, UInt32[] y, UInt32[] z) { }

	[Address(RVA = "0x10CB5F0", Offset = "0x10CA7F0", Length = "0x17C")]
	[CalledBy(Type = typeof(Nat384), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Nat384), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000198")]
	public static uint AddTo(UInt32[] x, int xOff, UInt32[] z, int zOff, uint cIn) { }

	[Address(RVA = "0x10CB3E0", Offset = "0x10CA5E0", Length = "0x201")]
	[CalledBy(Type = typeof(Nat384), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Nat384), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000199")]
	public static uint AddToEachOther(UInt32[] u, int uOff, UInt32[] v, int vOff) { }

	[Address(RVA = "0x10CB9A0", Offset = "0x10CABA0", Length = "0x101")]
	[CalledBy(Type = typeof(SecP192K1Curve), Member = "CreateCacheSafeLookupTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint[]), typeof(int), typeof(int)}, ReturnType = typeof(ECLookupTable))]
	[CalledBy(Type = typeof(SecP192R1Curve), Member = "CreateCacheSafeLookupTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint[]), typeof(int), typeof(int)}, ReturnType = typeof(ECLookupTable))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600019A")]
	public static void Copy(UInt32[] x, int xOff, UInt32[] z, int zOff) { }

	[Address(RVA = "0x10CB940", Offset = "0x10CAB40", Length = "0x5A")]
	[CalledBy(Type = typeof(SecT131Field), Member = "HalfTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT131FieldElement), Member = "HalfTrace", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT163Field), Member = "HalfTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT163K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600019B")]
	public static void Copy64(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x10CB8C0", Offset = "0x10CAAC0", Length = "0x7D")]
	[CalledBy(Type = typeof(SecT131R1Curve), Member = "CreateCacheSafeLookupTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint[]), typeof(int), typeof(int)}, ReturnType = typeof(ECLookupTable))]
	[CalledBy(Type = typeof(SecT131R2Curve), Member = "CreateCacheSafeLookupTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint[]), typeof(int), typeof(int)}, ReturnType = typeof(ECLookupTable))]
	[CalledBy(Type = typeof(SecT163K1Curve), Member = "CreateCacheSafeLookupTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint[]), typeof(int), typeof(int)}, ReturnType = typeof(ECLookupTable))]
	[CalledBy(Type = typeof(SecT163R1Curve), Member = "CreateCacheSafeLookupTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint[]), typeof(int), typeof(int)}, ReturnType = typeof(ECLookupTable))]
	[CalledBy(Type = typeof(SecT163R2Curve), Member = "CreateCacheSafeLookupTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint[]), typeof(int), typeof(int)}, ReturnType = typeof(ECLookupTable))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600019C")]
	public static void Copy64(UInt64[] x, int xOff, UInt64[] z, int zOff) { }

	[Address(RVA = "0x10CBB70", Offset = "0x10CAD70", Length = "0x35")]
	[CallerCount(Count = 53)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x600019D")]
	public static UInt32[] Create() { }

	[Address(RVA = "0x10CBAB0", Offset = "0x10CACB0", Length = "0x35")]
	[CallerCount(Count = 50)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x600019E")]
	public static UInt64[] Create64() { }

	[Address(RVA = "0x10CBB30", Offset = "0x10CAD30", Length = "0x35")]
	[CalledBy(Type = typeof(Nat384), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Nat384), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecP192R1Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192R1Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192R1Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192R1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x600019F")]
	public static UInt32[] CreateExt() { }

	[Address(RVA = "0x10CBAF0", Offset = "0x10CACF0", Length = "0x35")]
	[CalledBy(Type = typeof(SecT163Field), Member = "HalfTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT163Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT163Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT163Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT163FieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT163FieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT163K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x60001A0")]
	public static UInt64[] CreateExt64() { }

	[Address(RVA = "0x10CBBB0", Offset = "0x10CADB0", Length = "0x112")]
	[CalledBy(Type = typeof(Nat384), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Nat384), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Nat192), Member = "Sub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A1")]
	public static bool Diff(UInt32[] x, int xOff, UInt32[] y, int yOff, UInt32[] z, int zOff) { }

	[Address(RVA = "0x10CBD40", Offset = "0x10CAF40", Length = "0x63")]
	[CalledBy(Type = typeof(SecP192K1FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP192K1FieldElement), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecP192K1FieldElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SecP192R1FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP192R1FieldElement), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecP192R1FieldElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A2")]
	public static bool Eq(UInt32[] x, UInt32[] y) { }

	[Address(RVA = "0x10CBCD0", Offset = "0x10CAED0", Length = "0x63")]
	[CalledBy(Type = typeof(SecT131FieldElement), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecT131FieldElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SecT163FieldElement), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecT163FieldElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A3")]
	public static bool Eq64(UInt64[] x, UInt64[] y) { }

	[Address(RVA = "0x10CBDB0", Offset = "0x10CAFB0", Length = "0x5A")]
	[CalledBy(Type = typeof(SecP192K1FieldElement), Member = "TestBitZero", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SecP192R1FieldElement), Member = "TestBitZero", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A4")]
	public static uint GetBit(UInt32[] x, int bit) { }

	[Address(RVA = "0x10CBE80", Offset = "0x10CB080", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A6")]
	public static bool Gte(UInt32[] x, int xOff, UInt32[] y, int yOff) { }

	[Address(RVA = "0x10CBE10", Offset = "0x10CB010", Length = "0x67")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A5")]
	public static bool Gte(UInt32[] x, UInt32[] y) { }

	[Address(RVA = "0x10CBF80", Offset = "0x10CB180", Length = "0x56")]
	[CalledBy(Type = typeof(SecP192K1FieldElement), Member = "get_IsOne", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SecP192K1FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP192R1FieldElement), Member = "get_IsOne", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SecP192R1FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A7")]
	public static bool IsOne(UInt32[] x) { }

	[Address(RVA = "0x10CBF20", Offset = "0x10CB120", Length = "0x58")]
	[CalledBy(Type = typeof(SecT131FieldElement), Member = "get_IsOne", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SecT163FieldElement), Member = "get_IsOne", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A8")]
	public static bool IsOne64(UInt64[] x) { }

	[Address(RVA = "0x10CC040", Offset = "0x10CB240", Length = "0x50")]
	[CalledBy(Type = typeof(SecP192K1FieldElement), Member = "get_IsZero", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SecP192K1FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP192K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecP192R1FieldElement), Member = "get_IsZero", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SecP192R1FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP192R1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A9")]
	public static bool IsZero(UInt32[] x) { }

	[Address(RVA = "0x10CBFE0", Offset = "0x10CB1E0", Length = "0x51")]
	[CalledBy(Type = typeof(SecT131Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT131FieldElement), Member = "get_IsZero", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SecT163Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT163FieldElement), Member = "get_IsZero", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SecT163K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001AA")]
	public static bool IsZero64(UInt64[] x) { }

	[Address(RVA = "0x10CC6A0", Offset = "0x10CB8A0", Length = "0x287")]
	[CalledBy(Type = typeof(Nat384), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecP192R1Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192R1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001AB")]
	public static void Mul(UInt32[] x, UInt32[] y, UInt32[] zz) { }

	[Address(RVA = "0x10CC930", Offset = "0x10CBB30", Length = "0x33D")]
	[CalledBy(Type = typeof(Nat384), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001AC")]
	public static void Mul(UInt32[] x, int xOff, UInt32[] y, int yOff, UInt32[] zz, int zzOff) { }

	[Address(RVA = "0x10CC0A0", Offset = "0x10CB2A0", Length = "0x212")]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001AE")]
	public static ulong Mul33Add(uint w, UInt32[] x, int xOff, UInt32[] y, int yOff, UInt32[] z, int zOff) { }

	[Address(RVA = "0x10CC2C0", Offset = "0x10CB4C0", Length = "0x10A")]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001AF")]
	public static uint Mul33DWordAdd(uint x, ulong y, UInt32[] z, int zOff) { }

	[Address(RVA = "0x10CC3D0", Offset = "0x10CB5D0", Length = "0xD8")]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "Reduce32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B0")]
	public static uint Mul33WordAdd(uint x, uint y, UInt32[] z, int zOff) { }

	[Address(RVA = "0x10CC4B0", Offset = "0x10CB6B0", Length = "0x1E4")]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "MultiplyAddToExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecP192R1Field), Member = "MultiplyAddToExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192R1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001AD")]
	public static uint MulAddTo(UInt32[] x, UInt32[] y, UInt32[] zz) { }

	[Address(RVA = "0x10CCC70", Offset = "0x10CBE70", Length = "0x425")]
	[CalledBy(Type = typeof(Nat384), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192R1Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192R1Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B1")]
	public static void Square(UInt32[] x, UInt32[] zz) { }

	[Address(RVA = "0x10CD0A0", Offset = "0x10CC2A0", Length = "0x55B")]
	[CalledBy(Type = typeof(Nat384), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B2")]
	public static void Square(UInt32[] x, int xOff, UInt32[] zz, int zzOff) { }

	[Address(RVA = "0x10CD710", Offset = "0x10CC910", Length = "0x14D")]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "Negate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1FieldElement), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP192K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecP192K1Point), Member = "Twice", ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecP192R1Field), Member = "Negate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192R1Field), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B3")]
	public static int Sub(UInt32[] x, UInt32[] y, UInt32[] z) { }

	[Address(RVA = "0x10CD860", Offset = "0x10CCA60", Length = "0x1CE")]
	[CalledBy(Type = typeof(Nat192), Member = "Diff", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B4")]
	public static int Sub(UInt32[] x, int xOff, UInt32[] y, int yOff, UInt32[] z, int zOff) { }

	[Address(RVA = "0x10CD600", Offset = "0x10CC800", Length = "0x10A")]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(UInt32[]))]
	[CalledBy(Type = typeof(SecP192K1FieldElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192R1Field), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(UInt32[]))]
	[CalledBy(Type = typeof(SecP192R1FieldElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B5")]
	public static int SubFrom(UInt32[] x, UInt32[] z) { }

	[Address(RVA = "0x10CDB20", Offset = "0x10CCD20", Length = "0xE7")]
	[CalledBy(Type = typeof(SecP192K1FieldElement), Member = "ToBigInteger", ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(SecP192R1FieldElement), Member = "ToBigInteger", ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Pack), Member = "UInt32_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B6")]
	public static BigInteger ToBigInteger(UInt32[] x) { }

	[Address(RVA = "0x10CDA30", Offset = "0x10CCC30", Length = "0xE9")]
	[CalledBy(Type = typeof(SecT131FieldElement), Member = "ToBigInteger", ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(SecT163FieldElement), Member = "ToBigInteger", ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B7")]
	public static BigInteger ToBigInteger64(UInt64[] x) { }

}

