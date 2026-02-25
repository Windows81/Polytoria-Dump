namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

[Token(Token = "0x20000F6")]
internal class SecT409K1Point : AbstractF2mPoint
{

	[Token(Token = "0x17000120")]
	protected private virtual bool CompressionYTilde
	{
		[Address(RVA = "0x119A2E0", Offset = "0x11994E0", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A24")]
		private get { } //Length: 136
	}

	[Token(Token = "0x1700011F")]
	public virtual ECFieldElement YCoord
	{
		[Address(RVA = "0x119A370", Offset = "0x1199570", Length = "0x109")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ECPoint), Member = "get_IsInfinity", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A23")]
		 get { } //Length: 265
	}

	[Address(RVA = "0x1161840", Offset = "0x1160A40", Length = "0xE")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A21")]
	internal SecT409K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y) { }

	[Address(RVA = "0x1161830", Offset = "0x1160A30", Length = "0xE")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A22")]
	internal SecT409K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs) { }

	[Address(RVA = "0x11CAE00", Offset = "0x11CA000", Length = "0xB92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nat448), Member = "CreateExt64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SecT409Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT409Field), Member = "ImplMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interleave), Member = "Expand64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(int), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interleave), Member = "Expand32to64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(SecT409Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat448), Member = "IsZero64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SecT409Field), Member = "AddTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat448), Member = "Copy64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecT409Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat448), Member = "Create64", ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Nat), Member = "Create64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(ECPoint), Member = "get_IsInfinity", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 26)]
	[Token(Token = "0x6000A25")]
	public virtual ECPoint Add(ECPoint b) { }

	[Address(RVA = "0x119A2E0", Offset = "0x11994E0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A24")]
	protected private virtual bool get_CompressionYTilde() { }

	[Address(RVA = "0x119A370", Offset = "0x1199570", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ECPoint), Member = "get_IsInfinity", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A23")]
	public virtual ECFieldElement get_YCoord() { }

	[Address(RVA = "0x11CB9A0", Offset = "0x11CABA0", Length = "0x198")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ECPoint), Member = "get_IsInfinity", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000A28")]
	public virtual ECPoint Negate() { }

	[Address(RVA = "0x11CC110", Offset = "0x11CB310", Length = "0x47B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ECPoint), Member = "get_IsInfinity", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	[Token(Token = "0x6000A26")]
	public virtual ECPoint Twice() { }

	[Address(RVA = "0x11CBB40", Offset = "0x11CAD40", Length = "0x5CC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ECPoint), Member = "get_IsInfinity", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 30)]
	[Token(Token = "0x6000A27")]
	public virtual ECPoint TwicePlus(ECPoint b) { }

}

