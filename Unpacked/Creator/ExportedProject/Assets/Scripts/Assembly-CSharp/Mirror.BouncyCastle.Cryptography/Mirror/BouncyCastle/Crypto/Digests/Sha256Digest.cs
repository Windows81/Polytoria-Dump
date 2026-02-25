namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x200018E")]
public class Sha256Digest : GeneralDigest
{
	[Token(Token = "0x40003EF")]
	private static readonly UInt32[] K; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003E5")]
	private uint H1; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40003E6")]
	private uint H2; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003E7")]
	private uint H3; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40003E8")]
	private uint H4; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003E9")]
	private uint H5; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40003EA")]
	private uint H6; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003EB")]
	private uint H7; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40003EC")]
	private uint H8; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003ED")]
	private UInt32[] X; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003EE")]
	private int xOff; //Field offset: 0x50

	[Address(RVA = "0x10F56A0", Offset = "0x10F48A0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000EA9")]
	private static Sha256Digest() { }

	[Address(RVA = "0x10F5810", Offset = "0x10F4A10", Length = "0x8E")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection+<>c", Member = "<.cctor>b__47_1", ReturnType = typeof(HkdfBytesGenerator))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptionCredentials", Member = "PubKeyFingerprint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000E99")]
	public Sha256Digest() { }

	[Address(RVA = "0x10F5730", Offset = "0x10F4930", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E9A")]
	public Sha256Digest(Sha256Digest t) { }

	[Address(RVA = "0x10F49E0", Offset = "0x10F3BE0", Length = "0x10A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GeneralDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EA7")]
	public virtual IMemoable Copy() { }

	[Address(RVA = "0x10DD300", Offset = "0x10DC500", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E9B")]
	private void CopyIn(Sha256Digest t) { }

	[Address(RVA = "0x10F4AF0", Offset = "0x10F3CF0", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "Finish", ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "UInt32_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E9F")]
	public virtual int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x3CE2D0", Offset = "0x3CD4D0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E9C")]
	public virtual int GetDigestSize() { }

	[Address(RVA = "0x10F58A0", Offset = "0x10F4AA0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000EA1")]
	private void initHs() { }

	[Address(RVA = "0x10F4BD0", Offset = "0x10F3DD0", Length = "0x8A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000EA2")]
	internal virtual void ProcessBlock() { }

	[Address(RVA = "0x10F44B0", Offset = "0x10F36B0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E9E")]
	internal virtual void ProcessLength(long bitLength) { }

	[Address(RVA = "0x10F4520", Offset = "0x10F3720", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pack), Member = "BE_To_UInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E9D")]
	internal virtual void ProcessWord(Byte[] input, int inOff) { }

	[Address(RVA = "0x10F5580", Offset = "0x10F4780", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralDigest), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EA0")]
	public virtual void Reset() { }

	[Address(RVA = "0x10F5480", Offset = "0x10F4680", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GeneralDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeneralDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EA8")]
	public virtual void Reset(IMemoable other) { }

	[Address(RVA = "0x10F5600", Offset = "0x10F4800", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000EA4")]
	private static uint Sum0Maj(uint x, uint y, uint z) { }

	[Address(RVA = "0x10F5650", Offset = "0x10F4850", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000EA3")]
	private static uint Sum1Ch(uint x, uint y, uint z) { }

	[Address(RVA = "0x10F47A0", Offset = "0x10F39A0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA5")]
	private static uint Theta0(uint x) { }

	[Address(RVA = "0x10F47D0", Offset = "0x10F39D0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EA6")]
	private static uint Theta1(uint x) { }

}

