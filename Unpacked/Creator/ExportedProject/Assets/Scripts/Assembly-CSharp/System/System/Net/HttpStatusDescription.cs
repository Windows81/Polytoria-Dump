namespace System.Net;

[Token(Token = "0x2000201")]
internal static class HttpStatusDescription
{

	[Address(RVA = "0x17C0950", Offset = "0x17BFB50", Length = "0x7")]
	[CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(HttpStatusCode), typeof(WebHeaderCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(WebResponseStream), typeof(CookieContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.HttpResponseMessage", Member = "get_ReasonPhrase", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Http.HttpResponseMessage", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HttpStatusDescription), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000CC8")]
	internal static string Get(HttpStatusCode code) { }

	[Address(RVA = "0x17C0960", Offset = "0x17BFB60", Length = "0x6DC")]
	[CalledBy(Type = typeof(HttpStatusDescription), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000CC9")]
	internal static string Get(int code) { }

}

