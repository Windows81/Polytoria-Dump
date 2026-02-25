namespace Mirror.BouncyCastle.Math.EC.Abc;

[Token(Token = "0x2000108")]
internal static class Tnaf
{
	[Token(Token = "0x2000109")]
	private sealed class PartModPreCompCallback : IPreCompCallback
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400022C")]
		private readonly AbstractF2mCurve m_curve; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400022D")]
		private readonly sbyte m_mu; //Field offset: 0x18
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x400022E")]
		private readonly bool m_doV; //Field offset: 0x19

		[Address(RVA = "0x11553A0", Offset = "0x11545A0", Length = "0x56")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B03")]
		internal PartModPreCompCallback(AbstractF2mCurve curve, sbyte mu, bool doV) { }

		[Address(RVA = "0x11F0B90", Offset = "0x11EFD90", Length = "0x2AE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Tnaf), Member = "GetLucas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(int), typeof(bool)}, ReturnType = typeof(BigInteger[]))]
		[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(Tnaf), Member = "GetSi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AbstractF2mCurve)}, ReturnType = typeof(BigInteger[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6000B04")]
		public override PreCompInfo Precompute(PreCompInfo existing) { }

	}

	[Token(Token = "0x200010A")]
	private sealed class PartModPreCompInfo : PreCompInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400022F")]
		private readonly BigInteger m_lucas; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000230")]
		private readonly BigInteger m_s0; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000231")]
		private readonly BigInteger m_s1; //Field offset: 0x20

		[Token(Token = "0x1700013E")]
		internal BigInteger Lucas
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B06")]
			internal get { } //Length: 5
		}

		[Token(Token = "0x1700013F")]
		internal BigInteger S0
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B07")]
			internal get { } //Length: 5
		}

		[Token(Token = "0x17000140")]
		internal BigInteger S1
		{
			[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B08")]
			internal get { } //Length: 5
		}

		[Address(RVA = "0x1013590", Offset = "0x1012790", Length = "0x6B")]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B05")]
		internal PartModPreCompInfo(BigInteger lucas, BigInteger s0, BigInteger s1) { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B06")]
		internal BigInteger get_Lucas() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B07")]
		internal BigInteger get_S0() { }

		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B08")]
		internal BigInteger get_S1() { }

	}

	[Token(Token = "0x4000223")]
	private static readonly BigInteger MinusOne; //Field offset: 0x0
	[Token(Token = "0x4000224")]
	private static readonly BigInteger MinusTwo; //Field offset: 0x8
	[Token(Token = "0x4000225")]
	private static readonly BigInteger MinusThree; //Field offset: 0x10
	[Token(Token = "0x4000226")]
	private static readonly BigInteger Four; //Field offset: 0x18
	[Token(Token = "0x4000227")]
	private static readonly string PRECOMP_NAME; //Field offset: 0x20
	[Token(Token = "0x4000228")]
	public static readonly ZTauElement[] Alpha0; //Field offset: 0x28
	[Token(Token = "0x4000229")]
	public static readonly SByte[][] Alpha0Tnaf; //Field offset: 0x30
	[Token(Token = "0x400022A")]
	public static readonly ZTauElement[] Alpha1; //Field offset: 0x38
	[Token(Token = "0x400022B")]
	public static readonly SByte[][] Alpha1Tnaf; //Field offset: 0x40

	[Address(RVA = "0x11D8E40", Offset = "0x11D8040", Length = "0xDCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "Negate", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Token(Token = "0x6000B02")]
	private static Tnaf() { }

	[Address(RVA = "0x11D7090", Offset = "0x11D6290", Length = "0x192")]
	[CalledBy(Type = typeof(Tnaf), Member = "PartModReduction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AbstractF2mCurve), typeof(BigInteger), typeof(sbyte), typeof(sbyte), typeof(sbyte)}, ReturnType = typeof(ZTauElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "ShiftRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SimpleBigDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AF7")]
	public static SimpleBigDecimal ApproximateDivisionByN(BigInteger k, BigInteger s, BigInteger vm, sbyte a, int m, int c) { }

	[Address(RVA = "0x11D7230", Offset = "0x11D6430", Length = "0x1E4")]
	[CalledBy(Type = typeof(PartModPreCompCallback), Member = "Precompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PreCompInfo)}, ReturnType = typeof(PreCompInfo))]
	[CalledBy(Type = typeof(Tnaf), Member = "GetTw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Tnaf), Member = "GetSi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BigInteger), Member = "Negate", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Token(Token = "0x6000AF9")]
	public static BigInteger[] GetLucas(sbyte mu, int k, bool doV) { }

	[Address(RVA = "0x11D7420", Offset = "0x11D6620", Length = "0x12")]
	[CalledBy(Type = typeof(WTauNafMultiplier), Member = "MultiplyPositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000AF8")]
	public static sbyte GetMu(int curveA) { }

	[Address(RVA = "0x11D7440", Offset = "0x11D6640", Length = "0x28A")]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier+WTauNafCallback", Member = "Precompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PreCompInfo)}, ReturnType = typeof(PreCompInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Tnaf), Member = "MultiplyFromTnaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AbstractF2mPoint), typeof(AbstractF2mPoint), typeof(SByte[])}, ReturnType = typeof(AbstractF2mPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000B01")]
	public static AbstractF2mPoint[] GetPreComp(AbstractF2mPoint p, sbyte a) { }

	[Address(RVA = "0x11D76D0", Offset = "0x11D68D0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(BigInteger), Member = "get_IntValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000AFD")]
	private static int GetShiftsForCofactor(BigInteger h) { }

	[Address(RVA = "0x11D7760", Offset = "0x11D6960", Length = "0x14D")]
	[CalledBy(Type = typeof(PartModPreCompCallback), Member = "Precompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PreCompInfo)}, ReturnType = typeof(PreCompInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "get_IntValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 5)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000AFB")]
	public static BigInteger[] GetSi(AbstractF2mCurve curve) { }

	[Address(RVA = "0x11D78B0", Offset = "0x11D6AB0", Length = "0x2C1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(BigInteger), Member = "ShiftRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(BigInteger), Member = "Negate", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(Tnaf), Member = "GetLucas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(int), typeof(bool)}, ReturnType = typeof(BigInteger[]))]
	[Calls(Type = typeof(BigInteger), Member = "get_IntValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AFC")]
	public static BigInteger[] GetSi(int fieldSize, int curveA, BigInteger cofactor) { }

	[Address(RVA = "0x11D7B80", Offset = "0x11D6D80", Length = "0x184")]
	[CalledBy(Type = typeof(WTauNafMultiplier), Member = "MultiplyPositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(WTauNafMultiplier), Member = "MultiplyWTnaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AbstractF2mPoint), typeof(ZTauElement), typeof(sbyte), typeof(sbyte)}, ReturnType = typeof(AbstractF2mPoint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Tnaf), Member = "GetLucas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(int), typeof(bool)}, ReturnType = typeof(BigInteger[]))]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "ModDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AFA")]
	public static BigInteger GetTw(sbyte mu, int w) { }

	[Address(RVA = "0x11D7D10", Offset = "0x11D6F10", Length = "0x1E6")]
	[CalledBy(Type = typeof(Tnaf), Member = "GetPreComp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AbstractF2mPoint), typeof(sbyte)}, ReturnType = typeof(AbstractF2mPoint[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000AFF")]
	public static AbstractF2mPoint MultiplyFromTnaf(AbstractF2mPoint p, AbstractF2mPoint pNeg, SByte[] u) { }

	[Address(RVA = "0x11D7F00", Offset = "0x11D7100", Length = "0x123")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "Square", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000AF5")]
	public static BigInteger Norm(sbyte mu, ZTauElement lambda) { }

	[Address(RVA = "0x11D8030", Offset = "0x11D7230", Length = "0x2F8")]
	[CalledBy(Type = typeof(WTauNafMultiplier), Member = "MultiplyPositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(Tnaf), Member = "ApproximateDivisionByN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(sbyte), typeof(int), typeof(int)}, ReturnType = typeof(SimpleBigDecimal))]
	[Calls(Type = typeof(Tnaf), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleBigDecimal), typeof(SimpleBigDecimal), typeof(sbyte)}, ReturnType = typeof(ZTauElement))]
	[Calls(Type = typeof(BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000AFE")]
	public static ZTauElement PartModReduction(AbstractF2mCurve curve, BigInteger k, sbyte a, sbyte mu, sbyte c) { }

	[Address(RVA = "0x11D8330", Offset = "0x11D7530", Length = "0x54B")]
	[CalledBy(Type = typeof(Tnaf), Member = "PartModReduction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AbstractF2mCurve), typeof(BigInteger), typeof(sbyte), typeof(sbyte), typeof(sbyte)}, ReturnType = typeof(ZTauElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "ValueOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(SimpleBigDecimal), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleBigDecimal)}, ReturnType = typeof(SimpleBigDecimal))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SimpleBigDecimal), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleBigDecimal)}, ReturnType = typeof(SimpleBigDecimal))]
	[Calls(Type = typeof(SimpleBigDecimal), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(SimpleBigDecimal))]
	[Calls(Type = typeof(SimpleBigDecimal), Member = "Round", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AF6")]
	public static ZTauElement Round(SimpleBigDecimal lambda0, SimpleBigDecimal lambda1, sbyte mu) { }

	[Address(RVA = "0x11D8880", Offset = "0x11D7A80", Length = "0x5BF")]
	[CalledBy(Type = typeof(WTauNafMultiplier), Member = "MultiplyPositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(WTauNafMultiplier), Member = "MultiplyWTnaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AbstractF2mPoint), typeof(ZTauElement), typeof(sbyte), typeof(sbyte)}, ReturnType = typeof(AbstractF2mPoint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(BigInteger), Member = "get_LongValueExact", ReturnType = typeof(long))]
	[Calls(Type = typeof(BigInteger), Member = "Negate", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "ShiftRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "get_IntValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Square", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "get_IntValueExact", ReturnType = typeof(int))]
	[Token(Token = "0x6000B00")]
	public static SByte[] TauAdicWNaf(sbyte mu, ZTauElement lambda, int width, int tw, ZTauElement[] alpha) { }

}

