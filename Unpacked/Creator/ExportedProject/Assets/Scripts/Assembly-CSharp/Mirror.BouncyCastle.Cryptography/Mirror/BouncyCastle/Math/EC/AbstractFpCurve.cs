namespace Mirror.BouncyCastle.Math.EC;

[Token(Token = "0x200003C")]
public abstract class AbstractFpCurve : ECCurve
{
	[CompilerGenerated]
	[Token(Token = "0x200003D")]
	private sealed class <>c
	{
		[Token(Token = "0x4000098")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000099")]
		public static Func<BigInteger, Boolean, Boolean> <>9__2_0; //Field offset: 0x8

		[Address(RVA = "0x1155210", Offset = "0x1154410", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000266")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000267")]
		public <>c() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000268")]
		internal bool <.ctor>b__2_0(BigInteger key, bool value) { }

	}

	[Token(Token = "0x4000097")]
	private static readonly ConcurrentDictionary<BigInteger, Boolean> KnownPrimes; //Field offset: 0x0

	[Address(RVA = "0x1138B20", Offset = "0x1137D20", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Boolean>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000265")]
	private static AbstractFpCurve() { }

	[Address(RVA = "0x1138BB0", Offset = "0x1137DB0", Length = "0x4E8")]
	[CalledBy(Type = typeof(SM2P256V1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP256R1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP256K1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP224R1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP224K1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192R1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP192K1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP160R2Curve), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP160R1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP160K1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP128R1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FpCurve), Member = "CloneCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(ECFieldElement), typeof(ECFieldElement), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP384R1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecP521R1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Boolean>), Member = "AddOrUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(System.Func`3<System.Object, System.Boolean, System.Boolean>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Func`3<System.Object, System.Boolean, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Boolean>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AbstractFpCurve), Member = "ImplIsPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Platform), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Boolean>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = "get_IntValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600025E")]
	internal AbstractFpCurve(BigInteger q, bool isInternal) { }

	[Address(RVA = "0x1138390", Offset = "0x1137590", Length = "0x1D7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000260")]
	protected virtual ECPoint DecompressPoint(int yTilde, BigInteger X1) { }

	[Address(RVA = "0x1138570", Offset = "0x1137770", Length = "0x177")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Platform), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(AbstractFpCurve), Member = "ImplIsPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000261")]
	private static void ImplCheckQ(BigInteger q) { }

	[Address(RVA = "0x11386F0", Offset = "0x11378F0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000262")]
	private static int ImplGetIterations(int bits, int certainty) { }

	[Address(RVA = "0x1138780", Offset = "0x1137980", Length = "0x1C7")]
	[CalledBy(Type = typeof(AbstractFpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AbstractFpCurve), Member = "ImplCheckQ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Primes), Member = "HasAnySmallFactors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ECCurve), Member = "ImplGetInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(Primes), Member = "IsMRProbablePrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(SecureRandom), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000263")]
	private static bool ImplIsPrime(BigInteger q) { }

	[Address(RVA = "0x1138950", Offset = "0x1137B50", Length = "0xA6")]
	[CalledBy(Type = typeof(AbstractFpCurve), Member = "RandomFieldElementMult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureRandom)}, ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigIntegers), Member = "CreateRandomBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SecureRandom)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000264")]
	private static BigInteger ImplRandomFieldElementMult(SecureRandom r, BigInteger p) { }

	[Address(RVA = "0x1138A00", Offset = "0x1137C00", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AbstractFpCurve), Member = "ImplRandomFieldElementMult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureRandom), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600025F")]
	public virtual ECFieldElement RandomFieldElementMult(SecureRandom r) { }

}

