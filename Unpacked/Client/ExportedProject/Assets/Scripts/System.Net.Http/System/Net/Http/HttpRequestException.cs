namespace System.Net.Http;

[Token(Token = "0x2000015")]
public class HttpRequestException : Exception
{

	[Address(RVA = "0x1611810", Offset = "0x1610A10", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000064")]
	public HttpRequestException() { }

	[Address(RVA = "0x1611860", Offset = "0x1610A60", Length = "0x59")]
	[CalledBy(Type = "System.Net.Http.HttpContent+FixedMemoryStream", Member = "CheckOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpResponseMessage), Member = "EnsureSuccessStatusCode", ReturnType = typeof(HttpResponseMessage))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000065")]
	public HttpRequestException(string message) { }

	[Address(RVA = "0x16118C0", Offset = "0x1610AC0", Length = "0x69")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000066")]
	public HttpRequestException(string message, Exception inner) { }

}

