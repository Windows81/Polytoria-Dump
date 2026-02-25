namespace Mirror.BouncyCastle.Math.Raw;

[Token(Token = "0x2000023")]
internal static class Interleave
{

	[Address(RVA = "0x10C5880", Offset = "0x10C4A80", Length = "0x7A")]
	[CalledBy(Type = typeof(SecT409Field), Member = "Invert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT283Field), Member = "HalfTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT283Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT283Field), Member = "SquareExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT283Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT283Field), Member = "ImplSquare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT409Field), Member = "HalfTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT409K1Point), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(SecT409Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT409Field), Member = "SquareExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT409Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT409Field), Member = "ImplSquare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "Square", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT409FieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 18)]
	[Token(Token = "0x6000116")]
	internal static ulong Expand32to64(uint x) { }

	[Address(RVA = "0x10C5BB0", Offset = "0x10C4DB0", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000117")]
	internal static void Expand64To128(ulong x, UInt64[] z, int zOff) { }

	[Address(RVA = "0x10C59E0", Offset = "0x10C4BE0", Length = "0x1C0")]
	[CallerCount(Count = 114)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000118")]
	internal static void Expand64To128(UInt64[] xs, int xsOff, int xsLen, UInt64[] zs, int zsOff) { }

	[Address(RVA = "0x10C5900", Offset = "0x10C4B00", Length = "0xD3")]
	[CalledBy(Type = typeof(BasicGcmExponentiator), Member = "ExponentiateX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GcmUtilities), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldElement&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x6000119")]
	internal static ulong Expand64To128Rev(ulong x, out ulong low) { }

	[Address(RVA = "0x10C5CB0", Offset = "0x10C4EB0", Length = "0x2A")]
	[CalledBy(Type = typeof(SecT131Field), Member = "HalfTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT131Field), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT131Field), Member = "SquareExt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT131Field), Member = "SquareN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(int), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT131Field), Member = "ImplSquare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT131FieldElement), Member = "SquarePlusProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECFieldElement), typeof(ECFieldElement)}, ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT131FieldElement), Member = "HalfTrace", ReturnType = typeof(ECFieldElement))]
	[CallerCount(Count = 10)]
	[Token(Token = "0x6000115")]
	internal static uint Expand8to16(byte x) { }

	[Address(RVA = "0x10C5CE0", Offset = "0x10C4EE0", Length = "0x55")]
	[CalledBy(Type = typeof(Ed25519), Member = "GroupCombBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x600011A")]
	internal static uint Shuffle2(uint x) { }

	[Address(RVA = "0x10C5F80", Offset = "0x10C5180", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600011B")]
	internal static ulong Unshuffle(ulong x) { }

	[Address(RVA = "0x10C5EC0", Offset = "0x10C50C0", Length = "0xB9")]
	[CalledBy(Type = typeof(SecT131Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT131FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT163Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT193Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT193FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT283Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT409Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT571Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x600011C")]
	internal static ulong Unshuffle(ulong x, out ulong even) { }

	[Address(RVA = "0x10C5D40", Offset = "0x10C4F40", Length = "0x17F")]
	[CalledBy(Type = typeof(SecT113Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT113FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT131Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT131FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT163Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT193Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT193FieldElement), Member = "Sqrt", ReturnType = typeof(ECFieldElement))]
	[CalledBy(Type = typeof(SecT233Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT239Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT283Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT409Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SecT571Field), Member = "Sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64[]), typeof(UInt64[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Token(Token = "0x600011D")]
	internal static ulong Unshuffle(ulong x0, ulong x1, out ulong even) { }

}

