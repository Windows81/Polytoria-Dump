namespace Mirror.BouncyCastle.Math.EC.Custom.GM;

[Token(Token = "0x2000102")]
internal class SM2P256V1Curve : AbstractFpCurve
{
	[Token(Token = "0x2000103")]
	private class SM2P256V1LookupTable : AbstractECLookupTable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400021A")]
		private readonly SM2P256V1Curve m_outer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400021B")]
		private readonly UInt32[] m_table; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400021C")]
		private readonly int m_size; //Field offset: 0x20

		[Token(Token = "0x17000139")]
		public virtual int Size
		{
			[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000AB4")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x1160640", Offset = "0x115F840", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB3")]
		internal SM2P256V1LookupTable(SM2P256V1Curve outer, UInt32[] table, int size) { }

		[Address(RVA = "0x11C16E0", Offset = "0x11C08E0", Length = "0x106")]
		[CalledBy(Type = typeof(SM2P256V1LookupTable), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
		[CalledBy(Type = typeof(SM2P256V1LookupTable), Member = "LookupVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AB7")]
		private ECPoint CreatePoint(UInt32[] x, UInt32[] y) { }

		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB4")]
		public virtual int get_Size() { }

		[Address(RVA = "0x11C18F0", Offset = "0x11C0AF0", Length = "0x138")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat256), Member = "Create", ReturnType = typeof(UInt32[]))]
		[Calls(Type = typeof(SM2P256V1LookupTable), Member = "CreatePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000AB5")]
		public virtual ECPoint Lookup(int index) { }

		[Address(RVA = "0x11C17F0", Offset = "0x11C09F0", Length = "0xFC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nat256), Member = "Create", ReturnType = typeof(UInt32[]))]
		[Calls(Type = typeof(SM2P256V1LookupTable), Member = "CreatePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(ECPoint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000AB6")]
		public virtual ECPoint LookupVar(int index) { }

	}

	[Token(Token = "0x4000217")]
	public static readonly BigInteger q; //Field offset: 0x0
	[Token(Token = "0x4000218")]
	private static readonly ECFieldElement[] SM2P256V1_AFFINE_ZS; //Field offset: 0x8
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000219")]
	protected readonly SM2P256V1Point m_infinity; //Field offset: 0x58

	[Token(Token = "0x17000138")]
	public virtual int FieldSize
	{
		[Address(RVA = "0x11BF2D0", Offset = "0x11BE4D0", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000AAC")]
		 get { } //Length: 94
	}

	[Token(Token = "0x17000137")]
	public virtual ECPoint Infinity
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AAB")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x11BEEE0", Offset = "0x11BE0E0", Length = "0x17E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SM2P256V1FieldElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AB2")]
	private static SM2P256V1Curve() { }

	[Address(RVA = "0x11BF060", Offset = "0x11BE260", Length = "0x26A")]
	[CalledBy(Type = typeof(SM2P256V1Curve), Member = "CloneCurve", ReturnType = typeof(ECCurve))]
	[CalledBy(Type = typeof(SM2P256V1Holder), Member = "CreateCurve", ReturnType = typeof(ECCurve))]
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
	[Token(Token = "0x6000AA8")]
	public SM2P256V1Curve() { }

	[Address(RVA = "0x11BE930", Offset = "0x11BDB30", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SM2P256V1Curve), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000AA9")]
	protected virtual ECCurve CloneCurve() { }

	[Address(RVA = "0x11BE980", Offset = "0x11BDB80", Length = "0x1F4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Nat256), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AB0")]
	public virtual ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len) { }

	[Address(RVA = "0x11BEB80", Offset = "0x11BDD80", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AAE")]
	protected private virtual ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x11BEC00", Offset = "0x11BDE00", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AAF")]
	protected private virtual ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs) { }

	[Address(RVA = "0x11BEC90", Offset = "0x11BDE90", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SM2P256V1FieldElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000AAD")]
	public virtual ECFieldElement FromBigInteger(BigInteger x) { }

	[Address(RVA = "0x11BF2D0", Offset = "0x11BE4D0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AAC")]
	public virtual int get_FieldSize() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAB")]
	public virtual ECPoint get_Infinity() { }

	[Address(RVA = "0x11BECF0", Offset = "0x11BDEF0", Length = "0x1E9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat256), Member = "Create", ReturnType = typeof(UInt32[]))]
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
	[Token(Token = "0x6000AB1")]
	public virtual ECFieldElement RandomFieldElementMult(SecureRandom r) { }

	[Address(RVA = "0x115DCD0", Offset = "0x115CED0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAA")]
	public virtual bool SupportsCoordinateSystem(int coord) { }

}

