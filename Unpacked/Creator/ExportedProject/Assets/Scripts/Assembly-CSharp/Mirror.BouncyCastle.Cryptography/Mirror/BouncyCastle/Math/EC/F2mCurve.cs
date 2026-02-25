namespace Mirror.BouncyCastle.Math.EC;

[Token(Token = "0x2000040")]
public class F2mCurve : AbstractF2mCurve
{
	[Token(Token = "0x2000041")]
	private class DefaultF2mLookupTable : AbstractECLookupTable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000A2")]
		private readonly F2mCurve m_outer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000A3")]
		private readonly UInt64[] m_table; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000A4")]
		private readonly int m_size; //Field offset: 0x20

		[Token(Token = "0x1700002E")]
		public virtual int Size
		{
			[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x600028A")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x1139D30", Offset = "0x1138F30", Length = "0x5F")]
		[CallerCount(Count = 46)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000289")]
		internal DefaultF2mLookupTable(F2mCurve outer, UInt64[] table, int size) { }

		[Address(RVA = "0x11397C0", Offset = "0x11389C0", Length = "0x232")]
		[CalledBy(Type = typeof(DefaultF2mLookupTable), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
		[CalledBy(Type = typeof(DefaultF2mLookupTable), Member = "LookupVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600028D")]
		private ECPoint CreatePoint(UInt64[] x, UInt64[] y) { }

		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600028A")]
		public virtual int get_Size() { }

		[Address(RVA = "0x1139B70", Offset = "0x1138D70", Length = "0x1BF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(DefaultF2mLookupTable), Member = "CreatePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600028B")]
		public virtual ECPoint Lookup(int index) { }

		[Address(RVA = "0x1139A00", Offset = "0x1138C00", Length = "0x160")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(DefaultF2mLookupTable), Member = "CreatePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600028C")]
		public virtual ECPoint LookupVar(int index) { }

	}

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400009D")]
	private readonly int m; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400009E")]
	private readonly int k1; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400009F")]
	private readonly int k2; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40000A0")]
	private readonly int k3; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000A1")]
	protected readonly F2mPoint m_infinity; //Field offset: 0x68

	[Token(Token = "0x1700002C")]
	public virtual int FieldSize
	{
		[Address(RVA = "0x406220", Offset = "0x405420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000282")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700002D")]
	public virtual ECPoint Infinity
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000286")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1144D30", Offset = "0x1143F30", Length = "0x137")]
	[CalledBy(Type = typeof(Sect193r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect409r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect409k1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect239k1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect233r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect233k1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect193r2Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect113r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect113r2Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2tnb359v1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2tnb239v3Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2tnb239v2Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2tnb239v1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2tnb191v3Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2tnb191v2Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2tnb191v1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2tnb431r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ECPointBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AbstractF2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600027C")]
	public F2mCurve(int m, int k, BigInteger a, BigInteger b, BigInteger order, BigInteger cofactor) { }

	[Address(RVA = "0x1144BE0", Offset = "0x1143DE0", Length = "0x149")]
	[CalledBy(Type = typeof(Sect163k1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect571r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect571k1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect283r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect283k1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect163r2Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect163r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(Sect131r1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(X9Curve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X9FieldID), typeof(BigInteger), typeof(BigInteger), typeof(Asn1Sequence)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sect131r2Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2pnb304w1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2pnb272w1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2pnb208w1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2pnb176w1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2pnb163v3Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2pnb163v2Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2pnb163v1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(C2pnb368w1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ECPointBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AbstractF2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600027D")]
	public F2mCurve(int m, int k1, int k2, int k3, BigInteger a, BigInteger b, BigInteger order, BigInteger cofactor) { }

	[Address(RVA = "0x1144AC0", Offset = "0x1143CC0", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AbstractF2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ECPointBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x600027E")]
	internal F2mCurve(int m, int k1, int k2, int k3, ECFieldElement a, ECFieldElement b, BigInteger order, BigInteger cofactor) { }

	[Address(RVA = "0x1144230", Offset = "0x1143430", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AbstractF2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ECPointBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x600027F")]
	protected virtual ECCurve CloneCurve() { }

	[Address(RVA = "0x1144390", Offset = "0x1143590", Length = "0x248")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000288")]
	public virtual ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len) { }

	[Address(RVA = "0x11445E0", Offset = "0x11437E0", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GlvMultiplier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(GlvEndomorphism)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000281")]
	protected virtual ECMultiplier CreateDefaultMultiplier() { }

	[Address(RVA = "0x1144700", Offset = "0x1143900", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ECPointBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(F2mFieldElement), Member = "CheckFieldElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000284")]
	protected private virtual ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x1144820", Offset = "0x1143A20", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ECPointBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000285")]
	protected private virtual ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs) { }

	[Address(RVA = "0x11448B0", Offset = "0x1143AB0", Length = "0x1D7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(LongArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000283")]
	public virtual ECFieldElement FromBigInteger(BigInteger x) { }

	[Address(RVA = "0x406220", Offset = "0x405420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000282")]
	public virtual int get_FieldSize() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000286")]
	public virtual ECPoint get_Infinity() { }

	[Address(RVA = "0x1144A90", Offset = "0x1143C90", Length = "0x11")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000287")]
	public bool IsTrinomial() { }

	[Address(RVA = "0x1144AB0", Offset = "0x1143CB0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000280")]
	public virtual bool SupportsCoordinateSystem(int coord) { }

}

