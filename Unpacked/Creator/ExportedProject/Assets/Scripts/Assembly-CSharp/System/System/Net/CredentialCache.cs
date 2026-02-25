namespace System.Net;

[Token(Token = "0x2000225")]
public class CredentialCache
{

	[Token(Token = "0x170002BF")]
	public static ICredentials DefaultCredentials
	{
		[Address(RVA = "0x17D2E00", Offset = "0x17D2000", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000DF7")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170002C0")]
	public static NetworkCredential DefaultNetworkCredentials
	{
		[Address(RVA = "0x17D2E50", Offset = "0x17D2050", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000DF8")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x17D2E00", Offset = "0x17D2000", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000DF7")]
	public static ICredentials get_DefaultCredentials() { }

	[Address(RVA = "0x17D2E50", Offset = "0x17D2050", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000DF8")]
	public static NetworkCredential get_DefaultNetworkCredentials() { }

}

