namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x2000193")]
public class ShakeDigest : KeccakDigest, IXof, IDigest
{

	[Address(RVA = "0x10F6ED0", Offset = "0x10F60D0", Length = "0xE2")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CalledBy(Type = typeof(Ed448), Member = "CreateXof", ReturnType = typeof(IXof))]
	[CalledBy(Type = typeof(Ed448), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(KeccakDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000EC8")]
	public ShakeDigest(int bitLength) { }

	[Address(RVA = "0x10F6FC0", Offset = "0x10F61C0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(KeccakDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeccakDigest)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EC9")]
	public ShakeDigest(ShakeDigest source) { }

	[Address(RVA = "0x10F6C60", Offset = "0x10F5E60", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000EC7")]
	private static int CheckBitLength(int bitLength) { }

	[Address(RVA = "0x10F6D10", Offset = "0x10F5F10", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(KeccakDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeccakDigest)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000ECE")]
	public virtual IMemoable Copy() { }

	[Address(RVA = "0x10F6DA0", Offset = "0x10F5FA0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000ECB")]
	public virtual int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x10F6E00", Offset = "0x10F6000", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000ECA")]
	public virtual int GetDigestSize() { }

	[Address(RVA = "0x10F6E60", Offset = "0x10F6060", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeccakDigest), Member = "AbsorbBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeccakDigest), Member = "Squeeze", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000ECD")]
	public override int Output(Byte[] output, int outOff, int outLen) { }

	[Address(RVA = "0x10F6E10", Offset = "0x10F6010", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000ECC")]
	public override int OutputFinal(Byte[] output, int outOff, int outLen) { }

}

