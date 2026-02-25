namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000307")]
public abstract class SHA256 : HashAlgorithm
{

	[Address(RVA = "0x1343520", Offset = "0x1342720", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001866")]
	protected SHA256() { }

	[Address(RVA = "0x13434D0", Offset = "0x13426D0", Length = "0x44")]
	[CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController+<DoPublishScreenshot>d__27", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SHA256Managed), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001867")]
	public static SHA256 Create() { }

}

