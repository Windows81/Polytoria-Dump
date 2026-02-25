namespace System.Net.Http;

[Token(Token = "0x2000017")]
public class HttpResponseMessage : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000065")]
	private HttpResponseHeaders headers; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000066")]
	private string reasonPhrase; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000067")]
	private HttpStatusCode statusCode; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000068")]
	private Version version; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000069")]
	private bool disposed; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400006A")]
	private HttpContent <Content>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400006B")]
	private HttpRequestMessage <RequestMessage>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x17000012")]
	public HttpContent Content
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000076")]
		 get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000077")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000013")]
	public HttpResponseHeaders Headers
	{
		[Address(RVA = "0x1613070", Offset = "0x1612270", Length = "0xA1")]
		[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoWebRequestHandler), Member = "CreateResponseMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse), typeof(HttpRequestMessage), typeof(CancellationToken)}, ReturnType = typeof(HttpResponseMessage))]
		[CalledBy(Type = typeof(HttpResponseMessage), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(HttpHeaders), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000078")]
		 get { } //Length: 161
	}

	[Token(Token = "0x17000014")]
	public bool IsSuccessStatusCode
	{
		[Address(RVA = "0x1613120", Offset = "0x1612320", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000079")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000015")]
	public string ReasonPhrase
	{
		[Address(RVA = "0x1613140", Offset = "0x1612340", Length = "0x14")]
		[CalledBy(Type = typeof(HttpResponseMessage), Member = "EnsureSuccessStatusCode", ReturnType = typeof(HttpResponseMessage))]
		[CallerCount(Count = 1)]
		[Calls(Type = "System.Net.HttpStatusDescription", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode)}, ReturnType = typeof(string))]
		[Token(Token = "0x600007A")]
		 get { } //Length: 20
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600007B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000016")]
	public HttpRequestMessage RequestMessage
	{
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600007C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000017")]
	public HttpStatusCode StatusCode
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007D")]
		 get { } //Length: 4
		[Address(RVA = "0x16131C0", Offset = "0x16123C0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600007E")]
		 set { } //Length: 82
	}

	[Token(Token = "0x17000018")]
	public Version Version
	{
		[Address(RVA = "0x1613160", Offset = "0x1612360", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600007F")]
		 get { } //Length: 94
	}

	[Address(RVA = "0x1613000", Offset = "0x1612200", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000075")]
	public HttpResponseMessage(HttpStatusCode statusCode) { }

	[Address(RVA = "0x146EBB0", Offset = "0x146DDB0", Length = "0x16")]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000080")]
	public override void Dispose() { }

	[Address(RVA = "0x1612C90", Offset = "0x1611E90", Length = "0x30")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000081")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1612CC0", Offset = "0x1611EC0", Length = "0xB2")]
	[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController+<GetMeshUrlAsync>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(HttpResponseMessage), Member = "get_ReasonPhrase", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(HttpRequestException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000082")]
	public HttpResponseMessage EnsureSuccessStatusCode() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000076")]
	public HttpContent get_Content() { }

	[Address(RVA = "0x1613070", Offset = "0x1612270", Length = "0xA1")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoWebRequestHandler), Member = "CreateResponseMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse), typeof(HttpRequestMessage), typeof(CancellationToken)}, ReturnType = typeof(HttpResponseMessage))]
	[CalledBy(Type = typeof(HttpResponseMessage), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpHeaders), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000078")]
	public HttpResponseHeaders get_Headers() { }

	[Address(RVA = "0x1613120", Offset = "0x1612320", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000079")]
	public bool get_IsSuccessStatusCode() { }

	[Address(RVA = "0x1613140", Offset = "0x1612340", Length = "0x14")]
	[CalledBy(Type = typeof(HttpResponseMessage), Member = "EnsureSuccessStatusCode", ReturnType = typeof(HttpResponseMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = "System.Net.HttpStatusDescription", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode)}, ReturnType = typeof(string))]
	[Token(Token = "0x600007A")]
	public string get_ReasonPhrase() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007D")]
	public HttpStatusCode get_StatusCode() { }

	[Address(RVA = "0x1613160", Offset = "0x1612360", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600007F")]
	public Version get_Version() { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000077")]
	public void set_Content(HttpContent value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600007B")]
	public void set_ReasonPhrase(string value) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600007C")]
	public void set_RequestMessage(HttpRequestMessage value) { }

	[Address(RVA = "0x16131C0", Offset = "0x16123C0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600007E")]
	public void set_StatusCode(HttpStatusCode value) { }

	[Address(RVA = "0x1612D80", Offset = "0x1611F80", Length = "0x272")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = "System.Net.HttpStatusDescription", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(HttpResponseMessage), Member = "get_Headers", ReturnType = typeof(HttpResponseHeaders))]
	[Calls(Type = typeof(HttpContent), Member = "get_Headers", ReturnType = typeof(HttpContentHeaders))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000083")]
	public virtual string ToString() { }

}

