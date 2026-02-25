namespace Mirror.BouncyCastle.Math;

[Token(Token = "0x2000021")]
public static class Primes
{
	[Token(Token = "0x4000074")]
	public static readonly int SmallFactorLimit; //Field offset: 0x0
	[Token(Token = "0x4000075")]
	private static readonly BigInteger One; //Field offset: 0x8
	[Token(Token = "0x4000076")]
	private static readonly BigInteger Two; //Field offset: 0x10
	[Token(Token = "0x4000077")]
	private static readonly BigInteger Three; //Field offset: 0x18

	[Address(RVA = "0x10D67A0", Offset = "0x10D59A0", Length = "0x142")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000111")]
	private static Primes() { }

	[Address(RVA = "0x10D5810", Offset = "0x10D4A10", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600010E")]
	private static void CheckCandidate(BigInteger n, string name) { }

	[Address(RVA = "0x10D5890", Offset = "0x10D4A90", Length = "0xCA")]
	[CalledBy(Type = typeof(AbstractFpCurve), Member = "ImplIsPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600010C")]
	public static bool HasAnySmallFactors(BigInteger candidate) { }

	[Address(RVA = "0x10D5960", Offset = "0x10D4B60", Length = "0x8A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Mod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "get_IntValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600010F")]
	private static bool ImplHasAnySmallFactors(BigInteger x) { }

	[Address(RVA = "0x10D6210", Offset = "0x10D5410", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "ModPow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "Square", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Mod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000110")]
	private static bool ImplMRProbablePrimeToBase(BigInteger w, BigInteger wSubOne, BigInteger m, int a, BigInteger b) { }

	[Address(RVA = "0x10D6380", Offset = "0x10D5580", Length = "0x41D")]
	[CalledBy(Type = typeof(AbstractFpCurve), Member = "ImplIsPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "ShiftRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(BigInteger), Member = "Mod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Square", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "ModPow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(BigInteger), Member = "GetLowestSetBit", ReturnType = typeof(int))]
	[Calls(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigIntegers), Member = "CreateRandomInRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(SecureRandom)}, ReturnType = typeof(BigInteger))]
	[Token(Token = "0x600010D")]
	public static bool IsMRProbablePrime(BigInteger candidate, SecureRandom random, int iterations) { }

}

