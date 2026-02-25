namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000309")]
public abstract class SHA384 : HashAlgorithm
{

	[Address(RVA = "0x1344D00", Offset = "0x1343F00", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001879")]
	protected SHA384() { }

	[Address(RVA = "0x1344CB0", Offset = "0x1343EB0", Length = "0x44")]
	[CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SHA384Managed), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600187A")]
	public static SHA384 Create() { }

}

