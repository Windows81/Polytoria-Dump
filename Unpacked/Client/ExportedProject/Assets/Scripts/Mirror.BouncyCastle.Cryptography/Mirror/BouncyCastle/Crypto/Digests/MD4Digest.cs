namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x2000185")]
public class MD4Digest : GeneralDigest
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000393")]
	private int H1; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000394")]
	private int H2; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000395")]
	private int H3; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000396")]
	private int H4; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000397")]
	private Int32[] X; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000398")]
	private int xOff; //Field offset: 0x40

	[Address(RVA = "0x12084D0", Offset = "0x12076D0", Length = "0xA9")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E02")]
	public MD4Digest() { }

	[Address(RVA = "0x12083D0", Offset = "0x12075D0", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MD4Digest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MD4Digest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E03")]
	public MD4Digest(MD4Digest t) { }

	[Address(RVA = "0x12073A0", Offset = "0x12065A0", Length = "0x122")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MD4Digest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MD4Digest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E0E")]
	public virtual IMemoable Copy() { }

	[Address(RVA = "0x12072F0", Offset = "0x12064F0", Length = "0xAF")]
	[CalledBy(Type = typeof(MD4Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MD4Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MD4Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(MD4Digest), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemoable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E04")]
	private void CopyIn(MD4Digest t) { }

	[Address(RVA = "0x12074D0", Offset = "0x12066D0", Length = "0x1BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "UInt32_To_LE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000E08")]
	public virtual int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x10D8890", Offset = "0x10D7A90", Length = "0xD")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E0A")]
	private int F(int u, int v, int w) { }

	[Address(RVA = "0x10F1EE0", Offset = "0x10F10E0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E0B")]
	private int G(int u, int v, int w) { }

	[Address(RVA = "0x7C8170", Offset = "0x7C7370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E05")]
	public virtual int GetDigestSize() { }

	[Address(RVA = "0x10D8810", Offset = "0x10D7A10", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E0C")]
	private int H(int u, int v, int w) { }

	[Address(RVA = "0x1207690", Offset = "0x1206890", Length = "0xC06")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 48)]
	[Token(Token = "0x6000E0D")]
	internal virtual void ProcessBlock() { }

	[Address(RVA = "0x10DA230", Offset = "0x10D9430", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E07")]
	internal virtual void ProcessLength(long bitLength) { }

	[Address(RVA = "0x10DA2A0", Offset = "0x10D94A0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E06")]
	internal virtual void ProcessWord(Byte[] input, int inOff) { }

	[Address(RVA = "0x1208320", Offset = "0x1207520", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E09")]
	public virtual void Reset() { }

	[Address(RVA = "0x12082A0", Offset = "0x12074A0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MD4Digest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MD4Digest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000E0F")]
	public virtual void Reset(IMemoable other) { }

}

