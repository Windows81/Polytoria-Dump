namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

[Token(Token = "0x20000D2")]
internal class SecT163R2Curve : AbstractF2mCurve
{
	[Token(Token = "0x20000D3")]
	private class SecT163R2LookupTable : AbstractECLookupTable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001D3")]
		private readonly SecT163R2Curve m_outer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001D4")]
		private readonly UInt64[] m_table; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D5")]
		private readonly int m_size; //Field offset: 0x20

		[Token(Token = "0x170000DA")]
		public virtual int Size
		{
			[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x600086B")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x1160640", Offset = "0x115F840", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600086A")]
		internal SecT163R2LookupTable(SecT163R2Curve outer, UInt64[] table, int size) { }

		[Address(RVA = "0x11A96F0", Offset = "0x11A88F0", Length = "0x105")]
		[CalledBy(Type = typeof(SecT163R2LookupTable), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
		[CalledBy(Type = typeof(SecT163R2LookupTable), Member = "LookupVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600086E")]
		private ECPoint CreatePoint(UInt64[] x, UInt64[] y) { }

		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600086B")]
		public virtual int get_Size() { }

		[Address(RVA = "0x11A9910", Offset = "0x11A8B10", Length = "0x13B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat192), Member = "Create64", ReturnType = typeof(UInt64[]))]
		[Calls(Type = typeof(SecT163R2LookupTable), Member = "CreatePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600086C")]
		public virtual ECPoint Lookup(int index) { }

		[Address(RVA = "0x11A9800", Offset = "0x11A8A00", Length = "0x10F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat192), Member = "Create64", ReturnType = typeof(UInt64[]))]
		[Calls(Type = typeof(SecT163R2LookupTable), Member = "CreatePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600086D")]
		public virtual ECPoint LookupVar(int index) { }

	}

	[Token(Token = "0x40001D1")]
	private static readonly ECFieldElement[] SECT163R2_AFFINE_ZS; //Field offset: 0x0
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001D2")]
	protected readonly SecT163R2Point m_infinity; //Field offset: 0x58

	[Token(Token = "0x170000D8")]
	public virtual int FieldSize
	{
		[Address(RVA = "0x11A4CE0", Offset = "0x11A3EE0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000863")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000D7")]
	public virtual ECPoint Infinity
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000862")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000D9")]
	public virtual bool IsKoblitz
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000867")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x11A93C0", Offset = "0x11A85C0", Length = "0x12C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SecT163FieldElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000869")]
	private static SecT163R2Curve() { }

	[Address(RVA = "0x11A94F0", Offset = "0x11A86F0", Length = "0x1F4")]
	[CalledBy(Type = typeof(SecT163R2Curve), Member = "CloneCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(SecT163R2Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AbstractF2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600085F")]
	public SecT163R2Curve() { }

	[Address(RVA = "0x11A8FF0", Offset = "0x11A81F0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SecT163R2Curve), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000860")]
	protected virtual ECCurve CloneCurve() { }

	[Address(RVA = "0x11A9040", Offset = "0x11A8240", Length = "0x204")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Nat192), Member = "Copy64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000868")]
	public virtual ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len) { }

	[Address(RVA = "0x11A92E0", Offset = "0x11A84E0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000865")]
	protected private virtual ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x11A9250", Offset = "0x11A8450", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000866")]
	protected private virtual ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs) { }

	[Address(RVA = "0x11A9360", Offset = "0x11A8560", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SecT163FieldElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000864")]
	public virtual ECFieldElement FromBigInteger(BigInteger x) { }

	[Address(RVA = "0x11A4CE0", Offset = "0x11A3EE0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000863")]
	public virtual int get_FieldSize() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000862")]
	public virtual ECPoint get_Infinity() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000867")]
	public virtual bool get_IsKoblitz() { }

	[Address(RVA = "0x1198700", Offset = "0x1197900", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000861")]
	public virtual bool SupportsCoordinateSystem(int coord) { }

}

