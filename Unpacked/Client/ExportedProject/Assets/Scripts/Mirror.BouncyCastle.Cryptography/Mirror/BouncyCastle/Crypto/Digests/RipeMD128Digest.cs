namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x2000188")]
public class RipeMD128Digest : GeneralDigest
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003B0")]
	private int H0; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40003B1")]
	private int H1; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003B2")]
	private int H2; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40003B3")]
	private int H3; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003B4")]
	private Int32[] X; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003B5")]
	private int xOff; //Field offset: 0x40

	[Address(RVA = "0x10DA4F0", Offset = "0x10D96F0", Length = "0x6C")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E27")]
	public RipeMD128Digest() { }

	[Address(RVA = "0x10DA420", Offset = "0x10D9620", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E28")]
	public RipeMD128Digest(RipeMD128Digest t) { }

	[Address(RVA = "0x10D8710", Offset = "0x10D7910", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E3D")]
	public virtual IMemoable Copy() { }

	[Address(RVA = "0x10D68F0", Offset = "0x10D5AF0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E29")]
	private void CopyIn(RipeMD128Digest t) { }

	[Address(RVA = "0x10D6A70", Offset = "0x10D5C70", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "Finish", ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "UInt32_To_LE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2D")]
	public virtual int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x10D8820", Offset = "0x10D7A20", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E34")]
	private int F1(int a, int b, int c, int d, int x, int s) { }

	[Address(RVA = "0x10D8810", Offset = "0x10D7A10", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E30")]
	private int F1(int x, int y, int z) { }

	[Address(RVA = "0x10D8850", Offset = "0x10D7A50", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E35")]
	private int F2(int a, int b, int c, int d, int x, int s) { }

	[Address(RVA = "0x10D8890", Offset = "0x10D7A90", Length = "0xD")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E31")]
	private int F2(int x, int y, int z) { }

	[Address(RVA = "0x10D88A0", Offset = "0x10D7AA0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E36")]
	private int F3(int a, int b, int c, int d, int x, int s) { }

	[Address(RVA = "0x10D88E0", Offset = "0x10D7AE0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E32")]
	private int F3(int x, int y, int z) { }

	[Address(RVA = "0x10D8930", Offset = "0x10D7B30", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E33")]
	private int F4(int x, int y, int z) { }

	[Address(RVA = "0x10D88F0", Offset = "0x10D7AF0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E37")]
	private int F4(int a, int b, int c, int d, int x, int s) { }

	[Address(RVA = "0x10D8820", Offset = "0x10D7A20", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E38")]
	private int FF1(int a, int b, int c, int d, int x, int s) { }

	[Address(RVA = "0x10D8940", Offset = "0x10D7B40", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E39")]
	private int FF2(int a, int b, int c, int d, int x, int s) { }

	[Address(RVA = "0x10D8980", Offset = "0x10D7B80", Length = "0x37")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E3A")]
	private int FF3(int a, int b, int c, int d, int x, int s) { }

	[Address(RVA = "0x10D89C0", Offset = "0x10D7BC0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E3B")]
	private int FF4(int a, int b, int c, int d, int x, int s) { }

	[Address(RVA = "0x7C8170", Offset = "0x7C7370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2A")]
	public virtual int GetDigestSize() { }

	[Address(RVA = "0x10D8A00", Offset = "0x10D7C00", Length = "0x1823")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E3C")]
	internal virtual void ProcessBlock() { }

	[Address(RVA = "0x10DA230", Offset = "0x10D9430", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2C")]
	internal virtual void ProcessLength(long bitLength) { }

	[Address(RVA = "0x10DA2A0", Offset = "0x10D94A0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2B")]
	internal virtual void ProcessWord(Byte[] input, int inOff) { }

	[Address(RVA = "0x10D8010", Offset = "0x10D7210", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2E")]
	public virtual void Reset() { }

	[Address(RVA = "0x10DA340", Offset = "0x10D9540", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E3E")]
	public virtual void Reset(IMemoable other) { }

	[Address(RVA = "0x10DA320", Offset = "0x10D9520", Length = "0x16")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2F")]
	private int RL(int x, int n) { }

}

