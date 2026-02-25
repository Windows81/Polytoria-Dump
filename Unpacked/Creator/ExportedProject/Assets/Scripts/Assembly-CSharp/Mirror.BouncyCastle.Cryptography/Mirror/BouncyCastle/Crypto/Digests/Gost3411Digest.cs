namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x200017E")]
public class Gost3411Digest : IDigest, IMemoable
{
	[Token(Token = "0x4000367")]
	private static readonly Byte[] C2; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000355")]
	private Byte[] H; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000356")]
	private Byte[] L; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000357")]
	private Byte[] M; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000358")]
	private Byte[] Sum; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000359")]
	private Byte[][] C; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400035A")]
	private Byte[] xBuf; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400035B")]
	private int xBufOff; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400035C")]
	private ulong byteCount; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400035D")]
	private readonly IBlockCipher cipher; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400035E")]
	private Byte[] sBox; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400035F")]
	private Byte[] K; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000360")]
	private Byte[] a; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000361")]
	internal Int16[] wS; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000362")]
	internal Int16[] w_S; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000363")]
	internal Byte[] S; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000364")]
	internal Byte[] U; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000365")]
	internal Byte[] V; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000366")]
	internal Byte[] W; //Field offset: 0x98

	[Address(RVA = "0x11FF420", Offset = "0x11FE620", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000DAA")]
	private static Gost3411Digest() { }

	[Address(RVA = "0x11FF4B0", Offset = "0x11FE6B0", Length = "0x33A")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Gost3411Digest), Member = "MakeC", ReturnType = typeof(Byte[][]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gost28147Engine), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost28147Engine), Member = "GetSBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180182D70")]
	[Calls(Type = typeof(Gost3411Digest), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D97")]
	public Gost3411Digest() { }

	[Address(RVA = "0x11FF7F0", Offset = "0x11FE9F0", Length = "0x296")]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Gost3411Digest), Member = "MakeC", ReturnType = typeof(Byte[][]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gost28147Engine), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411Digest), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemoable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D98")]
	public Gost3411Digest(Gost3411Digest t) { }

	[Address(RVA = "0x11FE790", Offset = "0x11FD990", Length = "0xCA")]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "processBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D9D")]
	private Byte[] A(Byte[] input) { }

	[Address(RVA = "0x11FE860", Offset = "0x11FDA60", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gost3411Digest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411Digest), Member = "processBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D9B")]
	public override void BlockUpdate(Byte[] input, int inOff, int length) { }

	[Address(RVA = "0x11FEA10", Offset = "0x11FDC10", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gost3411Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gost3411Digest)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000DA8")]
	public override IMemoable Copy() { }

	[Address(RVA = "0x11FFA90", Offset = "0x11FEC90", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DA5")]
	private static void cpyBytesToShort(Byte[] S, Int16[] wS) { }

	[Address(RVA = "0x11FFB30", Offset = "0x11FED30", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DA6")]
	private static void cpyShortToBytes(Int16[] wS, Byte[] S) { }

	[Address(RVA = "0x11FEA70", Offset = "0x11FDC70", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_LE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411Digest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411Digest), Member = "processBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411Digest), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DA2")]
	public override int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x11FEB20", Offset = "0x11FDD20", Length = "0x145")]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "processBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(KeyParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180182D70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D9E")]
	private void E(Byte[] key, Byte[] s, int sOff, Byte[] input, int inOff) { }

	[Address(RVA = "0x11FEC70", Offset = "0x11FDE70", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_LE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411Digest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411Digest), Member = "processBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000DA1")]
	private void Finish() { }

	[Address(RVA = "0x11FFBD0", Offset = "0x11FEDD0", Length = "0x225")]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "processBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D9F")]
	private void fw(Byte[] input) { }

	[Address(RVA = "0x3CE2D0", Offset = "0x3CD4D0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DA7")]
	public override int GetByteLength() { }

	[Address(RVA = "0x3CE2D0", Offset = "0x3CD4D0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D99")]
	public override int GetDigestSize() { }

	[Address(RVA = "0x11FECD0", Offset = "0x11FDED0", Length = "0xAA")]
	[CalledBy(Type = typeof(Gost3411Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gost3411Digest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D96")]
	private static Byte[][] MakeC() { }

	[Address(RVA = "0x11FED80", Offset = "0x11FDF80", Length = "0x110")]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "processBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D9C")]
	private Byte[] P(Byte[] input) { }

	[Address(RVA = "0x11FFE00", Offset = "0x11FF000", Length = "0x59C")]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "Finish", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411Digest), Member = "E", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[]), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gost3411Digest), Member = "A", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Gost3411Digest), Member = "P", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Gost3411Digest), Member = "fw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DA0")]
	private void processBlock(Byte[] input, int inOff) { }

	[Address(RVA = "0x11FF1B0", Offset = "0x11FE3B0", Length = "0x181")]
	[CalledBy(Type = typeof(Gost3411Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemoable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DA3")]
	public override void Reset() { }

	[Address(RVA = "0x11FEEA0", Offset = "0x11FE0A0", Length = "0x30F")]
	[CalledBy(Type = typeof(Gost3411Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gost3411Digest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180182D70")]
	[Calls(Type = typeof(Gost3411Digest), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DA9")]
	public override void Reset(IMemoable other) { }

	[Address(RVA = "0x12003A0", Offset = "0x11FF5A0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DA4")]
	private void sumByteArray(Byte[] input) { }

	[Address(RVA = "0x11FF340", Offset = "0x11FE540", Length = "0xD8")]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "Finish", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gost3411Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Gost3411Digest), Member = "processBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D9A")]
	public override void Update(byte input) { }

}

