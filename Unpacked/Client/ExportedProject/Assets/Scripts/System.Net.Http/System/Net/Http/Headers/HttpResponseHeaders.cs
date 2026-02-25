namespace System.Net.Http.Headers;

[Token(Token = "0x200002F")]
public sealed class HttpResponseHeaders : HttpHeaders
{

	[Address(RVA = "0x1612C40", Offset = "0x1611E40", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpHeaders), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000138")]
	internal HttpResponseHeaders() { }

}

