namespace Mirror.BouncyCastle.Math.EC.Rfc7748;

[Token(Token = "0x2000062")]
public static class X25519Field
{
	[Token(Token = "0x40000FB")]
	private static readonly UInt32[] P32; //Field offset: 0x0
	[Token(Token = "0x40000FC")]
	private static readonly Int32[] RootNegOne; //Field offset: 0x8

	[Address(RVA = "0x11679D0", Offset = "0x1166BD0", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60003D8")]
	private static X25519Field() { }

	[Address(RVA = "0x1164AB0", Offset = "0x1163CB0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003B4")]
	public static void Add(Int32[] x, Int32[] y, Int32[] z) { }

	[Address(RVA = "0x1164A80", Offset = "0x1163C80", Length = "0x22")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003B5")]
	public static void AddOne(Int32[] z) { }

	[Address(RVA = "0x1164B30", Offset = "0x1163D30", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003B6")]
	public static void Apm(Int32[] x, Int32[] y, Int32[] zp, Int32[] zm) { }

	[Address(RVA = "0x1164CE0", Offset = "0x1163EE0", Length = "0x209")]
	[CalledBy(Type = typeof(Ed25519), Member = "PointDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003B7")]
	public static void Carry(Int32[] z) { }

	[Address(RVA = "0x1164BF0", Offset = "0x1163DF0", Length = "0x92")]
	[CalledBy(Type = typeof(Ed25519), Member = "PointLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(PointPrecomp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003B8")]
	public static void CMov(int cond, Int32[] x, int xOff, Int32[] z, int zOff) { }

	[Address(RVA = "0x1164C90", Offset = "0x1163E90", Length = "0x4F")]
	[CalledBy(Type = typeof(Ed25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003B9")]
	public static void CNegate(int negate, Int32[] z) { }

	[Address(RVA = "0x1164EF0", Offset = "0x11640F0", Length = "0x71")]
	[CalledBy(Type = typeof(Ed25519), Member = "ExportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed25519), Member = "InvertDoubleZs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointExtended[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "PointCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&), typeof(PointExtended&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "PointCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointExtended&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "PointPrecompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointExtended[]), typeof(int), typeof(int), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "ScalarMultBaseYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003BA")]
	public static void Copy(Int32[] x, int xOff, Int32[] z, int zOff) { }

	[Address(RVA = "0x1164FB0", Offset = "0x11641B0", Length = "0x35")]
	[CalledBy(Type = typeof(Ed25519), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointPrecomp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed25519), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Math.EC.Rfc8032.Ed25519+PointAccum"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed25519), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Ed25519), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed25519), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointExtended&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "InvertDoubleZs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointExtended[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "PointPrecompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointExtended[]), typeof(int), typeof(int), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "ValidatePublicKeyPartialExport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CallerCount(Count = 63)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60003BB")]
	public static Int32[] Create() { }

	[Address(RVA = "0x1164F70", Offset = "0x1164170", Length = "0x3A")]
	[CalledBy(Type = typeof(Ed25519), Member = "InvertDoubleZs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointExtended[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x60003BC")]
	public static Int32[] CreateTable(int n) { }

	[Address(RVA = "0x11653B0", Offset = "0x11645B0", Length = "0x159")]
	[CalledBy(Type = typeof(X25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "InvVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Decode128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CLSCompliant(False)]
	[Token(Token = "0x60003BD")]
	public static void Decode(UInt32[] x, int xOff, Int32[] z) { }

	[Address(RVA = "0x1165510", Offset = "0x1164710", Length = "0x9E")]
	[CalledBy(Type = typeof(Ed25519), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Decode128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003BE")]
	public static void Decode(Byte[] x, Int32[] z) { }

	[Address(RVA = "0x11652A0", Offset = "0x11644A0", Length = "0x10D")]
	[CalledBy(Type = typeof(X25519Field), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003BF")]
	private static void Decode128(UInt32[] x, int xOff, Int32[] z, int zOff) { }

	[Address(RVA = "0x1164FF0", Offset = "0x11641F0", Length = "0x2AA")]
	[CalledBy(Type = typeof(X25519Field), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003C0")]
	private static void Decode128(Byte[] bs, int off, Int32[] z, int zOff) { }

	[Address(RVA = "0x1139590", Offset = "0x1138790", Length = "0x6B")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C1")]
	private static uint Decode32(Byte[] bs, int off) { }

	[Address(RVA = "0x1165A10", Offset = "0x1164C10", Length = "0x135")]
	[CalledBy(Type = typeof(X25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "InvVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Encode128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CLSCompliant(False)]
	[Token(Token = "0x60003C2")]
	public static void Encode(Int32[] x, UInt32[] z, int zOff) { }

	[Address(RVA = "0x1165980", Offset = "0x1164B80", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Encode128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003C3")]
	public static void Encode(Int32[] x, Byte[] z, int zOff) { }

	[Address(RVA = "0x1165B50", Offset = "0x1164D50", Length = "0x98")]
	[CalledBy(Type = typeof(Ed25519), Member = "EncodePublicPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PublicPoint), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Encode128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003C4")]
	public static void Encode(Int32[] x, int xOff, Byte[] z, int zOff) { }

	[Address(RVA = "0x11655B0", Offset = "0x11647B0", Length = "0x259")]
	[CalledBy(Type = typeof(X25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003C6")]
	private static void Encode128(Int32[] x, int xOff, Byte[] bs, int off) { }

	[Address(RVA = "0x1165810", Offset = "0x1164A10", Length = "0xF6")]
	[CalledBy(Type = typeof(X25519Field), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003C5")]
	private static void Encode128(Int32[] x, int xOff, UInt32[] z, int zOff) { }

	[Address(RVA = "0x1165910", Offset = "0x1164B10", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C7")]
	private static void Encode32(uint n, Byte[] bs, int off) { }

	[Address(RVA = "0x1165DC0", Offset = "0x1164FC0", Length = "0x1C7")]
	[CalledBy(Type = typeof(Ed25519), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed25519), Member = "NormalizeToAffine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&), typeof(PointAffine&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X25519Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mod), Member = "ModOddInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(X25519Field), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003C8")]
	public static void Inv(Int32[] x, Int32[] z) { }

	[Address(RVA = "0x1165BF0", Offset = "0x1164DF0", Length = "0x1C7")]
	[CalledBy(Type = typeof(Ed25519), Member = "InvertDoubleZs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointExtended[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X25519Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mod), Member = "ModOddInverseVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X25519Field), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003C9")]
	public static void InvVar(Int32[] x, Int32[] z) { }

	[Address(RVA = "0x1166030", Offset = "0x1165230", Length = "0x5A")]
	[CalledBy(Type = typeof(Ed25519), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed25519), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Math.EC.Rfc8032.Ed25519+PointAccum"}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003CA")]
	public static int IsZero(Int32[] x) { }

	[Address(RVA = "0x1165F90", Offset = "0x1165190", Length = "0x90")]
	[CalledBy(Type = typeof(Ed25519), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003CB")]
	public static bool IsZeroVar(Int32[] x) { }

	[Address(RVA = "0x1166090", Offset = "0x1165290", Length = "0x82E")]
	[CalledBy(Type = typeof(Ed25519), Member = "PointCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&), typeof(PointExtended&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "PointPrecompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointExtended[]), typeof(int), typeof(int), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "PointDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "PointCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointExtended&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointPrecomp&), typeof(PointAccum&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "PointAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointExtended&), typeof(PointExtended&), typeof(PointExtended&), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "NormalizeToAffine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&), typeof(PointAffine&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "InvertDoubleZs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointExtended[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed25519), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Ed25519), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Math.EC.Rfc8032.Ed25519+PointAccum"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed25519), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(X25519Field), Member = "PowPm5d8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "SqrtRatioVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 65)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003CC")]
	public static void Mul(Int32[] x, Int32[] y, Int32[] z) { }

	[Address(RVA = "0x11668C0", Offset = "0x1165AC0", Length = "0x53")]
	[CalledBy(Type = typeof(Ed25519), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003CD")]
	public static void Negate(Int32[] x, Int32[] z) { }

	[Address(RVA = "0x1166920", Offset = "0x1165B20", Length = "0x84")]
	[CalledBy(Type = typeof(Ed25519), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed25519), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Math.EC.Rfc8032.Ed25519+PointAccum"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed25519), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Ed25519), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CalledBy(Type = typeof(Ed25519), Member = "NormalizeToAffine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&), typeof(PointAffine&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003CE")]
	public static void Normalize(Int32[] z) { }

	[Address(RVA = "0x11669B0", Offset = "0x1165BB0", Length = "0x47")]
	[CalledBy(Type = typeof(Ed25519), Member = "PointCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointExtended&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "PointPrecompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&), typeof(PointExtended[]), typeof(int), typeof(int), typeof(PointTemp&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "PointSetNeutral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "Precompute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003CF")]
	public static void One(Int32[] z) { }

	[Address(RVA = "0x1166A00", Offset = "0x1165C00", Length = "0x280")]
	[CalledBy(Type = typeof(X25519Field), Member = "SqrtRatioVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X25519Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60003D0")]
	private static void PowPm5d8(Int32[] x, Int32[] rx2, Int32[] rz) { }

	[Address(RVA = "0x1166C80", Offset = "0x1165E80", Length = "0x15B")]
	[CalledBy(Type = typeof(X25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "Inv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "InvVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "SqrtRatioVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003D1")]
	private static void Reduce(Int32[] z, int x) { }

	[Address(RVA = "0x1166E80", Offset = "0x1166080", Length = "0x53B")]
	[CalledBy(Type = typeof(Ed25519), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAffine&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed25519), Member = "CheckPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Math.EC.Rfc8032.Ed25519+PointAccum"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Ed25519), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Ed25519), Member = "PointDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "PowPm5d8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X25519Field), Member = "SqrtRatioVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003D2")]
	public static void Sqr(Int32[] x, Int32[] z) { }

	[Address(RVA = "0x1166DE0", Offset = "0x1165FE0", Length = "0x99")]
	[CalledBy(Type = typeof(X25519Field), Member = "PowPm5d8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X25519Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60003D3")]
	public static void Sqr(Int32[] x, int n, Int32[] z) { }

	[Address(RVA = "0x11673C0", Offset = "0x11665C0", Length = "0x500")]
	[CalledBy(Type = typeof(Ed25519), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(X25519Field), Member = "Mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Sqr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "PowPm5d8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X25519Field), Member = "Reduce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003D4")]
	public static bool SqrtRatioVar(Int32[] u, Int32[] v, Int32[] z) { }

	[Address(RVA = "0x1167900", Offset = "0x1166B00", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003D5")]
	public static void Sub(Int32[] x, Int32[] y, Int32[] z) { }

	[Address(RVA = "0x11678D0", Offset = "0x1166AD0", Length = "0x22")]
	[CalledBy(Type = typeof(Ed25519), Member = "DecodePointVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(PointAffine&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003D6")]
	public static void SubOne(Int32[] z) { }

	[Address(RVA = "0x1167980", Offset = "0x1166B80", Length = "0x49")]
	[CalledBy(Type = typeof(Ed25519), Member = "PointSetNeutral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ed25519), Member = "ScalarMultBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(PointAccum&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003D7")]
	public static void Zero(Int32[] z) { }

}

