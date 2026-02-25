namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

[Token(Token = "0x2000080")]
internal class SecP128R1Curve : AbstractFpCurve
{
	[Token(Token = "0x2000081")]
	private class SecP128R1LookupTable : AbstractECLookupTable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000134")]
		private readonly SecP128R1Curve m_outer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000135")]
		private readonly UInt32[] m_table; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000136")]
		private readonly int m_size; //Field offset: 0x20

		[Token(Token = "0x17000064")]
		public virtual int Size
		{
			[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000481")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x1160640", Offset = "0x115F840", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000480")]
		internal SecP128R1LookupTable(SecP128R1Curve outer, UInt32[] table, int size) { }

		[Address(RVA = "0x11602F0", Offset = "0x115F4F0", Length = "0x106")]
		[CalledBy(Type = typeof(SecP128R1LookupTable), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
		[CalledBy(Type = typeof(SecP128R1LookupTable), Member = "LookupVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000484")]
		private ECPoint CreatePoint(UInt32[] x, UInt32[] y) { }

		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000481")]
		public virtual int get_Size() { }

		[Address(RVA = "0x1160500", Offset = "0x115F700", Length = "0x138")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat128), Member = "Create", ReturnType = typeof(UInt32[]))]
		[Calls(Type = typeof(SecP128R1LookupTable), Member = "CreatePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000482")]
		public virtual ECPoint Lookup(int index) { }

		[Address(RVA = "0x1160400", Offset = "0x115F600", Length = "0xF6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat128), Member = "Create", ReturnType = typeof(UInt32[]))]
		[Calls(Type = typeof(SecP128R1LookupTable), Member = "CreatePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000483")]
		public virtual ECPoint LookupVar(int index) { }

	}

	[Token(Token = "0x4000131")]
	public static readonly BigInteger q; //Field offset: 0x0
	[Token(Token = "0x4000132")]
	private static readonly ECFieldElement[] SECP128R1_AFFINE_ZS; //Field offset: 0x8
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000133")]
	protected readonly SecP128R1Point m_infinity; //Field offset: 0x58

	[Token(Token = "0x17000063")]
	public virtual int FieldSize
	{
		[Address(RVA = "0x115E0D0", Offset = "0x115D2D0", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000479")]
		 get { } //Length: 94
	}

	[Token(Token = "0x17000062")]
	public virtual ECPoint Infinity
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000478")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x115DCE0", Offset = "0x115CEE0", Length = "0x17E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SecP128R1FieldElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600047F")]
	private static SecP128R1Curve() { }

	[Address(RVA = "0x115DE60", Offset = "0x115D060", Length = "0x26A")]
	[CalledBy(Type = typeof(SecP128R1Curve), Member = "CloneCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(SecP128R1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AbstractFpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Hex), Member = "DecodeStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000475")]
	public SecP128R1Curve() { }

	[Address(RVA = "0x115D720", Offset = "0x115C920", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SecP128R1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000476")]
	protected virtual ECCurve CloneCurve() { }

	[Address(RVA = "0x115D770", Offset = "0x115C970", Length = "0x1F4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Nat128), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600047D")]
	public virtual ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len) { }

	[Address(RVA = "0x115D970", Offset = "0x115CB70", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600047B")]
	protected private virtual ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x115D9F0", Offset = "0x115CBF0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600047C")]
	protected private virtual ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs) { }

	[Address(RVA = "0x115DA80", Offset = "0x115CC80", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SecP128R1FieldElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Token(Token = "0x600047A")]
	public virtual ECFieldElement FromBigInteger(BigInteger x) { }

	[Address(RVA = "0x115E0D0", Offset = "0x115D2D0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000479")]
	public virtual int get_FieldSize() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000478")]
	public virtual ECPoint get_Infinity() { }

	[Address(RVA = "0x115DAE0", Offset = "0x115CCE0", Length = "0x1E9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat128), Member = "Create", ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Pack), Member = "LE_To_UInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat), Member = "LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600047E")]
	public virtual ECFieldElement RandomFieldElementMult(SecureRandom r) { }

	[Address(RVA = "0x115DCD0", Offset = "0x115CED0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000477")]
	public virtual bool SupportsCoordinateSystem(int coord) { }

}

