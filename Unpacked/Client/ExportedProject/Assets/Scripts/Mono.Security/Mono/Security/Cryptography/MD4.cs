namespace Mono.Security.Cryptography;

[Token(Token = "0x200004B")]
public abstract class MD4 : HashAlgorithm
{

	[Address(RVA = "0x12CAE20", Offset = "0x12CA020", Length = "0x1D")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600018B")]
	protected MD4() { }

	[Address(RVA = "0x12CC1C0", Offset = "0x12CB3C0", Length = "0x12E")]
	[CalledBy(Type = typeof(ChallengeResponse), Member = "set_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLM_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600018C")]
	public static MD4 Create() { }

}

