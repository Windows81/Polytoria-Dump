namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

[Token(Token = "0x20000E5")]
internal static class SecT239Field
{

	[Address(RVA = "0x11973D0", Offset = "0x11965D0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000938")]
	public static void Add(UInt64[] x, UInt64[] y, UInt64[] z) { }

	[Address(RVA = "0x11B21C0", Offset = "0x11B13C0", Length = "0x15B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000939")]
	public static void AddExt(UInt64[] xx, UInt64[] yy, UInt64[] zz) { }

	[Address(RVA = "0x11ABEB0", Offset = "0x11AB0B0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600093A")]
	public static void AddOne(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x11ABF30", Offset = "0x11AB130", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600093B")]
	public static void AddTo(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x11B92D0", Offset = "0x11B84D0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat), Member = "FromBigInteger64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BigInteger)}, ReturnType = typeof(UInt64[]))]
	[Token(Token = "0x600093C")]
	public static UInt64[] FromBigInteger(BigInteger x) { }

	[Address(RVA = "0x11B92E0", Offset = "0x11B84E0", Length = "0x125")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat256), Member = "Copy64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT239Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600093D")]
	public static void HalfTrace(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x11B9410", Offset = "0x11B8610", Length = "0x14E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000947")]
	private static void ImplCompactExt(UInt64[] zz) { }

	[Address(RVA = "0x11B9560", Offset = "0x11B8760", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000948")]
	private static void ImplExpand(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x11B9620", Offset = "0x11B8820", Length = "0x664")]
	[CalledBy(Type = typeof(SecT239Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT239Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT239Field), Member = "MultiplyAddToExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT239FieldElement), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SecT239Field), Member = "ImplMulwAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(ulong), typeof(ulong), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000949")]
	private static void ImplMultiply(UInt64[] x, UInt64[] y, UInt64[] zz) { }

	[Address(RVA = "0x11B9C90", Offset = "0x11B8E90", Length = "0x1E3")]
	[CalledBy(Type = typeof(SecT239Field), Member = "ImplMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600094A")]
	private static void ImplMulwAcc(UInt64[] u, ulong x, ulong y, UInt64[] z, int zOff) { }

	[Address(RVA = "0x11B2EB0", Offset = "0x11B20B0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600094B")]
	private static void ImplSquare(UInt64[] x, UInt64[] zz) { }

	[Address(RVA = "0x11B9E80", Offset = "0x11B9080", Length = "0x464")]
	[CalledBy(Type = typeof(SecT239FieldElement), Member = "Invert", ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nat256), Member = "IsZero64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nat256), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT239Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT239Field), Member = "ImplMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT239Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600093E")]
	public static void Invert(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x11BA420", Offset = "0x11B9620", Length = "0x5A")]
	[CalledBy(Type = typeof(SecT239K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT239Field), Member = "ImplMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600093F")]
	public static void Multiply(UInt64[] x, UInt64[] y, UInt64[] z) { }

	[Address(RVA = "0x11BA2F0", Offset = "0x11B94F0", Length = "0x122")]
	[CalledBy(Type = typeof(SecT239FieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT239FieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT239K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(SecT239Field), Member = "ImplMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000940")]
	public static void MultiplyAddToExt(UInt64[] x, UInt64[] y, UInt64[] zz) { }

	[Address(RVA = "0x11BA480", Offset = "0x11B9680", Length = "0x195")]
	[CalledBy(Type = typeof(SecT239Field), Member = "HalfTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT239Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT239Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT239Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT239Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT239FieldElement), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT239FieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT239FieldElement), Member = "Square", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT239FieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT239FieldElement), Member = "HalfTrace", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT239K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000941")]
	public static void Reduce(UInt64[] xx, UInt64[] z) { }

	[Address(RVA = "0x11BA620", Offset = "0x11B9820", Length = "0x274")]
	[CalledBy(Type = typeof(SecT239FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Interleave), Member = "Unshuffle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong), typeof(UInt64&)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SecT239Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000942")]
	public static void Sqrt(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x11BA950", Offset = "0x11B9B50", Length = "0x5A")]
	[CalledBy(Type = typeof(SecT239K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT239Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000943")]
	public static void Square(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x11B2EB0", Offset = "0x11B20B0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000944")]
	public static void SquareExt(UInt64[] x, UInt64[] zz) { }

	[Address(RVA = "0x11BA8A0", Offset = "0x11B9AA0", Length = "0xAD")]
	[CalledBy(Type = typeof(SecT239Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT239FieldElement), Member = "SquarePow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Nat256), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT239Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000945")]
	public static void SquareN(UInt64[] x, int n, UInt64[] z) { }

	[Address(RVA = "0x11BA9B0", Offset = "0x11B9BB0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000946")]
	public static uint Trace(UInt64[] x) { }

}

