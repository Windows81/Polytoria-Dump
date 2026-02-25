namespace System.Net.Http.Headers;

[Token(Token = "0x200002D")]
public sealed class HttpRequestHeaders : HttpHeaders
{
	[CompilerGenerated]
	[Token(Token = "0x200002E")]
	private sealed class <>c
	{
		[Token(Token = "0x40000AB")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000AC")]
		public static Predicate<String> <>9__19_0; //Field offset: 0x8
		[Token(Token = "0x40000AD")]
		public static Predicate<TransferCodingHeaderValue> <>9__29_0; //Field offset: 0x10
		[Token(Token = "0x40000AE")]
		public static Predicate<TransferCodingHeaderValue> <>9__71_0; //Field offset: 0x18

		[Address(RVA = "0x1620A10", Offset = "0x161FC10", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000133")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000134")]
		public <>c() { }

		[Address(RVA = "0x16208A0", Offset = "0x161FAA0", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000135")]
		internal bool <get_ConnectionClose>b__19_0(string l) { }

		[Address(RVA = "0x16208F0", Offset = "0x161FAF0", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000136")]
		internal bool <get_ExpectContinue>b__29_0(TransferCodingHeaderValue l) { }

		[Address(RVA = "0x1620940", Offset = "0x161FB40", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000137")]
		internal bool <get_TransferEncodingChunked>b__71_0(TransferCodingHeaderValue l) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000AA")]
	private Nullable<Boolean> expectContinue; //Field offset: 0x20

	[Token(Token = "0x1700003E")]
	public HttpHeaderValueCollection<String> Connection
	{
		[Address(RVA = "0x1611D80", Offset = "0x1610F80", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
		[Token(Token = "0x600012C")]
		 get { } //Length: 76
	}

	[Token(Token = "0x1700003F")]
	public Nullable<Boolean> ConnectionClose
	{
		[Address(RVA = "0x1611B90", Offset = "0x1610D90", Length = "0x1E8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(HttpHeaderValueCollection`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600012D")]
		 get { } //Length: 488
	}

	[Token(Token = "0x17000040")]
	public Nullable<Boolean> ExpectContinue
	{
		[Address(RVA = "0x1611DD0", Offset = "0x1610FD0", Length = "0x1C0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(HttpHeaderValueCollection`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600012E")]
		 get { } //Length: 448
	}

	[Token(Token = "0x17000041")]
	public string Host
	{
		[Address(RVA = "0x1611FA0", Offset = "0x16111A0", Length = "0x4C")]
		[CalledBy(Type = typeof(MonoWebRequestHandler), Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage)}, ReturnType = typeof(HttpWebRequest))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HttpHeaders), Member = "GetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
		[Token(Token = "0x600012F")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000042")]
	public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding
	{
		[Address(RVA = "0x16121C0", Offset = "0x16113C0", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
		[Token(Token = "0x6000130")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000043")]
	public Nullable<Boolean> TransferEncodingChunked
	{
		[Address(RVA = "0x1611FF0", Offset = "0x16111F0", Length = "0x1C0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(HttpHeaderValueCollection`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000131")]
		 get { } //Length: 448
	}

	[Address(RVA = "0x1611B40", Offset = "0x1610D40", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpHeaders), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
	[Token(Token = "0x600012B")]
	internal HttpRequestHeaders() { }

	[Address(RVA = "0x1611930", Offset = "0x1610B30", Length = "0x204")]
	[CalledBy(Type = typeof(HttpClient), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage), typeof(HttpCompletionOption), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(HttpHeaders), Member = "TryAddWithoutValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000132")]
	internal void AddHeaders(HttpRequestHeaders headers) { }

	[Address(RVA = "0x1611D80", Offset = "0x1610F80", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
	[Token(Token = "0x600012C")]
	public HttpHeaderValueCollection<String> get_Connection() { }

	[Address(RVA = "0x1611B90", Offset = "0x1610D90", Length = "0x1E8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HttpHeaderValueCollection`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600012D")]
	public Nullable<Boolean> get_ConnectionClose() { }

	[Address(RVA = "0x1611DD0", Offset = "0x1610FD0", Length = "0x1C0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HttpHeaderValueCollection`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600012E")]
	public Nullable<Boolean> get_ExpectContinue() { }

	[Address(RVA = "0x1611FA0", Offset = "0x16111A0", Length = "0x4C")]
	[CalledBy(Type = typeof(MonoWebRequestHandler), Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage)}, ReturnType = typeof(HttpWebRequest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpHeaders), Member = "GetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Token(Token = "0x600012F")]
	public string get_Host() { }

	[Address(RVA = "0x16121C0", Offset = "0x16113C0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
	[Token(Token = "0x6000130")]
	public HttpHeaderValueCollection<TransferCodingHeaderValue> get_TransferEncoding() { }

	[Address(RVA = "0x1611FF0", Offset = "0x16111F0", Length = "0x1C0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HttpHeaderValueCollection`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000131")]
	public Nullable<Boolean> get_TransferEncodingChunked() { }

}

