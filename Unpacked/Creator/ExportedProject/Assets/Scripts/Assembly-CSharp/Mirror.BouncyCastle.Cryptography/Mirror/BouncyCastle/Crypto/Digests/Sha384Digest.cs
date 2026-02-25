namespace Mirror.BouncyCastle.Crypto.Digests;

[Token(Token = "0x200018F")]
public class Sha384Digest : LongDigest
{

	[Address(RVA = "0x10F5B40", Offset = "0x10F4D40", Length = "0x49")]
	[CalledBy(Type = typeof(DigestUtilities), Member = "GetDigestForMechanism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDigest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LongDigest), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000EAA")]
	public Sha384Digest() { }

	[Address(RVA = "0x10F5B90", Offset = "0x10F4D90", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LongDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongDigest)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EAB")]
	public Sha384Digest(Sha384Digest t) { }

	[Address(RVA = "0x10F58E0", Offset = "0x10F4AE0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LongDigest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongDigest)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000EAF")]
	public virtual IMemoable Copy() { }

	[Address(RVA = "0x10F5970", Offset = "0x10F4B70", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LongDigest), Member = "Finish", ReturnType = typeof(void))]
	[Calls(Type = typeof(Pack), Member = "UInt64_To_BE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EAD")]
	public virtual int DoFinal(Byte[] output, int outOff) { }

	[Address(RVA = "0x3CE050", Offset = "0x3CD250", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EAC")]
	public virtual int GetDigestSize() { }

	[Address(RVA = "0x10F5A30", Offset = "0x10F4C30", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LongDigest), Member = "Reset", ReturnType = typeof(void))]
	[Token(Token = "0x6000EAE")]
	public virtual void Reset() { }

	[Address(RVA = "0x10F5AC0", Offset = "0x10F4CC0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LongDigest), Member = "CopyIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LongDigest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000EB0")]
	public virtual void Reset(IMemoable other) { }

}

