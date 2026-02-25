namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x2000190")]
public class Sha3Digest : KeccakDigest
{

	[Address(RVA = "0x10F5D90", Offset = "0x10F4F90", Length = "0xF7")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
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
	[Token(Token = "0x6000EB2")]
	public Sha3Digest(int bitLength) { }

	[Address(RVA = "0x10F5E90", Offset = "0x10F5090", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(KeccakDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeccakDigest)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EB3")]
	public Sha3Digest(Sha3Digest source) { }

	[Address(RVA = "0x10F5BF0", Offset = "0x10F4DF0", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000EB1")]
	private static int CheckBitLength(int bitLength) { }

	[Address(RVA = "0x10F5CB0", Offset = "0x10F4EB0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(KeccakDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeccakDigest)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EB5")]
	public virtual IMemoable Copy() { }

	[Address(RVA = "0x10F5D40", Offset = "0x10F4F40", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeccakDigest), Member = "AbsorbBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeccakDigest), Member = "DoFinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000EB4")]
	public virtual int DoFinal(Byte[] output, int outOff) { }

}

