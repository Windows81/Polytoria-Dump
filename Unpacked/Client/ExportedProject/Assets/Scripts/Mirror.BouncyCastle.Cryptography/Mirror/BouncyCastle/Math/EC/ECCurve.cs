namespace Mirror.BouncyCastle.Math.EC;

[Token(Token = "0x2000039")]
public abstract class ECCurve
{
	[Token(Token = "0x200003A")]
	internal class Config
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000090")]
		protected ECCurve outer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000091")]
		protected int coord; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000092")]
		protected ECEndomorphism endomorphism; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000093")]
		protected ECMultiplier multiplier; //Field offset: 0x28

		[Address(RVA = "0x1139750", Offset = "0x1138950", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000256")]
		internal Config(ECCurve outer, int coord, ECEndomorphism endomorphism, ECMultiplier multiplier) { }

		[Address(RVA = "0x1139600", Offset = "0x1138800", Length = "0x12B")]
		[CalledBy(Type = typeof(CustomNamedCurves), Member = "ConfigureCurveGlv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(ECCurve))]
		[CalledBy(Type = typeof(SecNamedCurves), Member = "ConfigureCurveGlv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(ECCurve))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000258")]
		public ECCurve Create() { }

		[Address(RVA = "0x1139730", Offset = "0x1138930", Length = "0x1F")]
		[CalledBy(Type = typeof(CustomNamedCurves), Member = "ConfigureCurveGlv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(ECCurve))]
		[CalledBy(Type = typeof(SecNamedCurves), Member = "ConfigureCurveGlv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvTypeBParameters)}, ReturnType = typeof(ECCurve))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000257")]
		public Config SetEndomorphism(ECEndomorphism endomorphism) { }

	}

	[Token(Token = "0x200003B")]
	private class DefaultLookupTable : AbstractECLookupTable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000094")]
		private readonly ECCurve m_outer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000095")]
		private readonly Byte[] m_table; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000096")]
		private readonly int m_size; //Field offset: 0x20

		[Token(Token = "0x17000028")]
		public virtual int Size
		{
			[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x600025A")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x1139D30", Offset = "0x1138F30", Length = "0x5F")]
		[CallerCount(Count = 46)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000259")]
		internal DefaultLookupTable(ECCurve outer, Byte[] table, int size) { }

		[Address(RVA = "0x1139D90", Offset = "0x1138F90", Length = "0x112")]
		[CalledBy(Type = typeof(DefaultLookupTable), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
		[CalledBy(Type = typeof(DefaultLookupTable), Member = "LookupVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x600025D")]
		private ECPoint CreatePoint(Byte[] x, Byte[] y) { }

		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600025A")]
		public virtual int get_Size() { }

		[Address(RVA = "0x113A030", Offset = "0x1139230", Length = "0x1D3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(DefaultLookupTable), Member = "CreatePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600025B")]
		public virtual ECPoint Lookup(int index) { }

		[Address(RVA = "0x1139EB0", Offset = "0x11390B0", Length = "0x173")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(DefaultLookupTable), Member = "CreatePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600025C")]
		public virtual ECPoint LookupVar(int index) { }

	}

	[Token(Token = "0x400007F")]
	public const int COORD_AFFINE = 0; //Field offset: 0x0
	[Token(Token = "0x4000080")]
	public const int COORD_HOMOGENEOUS = 1; //Field offset: 0x0
	[Token(Token = "0x4000081")]
	public const int COORD_JACOBIAN = 2; //Field offset: 0x0
	[Token(Token = "0x4000082")]
	public const int COORD_JACOBIAN_CHUDNOVSKY = 3; //Field offset: 0x0
	[Token(Token = "0x4000083")]
	public const int COORD_JACOBIAN_MODIFIED = 4; //Field offset: 0x0
	[Token(Token = "0x4000084")]
	public const int COORD_LAMBDA_AFFINE = 5; //Field offset: 0x0
	[Token(Token = "0x4000085")]
	public const int COORD_LAMBDA_PROJECTIVE = 6; //Field offset: 0x0
	[Token(Token = "0x4000086")]
	public const int COORD_SKEWED = 7; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000087")]
	protected readonly IFiniteField m_field; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000088")]
	protected ECFieldElement m_a; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000089")]
	protected ECFieldElement m_b; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400008A")]
	protected BigInteger m_order; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400008B")]
	protected BigInteger m_cofactor; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400008C")]
	protected int m_coord; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400008D")]
	protected ECEndomorphism m_endomorphism; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400008E")]
	protected ECMultiplier m_multiplier; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400008F")]
	private IDictionary<String, PreCompInfo> m_preCompTable; //Field offset: 0x50

	[Token(Token = "0x17000023")]
	public override ECFieldElement A
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000247")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000024")]
	public override ECFieldElement B
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000248")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000026")]
	public override BigInteger Cofactor
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x600024A")]
		 get { } //Length: 95
	}

	[Token(Token = "0x17000027")]
	public override int CoordinateSystem
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600024B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000022")]
	public override IFiniteField Field
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000246")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000020")]
	public override int FieldElementEncodingLength
	{
		[Address(RVA = "0x113D7C0", Offset = "0x113C9C0", Length = "0x28")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000238")]
		 get { } //Length: 40
	}

	[Token(Token = "0x1700001F")]
	public abstract int FieldSize
	{
		[Token(Token = "0x6000234")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000021")]
	public abstract ECPoint Infinity
	{
		[Token(Token = "0x6000245")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000025")]
	public override BigInteger Order
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000249")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000233")]
	protected ECCurve(IFiniteField field) { }

	[Address(RVA = "0x113BB90", Offset = "0x113AD90", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600024D")]
	protected override void CheckPoint(ECPoint point) { }

	[Address(RVA = "0x113BC30", Offset = "0x113AE30", Length = "0x1B3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600024E")]
	protected override void CheckPoints(ECPoint[] points, int off, int len) { }

	[Token(Token = "0x600023B")]
	protected abstract ECCurve CloneCurve() { }

	[Address(RVA = "0x113BDF0", Offset = "0x113AFF0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000237")]
	public override Config Configure() { }

	[Address(RVA = "0x113BEA0", Offset = "0x113B0A0", Length = "0x18C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600024C")]
	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len) { }

	[Address(RVA = "0x113C030", Offset = "0x113B230", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GlvMultiplier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvEndomorphism)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600023E")]
	protected override ECMultiplier CreateDefaultMultiplier() { }

	[Address(RVA = "0x113C0F0", Offset = "0x113B2F0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600023A")]
	public override ECPoint CreatePoint(BigInteger x, BigInteger y) { }

	[Token(Token = "0x600023C")]
	protected private abstract ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y) { }

	[Token(Token = "0x600023D")]
	protected private abstract ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs) { }

	[Address(RVA = "0x113C170", Offset = "0x113B370", Length = "0x58C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ECPoint), Member = "ImplIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000254")]
	public override ECPoint DecodePoint(Byte[] encoded) { }

	[Token(Token = "0x6000252")]
	protected abstract ECPoint DecompressPoint(int yTilde, BigInteger X1) { }

	[Address(RVA = "0x113C7B0", Offset = "0x113B9B0", Length = "0x1CD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 11)]
	[Token(Token = "0x600024F")]
	public override bool Equals(ECCurve other) { }

	[Address(RVA = "0x113C720", Offset = "0x113B920", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000250")]
	public virtual bool Equals(object obj) { }

	[Token(Token = "0x6000235")]
	public abstract ECFieldElement FromBigInteger(BigInteger x) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000247")]
	public override ECFieldElement get_A() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000248")]
	public override ECFieldElement get_B() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x600024A")]
	public override BigInteger get_Cofactor() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600024B")]
	public override int get_CoordinateSystem() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000246")]
	public override IFiniteField get_Field() { }

	[Address(RVA = "0x113D7C0", Offset = "0x113C9C0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000238")]
	public override int get_FieldElementEncodingLength() { }

	[Token(Token = "0x6000234")]
	public abstract int get_FieldSize() { }

	[Token(Token = "0x6000245")]
	public abstract ECPoint get_Infinity() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000249")]
	public override BigInteger get_Order() { }

	[Address(RVA = "0x113C980", Offset = "0x113BB80", Length = "0x15D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000251")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x113CAE0", Offset = "0x113BCE0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000253")]
	public override ECMultiplier GetMultiplier() { }

	[Address(RVA = "0x113CB30", Offset = "0x113BD30", Length = "0x76")]
	[CalledBy(Type = typeof(AbstractFpCurve), Member = "ImplIsPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Platform), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000255")]
	internal static int ImplGetInteger(string envVariable, int defaultValue) { }

	[Address(RVA = "0x113CBB0", Offset = "0x113BDB0", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000242")]
	public override ECPoint ImportPoint(ECPoint p) { }

	[Address(RVA = "0x113CD00", Offset = "0x113BF00", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000243")]
	public override void NormalizeAll(ECPoint[] points) { }

	[Address(RVA = "0x113CD40", Offset = "0x113BF40", Length = "0x3F8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ECAlgorithms), Member = "MontgomeryTrick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement[]), typeof(int), typeof(int), typeof(ECFieldElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000244")]
	public override void NormalizeAll(ECPoint[] points, int off, int len, ECFieldElement iso) { }

	[Address(RVA = "0x113D140", Offset = "0x113C340", Length = "0x30D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000241")]
	public override PreCompInfo Precompute(ECPoint point, string name, IPreCompCallback callback) { }

	[Address(RVA = "0x113D450", Offset = "0x113C650", Length = "0x2C8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000240")]
	internal override PreCompInfo Precompute(string name, IPreCompCallback callback) { }

	[Token(Token = "0x6000236")]
	public abstract ECFieldElement RandomFieldElementMult(SecureRandom r) { }

	[Address(RVA = "0x113D720", Offset = "0x113C920", Length = "0x6")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600023F")]
	public override bool SupportsCoordinateSystem(int coord) { }

	[Address(RVA = "0x113D730", Offset = "0x113C930", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ECPoint), Member = "ImplIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000239")]
	public override ECPoint ValidatePoint(BigInteger x, BigInteger y) { }

}

