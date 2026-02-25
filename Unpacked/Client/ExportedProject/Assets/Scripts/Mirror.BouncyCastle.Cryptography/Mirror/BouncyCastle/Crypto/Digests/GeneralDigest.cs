namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x200017D")]
public abstract class GeneralDigest : IDigest, IMemoable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000352")]
	private Byte[] xBuf; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000353")]
	private int xBufOff; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000354")]
	private long byteCount; //Field offset: 0x20

	[Address(RVA = "0x11FE730", Offset = "0x11FD930", Length = "0x55")]
	[CalledBy(Type = typeof(MD5Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RipeMD128Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RipeMD160Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RipeMD256Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RipeMD320Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha1Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha224Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha256Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SM3Digest), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D87")]
	internal GeneralDigest() { }

	[Address(RVA = "0x11FE680", Offset = "0x11FD880", Length = "0xAC")]
	[CalledBy(Type = typeof(Sha1Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(SM3Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(SM3Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SM3Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha256Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(Sha256Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sha256Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha224Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(Sha224Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sha224Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RipeMD320Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(RipeMD320Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RipeMD320Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha1Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sha1Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RipeMD256Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RipeMD256Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RipeMD160Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(RipeMD160Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RipeMD160Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RipeMD128Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(RipeMD128Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RipeMD128Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MD5Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CalledBy(Type = typeof(MD5Digest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MD5Digest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RipeMD256Digest), Member = "Copy", ReturnType = typeof(IMemoable))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D88")]
	internal GeneralDigest(GeneralDigest t) { }

	[Address(RVA = "0x11FE290", Offset = "0x11FD490", Length = "0x19A")]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptionCredentials", Member = "PubKeyFingerprint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000D8B")]
	public override void BlockUpdate(Byte[] input, int inOff, int length) { }

	[Token(Token = "0x6000D94")]
	public abstract IMemoable Copy() { }

	[Address(RVA = "0x11FE430", Offset = "0x11FD630", Length = "0x5E")]
	[CallerCount(Count = 42)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D89")]
	protected void CopyIn(GeneralDigest t) { }

	[Token(Token = "0x6000D93")]
	public abstract int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x11FE490", Offset = "0x11FD690", Length = "0x129")]
	[CalledBy(Type = typeof(MD5Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RipeMD128Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RipeMD160Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RipeMD256Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RipeMD320Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Sha1Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Sha224Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Sha256Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SM3Digest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000D8C")]
	public void Finish() { }

	[Address(RVA = "0x7C8250", Offset = "0x7C7450", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D8E")]
	public override int GetByteLength() { }

	[Token(Token = "0x6000D92")]
	public abstract int GetDigestSize() { }

	[Token(Token = "0x6000D91")]
	internal abstract void ProcessBlock() { }

	[Token(Token = "0x6000D90")]
	internal abstract void ProcessLength(long bitLength) { }

	[Token(Token = "0x6000D8F")]
	internal abstract void ProcessWord(Byte[] input, int inOff) { }

	[Address(RVA = "0x11FE5C0", Offset = "0x11FD7C0", Length = "0x31")]
	[CalledBy(Type = typeof(MD5Digest), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RipeMD128Digest), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RipeMD160Digest), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RipeMD256Digest), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RipeMD320Digest), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha1Digest), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha224Digest), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sha256Digest), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SM3Digest), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D8D")]
	public override void Reset() { }

	[Token(Token = "0x6000D95")]
	public abstract void Reset(IMemoable t) { }

	[Address(RVA = "0x11FE600", Offset = "0x11FD800", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D8A")]
	public override void Update(byte input) { }

}

