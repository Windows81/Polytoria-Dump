namespace Mirror.BouncyCastle.Math.Raw;

[Token(Token = "0x200002B")]
internal static class Nat320
{

	[Address(RVA = "0x10D2B70", Offset = "0x10D1D70", Length = "0x82")]
	[CalledBy(Type = typeof(SecT283Field), Member = "HalfTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT283K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001EE")]
	public static void Copy64(UInt64[] x, UInt64[] z) { }

	[Address(RVA = "0x10D2C00", Offset = "0x10D1E00", Length = "0xD7")]
	[CalledBy(Type = typeof(SecT283K1Curve), Member = "CreateCacheSafeLookupTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint[]), typeof(int), typeof(int)}, ReturnType = typeof(ECLookupTable))]
	[CalledBy(Type = typeof(SecT283R1Curve), Member = "CreateCacheSafeLookupTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint[]), typeof(int), typeof(int)}, ReturnType = typeof(ECLookupTable))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001EF")]
	public static void Copy64(UInt64[] x, int xOff, UInt64[] z, int zOff) { }

	[Address(RVA = "0x10D2CE0", Offset = "0x10D1EE0", Length = "0x35")]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "SquarePow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT283K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Curve+SecT283K1LookupTable", Member = "LookupVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Curve+SecT283K1LookupTable", Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "Invert", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "HalfTrace", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Curve+SecT283R1LookupTable", Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "MultiplyPlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "AddOne", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT283Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT283Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "Square", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Curve+SecT283R1LookupTable", Member = "LookupVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60001F0")]
	public static UInt64[] Create64() { }

	[Address(RVA = "0x10D2D20", Offset = "0x10D1F20", Length = "0x35")]
	[CalledBy(Type = typeof(SecT283Field), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT283Field), Member = "MultiplyAddToExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x60001F1")]
	public static UInt64[] CreateExt64() { }

	[Address(RVA = "0x10D2D60", Offset = "0x10D1F60", Length = "0x63")]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecT283FieldElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001F2")]
	public static bool Eq64(UInt64[] x, UInt64[] y) { }

	[Address(RVA = "0x10D2DD0", Offset = "0x10D1FD0", Length = "0x58")]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "get_IsOne", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001F3")]
	public static bool IsOne64(UInt64[] x) { }

	[Address(RVA = "0x10D2E30", Offset = "0x10D2030", Length = "0x51")]
	[CalledBy(Type = typeof(SecT283Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "get_IsZero", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SecT283K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001F4")]
	public static bool IsZero64(UInt64[] x) { }

	[Address(RVA = "0x10D2E90", Offset = "0x10D2090", Length = "0xE9")]
	[CalledBy(Type = typeof(SecT283FieldElement), Member = "ToBigInteger", ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001F5")]
	public static BigInteger ToBigInteger64(UInt64[] x) { }

}

