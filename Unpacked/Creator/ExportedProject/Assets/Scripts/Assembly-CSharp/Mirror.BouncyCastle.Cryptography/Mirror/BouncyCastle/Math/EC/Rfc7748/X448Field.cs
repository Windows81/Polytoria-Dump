namespace Mirror.BouncyCastle.Math.EC.Rfc7748;

[CLSCompliant(False)]
[Token(Token = "0x2000064")]
public static class X448Field
{
	[Token(Token = "0x40000FD")]
	private static readonly UInt32[] P32; //Field offset: 0x0

	[Address(RVA = "0x116C680", Offset = "0x116B880", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000401")]
	private static X448Field() { }

	[Address(RVA = "0x1167EC0", Offset = "0x11670C0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003DB")]
	public static void Add(UInt32[] x, UInt32[] y, UInt32[] z) { }

	[Address(RVA = "0x1164A80", Offset = "0x1163C80", Length = "0x22")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DC")]
	public static void AddOne(UInt32[] z) { }

	[Address(RVA = "0x11680D0", Offset = "0x11672D0", Length = "0x331")]
	[CalledBy(Type = typeof(Ed448), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "PointDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003DD")]
	public static void Carry(UInt32[] z) { }

	[Address(RVA = "0x1167F40", Offset = "0x1167140", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003DE")]
	public static void CMov(int cond, UInt32[] x, int xOff, UInt32[] z, int zOff) { }

	[Address(RVA = "0x1167FE0", Offset = "0x11671E0", Length = "0xE1")]
	[CalledBy(Type = typeof(Ed448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointProjective&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X448Field), Member = "Sub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003DF")]
	public static void CNegate(int negate, UInt32[] z) { }

	[Address(RVA = "0x1168410", Offset = "0x1167610", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003E0")]
	public static void Copy(UInt32[] x, int xOff, UInt32[] z, int zOff) { }

	[Address(RVA = "0x11684D0", Offset = "0x11676D0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x60003E1")]
	public static UInt32[] Create() { }

	[Address(RVA = "0x1168490", Offset = "0x1167690", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x60003E2")]
	public static UInt32[] CreateTable(int n) { }

	[Address(RVA = "0x1168890", Offset = "0x1167A90", Length = "0x8E")]
	[CalledBy(Type = typeof(Ed448), Member = "InvertZs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "InvVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X448Field), Member = "Decode224", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003E3")]
	public static void Decode(UInt32[] x, int xOff, UInt32[] z) { }

	[Address(RVA = "0x1168920", Offset = "0x1167B20", Length = "0x12A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X448Field), Member = "Decode56", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003E4")]
	public static void Decode(Byte[] x, UInt32[] z) { }

	[Address(RVA = "0x1168510", Offset = "0x1167710", Length = "0x1CE")]
	[CalledBy(Type = typeof(X448Field), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003E5")]
	private static void Decode224(UInt32[] x, int xOff, UInt32[] z, int zOff) { }

	[Address(RVA = "0x11686E0", Offset = "0x11678E0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003E6")]
	private static uint Decode24(Byte[] bs, int off) { }

	[Address(RVA = "0x1139590", Offset = "0x1138790", Length = "0x6B")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E7")]
	private static uint Decode32(Byte[] bs, int off) { }

	[Address(RVA = "0x1168740", Offset = "0x1167940", Length = "0x142")]
	[CalledBy(Type = typeof(Ed448), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X448Field), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003E8")]
	private static void Decode56(Byte[] bs, int off, UInt32[] z, int zOff) { }

	[Address(RVA = "0x1168FF0", Offset = "0x11681F0", Length = "0x8F")]
	[CalledBy(Type = typeof(Ed448), Member = "InvertZs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "InvVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X448Field), Member = "Encode224", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003E9")]
	public static void Encode(UInt32[] x, UInt32[] z, int zOff) { }

	[Address(RVA = "0x1168D90", Offset = "0x1167F90", Length = "0x129")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X448Field), Member = "Encode56", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003EA")]
	public static void Encode(UInt32[] x, Byte[] z, int zOff) { }

	[Address(RVA = "0x1168EC0", Offset = "0x11680C0", Length = "0x129")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X448Field), Member = "Encode56", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003EB")]
	public static void Encode(UInt32[] x, int xOff, Byte[] z, int zOff) { }

	[Address(RVA = "0x1168A50", Offset = "0x1167C50", Length = "0x1AE")]
	[CalledBy(Type = typeof(X448Field), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003EC")]
	private static void Encode224(UInt32[] x, int xOff, UInt32[] z, int zOff) { }

	[Address(RVA = "0x1168C00", Offset = "0x1167E00", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003ED")]
	private static void Encode24(uint n, Byte[] bs, int off) { }

	[Address(RVA = "0x1165910", Offset = "0x1164B10", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003EE")]
	private static void Encode32(uint n, Byte[] bs, int off) { }

	[Address(RVA = "0x1168C60", Offset = "0x1167E60", Length = "0x12F")]
	[CalledBy(Type = typeof(Ed448), Member = "EncodePublicPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PublicPoint), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003EF")]
	private static void Encode56(UInt32[] x, int xOff, Byte[] bs, int off) { }

	[Address(RVA = "0x1169240", Offset = "0x1168440", Length = "0x1B8")]
	[CalledBy(Type = typeof(Ed448), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed448), Member = "NormalizeToAffine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointAffine&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X448Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mod), Member = "ModOddInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(X448Field), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003F0")]
	public static void Inv(UInt32[] x, UInt32[] z) { }

	[Address(RVA = "0x1169080", Offset = "0x1168280", Length = "0x1B8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X448Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mod), Member = "ModOddInverseVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X448Field), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003F1")]
	public static void InvVar(UInt32[] x, UInt32[] z) { }

	[Address(RVA = "0x11694A0", Offset = "0x11686A0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003F2")]
	public static int IsZero(UInt32[] x) { }

	[Address(RVA = "0x1169400", Offset = "0x1168600", Length = "0x90")]
	[CalledBy(Type = typeof(Ed448), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003F3")]
	public static bool IsZeroVar(UInt32[] x) { }

	[Address(RVA = "0x116A840", Offset = "0x1169A40", Length = "0x395")]
	[CalledBy(Type = typeof(Ed448), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed448), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Math.EC.Rfc8032.Ed448+PointProjective"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed448), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Ed448), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003F4")]
	public static void Mul(UInt32[] x, uint y, UInt32[] z) { }

	[Address(RVA = "0x1169500", Offset = "0x1168700", Length = "0x1335")]
	[CalledBy(Type = typeof(Ed448), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed448), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Math.EC.Rfc8032.Ed448+PointProjective"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed448), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed448), Member = "InvertZs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "NormalizeToAffine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointAffine&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "PointDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "Precompute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "PowPm3d4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "SqrtRatioVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 57)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003F5")]
	public static void Mul(UInt32[] x, UInt32[] y, UInt32[] z) { }

	[Address(RVA = "0x116ABE0", Offset = "0x1169DE0", Length = "0x89")]
	[CalledBy(Type = typeof(Ed448), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Ed448), Member = "Precompute", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X448Field), Member = "Sub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60003F6")]
	public static void Negate(UInt32[] x, UInt32[] z) { }

	[Address(RVA = "0x116AC70", Offset = "0x1169E70", Length = "0x5F")]
	[CalledBy(Type = typeof(Ed448), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X448Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003F7")]
	public static void Normalize(UInt32[] z) { }

	[Address(RVA = "0x116ACD0", Offset = "0x1169ED0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003F8")]
	public static void One(UInt32[] z) { }

	[Address(RVA = "0x116AD20", Offset = "0x1169F20", Length = "0x447")]
	[CalledBy(Type = typeof(X448Field), Member = "SqrtRatioVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X448Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60003F9")]
	private static void PowPm3d4(UInt32[] x, UInt32[] z) { }

	[Address(RVA = "0x116B170", Offset = "0x116A370", Length = "0xCD")]
	[CalledBy(Type = typeof(Ed448), Member = "Precompute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed448), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Math.EC.Rfc8032.Ed448+PointProjective"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed448), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Ed448), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed448), Member = "InvertZs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "NormalizeToAffine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointAffine&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "InvVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "SqrtRatioVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 44)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003FA")]
	private static void Reduce(UInt32[] z, int x) { }

	[Address(RVA = "0x116B240", Offset = "0x116A440", Length = "0xB1A")]
	[CalledBy(Type = typeof(Ed448), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed448), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Math.EC.Rfc8032.Ed448+PointProjective"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed448), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Ed448), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "PointDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "PowPm3d4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "SqrtRatioVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003FB")]
	public static void Sqr(UInt32[] x, UInt32[] z) { }

	[Address(RVA = "0x116BD60", Offset = "0x116AF60", Length = "0x99")]
	[CalledBy(Type = typeof(X448Field), Member = "PowPm3d4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X448Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60003FC")]
	public static void Sqr(UInt32[] x, int n, UInt32[] z) { }

	[Address(RVA = "0x116BE00", Offset = "0x116B000", Length = "0x308")]
	[CalledBy(Type = typeof(Ed448), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X448Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "PowPm3d4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Sub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003FD")]
	public static bool SqrtRatioVar(UInt32[] u, UInt32[] v, UInt32[] z) { }

	[Address(RVA = "0x116C1B0", Offset = "0x116B3B0", Length = "0x47C")]
	[CalledBy(Type = typeof(Ed448), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed448), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Math.EC.Rfc8032.Ed448+PointProjective"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed448), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "PointDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "CNegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "Negate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X448Field), Member = "SqrtRatioVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003FE")]
	public static void Sub(UInt32[] x, UInt32[] y, UInt32[] z) { }

	[Address(RVA = "0x116C110", Offset = "0x116B310", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60003FF")]
	public static void SubOne(UInt32[] z) { }

	[Address(RVA = "0x116C630", Offset = "0x116B830", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000400")]
	public static void Zero(UInt32[] z) { }

}

