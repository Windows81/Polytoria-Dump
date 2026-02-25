namespace System.Net.Http.Headers;

[Token(Token = "0x2000029")]
public sealed class HttpHeaderValueCollection : ICollection<T>, IEnumerable<T>, IEnumerable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009A")]
	private readonly List<T> list; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009B")]
	private readonly HttpHeaders headers; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009C")]
	private readonly HeaderInfo headerInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009D")]
	private List<String> invalidValues; //Field offset: 0x0

	[Token(Token = "0x17000037")]
	public override int Count
	{
		[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FF")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000038")]
	internal List<String> InvalidValues
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000100")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000039")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000101")]
		 get { } //Length: 3
	}

	[Address(RVA = "0xC86400", Offset = "0xC85600", Length = "0xB8")]
	[CalledBy(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FE")]
	internal HttpHeaderValueCollection`1(HttpHeaders headers, HeaderInfo headerInfo) { }

	[Address(RVA = "0xC860C0", Offset = "0xC852C0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000102")]
	public override void Add(T item) { }

	[Address(RVA = "0xC85F90", Offset = "0xC85190", Length = "0xFC")]
	[CalledBy(Type = typeof(HttpHeaders), Member = "GetValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.Http.Headers.HttpHeaderValueCollection`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000104")]
	internal void AddInvalidValue(string invalidValue) { }

	[Address(RVA = "0xC86090", Offset = "0xC85290", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000103")]
	internal void AddRange(List<T> values) { }

	[Address(RVA = "0xC86140", Offset = "0xC85340", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000105")]
	public override void Clear() { }

	[Address(RVA = "0xC861A0", Offset = "0xC853A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000106")]
	public override bool Contains(T item) { }

	[Address(RVA = "0xC861D0", Offset = "0xC853D0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000107")]
	public override void CopyTo(T[] array, int arrayIndex) { }

	[Address(RVA = "0xC86200", Offset = "0xC85400", Length = "0x2D")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoWebRequestHandler), Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestMessage)}, ReturnType = typeof(HttpWebRequest))]
	[CalledBy(Type = typeof(HttpRequestHeaders), Member = "get_ConnectionClose", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(HttpRequestHeaders), Member = "get_ExpectContinue", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(HttpRequestHeaders), Member = "get_TransferEncodingChunked", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600010C")]
	internal T Find(Predicate<T> predicate) { }

	[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FF")]
	public override int get_Count() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000100")]
	internal List<String> get_InvalidValues() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000101")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0xC86230", Offset = "0xC85430", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600010A")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0xC862A0", Offset = "0xC854A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000108")]
	public override bool Remove(T item) { }

	[Address(RVA = "0xC862D0", Offset = "0xC854D0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600010B")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xC86350", Offset = "0xC85550", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Join", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000109")]
	public virtual string ToString() { }

}

