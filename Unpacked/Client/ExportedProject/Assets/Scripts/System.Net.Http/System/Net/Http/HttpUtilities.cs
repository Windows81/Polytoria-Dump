namespace System.Net.Http;

[Extension]
[Token(Token = "0x2000002")]
internal static class HttpUtilities
{

	[Address(RVA = "0x1613220", Offset = "0x1612420", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000002")]
	internal static bool IsSecureWebSocketScheme(string scheme) { }

	[Address(RVA = "0x1613270", Offset = "0x1612470", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000001")]
	internal static bool IsSupportedSecureScheme(string scheme) { }

}

