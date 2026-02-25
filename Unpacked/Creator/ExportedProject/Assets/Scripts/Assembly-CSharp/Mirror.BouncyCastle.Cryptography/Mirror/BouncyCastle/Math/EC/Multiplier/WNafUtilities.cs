namespace Mirror.BouncyCastle.Math.EC.Multiplier;

[Token(Token = "0x2000071")]
public abstract class WNafUtilities
{
	[Token(Token = "0x2000072")]
	private class ConfigureBasepointCallback : IPreCompCallback
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000113")]
		private readonly ECCurve m_curve; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000114")]
		private readonly int m_confWidth; //Field offset: 0x18

		[Address(RVA = "0x351B70", Offset = "0x350D70", Length = "0x42")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000442")]
		internal ConfigureBasepointCallback(ECCurve curve, int confWidth) { }

		[Address(RVA = "0x1155510", Offset = "0x1154710", Length = "0x1DB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 10)]
		[Token(Token = "0x6000443")]
		public override PreCompInfo Precompute(PreCompInfo existing) { }

	}

	[Token(Token = "0x2000073")]
	private class PrecomputeCallback : IPreCompCallback
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000115")]
		private readonly ECPoint m_p; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000116")]
		private readonly int m_minWidth; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000117")]
		private readonly bool m_includeNegated; //Field offset: 0x1C

		[Address(RVA = "0x115CA10", Offset = "0x115BC10", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000444")]
		internal PrecomputeCallback(ECPoint p, int minWidth, bool includeNegated) { }

		[Address(RVA = "0x115BD50", Offset = "0x115AF50", Length = "0x125")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000446")]
		private bool CheckExisting(WNafPreCompInfo existingWNaf, int width, int reqPreCompLen, bool includeNegated) { }

		[Address(RVA = "0x115BE80", Offset = "0x115B080", Length = "0x10")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000447")]
		private bool CheckTable(ECPoint[] table, int reqLen) { }

		[Address(RVA = "0x115BE90", Offset = "0x115B090", Length = "0xB72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ECAlgorithms), Member = "IsFpCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ECPoint), Member = "get_IsInfinity", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 33)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000445")]
		public override PreCompInfo Precompute(PreCompInfo existing) { }

	}

	[Token(Token = "0x2000074")]
	private class PrecomputeWithPointMapCallback : IPreCompCallback
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000118")]
		private readonly ECPoint m_point; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000119")]
		private readonly ECPointMap m_pointMap; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400011A")]
		private readonly WNafPreCompInfo m_fromWNaf; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400011B")]
		private readonly bool m_includeNegated; //Field offset: 0x28

		[Address(RVA = "0x115D040", Offset = "0x115C240", Length = "0x74")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000448")]
		internal PrecomputeWithPointMapCallback(ECPoint point, ECPointMap pointMap, WNafPreCompInfo fromWNaf, bool includeNegated) { }

		[Address(RVA = "0x115CA70", Offset = "0x115BC70", Length = "0xB7")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600044A")]
		private bool CheckExisting(WNafPreCompInfo existingWNaf, int width, int reqPreCompLen, bool includeNegated) { }

		[Address(RVA = "0x115BE80", Offset = "0x115B080", Length = "0x10")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600044B")]
		private bool CheckTable(ECPoint[] table, int reqLen) { }

		[Address(RVA = "0x115CB30", Offset = "0x115BD30", Length = "0x50E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 13)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000449")]
		public override PreCompInfo Precompute(PreCompInfo existing) { }

	}

	[Token(Token = "0x400010F")]
	public static readonly string PRECOMP_NAME; //Field offset: 0x0
	[Token(Token = "0x4000110")]
	private static readonly Int32[] DEFAULT_WINDOW_SIZE_CUTOFFS; //Field offset: 0x8
	[Token(Token = "0x4000111")]
	private static readonly int MAX_WIDTH; //Field offset: 0x10
	[Token(Token = "0x4000112")]
	private static readonly ECPoint[] EMPTY_POINTS; //Field offset: 0x18

	[Address(RVA = "0x1163ED0", Offset = "0x11630D0", Length = "0x12A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000441")]
	private static WNafUtilities() { }

	[Address(RVA = "0x1162A30", Offset = "0x1161C30", Length = "0x1DE")]
	[CalledBy(Type = typeof(AnssiNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(X962NamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(GMNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(ECGost3410NamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(Frp256v1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WNafUtilities), Member = "GetWindowSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000433")]
	public static void ConfigureBasepoint(ECPoint p) { }

	[Address(RVA = "0x1162C10", Offset = "0x1161E10", Length = "0x2D8")]
	[CalledBy(Type = typeof(WNafUtilities), Member = "GenerateCompactWindowNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BigInteger)}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "Xor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000434")]
	public static Int32[] GenerateCompactNaf(BigInteger k) { }

	[Address(RVA = "0x1162EF0", Offset = "0x11620F0", Length = "0x323")]
	[CalledBy(Type = typeof(WNafL2RMultiplier), Member = "MultiplyPositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "ShiftRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(WNafUtilities), Member = "GenerateCompactNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(WNafUtilities), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "get_IntValue", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000435")]
	public static Int32[] GenerateCompactWindowNaf(int width, BigInteger k) { }

	[Address(RVA = "0x1163220", Offset = "0x1162420", Length = "0x1C1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(BigInteger), Member = "Xor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000436")]
	public static Byte[] GenerateNaf(BigInteger k) { }

	[Address(RVA = "0x11633F0", Offset = "0x11625F0", Length = "0x467")]
	[CalledBy(Type = typeof(ECAlgorithms), Member = "ImplShamirsTrickWNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger), typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(ECAlgorithms), Member = "ImplShamirsTrickWNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECEndomorphism), typeof(ECPoint), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BigInteger), Member = "get_IntValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(BigInteger), Member = "Xor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(BigInteger), Member = "ShiftRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000437")]
	public static Byte[] GenerateWindowNaf(int width, BigInteger k) { }

	[Address(RVA = "0x1163860", Offset = "0x1162A60", Length = "0x68")]
	[CalledBy(Type = typeof(ECKeyPairGenerator), Member = "GenerateKeyPair", ReturnType = typeof(AsymmetricCipherKeyPair))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Xor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "get_BitCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000438")]
	public static int GetNafWeight(BigInteger k) { }

	[Address(RVA = "0x1163940", Offset = "0x1162B40", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000439")]
	public static int GetWindowSize(int bits) { }

	[Address(RVA = "0x11638D0", Offset = "0x1162AD0", Length = "0x6B")]
	[CalledBy(Type = typeof(ECAlgorithms), Member = "ImplShamirsTrickWNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger), typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(ECAlgorithms), Member = "ImplShamirsTrickWNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECEndomorphism), typeof(ECPoint), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WNafUtilities), Member = "GetWindowSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x600043A")]
	public static int GetWindowSize(int bits, int maxWidth) { }

	[Address(RVA = "0x11639B0", Offset = "0x1162BB0", Length = "0xB8")]
	[CalledBy(Type = typeof(WNafL2RMultiplier), Member = "MultiplyPositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(WNafUtilities), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WNafUtilities), Member = "GetWindowSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600043B")]
	public static int GetWindowSize(int bits, Int32[] windowSizeCutoffs, int maxWidth) { }

	[Address(RVA = "0x1163BF0", Offset = "0x1162DF0", Length = "0x155")]
	[CalledBy(Type = typeof(ECAlgorithms), Member = "ImplShamirsTrickWNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger), typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(ECAlgorithms), Member = "ImplShamirsTrickWNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECEndomorphism), typeof(ECPoint), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600043C")]
	public static WNafPreCompInfo Precompute(ECPoint p, int minWidth, bool includeNegated) { }

	[Address(RVA = "0x1163A70", Offset = "0x1162C70", Length = "0x17F")]
	[CalledBy(Type = typeof(ECAlgorithms), Member = "ImplShamirsTrickWNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECEndomorphism), typeof(ECPoint), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600043D")]
	public static WNafPreCompInfo PrecomputeWithPointMap(ECPoint p, ECPointMap pointMap, WNafPreCompInfo fromWNaf, bool includeNegated) { }

	[Address(RVA = "0x1163D50", Offset = "0x1162F50", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000440")]
	private static ECPoint[] ResizeTable(ECPoint[] a, int length) { }

	[Address(RVA = "0x1163E50", Offset = "0x1163050", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600043E")]
	private static Byte[] Trim(Byte[] a, int length) { }

	[Address(RVA = "0x1163DD0", Offset = "0x1162FD0", Length = "0x74")]
	[CalledBy(Type = typeof(WNafUtilities), Member = "GenerateCompactWindowNaf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BigInteger)}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600043F")]
	private static Int32[] Trim(Int32[] a, int length) { }

}

