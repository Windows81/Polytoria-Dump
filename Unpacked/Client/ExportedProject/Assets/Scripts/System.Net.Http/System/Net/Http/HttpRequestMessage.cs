namespace System.Net.Http;

[Token(Token = "0x2000016")]
public class HttpRequestMessage : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400005E")]
	private HttpRequestHeaders headers; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400005F")]
	private HttpMethod method; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000060")]
	private Version version; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000061")]
	private Uri uri; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000062")]
	private bool is_used; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000063")]
	private bool disposed; //Field offset: 0x31
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000064")]
	private HttpContent <Content>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x1700000D")]
	public HttpContent Content
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000069")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000E")]
	public HttpRequestHeaders Headers
	{
		[Address(RVA = "0x1612870", Offset = "0x1611A70", Length = "0xA1")]
		[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoWebRequestHandler), Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage)}, ReturnType = typeof(HttpWebRequest))]
		[CalledBy(Type = typeof(HttpClient), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage), typeof(HttpCompletionOption), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>))]
		[CalledBy(Type = typeof(HttpRequestMessage), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(HttpHeaders), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600006A")]
		 get { } //Length: 161
	}

	[Token(Token = "0x1700000F")]
	public HttpMethod Method
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006B")]
		 get { } //Length: 5
		[Address(RVA = "0x1612980", Offset = "0x1611B80", Length = "0xA8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600006C")]
		 set { } //Length: 168
	}

	[Token(Token = "0x17000010")]
	public Uri RequestUri
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006D")]
		 get { } //Length: 5
		[Address(RVA = "0x1612A30", Offset = "0x1611C30", Length = "0x20F")]
		[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoWebRequestHandler), Member = "CreateResponseMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse), typeof(HttpRequestMessage), typeof(CancellationToken)}, ReturnType = typeof(HttpResponseMessage))]
		[CalledBy(Type = typeof(HttpClient), Member = "GetAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>))]
		[CalledBy(Type = typeof(HttpClient), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage), typeof(HttpCompletionOption), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>))]
		[CalledBy(Type = typeof(HttpRequestMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpMethod), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HttpRequestMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpMethod), typeof(Uri)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x600006E")]
		 set { } //Length: 527
	}

	[Token(Token = "0x17000011")]
	public Version Version
	{
		[Address(RVA = "0x1612920", Offset = "0x1611B20", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000070")]
		 get { } //Length: 94
	}

	[Address(RVA = "0x1612670", Offset = "0x1611870", Length = "0x125")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HttpRequestMessage), Member = "set_RequestUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000067")]
	public HttpRequestMessage(HttpMethod method, string requestUri) { }

	[Address(RVA = "0x16127A0", Offset = "0x16119A0", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HttpRequestMessage), Member = "set_RequestUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000068")]
	public HttpRequestMessage(HttpMethod method, Uri requestUri) { }

	[Address(RVA = "0x146EBB0", Offset = "0x146DDB0", Length = "0x16")]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000071")]
	public override void Dispose() { }

	[Address(RVA = "0x1612210", Offset = "0x1611410", Length = "0x30")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000072")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000069")]
	public HttpContent get_Content() { }

	[Address(RVA = "0x1612870", Offset = "0x1611A70", Length = "0xA1")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoWebRequestHandler), Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage)}, ReturnType = typeof(HttpWebRequest))]
	[CalledBy(Type = typeof(HttpClient), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage), typeof(HttpCompletionOption), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>))]
	[CalledBy(Type = typeof(HttpRequestMessage), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpHeaders), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600006A")]
	public HttpRequestHeaders get_Headers() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006B")]
	public HttpMethod get_Method() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006D")]
	public Uri get_RequestUri() { }

	[Address(RVA = "0x1612920", Offset = "0x1611B20", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000070")]
	public Version get_Version() { }

	[Address(RVA = "0x1612240", Offset = "0x1611440", Length = "0x15E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600006F")]
	private static bool IsAllowedAbsoluteUri(Uri uri) { }

	[Address(RVA = "0x1612980", Offset = "0x1611B80", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600006C")]
	public void set_Method(HttpMethod value) { }

	[Address(RVA = "0x1612A30", Offset = "0x1611C30", Length = "0x20F")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoWebRequestHandler), Member = "CreateResponseMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse), typeof(HttpRequestMessage), typeof(CancellationToken)}, ReturnType = typeof(HttpResponseMessage))]
	[CalledBy(Type = typeof(HttpClient), Member = "GetAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>))]
	[CalledBy(Type = typeof(HttpClient), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage), typeof(HttpCompletionOption), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>))]
	[CalledBy(Type = typeof(HttpRequestMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpMethod), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpRequestMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpMethod), typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600006E")]
	public void set_RequestUri(Uri value) { }

	[Address(RVA = "0x16123A0", Offset = "0x16115A0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000073")]
	internal bool SetIsUsed() { }

	[Address(RVA = "0x16123B0", Offset = "0x16115B0", Length = "0x2BD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpRequestMessage), Member = "get_Headers", ReturnType = typeof(HttpRequestHeaders))]
	[Calls(Type = typeof(HttpContent), Member = "get_Headers", ReturnType = typeof(HttpContentHeaders))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000074")]
	public virtual string ToString() { }

}

