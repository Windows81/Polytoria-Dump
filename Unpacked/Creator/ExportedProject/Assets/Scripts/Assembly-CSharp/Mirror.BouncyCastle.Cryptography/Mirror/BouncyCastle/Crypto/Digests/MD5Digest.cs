namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x2000186")]
public class MD5Digest : GeneralDigest
{
	[Token(Token = "0x400039F")]
	private static readonly int S11; //Field offset: 0x0
	[Token(Token = "0x40003A0")]
	private static readonly int S12; //Field offset: 0x4
	[Token(Token = "0x40003A1")]
	private static readonly int S13; //Field offset: 0x8
	[Token(Token = "0x40003A2")]
	private static readonly int S14; //Field offset: 0xC
	[Token(Token = "0x40003A3")]
	private static readonly int S21; //Field offset: 0x10
	[Token(Token = "0x40003A4")]
	private static readonly int S22; //Field offset: 0x14
	[Token(Token = "0x40003A5")]
	private static readonly int S23; //Field offset: 0x18
	[Token(Token = "0x40003A6")]
	private static readonly int S24; //Field offset: 0x1C
	[Token(Token = "0x40003A7")]
	private static readonly int S31; //Field offset: 0x20
	[Token(Token = "0x40003A8")]
	private static readonly int S32; //Field offset: 0x24
	[Token(Token = "0x40003A9")]
	private static readonly int S33; //Field offset: 0x28
	[Token(Token = "0x40003AA")]
	private static readonly int S34; //Field offset: 0x2C
	[Token(Token = "0x40003AB")]
	private static readonly int S41; //Field offset: 0x30
	[Token(Token = "0x40003AC")]
	private static readonly int S42; //Field offset: 0x34
	[Token(Token = "0x40003AD")]
	private static readonly int S43; //Field offset: 0x38
	[Token(Token = "0x40003AE")]
	private static readonly int S44; //Field offset: 0x3C
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000399")]
	private uint H1; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400039A")]
	private uint H2; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400039B")]
	private uint H3; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400039C")]
	private uint H4; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400039D")]
	private UInt32[] X; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400039E")]
	private int xOff; //Field offset: 0x40

	[Address(RVA = "0x10D8180", Offset = "0x10D7380", Length = "0x174")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000E1F")]
	private static MD5Digest() { }

	[Address(RVA = "0x10D8300", Offset = "0x10D7500", Length = "0x6C")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E10")]
	public MD5Digest() { }

	[Address(RVA = "0x10D8370", Offset = "0x10D7570", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E11")]
	public MD5Digest(MD5Digest t) { }

	[Address(RVA = "0x10D6970", Offset = "0x10D5B70", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E1D")]
	public virtual IMemoable Copy() { }

	[Address(RVA = "0x10D68F0", Offset = "0x10D5AF0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E12")]
	private void CopyIn(MD5Digest t) { }

	[Address(RVA = "0x10D6A70", Offset = "0x10D5C70", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "Finish", ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "UInt32_To_LE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E16")]
	public virtual int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x10D6B10", Offset = "0x10D5D10", Length = "0xC")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E18")]
	private static uint F(uint u, uint v, uint w) { }

	[Address(RVA = "0x10D6B20", Offset = "0x10D5D20", Length = "0xD")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E19")]
	private static uint G(uint u, uint v, uint w) { }

	[Address(RVA = "0x7C8170", Offset = "0x7C7370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E13")]
	public virtual int GetDigestSize() { }

	[Address(RVA = "0x10D6B30", Offset = "0x10D5D30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E1A")]
	private static uint H(uint u, uint v, uint w) { }

	[Address(RVA = "0x10D6B40", Offset = "0x10D5D40", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E1B")]
	private static uint K(uint u, uint v, uint w) { }

	[Address(RVA = "0x10D6B50", Offset = "0x10D5D50", Length = "0x1360")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 64)]
	[Token(Token = "0x6000E1C")]
	internal virtual void ProcessBlock() { }

	[Address(RVA = "0x10D7EC0", Offset = "0x10D70C0", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E15")]
	internal virtual void ProcessLength(long bitLength) { }

	[Address(RVA = "0x10D7F90", Offset = "0x10D7190", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E14")]
	internal virtual void ProcessWord(Byte[] input, int inOff) { }

	[Address(RVA = "0x10D8010", Offset = "0x10D7210", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E17")]
	public virtual void Reset() { }

	[Address(RVA = "0x10D80A0", Offset = "0x10D72A0", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E1E")]
	public virtual void Reset(IMemoable other) { }

}

