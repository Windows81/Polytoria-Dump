namespace Mirror.BouncyCastle.Math.EC.Rfc8032;

[Token(Token = "0x2000053")]
public static class Ed25519
{
	[Token(Token = "0x2000055")]
	private struct PointAccum
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CB")]
		internal Int32[] x; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000CC")]
		internal Int32[] y; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CD")]
		internal Int32[] z; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000CE")]
		internal Int32[] u; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000CF")]
		internal Int32[] v; //Field offset: 0x20

	}

	[Token(Token = "0x2000056")]
	private struct PointAffine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D0")]
		internal Int32[] x; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000D1")]
		internal Int32[] y; //Field offset: 0x8

	}

	[Token(Token = "0x2000057")]
	private struct PointExtended
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D2")]
		internal Int32[] x; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000D3")]
		internal Int32[] y; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000D4")]
		internal Int32[] z; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000D5")]
		internal Int32[] t; //Field offset: 0x18

	}

	[Token(Token = "0x2000058")]
	private struct PointPrecomp
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D6")]
		internal Int32[] ymx_h; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000D7")]
		internal Int32[] ypx_h; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000D8")]
		internal Int32[] xyd; //Field offset: 0x10

	}

	[Token(Token = "0x2000059")]
	private struct PointTemp
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D9")]
		internal Int32[] r0; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000DA")]
		internal Int32[] r1; //Field offset: 0x8

	}

	[Token(Token = "0x2000054")]
	internal sealed class PublicPoint
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CA")]
		internal readonly Int32[] m_data; //Field offset: 0x10

		[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600038E")]
		internal PublicPoint(Int32[] data) { }

	}

	[Token(Token = "0x40000B7")]
	public static readonly int PrehashSize; //Field offset: 0x0
	[Token(Token = "0x40000B8")]
	public static readonly int PublicKeySize; //Field offset: 0x4
	[Token(Token = "0x40000B9")]
	public static readonly int SecretKeySize; //Field offset: 0x8
	[Token(Token = "0x40000BA")]
	public static readonly int SignatureSize; //Field offset: 0xC
	[Token(Token = "0x40000BB")]
	private static readonly Byte[] Dom2Prefix; //Field offset: 0x10
	[Token(Token = "0x40000BC")]
	private static readonly UInt32[] P; //Field offset: 0x18
	[Token(Token = "0x40000BD")]
	private static readonly UInt32[] Order8_y1; //Field offset: 0x20
	[Token(Token = "0x40000BE")]
	private static readonly UInt32[] Order8_y2; //Field offset: 0x28
	[Token(Token = "0x40000BF")]
	private static readonly Int32[] B_x; //Field offset: 0x30
	[Token(Token = "0x40000C0")]
	private static readonly Int32[] B_y; //Field offset: 0x38
	[Token(Token = "0x40000C1")]
	private static readonly Int32[] B128_x; //Field offset: 0x40
	[Token(Token = "0x40000C2")]
	private static readonly Int32[] B128_y; //Field offset: 0x48
	[Token(Token = "0x40000C3")]
	private static readonly Int32[] C_d; //Field offset: 0x50
	[Token(Token = "0x40000C4")]
	private static readonly Int32[] C_d2; //Field offset: 0x58
	[Token(Token = "0x40000C5")]
	private static readonly Int32[] C_d4; //Field offset: 0x60
	[Token(Token = "0x40000C6")]
	private static readonly object PrecompLock; //Field offset: 0x68
	[Token(Token = "0x40000C7")]
	private static PointPrecomp[] PrecompBaseWnaf; //Field offset: 0x70
	[Token(Token = "0x40000C8")]
	private static PointPrecomp[] PrecompBase128Wnaf; //Field offset: 0x78
	[Token(Token = "0x40000C9")]
	private static Int32[] PrecompBaseComb; //Field offset: 0x80

	[Address(RVA = "0x1143CA0", Offset = "0x1142EA0", Length = "0x583")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600038D")]
	private static Ed25519() { }

	[Address(RVA = "0x113FE40", Offset = "0x113F040", Length = "0x1B1")]
	[CalledBy(Type = typeof(Ed25519), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Create", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(X25519Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "IsZero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600036F")]
	private static int CheckPoint(ref PointAffine p) { }

	[Address(RVA = "0x1140000", Offset = "0x113F200", Length = "0x245")]
	[CalledBy(Type = typeof(Ed25519), Member = "ScalarMultBaseYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Create", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(X25519Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "IsZero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000370")]
	private static int CheckPoint(PointAccum p) { }

	[Address(RVA = "0x113FAB0", Offset = "0x113ECB0", Length = "0x385")]
	[CalledBy(Type = typeof(Ed25519), Member = "ValidatePublicKeyPartialExport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000371")]
	private static bool CheckPointFullVar(Byte[] p) { }

	[Address(RVA = "0x1140250", Offset = "0x113F450", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000372")]
	private static Byte[] Copy(Byte[] buf, int off, int len) { }

	[Address(RVA = "0x11402D0", Offset = "0x113F4D0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Sha512Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000373")]
	private static IDigest CreateDigest() { }

	[Address(RVA = "0x1140380", Offset = "0x113F580", Length = "0x1D6")]
	[CalledBy(Type = typeof(Ed25519), Member = "ValidatePublicKeyPartialExport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X25519Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Create", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "SubOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "SqrtRatioVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X25519Field), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "IsZeroVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X25519Field), Member = "Negate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000374")]
	private static bool DecodePointVar(Byte[] p, bool negate, ref PointAffine r) { }

	[Address(RVA = "0x1140560", Offset = "0x113F760", Length = "0xBD")]
	[CalledBy(Type = typeof(Ed25519PublicKeyParameters), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519PublicKeyParameters), Member = "GetEncoded", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000375")]
	public static void EncodePublicPoint(PublicPoint publicPoint, Byte[] pk, int pkOff) { }

	[Address(RVA = "0x1140620", Offset = "0x113F820", Length = "0xD8")]
	[CalledBy(Type = typeof(Ed25519), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed25519), Member = "ValidatePublicKeyPartialExport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000376")]
	private static PublicPoint ExportPoint(ref PointAffine p) { }

	[Address(RVA = "0x1140700", Offset = "0x113F900", Length = "0x455")]
	[CalledBy(Type = typeof(Ed25519PrivateKeyParameters), Member = "CreatePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Ed25519PublicKeyParameters))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Ed25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointAccum&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Ed25519), Member = "ExportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(PublicPoint))]
	[Calls(Type = typeof(Ed25519), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(X25519Field), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X25519Field), Member = "Create", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(Ed25519), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Sha512Digest), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000377")]
	public static PublicPoint GeneratePublicKey(Byte[] sk, int skOff) { }

	[Address(RVA = "0x1140B60", Offset = "0x113FD60", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interleave), Member = "Shuffle2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000378")]
	private static void GroupCombBits(UInt32[] n) { }

	[Address(RVA = "0x1140C30", Offset = "0x113FE30", Length = "0xB0")]
	[CalledBy(Type = typeof(Ed25519), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "ScalarMultBaseYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Create", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000379")]
	private static void Init(out PointAccum r) { }

	[Address(RVA = "0x1140BC0", Offset = "0x113FDC0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Create", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600037A")]
	private static void Init(out PointAffine r) { }

	[Address(RVA = "0x1140DE0", Offset = "0x113FFE0", Length = "0x99")]
	[CalledBy(Type = typeof(Ed25519), Member = "PointPrecompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointExtended[]), typeof(int), typeof(int), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Create", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600037B")]
	private static void Init(out PointExtended r) { }

	[Address(RVA = "0x1140CE0", Offset = "0x113FEE0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Create", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600037C")]
	private static void Init(out PointPrecomp r) { }

	[Address(RVA = "0x1140D70", Offset = "0x113FF70", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Create", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600037D")]
	private static void Init(out PointTemp r) { }

	[Address(RVA = "0x1140E80", Offset = "0x1140080", Length = "0x2D5")]
	[CalledBy(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "CreateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(X25519Field), Member = "Create", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(X25519Field), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "InvVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600037E")]
	private static void InvertDoubleZs(PointExtended[] points) { }

	[Address(RVA = "0x1141160", Offset = "0x1140360", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Token(Token = "0x600037F")]
	private static void NormalizeToAffine(ref PointAccum p, ref PointAffine r) { }

	[Address(RVA = "0x1141210", Offset = "0x1140410", Length = "0x396")]
	[CalledBy(Type = typeof(Ed25519), Member = "PointPrecompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointExtended[]), typeof(int), typeof(int), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000380")]
	private static void PointAdd(ref PointExtended p, ref PointExtended q, ref PointExtended r, ref PointTemp t) { }

	[Address(RVA = "0x11415B0", Offset = "0x11407B0", Length = "0x29D")]
	[CalledBy(Type = typeof(Ed25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000381")]
	private static void PointAdd(ref PointPrecomp p, ref PointAccum r, ref PointTemp t) { }

	[Address(RVA = "0x1141910", Offset = "0x1140B10", Length = "0xC8")]
	[CalledBy(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000382")]
	private static void PointCopy(ref PointAccum p, ref PointExtended r) { }

	[Address(RVA = "0x1141850", Offset = "0x1140A50", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "One", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000383")]
	private static void PointCopy(ref PointAffine p, ref PointExtended r) { }

	[Address(RVA = "0x11419E0", Offset = "0x1140BE0", Length = "0x29C")]
	[CalledBy(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Carry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000384")]
	private static void PointDouble(ref PointAccum r) { }

	[Address(RVA = "0x1141C80", Offset = "0x1140E80", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "CMov", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000385")]
	private static void PointLookup(int block, int index, ref PointPrecomp p) { }

	[Address(RVA = "0x1141DE0", Offset = "0x1140FE0", Length = "0x33E")]
	[CalledBy(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Ed25519), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointExtended&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "One", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Create", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Ed25519), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointExtended&), typeof(PointExtended&), typeof(PointExtended&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000386")]
	private static void PointPrecompute(ref PointAffine p, PointExtended[] points, int pointsOff, int pointsLen, ref PointTemp t) { }

	[Address(RVA = "0x1142120", Offset = "0x1141320", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Zero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "One", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000387")]
	private static void PointSetNeutral(ref PointAccum p) { }

	[Address(RVA = "0x11421B0", Offset = "0x11413B0", Length = "0x11B1")]
	[CalledBy(Type = typeof(Ed25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X25519Field), Member = "One", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "CreateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(X25519Field), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed25519), Member = "InvertDoubleZs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointExtended[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Negate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed25519), Member = "PointDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed25519), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointExtended&), typeof(PointExtended&), typeof(PointExtended&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed25519), Member = "PointCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&), typeof(PointExtended&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Ed25519), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed25519), Member = "PointPrecompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointExtended[]), typeof(int), typeof(int), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X25519Field), Member = "Create", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Ed25519), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointExtended&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000388")]
	public static void Precompute() { }

	[Address(RVA = "0x1143370", Offset = "0x1142570", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000389")]
	private static void PruneScalar(Byte[] n, int nOff, Byte[] r) { }

	[Address(RVA = "0x11435C0", Offset = "0x11427C0", Length = "0x54F")]
	[CalledBy(Type = typeof(Ed25519), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed25519), Member = "ScalarMultBaseYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Scalar25519), Member = "ToSignedDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed25519), Member = "PointDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed25519), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointPrecomp&), typeof(PointAccum&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "CNegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "CMov", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "One", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Zero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Interleave), Member = "Shuffle2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Scalar25519), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X25519Field), Member = "Create", ReturnType = typeof(Int32[]))]
	[Token(Token = "0x600038A")]
	private static void ScalarMultBase(Byte[] k, ref PointAccum r) { }

	[Address(RVA = "0x11433D0", Offset = "0x11425D0", Length = "0x1EC")]
	[CalledBy(Type = typeof(X25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Ed25519), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(X25519Field), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed25519), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Ed25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointAccum&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600038B")]
	internal static void ScalarMultBaseYZ(Byte[] k, int kOff, Int32[] y, Int32[] z) { }

	[Address(RVA = "0x1143B10", Offset = "0x1142D10", Length = "0x18B")]
	[CalledBy(Type = typeof(Ed25519PublicKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519PublicKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519PublicKeyParameters), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ed25519), Member = "CheckPointFullVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X25519Field), Member = "Create", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Ed25519), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Ed25519), Member = "ExportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(PublicPoint))]
	[Token(Token = "0x600038C")]
	public static PublicPoint ValidatePublicKeyPartialExport(Byte[] pk, int pkOff) { }

}

