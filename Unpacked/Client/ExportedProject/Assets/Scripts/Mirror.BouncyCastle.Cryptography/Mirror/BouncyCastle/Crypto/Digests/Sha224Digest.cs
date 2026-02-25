namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x200018D")]
public class Sha224Digest : GeneralDigest
{
	[Token(Token = "0x40003E4")]
	internal static readonly UInt32[] K; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003DA")]
	private uint H1; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40003DB")]
	private uint H2; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003DC")]
	private uint H3; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40003DD")]
	private uint H4; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003DE")]
	private uint H5; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40003DF")]
	private uint H6; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003E0")]
	private uint H7; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40003E1")]
	private uint H8; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003E2")]
	private UInt32[] X; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003E3")]
	private int xOff; //Field offset: 0x50

	[Address(RVA = "0x10F4800", Offset = "0x10F3A00", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E98")]
	private static Sha224Digest() { }

	[Address(RVA = "0x10F4970", Offset = "0x10F3B70", Length = "0x6C")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E87")]
	public Sha224Digest() { }

	[Address(RVA = "0x10F4890", Offset = "0x10F3A90", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E88")]
	public Sha224Digest(Sha224Digest t) { }

	[Address(RVA = "0x10F39E0", Offset = "0x10F2BE0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E90")]
	private static uint Ch(uint x, uint y, uint z) { }

	[Address(RVA = "0x10F39F0", Offset = "0x10F2BF0", Length = "0x10A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E96")]
	public virtual IMemoable Copy() { }

	[Address(RVA = "0x10DD300", Offset = "0x10DC500", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E89")]
	private void CopyIn(Sha224Digest t) { }

	[Address(RVA = "0x10F3B00", Offset = "0x10F2D00", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "Finish", ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "UInt32_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E8D")]
	public virtual int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x3CE280", Offset = "0x3CD480", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E8A")]
	public virtual int GetDigestSize() { }

	[Address(RVA = "0x10F3BD0", Offset = "0x10F2DD0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E91")]
	private static uint Maj(uint x, uint y, uint z) { }

	[Address(RVA = "0x10F3BE0", Offset = "0x10F2DE0", Length = "0x8C4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E8F")]
	internal virtual void ProcessBlock() { }

	[Address(RVA = "0x10F44B0", Offset = "0x10F36B0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E8C")]
	internal virtual void ProcessLength(long bitLength) { }

	[Address(RVA = "0x10F4520", Offset = "0x10F3720", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E8B")]
	internal virtual void ProcessWord(Byte[] input, int inOff) { }

	[Address(RVA = "0x10F46A0", Offset = "0x10F38A0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E8E")]
	public virtual void Reset() { }

	[Address(RVA = "0x10F45A0", Offset = "0x10F37A0", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E97")]
	public virtual void Reset(IMemoable other) { }

	[Address(RVA = "0x10F4720", Offset = "0x10F3920", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E92")]
	private static uint Sum0(uint x) { }

	[Address(RVA = "0x10F4760", Offset = "0x10F3960", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E93")]
	private static uint Sum1(uint x) { }

	[Address(RVA = "0x10F47A0", Offset = "0x10F39A0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E94")]
	private static uint Theta0(uint x) { }

	[Address(RVA = "0x10F47D0", Offset = "0x10F39D0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E95")]
	private static uint Theta1(uint x) { }

}

