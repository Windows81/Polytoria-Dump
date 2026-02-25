namespace Mirror.BouncyCastle.Math.Raw;

[Token(Token = "0x200002D")]
internal static class Nat448
{

	[Address(RVA = "0x11545B0", Offset = "0x11537B0", Length = "0xBA")]
	[CalledBy(Type = typeof(SecT409Field), Member = "HalfTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT409K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001F8")]
	public static void Copy64(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x1154480", Offset = "0x1153680", Length = "0x12D")]
	[CalledBy(Type = typeof(SecT409K1Curve), Member = "CreateCacheSafeLookupTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint[]), typeof(int), typeof(int)}, ReturnType = typeof(ECLookupTable))]
	[CalledBy(Type = typeof(SecT409R1Curve), Member = "CreateCacheSafeLookupTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint[]), typeof(int), typeof(int)}, ReturnType = typeof(ECLookupTable))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001F9")]
	public static void Copy64(UInt64[] x, int xOff, UInt64[] z, int zOff) { }

	[Address(RVA = "0x1154670", Offset = "0x1153870", Length = "0x35")]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "HalfTrace", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT409K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Curve+SecT409K1LookupTable", Member = "LookupVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Curve+SecT409K1LookupTable", Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "Invert", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "SquarePow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "Square", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "AddOne", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT409Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Curve+SecT409R1LookupTable", Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Curve+SecT409R1LookupTable", Member = "LookupVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60001FA")]
	public static UInt64[] Create64() { }

	[Address(RVA = "0x11546B0", Offset = "0x11538B0", Length = "0x35")]
	[CalledBy(Type = typeof(SecT409Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT409Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT409Field), Member = "MultiplyAddToExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT409K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x60001FB")]
	public static UInt64[] CreateExt64() { }

	[Address(RVA = "0x11546F0", Offset = "0x11538F0", Length = "0x63")]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecT409FieldElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001FC")]
	public static bool Eq64(UInt64[] x, UInt64[] y) { }

	[Address(RVA = "0x1154760", Offset = "0x1153960", Length = "0x58")]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "get_IsOne", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001FD")]
	public static bool IsOne64(UInt64[] x) { }

	[Address(RVA = "0x11547C0", Offset = "0x11539C0", Length = "0x51")]
	[CalledBy(Type = typeof(SecT409Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "get_IsZero", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SecT409K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001FE")]
	public static bool IsZero64(UInt64[] x) { }

	[Address(RVA = "0x1154820", Offset = "0x1153A20", Length = "0xE9")]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "ToBigInteger", ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001FF")]
	public static BigInteger ToBigInteger64(UInt64[] x) { }

}

