namespace Mirror.BouncyCastle.Math.EC;

[Token(Token = "0x200003F")]
public abstract class AbstractF2mCurve : ECCurve
{

	[Token(Token = "0x1700002B")]
	public override bool IsKoblitz
	{
		[Address(RVA = "0x1136D90", Offset = "0x1135F90", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x600027A")]
		 get { } //Length: 142
	}

	[Address(RVA = "0x1136B90", Offset = "0x1135D90", Length = "0x1FC")]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(FiniteFields), Member = "GetBinaryExtensionField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(IPolynomialExtensionField))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Platform), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000275")]
	protected AbstractF2mCurve(int m, int k1, int k2, int k3) { }

	[Address(RVA = "0x1136090", Offset = "0x1135290", Length = "0x1CB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Platform), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(FiniteFields), Member = "GetBinaryExtensionField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(IPolynomialExtensionField))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000274")]
	private static IFiniteField BuildField(int m, int k1, int k2, int k3) { }

	[Address(RVA = "0x1136260", Offset = "0x1135460", Length = "0x19D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x6000276")]
	public virtual ECPoint CreatePoint(BigInteger x, BigInteger y) { }

	[Address(RVA = "0x1136400", Offset = "0x1135600", Length = "0x293")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AbstractF2mCurve), Member = "SolveQuadraticEquation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000278")]
	protected virtual ECPoint DecompressPoint(int yTilde, BigInteger X1) { }

	[Address(RVA = "0x1136D90", Offset = "0x1135F90", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600027A")]
	public override bool get_IsKoblitz() { }

	[Address(RVA = "0x11366A0", Offset = "0x11358A0", Length = "0x6D")]
	[CalledBy(Type = typeof(AbstractF2mCurve), Member = "RandomFieldElementMult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureRandom)}, ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigIntegers), Member = "CreateRandomBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SecureRandom)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600027B")]
	private static BigInteger ImplRandomFieldElementMult(SecureRandom r, int m) { }

	[Address(RVA = "0x1136710", Offset = "0x1135910", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AbstractF2mCurve), Member = "ImplRandomFieldElementMult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureRandom), typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000277")]
	public virtual ECFieldElement RandomFieldElementMult(SecureRandom r) { }

	[Address(RVA = "0x11367D0", Offset = "0x11359D0", Length = "0x3BD")]
	[CalledBy(Type = typeof(AbstractF2mCurve), Member = "DecompressPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(AbstractF2mPoint), Member = "SatisfiesOrder", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "Arbitrary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 20)]
	[Token(Token = "0x6000279")]
	internal ECFieldElement SolveQuadraticEquation(ECFieldElement beta) { }

}

