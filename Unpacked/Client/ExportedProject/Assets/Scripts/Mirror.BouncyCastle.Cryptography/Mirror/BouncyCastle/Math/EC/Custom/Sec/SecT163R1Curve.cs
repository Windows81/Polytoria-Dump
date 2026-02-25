namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

[Token(Token = "0x20000CF")]
internal class SecT163R1Curve : AbstractF2mCurve
{
	[Token(Token = "0x20000D0")]
	private class SecT163R1LookupTable : AbstractECLookupTable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001CE")]
		private readonly SecT163R1Curve m_outer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001CF")]
		private readonly UInt64[] m_table; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D0")]
		private readonly int m_size; //Field offset: 0x20

		[Token(Token = "0x170000D4")]
		public virtual int Size
		{
			[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000853")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x1160640", Offset = "0x115F840", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000852")]
		internal SecT163R1LookupTable(SecT163R1Curve outer, UInt64[] table, int size) { }

		[Address(RVA = "0x11A7760", Offset = "0x11A6960", Length = "0x105")]
		[CalledBy(Type = typeof(SecT163R1LookupTable), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
		[CalledBy(Type = typeof(SecT163R1LookupTable), Member = "LookupVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000856")]
		private ECPoint CreatePoint(UInt64[] x, UInt64[] y) { }

		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000853")]
		public virtual int get_Size() { }

		[Address(RVA = "0x11A7980", Offset = "0x11A6B80", Length = "0x13B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat192), Member = "Create64", ReturnType = typeof(UInt64[]))]
		[Calls(Type = typeof(SecT163R1LookupTable), Member = "CreatePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000854")]
		public virtual ECPoint Lookup(int index) { }

		[Address(RVA = "0x11A7870", Offset = "0x11A6A70", Length = "0x10F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat192), Member = "Create64", ReturnType = typeof(UInt64[]))]
		[Calls(Type = typeof(SecT163R1LookupTable), Member = "CreatePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000855")]
		public virtual ECPoint LookupVar(int index) { }

	}

	[Token(Token = "0x40001CC")]
	private static readonly ECFieldElement[] SECT163R1_AFFINE_ZS; //Field offset: 0x0
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001CD")]
	protected readonly SecT163R1Point m_infinity; //Field offset: 0x58

	[Token(Token = "0x170000D2")]
	public virtual int FieldSize
	{
		[Address(RVA = "0x11A4CE0", Offset = "0x11A3EE0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600084B")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000D1")]
	public virtual ECPoint Infinity
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600084A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000D3")]
	public virtual bool IsKoblitz
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600084F")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x11A7400", Offset = "0x11A6600", Length = "0x12C")]
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
	[Token(Token = "0x6000851")]
	private static SecT163R1Curve() { }

	[Address(RVA = "0x11A7530", Offset = "0x11A6730", Length = "0x226")]
	[CalledBy(Type = typeof(SecT163R1Curve), Member = "CloneCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(SecT163R1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
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
	[Token(Token = "0x6000847")]
	public SecT163R1Curve() { }

	[Address(RVA = "0x11A7030", Offset = "0x11A6230", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SecT163R1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000848")]
	protected virtual ECCurve CloneCurve() { }

	[Address(RVA = "0x11A7080", Offset = "0x11A6280", Length = "0x204")]
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
	[Token(Token = "0x6000850")]
	public virtual ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len) { }

	[Address(RVA = "0x11A7290", Offset = "0x11A6490", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600084D")]
	protected private virtual ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x11A7310", Offset = "0x11A6510", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600084E")]
	protected private virtual ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs) { }

	[Address(RVA = "0x11A73A0", Offset = "0x11A65A0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SecT163FieldElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Token(Token = "0x600084C")]
	public virtual ECFieldElement FromBigInteger(BigInteger x) { }

	[Address(RVA = "0x11A4CE0", Offset = "0x11A3EE0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600084B")]
	public virtual int get_FieldSize() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600084A")]
	public virtual ECPoint get_Infinity() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600084F")]
	public virtual bool get_IsKoblitz() { }

	[Address(RVA = "0x1198700", Offset = "0x1197900", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000849")]
	public virtual bool SupportsCoordinateSystem(int coord) { }

}

