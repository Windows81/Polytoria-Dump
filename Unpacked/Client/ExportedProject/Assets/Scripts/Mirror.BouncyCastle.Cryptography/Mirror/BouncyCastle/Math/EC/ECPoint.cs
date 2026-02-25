namespace Mirror.BouncyCastle.Math.EC;

[Token(Token = "0x2000048")]
public abstract class ECPoint
{
	[Token(Token = "0x2000049")]
	private class ValidityCallback : IPreCompCallback
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B2")]
		private readonly ECPoint m_outer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B3")]
		private readonly bool m_decompressed; //Field offset: 0x18
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x40000B4")]
		private readonly bool m_checkOrder; //Field offset: 0x19

		[Address(RVA = "0x11553A0", Offset = "0x11545A0", Length = "0x56")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600030E")]
		internal ValidityCallback(ECPoint outer, bool decompressed, bool checkOrder) { }

		[Address(RVA = "0x1155280", Offset = "0x1154480", Length = "0x11B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ValidityPreCompInfo), Member = "ReportOrderPassed", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600030F")]
		public override PreCompInfo Precompute(PreCompInfo existing) { }

	}

	[Token(Token = "0x40000AC")]
	protected static readonly ECFieldElement[] EMPTY_ZS; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000AD")]
	protected private readonly ECCurve m_curve; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000AE")]
	protected private readonly ECFieldElement m_x; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000AF")]
	protected private readonly ECFieldElement m_y; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000B0")]
	protected private readonly ECFieldElement[] m_zs; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000B1")]
	protected private IDictionary<String, PreCompInfo> m_preCompTable; //Field offset: 0x30

	[Token(Token = "0x1700003C")]
	public override ECFieldElement AffineXCoord
	{
		[Address(RVA = "0x113F9E0", Offset = "0x113EBE0", Length = "0x38")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60002EC")]
		 get { } //Length: 56
	}

	[Token(Token = "0x1700003D")]
	public override ECFieldElement AffineYCoord
	{
		[Address(RVA = "0x113FA20", Offset = "0x113EC20", Length = "0x38")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60002ED")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000044")]
	protected private abstract bool CompressionYTilde
	{
		[Token(Token = "0x6000304")]
		private get { } //Length: 0
	}

	[Token(Token = "0x1700003A")]
	public override ECCurve Curve
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002EA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700003B")]
	protected override int CurveCoordinateSystem
	{
		[Address(RVA = "0x113FA60", Offset = "0x113EC60", Length = "0x22")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60002EB")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000043")]
	public bool IsInfinity
	{
		[Address(RVA = "0x113FA90", Offset = "0x113EC90", Length = "0x13")]
		[CallerCount(Count = 222)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60002F9")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000040")]
	protected private ECFieldElement RawXCoord
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F1")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000041")]
	protected private ECFieldElement RawYCoord
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F2")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000042")]
	protected private ECFieldElement[] RawZCoords
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F3")]
		private get { } //Length: 5
	}

	[Token(Token = "0x1700003E")]
	public override ECFieldElement XCoord
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002EE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700003F")]
	public override ECFieldElement YCoord
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002EF")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x113F820", Offset = "0x113EA20", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600030D")]
	private static ECPoint() { }

	[Address(RVA = "0x113F910", Offset = "0x113EB10", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ECPoint), Member = "GetInitialZCoords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve)}, ReturnType = typeof(ECFieldElement[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002E6")]
	protected ECPoint(ECCurve curve, ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x113F890", Offset = "0x113EA90", Length = "0x7D")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E7")]
	internal ECPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs) { }

	[Token(Token = "0x6000305")]
	public abstract ECPoint Add(ECPoint b) { }

	[Address(RVA = "0x113E270", Offset = "0x113D470", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002F4")]
	protected override void CheckNormalized() { }

	[Address(RVA = "0x113E2F0", Offset = "0x113D4F0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60002F8")]
	protected override ECPoint CreateScaledPoint(ECFieldElement sx, ECFieldElement sy) { }

	[Address(RVA = "0x113E3B0", Offset = "0x113D5B0", Length = "0x342")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000300")]
	public override bool Equals(ECPoint other) { }

	[Address(RVA = "0x113E700", Offset = "0x113D900", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002FF")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x113F9E0", Offset = "0x113EBE0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002EC")]
	public override ECFieldElement get_AffineXCoord() { }

	[Address(RVA = "0x113FA20", Offset = "0x113EC20", Length = "0x38")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002ED")]
	public override ECFieldElement get_AffineYCoord() { }

	[Token(Token = "0x6000304")]
	protected private abstract bool get_CompressionYTilde() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EA")]
	public override ECCurve get_Curve() { }

	[Address(RVA = "0x113FA60", Offset = "0x113EC60", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002EB")]
	protected override int get_CurveCoordinateSystem() { }

	[Address(RVA = "0x113FA90", Offset = "0x113EC90", Length = "0x13")]
	[CallerCount(Count = 222)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002F9")]
	public bool get_IsInfinity() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002F1")]
	protected private ECFieldElement get_RawXCoord() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002F2")]
	protected private ECFieldElement get_RawYCoord() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002F3")]
	protected private ECFieldElement[] get_RawZCoords() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EE")]
	public override ECFieldElement get_XCoord() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EF")]
	public override ECFieldElement get_YCoord() { }

	[Token(Token = "0x6000303")]
	public abstract Byte[] GetEncoded(bool compressed) { }

	[Address(RVA = "0x113E790", Offset = "0x113D990", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000301")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x113E8A0", Offset = "0x113DAA0", Length = "0xD8")]
	[CalledBy(Type = typeof(ECPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ECPointBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60002E5")]
	protected static ECFieldElement[] GetInitialZCoords(ECCurve curve) { }

	[Address(RVA = "0x113EC50", Offset = "0x113DE50", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F0")]
	public override ECFieldElement GetZCoord(int index) { }

	[Address(RVA = "0x113EC90", Offset = "0x113DE90", Length = "0x160")]
	[CalledBy(Type = typeof(ECAlgorithms), Member = "ImplCheckResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(ECCurve), Member = "ValidatePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(ECCurve), Member = "DecodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(ECPoint), Member = "IsValid", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ECPoint), Member = "IsValidPartial", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002FC")]
	internal bool ImplIsValid(bool decompressed, bool checkOrder) { }

	[Address(RVA = "0x113EE00", Offset = "0x113E000", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002F5")]
	public override bool IsNormalized() { }

	[Address(RVA = "0x113EE90", Offset = "0x113E090", Length = "0xD")]
	[CalledBy(Type = typeof(ECDomainParameters), Member = "ValidatePublicPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ECPoint), Member = "ImplIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60002FA")]
	public bool IsValid() { }

	[Address(RVA = "0x113EE80", Offset = "0x113E080", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ECPoint), Member = "ImplIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60002FB")]
	internal bool IsValidPartial() { }

	[Token(Token = "0x600030A")]
	public abstract ECPoint Multiply(BigInteger b) { }

	[Token(Token = "0x6000307")]
	public abstract ECPoint Negate() { }

	[Address(RVA = "0x113F0A0", Offset = "0x113E2A0", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60002F7")]
	internal override ECPoint Normalize(ECFieldElement zInv) { }

	[Address(RVA = "0x113EEA0", Offset = "0x113E0A0", Length = "0x1F6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x60002F6")]
	public override ECPoint Normalize() { }

	[Token(Token = "0x60002E8")]
	protected abstract bool SatisfiesCurveEquation() { }

	[Address(RVA = "0x113F1F0", Offset = "0x113E3F0", Length = "0x236")]
	[CalledBy(Type = typeof(AbstractF2mPoint), Member = "SatisfiesOrder", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "Abs", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002E9")]
	protected override bool SatisfiesOrder() { }

	[Address(RVA = "0x113F430", Offset = "0x113E630", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002FD")]
	public override ECPoint ScaleX(ECFieldElement scale) { }

	[Address(RVA = "0x113F4E0", Offset = "0x113E6E0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002FE")]
	public override ECPoint ScaleY(ECFieldElement scale) { }

	[Token(Token = "0x6000306")]
	public abstract ECPoint Subtract(ECPoint b) { }

	[Address(RVA = "0x113F5A0", Offset = "0x113E7A0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600030C")]
	public override ECPoint ThreeTimes() { }

	[Address(RVA = "0x113F5C0", Offset = "0x113E7C0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000308")]
	public override ECPoint TimesPow2(int e) { }

	[Address(RVA = "0x113F670", Offset = "0x113E870", Length = "0x157")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000302")]
	public virtual string ToString() { }

	[Token(Token = "0x6000309")]
	public abstract ECPoint Twice() { }

	[Address(RVA = "0x113F7D0", Offset = "0x113E9D0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600030B")]
	public override ECPoint TwicePlus(ECPoint b) { }

}

