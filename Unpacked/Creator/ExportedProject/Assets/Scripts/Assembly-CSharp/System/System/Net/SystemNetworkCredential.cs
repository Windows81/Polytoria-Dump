namespace System.Net;

[Token(Token = "0x2000226")]
internal class SystemNetworkCredential : NetworkCredential
{
	[Token(Token = "0x40008AC")]
	internal static readonly SystemNetworkCredential defaultCredential; //Field offset: 0x0

	[Address(RVA = "0x17E0510", Offset = "0x17DF710", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SecureStringHelper), Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DFA")]
	private static SystemNetworkCredential() { }

	[Address(RVA = "0x17E0620", Offset = "0x17DF820", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SecureStringHelper), Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DF9")]
	private SystemNetworkCredential() { }

}

