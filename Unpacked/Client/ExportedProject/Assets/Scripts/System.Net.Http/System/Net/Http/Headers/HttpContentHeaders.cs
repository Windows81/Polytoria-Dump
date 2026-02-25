namespace System.Net.Http.Headers;

[Token(Token = "0x2000027")]
public sealed class HttpContentHeaders : HttpHeaders
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000094")]
	private readonly HttpContent content; //Field offset: 0x20

	[Token(Token = "0x17000035")]
	public Nullable<Int64> ContentLength
	{
		[Address(RVA = "0x160CC20", Offset = "0x160BE20", Length = "0x1B9")]
		[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HttpHeaders), Member = "GetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HttpHeaders), Member = "SetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(System.Func`2<System.Object, System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60000FC")]
		 get { } //Length: 441
	}

	[Token(Token = "0x17000036")]
	public MediaTypeHeaderValue ContentType
	{
		[Address(RVA = "0x160CDE0", Offset = "0x160BFE0", Length = "0x4C")]
		[CalledBy(Type = "System.Net.Http.HttpContent+<ReadAsStringAsync>d__20", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HttpHeaders), Member = "GetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
		[Token(Token = "0x60000FD")]
		 get { } //Length: 76
	}

	[Address(RVA = "0x160CBB0", Offset = "0x160BDB0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpHeaders), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000FB")]
	internal HttpContentHeaders(HttpContent content) { }

	[Address(RVA = "0x160CC20", Offset = "0x160BE20", Length = "0x1B9")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpHeaders), Member = "GetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpHeaders), Member = "SetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(System.Func`2<System.Object, System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000FC")]
	public Nullable<Int64> get_ContentLength() { }

	[Address(RVA = "0x160CDE0", Offset = "0x160BFE0", Length = "0x4C")]
	[CalledBy(Type = "System.Net.Http.HttpContent+<ReadAsStringAsync>d__20", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpHeaders), Member = "GetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Token(Token = "0x60000FD")]
	public MediaTypeHeaderValue get_ContentType() { }

}

