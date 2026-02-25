namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x2000183")]
public abstract class LongDigest : IDigest, IMemoable
{
	[Token(Token = "0x400038B")]
	internal static readonly UInt64[] K; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400037D")]
	private Byte[] xBuf; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400037E")]
	private int xBufOff; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400037F")]
	private long byteCount1; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000380")]
	private long byteCount2; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000381")]
	internal ulong H1; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000382")]
	internal ulong H2; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000383")]
	internal ulong H3; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000384")]
	internal ulong H4; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000385")]
	internal ulong H5; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000386")]
	internal ulong H6; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000387")]
	internal ulong H7; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000388")]
	internal ulong H8; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000389")]
	private UInt64[] W; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400038A")]
	private int wOff; //Field offset: 0x78

	[Address(RVA = "0x1206560", Offset = "0x1205760", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000DF3")]
	private static LongDigest() { }

	[Address(RVA = "0x12065F0", Offset = "0x12057F0", Length = "0x99")]
	[CalledBy(Type = typeof(Sha384Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha512Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha512tDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DDD")]
	internal LongDigest() { }

	[Address(RVA = "0x1206690", Offset = "0x1205890", Length = "0x15E")]
	[CalledBy(Type = typeof(Sha384Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sha384Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha384Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(Sha512Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sha512Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha512Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(Sha512tDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sha512tDigest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha512tDigest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DDE")]
	internal LongDigest(LongDigest t) { }

	[Address(RVA = "0x1205430", Offset = "0x1204630", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000DE5")]
	private void AdjustByteCounts() { }

	[Address(RVA = "0x1205460", Offset = "0x1204660", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LongDigest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(LongDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DE1")]
	public override void BlockUpdate(Byte[] input, int inOff, int length) { }

	[Address(RVA = "0x12055A0", Offset = "0x12047A0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE8")]
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	[Token(Token = "0x6000DF1")]
	public abstract IMemoable Copy() { }

	[Address(RVA = "0x12055B0", Offset = "0x12047B0", Length = "0xDF")]
	[CalledBy(Type = typeof(Sha384Digest), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemoable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha512Digest), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemoable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha512tDigest), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemoable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000DDF")]
	protected void CopyIn(LongDigest t) { }

	[Token(Token = "0x6000DF0")]
	public abstract int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x1205690", Offset = "0x1204890", Length = "0x1D8")]
	[CalledBy(Type = typeof(Sha384Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Sha512Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Sha512tDigest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Sha512tDigest), Member = "tIvGenerate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(LongDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000DE2")]
	public void Finish() { }

	[Address(RVA = "0x11F7A60", Offset = "0x11F6C60", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DEE")]
	public override int GetByteLength() { }

	[Token(Token = "0x6000DEF")]
	public abstract int GetDigestSize() { }

	[Address(RVA = "0x1205870", Offset = "0x1204A70", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE9")]
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	[Address(RVA = "0x1205880", Offset = "0x1204A80", Length = "0x9E4")]
	[CalledBy(Type = typeof(LongDigest), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LongDigest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LongDigest), Member = "Finish", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LongDigest), Member = "ProcessWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LongDigest), Member = "ProcessLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DE7")]
	internal void ProcessBlock() { }

	[Address(RVA = "0x1206270", Offset = "0x1205470", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LongDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DE6")]
	internal void ProcessLength(long lowW, long hiW) { }

	[Address(RVA = "0x12062E0", Offset = "0x12054E0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(LongDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DE4")]
	internal void ProcessWord(Byte[] input, int inOff) { }

	[Address(RVA = "0x1206350", Offset = "0x1205550", Length = "0x7F")]
	[CalledBy(Type = typeof(Sha384Digest), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha512Digest), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha512tDigest), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DE3")]
	public override void Reset() { }

	[Token(Token = "0x6000DF2")]
	public abstract void Reset(IMemoable t) { }

	[Address(RVA = "0x12063D0", Offset = "0x12055D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000DEC")]
	private static ulong Sigma0(ulong x) { }

	[Address(RVA = "0x1206400", Offset = "0x1205600", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000DED")]
	private static ulong Sigma1(ulong x) { }

	[Address(RVA = "0x1206430", Offset = "0x1205630", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000DEA")]
	private static ulong Sum0(ulong x) { }

	[Address(RVA = "0x1206470", Offset = "0x1205670", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000DEB")]
	private static ulong Sum1(ulong x) { }

	[Address(RVA = "0x12064B0", Offset = "0x12056B0", Length = "0xA4")]
	[CalledBy(Type = typeof(LongDigest), Member = "BlockUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha512tDigest), Member = "tIvGenerate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(LongDigest), Member = "ProcessBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DE0")]
	public override void Update(byte input) { }

}

