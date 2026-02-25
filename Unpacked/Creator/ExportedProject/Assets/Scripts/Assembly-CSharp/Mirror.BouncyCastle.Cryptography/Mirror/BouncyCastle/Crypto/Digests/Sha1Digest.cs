namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x200018C")]
public class Sha1Digest : GeneralDigest
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003D3")]
	private uint H1; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40003D4")]
	private uint H2; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003D5")]
	private uint H3; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40003D6")]
	private uint H4; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003D7")]
	private uint H5; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003D8")]
	private UInt32[] X; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003D9")]
	private int xOff; //Field offset: 0x48

	[Address(RVA = "0x10F38A0", Offset = "0x10F2AA0", Length = "0x6C")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E79")]
	public Sha1Digest() { }

	[Address(RVA = "0x10F3910", Offset = "0x10F2B10", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E7A")]
	public Sha1Digest(Sha1Digest t) { }

	[Address(RVA = "0x10F2BE0", Offset = "0x10F1DE0", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E85")]
	public virtual IMemoable Copy() { }

	[Address(RVA = "0x10DA560", Offset = "0x10D9760", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E7B")]
	private void CopyIn(Sha1Digest t) { }

	[Address(RVA = "0x10F2CE0", Offset = "0x10F1EE0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "Finish", ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "UInt32_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E7F")]
	public virtual int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x10D6B10", Offset = "0x10D5D10", Length = "0xC")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E81")]
	private static uint F(uint u, uint v, uint w) { }

	[Address(RVA = "0x10F2D90", Offset = "0x10F1F90", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E83")]
	private static uint G(uint u, uint v, uint w) { }

	[Address(RVA = "0x3CE250", Offset = "0x3CD450", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E7C")]
	public virtual int GetDigestSize() { }

	[Address(RVA = "0x10D6B30", Offset = "0x10D5D30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E82")]
	private static uint H(uint u, uint v, uint w) { }

	[Address(RVA = "0x10F2DA0", Offset = "0x10F1FA0", Length = "0x8BE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E84")]
	internal virtual void ProcessBlock() { }

	[Address(RVA = "0x10F3660", Offset = "0x10F2860", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E7E")]
	internal virtual void ProcessLength(long bitLength) { }

	[Address(RVA = "0x10F36D0", Offset = "0x10F28D0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E7D")]
	internal virtual void ProcessWord(Byte[] input, int inOff) { }

	[Address(RVA = "0x10F3750", Offset = "0x10F2950", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E80")]
	public virtual void Reset() { }

	[Address(RVA = "0x10F37B0", Offset = "0x10F29B0", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E86")]
	public virtual void Reset(IMemoable other) { }

}

