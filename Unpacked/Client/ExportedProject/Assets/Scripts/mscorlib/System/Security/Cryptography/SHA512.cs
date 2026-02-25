namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200030B")]
public abstract class SHA512 : HashAlgorithm
{

	[Address(RVA = "0x1344D70", Offset = "0x1343F70", Length = "0x1D")]
	[CalledBy(Type = typeof(SHA512Managed), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600188C")]
	protected SHA512() { }

	[Address(RVA = "0x1344D20", Offset = "0x1343F20", Length = "0x44")]
	[CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SHA512Managed), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600188D")]
	public static SHA512 Create() { }

}

