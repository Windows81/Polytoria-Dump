namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x2000191")]
public class Sha512Digest : LongDigest
{

	[Address(RVA = "0x10F6180", Offset = "0x10F5380", Length = "0x49")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CalledBy(Type = typeof(Ed25519), Member = "CreateDigest", ReturnType = typeof(IDigest))]
	[CalledBy(Type = typeof(Ed25519), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LongDigest), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000EB6")]
	public Sha512Digest() { }

	[Address(RVA = "0x10F61D0", Offset = "0x10F53D0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LongDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongDigest)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EB7")]
	public Sha512Digest(Sha512Digest t) { }

	[Address(RVA = "0x10F5EF0", Offset = "0x10F50F0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LongDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongDigest)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EBB")]
	public virtual IMemoable Copy() { }

	[Address(RVA = "0x10F5F80", Offset = "0x10F5180", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LongDigest), Member = "Finish", ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EB9")]
	public virtual int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x7C8250", Offset = "0x7C7450", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EB8")]
	public virtual int GetDigestSize() { }

	[Address(RVA = "0x10F60F0", Offset = "0x10F52F0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LongDigest), Member = "Reset", ReturnType = typeof(void))]
	[Token(Token = "0x6000EBA")]
	public virtual void Reset() { }

	[Address(RVA = "0x10F6070", Offset = "0x10F5270", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000EBC")]
	public virtual void Reset(IMemoable other) { }

}

