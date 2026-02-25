namespace Mirror.BouncyCastle.Math.Raw;

[Token(Token = "0x2000026")]
internal static class Nat128
{

	[Address(RVA = "0x10C8DA0", Offset = "0x10C7FA0", Length = "0xE3")]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600016A")]
	public static uint Add(UInt32[] x, UInt32[] y, UInt32[] z) { }

	[Address(RVA = "0x10C8C90", Offset = "0x10C7E90", Length = "0x108")]
	[CalledBy(Type = typeof(SecP128R1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecP128R1Point), Member = "Twice", ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600016B")]
	public static uint AddBothTo(UInt32[] x, UInt32[] y, UInt32[] z) { }

	[Address(RVA = "0x10C8F40", Offset = "0x10C8140", Length = "0xA7")]
	[CalledBy(Type = typeof(SecP128R1Curve), Member = "CreateCacheSafeLookupTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint[]), typeof(int), typeof(int)}, ReturnType = typeof(ECLookupTable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600016C")]
	public static void Copy(UInt32[] x, int xOff, UInt32[] z, int zOff) { }

	[Address(RVA = "0x10C8E90", Offset = "0x10C8090", Length = "0x46")]
	[CalledBy(Type = typeof(SecT113Field), Member = "HalfTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600016D")]
	public static void Copy64(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x10C8EE0", Offset = "0x10C80E0", Length = "0x5A")]
	[CalledBy(Type = typeof(SecT113R1Curve), Member = "CreateCacheSafeLookupTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint[]), typeof(int), typeof(int)}, ReturnType = typeof(ECLookupTable))]
	[CalledBy(Type = typeof(SecT113R2Curve), Member = "CreateCacheSafeLookupTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint[]), typeof(int), typeof(int)}, ReturnType = typeof(ECLookupTable))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600016E")]
	public static void Copy64(UInt64[] x, int xOff, UInt64[] z, int zOff) { }

	[Address(RVA = "0x10C90B0", Offset = "0x10C82B0", Length = "0x35")]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "Divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Curve+SecP128R1LookupTable", Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Curve+SecP128R1LookupTable", Member = "LookupVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecP128R1Curve), Member = "RandomFieldElementMult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureRandom)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "AddOne", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "Negate", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "Square", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "Invert", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP128R1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecP128R1Point), Member = "Twice", ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600016F")]
	public static UInt32[] Create() { }

	[Address(RVA = "0x10C8FF0", Offset = "0x10C81F0", Length = "0x35")]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "SquarePow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Curve+SecT113R1LookupTable", Member = "LookupVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Curve+SecT113R1LookupTable", Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "Invert", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "HalfTrace", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Curve+SecT113R2LookupTable", Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "AddOne", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT113Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "Square", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Curve+SecT113R2LookupTable", Member = "LookupVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000170")]
	public static UInt64[] Create64() { }

	[Address(RVA = "0x10C9070", Offset = "0x10C8270", Length = "0x35")]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP128R1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x6000171")]
	public static UInt32[] CreateExt() { }

	[Address(RVA = "0x10C9030", Offset = "0x10C8230", Length = "0x35")]
	[CalledBy(Type = typeof(SecT113Field), Member = "HalfTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT113Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT113Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT113Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "Square", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x6000172")]
	public static UInt64[] CreateExt64() { }

	[Address(RVA = "0x10C9160", Offset = "0x10C8360", Length = "0x63")]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecP128R1FieldElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000173")]
	public static bool Eq(UInt32[] x, UInt32[] y) { }

	[Address(RVA = "0x10C90F0", Offset = "0x10C82F0", Length = "0x63")]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecT113FieldElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000174")]
	public static bool Eq64(UInt64[] x, UInt64[] y) { }

	[Address(RVA = "0x10C91D0", Offset = "0x10C83D0", Length = "0x5E")]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "TestBitZero", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000175")]
	public static uint GetBit(UInt32[] x, int bit) { }

	[Address(RVA = "0x10C9230", Offset = "0x10C8430", Length = "0x67")]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "AddOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(UInt32[]))]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "Reduce32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "Twice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "AddOne", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP128R1Point), Member = "Twice", ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000176")]
	public static bool Gte(UInt32[] x, UInt32[] y) { }

	[Address(RVA = "0x10C9300", Offset = "0x10C8500", Length = "0x56")]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "get_IsOne", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000177")]
	public static bool IsOne(UInt32[] x) { }

	[Address(RVA = "0x10C92A0", Offset = "0x10C84A0", Length = "0x58")]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "get_IsOne", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000178")]
	public static bool IsOne64(UInt64[] x) { }

	[Address(RVA = "0x10C93C0", Offset = "0x10C85C0", Length = "0x50")]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "get_IsZero", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecP128R1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000179")]
	public static bool IsZero(UInt32[] x) { }

	[Address(RVA = "0x10C9360", Offset = "0x10C8560", Length = "0x51")]
	[CalledBy(Type = typeof(SecT113Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "get_IsZero", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600017A")]
	public static bool IsZero64(UInt64[] x) { }

	[Address(RVA = "0x10C95A0", Offset = "0x10C87A0", Length = "0x1E7")]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP128R1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600017B")]
	public static void Mul(UInt32[] x, UInt32[] y, UInt32[] zz) { }

	[Address(RVA = "0x10C9420", Offset = "0x10C8620", Length = "0x17A")]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "MultiplyAddToExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP128R1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600017C")]
	public static uint MulAddTo(UInt32[] x, UInt32[] y, UInt32[] zz) { }

	[Address(RVA = "0x10C9790", Offset = "0x10C8990", Length = "0x28E")]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600017D")]
	public static void Square(UInt32[] x, UInt32[] zz) { }

	[Address(RVA = "0x10C9AE0", Offset = "0x10C8CE0", Length = "0xE3")]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "Negate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600017E")]
	public static int Sub(UInt32[] x, UInt32[] y, UInt32[] z) { }

	[Address(RVA = "0x10C9A20", Offset = "0x10C8C20", Length = "0xB6")]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(UInt32[]))]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600017F")]
	public static int SubFrom(UInt32[] x, UInt32[] z) { }

	[Address(RVA = "0x10C9CC0", Offset = "0x10C8EC0", Length = "0xE7")]
	[CalledBy(Type = typeof(SecP128R1FieldElement), Member = "ToBigInteger", ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Pack), Member = "UInt32_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000180")]
	public static BigInteger ToBigInteger(UInt32[] x) { }

	[Address(RVA = "0x10C9BD0", Offset = "0x10C8DD0", Length = "0xE4")]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "ToBigInteger", ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000181")]
	public static BigInteger ToBigInteger64(UInt64[] x) { }

}

