namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000300")]
public abstract class RIPEMD160 : HashAlgorithm
{

	[Address(RVA = "0x133B7B0", Offset = "0x133A9B0", Length = "0x1D")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001834")]
	protected RIPEMD160() { }

	[Address(RVA = "0x133B760", Offset = "0x133A960", Length = "0x44")]
	[CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RIPEMD160Managed), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001835")]
	public static RIPEMD160 Create() { }

}

