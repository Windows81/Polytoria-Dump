namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

[Token(Token = "0x20000DD")]
internal static class SecT233Field
{

	[Address(RVA = "0x11973D0", Offset = "0x11965D0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D6")]
	public static void Add(UInt64[] x, UInt64[] y, UInt64[] z) { }

	[Address(RVA = "0x11B2110", Offset = "0x11B1310", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008D7")]
	public static void AddBothTo(UInt64[] x, UInt64[] y, UInt64[] z) { }

	[Address(RVA = "0x11B21C0", Offset = "0x11B13C0", Length = "0x15B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D8")]
	public static void AddExt(UInt64[] xx, UInt64[] yy, UInt64[] zz) { }

	[Address(RVA = "0x11ABEB0", Offset = "0x11AB0B0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D9")]
	public static void AddOne(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x11ABF30", Offset = "0x11AB130", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008DA")]
	public static void AddTo(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x11B2320", Offset = "0x11B1520", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat), Member = "FromBigInteger64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BigInteger)}, ReturnType = typeof(UInt64[]))]
	[Token(Token = "0x60008DB")]
	public static UInt64[] FromBigInteger(BigInteger x) { }

	[Address(RVA = "0x11B2330", Offset = "0x11B1530", Length = "0x125")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat256), Member = "Copy64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT233Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008DC")]
	public static void HalfTrace(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x11B2460", Offset = "0x11B1660", Length = "0x14E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008E7")]
	private static void ImplCompactExt(UInt64[] zz) { }

	[Address(RVA = "0x11B25B0", Offset = "0x11B17B0", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008E8")]
	private static void ImplExpand(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x11B2670", Offset = "0x11B1870", Length = "0x664")]
	[CalledBy(Type = typeof(SecT233Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT233Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT233Field), Member = "MultiplyAddToExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT233Field), Member = "MultiplyExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT233FieldElement), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Token(Token = "0x60008E9")]
	private static void ImplMultiply(UInt64[] x, UInt64[] y, UInt64[] zz) { }

	[Address(RVA = "0x11B2CE0", Offset = "0x11B1EE0", Length = "0x1C5")]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008EA")]
	private static void ImplMulwAcc(UInt64[] u, ulong x, ulong y, UInt64[] z, int zOff) { }

	[Address(RVA = "0x11B2EB0", Offset = "0x11B20B0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60008EB")]
	private static void ImplSquare(UInt64[] x, UInt64[] zz) { }

	[Address(RVA = "0x11B2EE0", Offset = "0x11B20E0", Length = "0x3A8")]
	[CalledBy(Type = typeof(SecT233FieldElement), Member = "Invert", ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nat256), Member = "IsZero64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT233Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT233Field), Member = "ImplMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT233Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60008DD")]
	public static void Invert(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x11B3410", Offset = "0x11B2610", Length = "0x5A")]
	[CalledBy(Type = typeof(SecT233K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecT233R1Point), Member = "Twice", ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecT233R1Point), Member = "TwicePlus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT233Field), Member = "ImplMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60008DE")]
	public static void Multiply(UInt64[] x, UInt64[] y, UInt64[] z) { }

	[Address(RVA = "0x11B3290", Offset = "0x11B2490", Length = "0x122")]
	[CalledBy(Type = typeof(SecT233FieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT233FieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT233K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecT233R1Point), Member = "Twice", ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecT233R1Point), Member = "TwicePlus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT233Field), Member = "ImplMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008DF")]
	public static void MultiplyAddToExt(UInt64[] x, UInt64[] y, UInt64[] zz) { }

	[Address(RVA = "0x11B33C0", Offset = "0x11B25C0", Length = "0x4B")]
	[CalledBy(Type = typeof(SecT233R1Point), Member = "TwicePlus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT233Field), Member = "ImplMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60008E0")]
	public static void MultiplyExt(UInt64[] x, UInt64[] y, UInt64[] zz) { }

	[Address(RVA = "0x11B3470", Offset = "0x11B2670", Length = "0x19C")]
	[CalledBy(Type = typeof(SecT233FieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT233Field), Member = "HalfTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT233Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT233Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT233Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT233Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT233FieldElement), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT233FieldElement), Member = "Square", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT233FieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT233FieldElement), Member = "HalfTrace", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT233K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecT233R1Point), Member = "Twice", ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecT233R1Point), Member = "TwicePlus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008E1")]
	public static void Reduce(UInt64[] xx, UInt64[] z) { }

	[Address(RVA = "0x11B3610", Offset = "0x11B2810", Length = "0x243")]
	[CalledBy(Type = typeof(SecT233FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Interleave), Member = "Unshuffle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong), typeof(UInt64&)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT233Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008E2")]
	public static void Sqrt(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x11B3910", Offset = "0x11B2B10", Length = "0x5A")]
	[CalledBy(Type = typeof(SecT233K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecT233R1Point), Member = "Twice", ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecT233R1Point), Member = "TwicePlus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT233Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60008E3")]
	public static void Square(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x11B2EB0", Offset = "0x11B20B0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60008E4")]
	public static void SquareExt(UInt64[] x, UInt64[] zz) { }

	[Address(RVA = "0x11B3860", Offset = "0x11B2A60", Length = "0xAD")]
	[CalledBy(Type = typeof(SecT233Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT233FieldElement), Member = "SquarePow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT233Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60008E5")]
	public static void SquareN(UInt64[] x, int n, UInt64[] z) { }

	[Address(RVA = "0x11B3970", Offset = "0x11B2B70", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008E6")]
	public static uint Trace(UInt64[] x) { }

}

