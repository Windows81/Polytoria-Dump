namespace Mirror.BouncyCastle.Math.EC.Rfc8032;

[Token(Token = "0x200005A")]
public static class Ed448
{
	[Token(Token = "0x200005C")]
	private struct PointAffine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EA")]
		internal UInt32[] x; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000EB")]
		internal UInt32[] y; //Field offset: 0x8

	}

	[Token(Token = "0x200005D")]
	private struct PointProjective
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EC")]
		internal UInt32[] x; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000ED")]
		internal UInt32[] y; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000EE")]
		internal UInt32[] z; //Field offset: 0x10

	}

	[Token(Token = "0x200005E")]
	private struct PointTemp
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EF")]
		internal UInt32[] r0; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000F0")]
		internal UInt32[] r1; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F1")]
		internal UInt32[] r2; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000F2")]
		internal UInt32[] r3; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000F3")]
		internal UInt32[] r4; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000F4")]
		internal UInt32[] r5; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000F5")]
		internal UInt32[] r6; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000F6")]
		internal UInt32[] r7; //Field offset: 0x38

	}

	[Token(Token = "0x200005B")]
	internal sealed class PublicPoint
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E9")]
		internal readonly UInt32[] m_data; //Field offset: 0x10

		[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003AB")]
		internal PublicPoint(UInt32[] data) { }

	}

	[Token(Token = "0x40000DB")]
	public static readonly int PrehashSize; //Field offset: 0x0
	[Token(Token = "0x40000DC")]
	public static readonly int PublicKeySize; //Field offset: 0x4
	[Token(Token = "0x40000DD")]
	public static readonly int SecretKeySize; //Field offset: 0x8
	[Token(Token = "0x40000DE")]
	public static readonly int SignatureSize; //Field offset: 0xC
	[Token(Token = "0x40000DF")]
	private static readonly Byte[] Dom4Prefix; //Field offset: 0x10
	[Token(Token = "0x40000E0")]
	private static readonly UInt32[] P; //Field offset: 0x18
	[Token(Token = "0x40000E1")]
	private static readonly UInt32[] B_x; //Field offset: 0x20
	[Token(Token = "0x40000E2")]
	private static readonly UInt32[] B_y; //Field offset: 0x28
	[Token(Token = "0x40000E3")]
	private static readonly UInt32[] B225_x; //Field offset: 0x30
	[Token(Token = "0x40000E4")]
	private static readonly UInt32[] B225_y; //Field offset: 0x38
	[Token(Token = "0x40000E5")]
	private static readonly object PrecompLock; //Field offset: 0x40
	[Token(Token = "0x40000E6")]
	private static PointAffine[] PrecompBaseWnaf; //Field offset: 0x48
	[Token(Token = "0x40000E7")]
	private static PointAffine[] PrecompBase225Wnaf; //Field offset: 0x50
	[Token(Token = "0x40000E8")]
	private static UInt32[] PrecompBaseComb; //Field offset: 0x58

	[Address(RVA = "0x1159DA0", Offset = "0x1158FA0", Length = "0x39A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003AA")]
	private static Ed448() { }

	[Address(RVA = "0x11558F0", Offset = "0x1154AF0", Length = "0x362")]
	[CalledBy(Type = typeof(Ed448), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X448Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Sub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600038F")]
	private static int CheckPoint(ref PointAffine p) { }

	[Address(RVA = "0x1155C60", Offset = "0x1154E60", Length = "0x414")]
	[CalledBy(Type = typeof(Ed448), Member = "ScalarMultBaseXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X448Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Sub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000390")]
	private static int CheckPoint(PointProjective p) { }

	[Address(RVA = "0x11556F0", Offset = "0x11548F0", Length = "0x1F2")]
	[CalledBy(Type = typeof(Ed448), Member = "ValidatePublicKeyPartialExport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000391")]
	private static bool CheckPointFullVar(Byte[] p) { }

	[Address(RVA = "0x1156080", Offset = "0x1155280", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000392")]
	private static Byte[] Copy(Byte[] buf, int off, int len) { }

	[Address(RVA = "0x1156100", Offset = "0x1155300", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ShakeDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000393")]
	private static IXof CreateXof() { }

	[Address(RVA = "0x1156150", Offset = "0x1155350", Length = "0x354")]
	[CalledBy(Type = typeof(Ed448), Member = "ValidatePublicKeyPartialExport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X448Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "IsZeroVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X448Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "SqrtRatioVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X448Field), Member = "Negate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X448Field), Member = "Decode56", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000394")]
	private static bool DecodePointVar(Byte[] p, bool negate, ref PointAffine r) { }

	[Address(RVA = "0x11564B0", Offset = "0x11556B0", Length = "0x1A8")]
	[CalledBy(Type = typeof(Ed448PublicKeyParameters), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448PublicKeyParameters), Member = "GetEncoded", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X448Field), Member = "Encode56", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000395")]
	public static void EncodePublicPoint(PublicPoint publicPoint, Byte[] pk, int pkOff) { }

	[Address(RVA = "0x1156660", Offset = "0x1155860", Length = "0x13C")]
	[CalledBy(Type = typeof(Ed448), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed448), Member = "ValidatePublicKeyPartialExport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000396")]
	private static PublicPoint ExportPoint(ref PointAffine p) { }

	[Address(RVA = "0x11567A0", Offset = "0x11559A0", Length = "0x463")]
	[CalledBy(Type = typeof(Ed448PrivateKeyParameters), Member = "CreatePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Ed448PublicKeyParameters))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Ed448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointProjective&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Ed448), Member = "ExportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(PublicPoint))]
	[Calls(Type = typeof(Ed448), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(X448Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ShakeDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000397")]
	public static PublicPoint GeneratePublicKey(Byte[] sk, int skOff) { }

	[Address(RVA = "0x1156F40", Offset = "0x1156140", Length = "0xB7")]
	[CalledBy(Type = typeof(Ed448), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed448), Member = "Precompute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointProjective&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "ValidatePublicKeyPartialExport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000398")]
	private static void Init(out PointAffine r) { }

	[Address(RVA = "0x1156E40", Offset = "0x1156040", Length = "0xF4")]
	[CalledBy(Type = typeof(Ed448), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed448), Member = "PointPrecompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointProjective[]), typeof(int), typeof(int), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "Precompute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "ScalarMultBaseXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000399")]
	private static void Init(out PointProjective r) { }

	[Address(RVA = "0x1156C10", Offset = "0x1155E10", Length = "0x225")]
	[CalledBy(Type = typeof(Ed448), Member = "Precompute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointProjective&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600039A")]
	private static void Init(out PointTemp r) { }

	[Address(RVA = "0x1157000", Offset = "0x1156200", Length = "0x5ED")]
	[CalledBy(Type = typeof(Ed448), Member = "Precompute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mod), Member = "ModOddInverseVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X448Field), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600039B")]
	private static void InvertZs(PointProjective[] points) { }

	[Address(RVA = "0x11575F0", Offset = "0x11567F0", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X448Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600039C")]
	private static void NormalizeToAffine(ref PointProjective p, ref PointAffine r) { }

	[Address(RVA = "0x1157A90", Offset = "0x1156C90", Length = "0x382")]
	[CalledBy(Type = typeof(Ed448), Member = "PointPrecompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointProjective[]), typeof(int), typeof(int), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "Precompute", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Sub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Carry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600039E")]
	private static void PointAdd(ref PointProjective p, ref PointProjective r, ref PointTemp t) { }

	[Address(RVA = "0x1157740", Offset = "0x1156940", Length = "0x346")]
	[CalledBy(Type = typeof(Ed448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointProjective&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X448Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Sub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Carry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600039D")]
	private static void PointAdd(ref PointAffine p, ref PointProjective r, ref PointTemp t) { }

	[Address(RVA = "0x1157E20", Offset = "0x1157020", Length = "0x14D")]
	[CalledBy(Type = typeof(Ed448), Member = "PointPrecompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointProjective[]), typeof(int), typeof(int), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "Precompute", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600039F")]
	private static void PointCopy(ref PointAffine p, ref PointProjective r) { }

	[Address(RVA = "0x1157F70", Offset = "0x1157170", Length = "0x141")]
	[CalledBy(Type = typeof(Ed448), Member = "PointPrecompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointProjective[]), typeof(int), typeof(int), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "Precompute", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003A0")]
	private static void PointCopy(ref PointProjective p, ref PointProjective r) { }

	[Address(RVA = "0x11580C0", Offset = "0x11572C0", Length = "0x255")]
	[CalledBy(Type = typeof(Ed448), Member = "PointPrecompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointProjective[]), typeof(int), typeof(int), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "Precompute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointProjective&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X448Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Carry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Sub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003A1")]
	private static void PointDouble(ref PointProjective r, ref PointTemp t) { }

	[Address(RVA = "0x1158320", Offset = "0x1157520", Length = "0x1A0")]
	[CalledBy(Type = typeof(Ed448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointProjective&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003A2")]
	private static void PointLookup(int block, int index, ref PointAffine p) { }

	[Address(RVA = "0x11584D0", Offset = "0x11576D0", Length = "0x1B6")]
	[CalledBy(Type = typeof(Ed448), Member = "Precompute", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Ed448), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "PointCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointProjective&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "PointDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "PointCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointProjective&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003A3")]
	private static void PointPrecompute(ref PointAffine p, PointProjective[] points, int pointsOff, int pointsLen, ref PointTemp t) { }

	[Address(RVA = "0x1158690", Offset = "0x1157890", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003A4")]
	private static void PointSetNeutral(ref PointProjective p) { }

	[Address(RVA = "0x11587A0", Offset = "0x11579A0", Length = "0xE34")]
	[CalledBy(Type = typeof(Ed448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointProjective&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Ed448), Member = "PointCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointProjective&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Ed448), Member = "InvertZs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "Negate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "PointDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "PointCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointProjective&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Ed448), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "PointPrecompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointProjective[]), typeof(int), typeof(int), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointTemp&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Ed448), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003A5")]
	public static void Precompute() { }

	[Address(RVA = "0x11595E0", Offset = "0x11587E0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003A6")]
	private static void PruneScalar(Byte[] n, int nOff, Byte[] r) { }

	[Address(RVA = "0x1159860", Offset = "0x1158A60", Length = "0x40A")]
	[CalledBy(Type = typeof(Ed448), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed448), Member = "ScalarMultBaseXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Codec), Member = "Decode32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "PointDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointProjective&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X448Field), Member = "CNegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "PointLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(PointAffine&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointTemp&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nat), Member = "ShiftDownBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[]), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Ed448), Member = "Precompute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nat), Member = "CAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(uint))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003A7")]
	private static void ScalarMultBase(Byte[] k, ref PointProjective r) { }

	[Address(RVA = "0x1159640", Offset = "0x1158840", Length = "0x21F")]
	[CalledBy(Type = typeof(X448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Ed448), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Ed448), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointProjective)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Ed448), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointProjective&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003A8")]
	internal static void ScalarMultBaseXY(Byte[] k, int kOff, UInt32[] x, UInt32[] y) { }

	[Address(RVA = "0x1159C70", Offset = "0x1158E70", Length = "0x12F")]
	[CalledBy(Type = typeof(Ed448PublicKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448PublicKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed448PublicKeyParameters), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "CheckPointFullVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Ed448), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed448), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Ed448), Member = "ExportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(PublicPoint))]
	[Token(Token = "0x60003A9")]
	public static PublicPoint ValidatePublicKeyPartialExport(Byte[] pk, int pkOff) { }

}

