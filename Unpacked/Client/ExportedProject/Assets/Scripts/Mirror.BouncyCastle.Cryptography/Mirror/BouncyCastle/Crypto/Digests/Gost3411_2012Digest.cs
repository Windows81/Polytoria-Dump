namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x200017F")]
public abstract class Gost3411_2012Digest : IDigest, IMemoable
{
	[Token(Token = "0x4000371")]
	private static readonly Byte[][] C; //Field offset: 0x0
	[Token(Token = "0x4000372")]
	private static readonly Byte[] Zero; //Field offset: 0x8
	[Token(Token = "0x4000373")]
	private static readonly UInt64[][] T; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000368")]
	private readonly Byte[] IV; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000369")]
	private readonly Byte[] N; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400036A")]
	private readonly Byte[] Sigma; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400036B")]
	private readonly Byte[] Ki; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400036C")]
	private readonly Byte[] m; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400036D")]
	private readonly Byte[] h; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400036E")]
	private readonly Byte[] tmp; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400036F")]
	private readonly Byte[] block; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000370")]
	private int bOff; //Field offset: 0x50

	[Address(RVA = "0x12023B0", Offset = "0x12015B0", Length = "0x725")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DBB")]
	private static Gost3411_2012Digest() { }

	[Address(RVA = "0x1202AE0", Offset = "0x1201CE0", Length = "0x179")]
	[CalledBy(Type = typeof(Gost3411_2012_256Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411_2012_256Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gost3411_2012_256Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411_2012_256Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(Gost3411_2012_512Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411_2012_512Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gost3411_2012_512Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411_2012_512Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DAB")]
	protected Gost3411_2012Digest(Byte[] IV) { }

	[Address(RVA = "0x1202CE0", Offset = "0x1201EE0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DB8")]
	private void addMod512(Byte[] A, int num) { }

	[Address(RVA = "0x1202C60", Offset = "0x1201E60", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DB9")]
	private void addMod512(Byte[] A, Byte[] B) { }

	[Address(RVA = "0x1200430", Offset = "0x11FF630", Length = "0x266")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gost3411_2012Digest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411_2012Digest), Member = "g_N", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DB3")]
	public override void BlockUpdate(Byte[] input, int inOff, int len) { }

	[Token(Token = "0x6000DAC")]
	public abstract IMemoable Copy() { }

	[Address(RVA = "0x12006A0", Offset = "0x11FF8A0", Length = "0x375")]
	[CalledBy(Type = typeof(Gost3411_2012_256Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411_2012Digest), Member = "g_N", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DAD")]
	public override int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x1200A20", Offset = "0x11FFC20", Length = "0x1C8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Bytes), Member = "XorTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411_2012Digest), Member = "F", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DB6")]
	private void E(Byte[] K, Byte[] m) { }

	[Address(RVA = "0x1200BF0", Offset = "0x11FFDF0", Length = "0x1445")]
	[CalledBy(Type = typeof(Gost3411_2012Digest), Member = "E", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411_2012Digest), Member = "g_N", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DB4")]
	private void F(Byte[] V) { }

	[Address(RVA = "0x1202D70", Offset = "0x1201F70", Length = "0x25D")]
	[CalledBy(Type = typeof(Gost3411_2012Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Gost3411_2012Digest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411_2012Digest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Bytes), Member = "XorTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411_2012Digest), Member = "F", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DB7")]
	private void g_N(Byte[] h, Byte[] N, Byte[] m) { }

	[Address(RVA = "0x7C8250", Offset = "0x7C7450", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DAE")]
	public override int GetByteLength() { }

	[Token(Token = "0x6000DAF")]
	public abstract int GetDigestSize() { }

	[Address(RVA = "0x1202040", Offset = "0x1201240", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000DB0")]
	public override void Reset() { }

	[Address(RVA = "0x12020E0", Offset = "0x12012E0", Length = "0x16C")]
	[CalledBy(Type = typeof(Gost3411_2012_256Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gost3411_2012_256Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411_2012_256Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(Gost3411_2012_512Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gost3411_2012_512Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411_2012_512Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000DB1")]
	public override void Reset(IMemoable other) { }

	[Address(RVA = "0x1202FD0", Offset = "0x12021D0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DBA")]
	private void reverse(Byte[] src, Byte[] dst) { }

	[Address(RVA = "0x1202250", Offset = "0x1201450", Length = "0x14E")]
	[CalledBy(Type = typeof(Gost3411_2012Digest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Gost3411_2012Digest), Member = "g_N", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DB2")]
	public override void Update(byte input) { }

	[Address(RVA = "0x12023A0", Offset = "0x12015A0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bytes), Member = "XorTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000DB5")]
	private static void Xor512(Byte[] A, Byte[] B) { }

}

