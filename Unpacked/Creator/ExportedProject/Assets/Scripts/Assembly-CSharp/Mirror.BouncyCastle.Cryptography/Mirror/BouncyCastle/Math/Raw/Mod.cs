namespace Mirror.BouncyCastle.Math.Raw;

[Token(Token = "0x2000024")]
internal static class Mod
{
	[Token(Token = "0x4000078")]
	private static readonly int MaxStackAlloc; //Field offset: 0x0

	[Address(RVA = "0x10C8C20", Offset = "0x10C7E20", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Platform), Member = "get_Is64BitProcess", ReturnType = typeof(bool))]
	[Token(Token = "0x6000134")]
	private static Mod() { }

	[Address(RVA = "0x10C6030", Offset = "0x10C5230", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000125")]
	private static int Add30(int len30, Int32[] D, Int32[] M) { }

	[Address(RVA = "0x10C6340", Offset = "0x10C5540", Length = "0xB6")]
	[CalledBy(Type = typeof(SecP256R1Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SM2P256V1Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP521R1Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP384R1Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP256K1Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP224K1Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP224R1Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP160R2Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP160R1Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP128R1Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192R1Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Mod), Member = "ModOddInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600011E")]
	public static void CheckedModOddInverse(UInt32[] m, UInt32[] x, UInt32[] z) { }

	[Address(RVA = "0x10C6110", Offset = "0x10C5310", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000126")]
	private static void CNegate30(int len30, int cond, Int32[] D) { }

	[Address(RVA = "0x10C61B0", Offset = "0x10C53B0", Length = "0x18F")]
	[CalledBy(Type = typeof(Mod), Member = "ModOddInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000127")]
	private static void CNormalize30(int len30, int condNegate, Int32[] D, Int32[] M) { }

	[Address(RVA = "0x10C6400", Offset = "0x10C5600", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000128")]
	private static void Decode30(int bits, Int32[] x, UInt32[] z) { }

	[Address(RVA = "0x10C6520", Offset = "0x10C5720", Length = "0x18A")]
	[CalledBy(Type = typeof(Mod), Member = "ModOddInverseVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Mod), Member = "ModOddIsCoprimeVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Integers), Member = "NumberOfTrailingZeros", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000129")]
	private static int Divsteps30Var(int eta, int f0, int g0, Int32[] t) { }

	[Address(RVA = "0x10C66B0", Offset = "0x10C58B0", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600012A")]
	private static void Encode30(int bits, UInt32[] x, Int32[] z) { }

	[Address(RVA = "0x10C6840", Offset = "0x10C5A40", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600012B")]
	private static int EqualTo(int len, Int32[] x, int y) { }

	[Address(RVA = "0x10C67D0", Offset = "0x10C59D0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600012C")]
	private static bool EqualToVar(int len, Int32[] x, int y) { }

	[Address(RVA = "0x10C68B0", Offset = "0x10C5AB0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600012D")]
	private static int GetMaximumDivsteps(int bits) { }

	[Address(RVA = "0x10C68E0", Offset = "0x10C5AE0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600012E")]
	private static int GetMaximumHDDivsteps(int bits) { }

	[Address(RVA = "0x10C6900", Offset = "0x10C5B00", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600012F")]
	private static int HDDivsteps30(int theta, int f0, int g0, Int32[] t) { }

	[Address(RVA = "0x10C69E0", Offset = "0x10C5BE0", Length = "0x46")]
	[CalledBy(Type = typeof(BigInteger), Member = "ModPowMonty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "GetMQuote", ReturnType = typeof(uint))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x600011F")]
	public static uint Inverse32(uint d) { }

	[Address(RVA = "0x10C6A30", Offset = "0x10C5C30", Length = "0x5F")]
	[CalledBy(Type = typeof(BigInteger), Member = "ModInversePow2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000120")]
	public static ulong Inverse64(ulong d) { }

	[Address(RVA = "0x10C7550", Offset = "0x10C6750", Length = "0x8BE")]
	[CalledBy(Type = typeof(BigIntegers), Member = "ModOddInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Mod), Member = "CheckedModOddInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mod), Member = "CNormalize30", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mod), Member = "UpdateFG30", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mod), Member = "UpdateDE30", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(Int32[]), typeof(Int32[]), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Integers), Member = "NumberOfLeadingZeros", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000121")]
	public static uint ModOddInverse(UInt32[] m, UInt32[] x, UInt32[] z) { }

	[Address(RVA = "0x10C6A90", Offset = "0x10C5C90", Length = "0xAB3")]
	[CalledBy(Type = typeof(BigIntegers), Member = "ModOddInverseVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Ed448), Member = "InvertZs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "InvVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "InvVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Mod), Member = "UpdateFG30", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mod), Member = "UpdateDE30", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(Int32[]), typeof(Int32[]), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mod), Member = "Divsteps30Var", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Integers), Member = "NumberOfLeadingZeros", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000122")]
	public static bool ModOddInverseVar(UInt32[] m, UInt32[] x, UInt32[] z) { }

	[Address(RVA = "0x10C7E10", Offset = "0x10C7010", Length = "0x6EF")]
	[CalledBy(Type = typeof(BigIntegers), Member = "ModOddIsCoprimeVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Integers), Member = "NumberOfLeadingZeros", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mod), Member = "Divsteps30Var", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mod), Member = "UpdateFG30", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000123")]
	public static bool ModOddIsCoprimeVar(UInt32[] m, UInt32[] x) { }

	[Address(RVA = "0x10C8500", Offset = "0x10C7700", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000130")]
	private static int Negate30(int len30, Int32[] D) { }

	[Address(RVA = "0x10C8590", Offset = "0x10C7790", Length = "0x19A")]
	[CalledBy(Type = typeof(SecP224R1FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000124")]
	public static UInt32[] Random(SecureRandom random, UInt32[] p) { }

	[Address(RVA = "0x10C8730", Offset = "0x10C7930", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000131")]
	private static int TrimFG30Var(int len30, Int32[] F, Int32[] G) { }

	[Address(RVA = "0x10C87C0", Offset = "0x10C79C0", Length = "0x2A2")]
	[CalledBy(Type = typeof(Mod), Member = "ModOddInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Mod), Member = "ModOddInverseVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000132")]
	private static void UpdateDE30(int len30, Int32[] D, Int32[] E, Int32[] t, int m0Inv32, Int32[] M) { }

	[Address(RVA = "0x10C8A70", Offset = "0x10C7C70", Length = "0x1AA")]
	[CalledBy(Type = typeof(Mod), Member = "ModOddInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Mod), Member = "ModOddInverseVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Mod), Member = "ModOddIsCoprimeVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000133")]
	private static void UpdateFG30(int len30, Int32[] F, Int32[] G, Int32[] t) { }

}

