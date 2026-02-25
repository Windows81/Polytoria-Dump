namespace System.Net.Http;

[Token(Token = "0x200000E")]
public abstract class HttpContent : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000010")]
	private struct <LoadIntoBufferAsync>d__17 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400004D")]
		public HttpContent <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400004E")]
		public long maxBufferSize; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400004F")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x161D510", Offset = "0x161C710", Length = "0x2A9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600004F")]
		private override void MoveNext() { }

		[Address(RVA = "0x161D7C0", Offset = "0x161C9C0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6000050")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000011")]
	private struct <ReadAsStringAsync>d__20 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000050")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000052")]
		public HttpContent <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000053")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x28

		[Address(RVA = "0x161D820", Offset = "0x161CA20", Length = "0x441")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HttpContent), Member = "GetEncodingFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<ReadAsStringAsync>d__20)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<ReadAsStringAsync>d__20&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(MediaTypeHeaderValue), Member = "get_CharSet", ReturnType = typeof(string))]
		[Calls(Type = typeof(HttpContentHeaders), Member = "get_ContentType", ReturnType = typeof(MediaTypeHeaderValue))]
		[Calls(Type = typeof(HttpHeaders), Member = "GetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(HttpContent), Member = "LoadIntoBufferAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6000051")]
		private override void MoveNext() { }

		[Address(RVA = "0x161DC70", Offset = "0x161CE70", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6000052")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x200000F")]
	private sealed class FixedMemoryStream : MemoryStream
	{
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400004A")]
		private readonly long maxSize; //Field offset: 0x50

		[Address(RVA = "0x160B030", Offset = "0x160A230", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600004B")]
		public FixedMemoryStream(long maxSize) { }

		[Address(RVA = "0x160AEE0", Offset = "0x160A0E0", Length = "0xAD")]
		[CalledBy(Type = typeof(FixedMemoryStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FixedMemoryStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(HttpRequestException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600004C")]
		private void CheckOverflow(int count) { }

		[Address(RVA = "0x160AFD0", Offset = "0x160A1D0", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedMemoryStream), Member = "CheckOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MemoryStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x600004E")]
		public virtual void Write(Byte[] buffer, int offset, int count) { }

		[Address(RVA = "0x160AF90", Offset = "0x160A190", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedMemoryStream), Member = "CheckOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MemoryStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Token(Token = "0x600004D")]
		public virtual void WriteByte(byte value) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000047")]
	private FixedMemoryStream buffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000048")]
	private bool disposed; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000049")]
	private HttpContentHeaders headers; //Field offset: 0x20

	[Token(Token = "0x17000009")]
	public HttpContentHeaders Headers
	{
		[Address(RVA = "0x160D4A0", Offset = "0x160C6A0", Length = "0xB1")]
		[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoWebRequestHandler), Member = "CreateResponseMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse), typeof(HttpRequestMessage), typeof(CancellationToken)}, ReturnType = typeof(HttpResponseMessage))]
		[CalledBy(Type = typeof(HttpRequestMessage), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(HttpResponseMessage), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(HttpHeaders), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600003C")]
		 get { } //Length: 177
	}

	[Token(Token = "0x1700000A")]
	internal Nullable<Int64> LoadedBufferLength
	{
		[Address(RVA = "0x160D560", Offset = "0x160C760", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003D")]
		internal get { } //Length: 154
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004A")]
	protected HttpContent() { }

	[Address(RVA = "0x160CE30", Offset = "0x160C030", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stream), Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003E")]
	public Task CopyToAsync(Stream stream) { }

	[Address(RVA = "0x160CED0", Offset = "0x160C0D0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stream), Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003F")]
	public Task CopyToAsync(Stream stream, TransportContext context) { }

	[Address(RVA = "0x160CF70", Offset = "0x160C170", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000040")]
	private static FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize) { }

	[Address(RVA = "0x146EBB0", Offset = "0x146DDB0", Length = "0x16")]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000041")]
	public override void Dispose() { }

	[Address(RVA = "0x160CFD0", Offset = "0x160C1D0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000042")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x160D4A0", Offset = "0x160C6A0", Length = "0xB1")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoWebRequestHandler), Member = "CreateResponseMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebResponse), typeof(HttpRequestMessage), typeof(CancellationToken)}, ReturnType = typeof(HttpResponseMessage))]
	[CalledBy(Type = typeof(HttpRequestMessage), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(HttpResponseMessage), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpHeaders), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpHeaderKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600003C")]
	public HttpContentHeaders get_Headers() { }

	[Address(RVA = "0x160D560", Offset = "0x160C760", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003D")]
	internal Nullable<Int64> get_LoadedBufferLength() { }

	[Address(RVA = "0x160D000", Offset = "0x160C200", Length = "0x222")]
	[CalledBy(Type = typeof(<ReadAsStringAsync>d__20), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF32", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000046")]
	private static Encoding GetEncodingFromBuffer(Byte[] buffer, int length, ref int preambleLength) { }

	[Address(RVA = "0x160D320", Offset = "0x160C520", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpContent), Member = "LoadIntoBufferAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Task))]
	[Token(Token = "0x6000043")]
	public Task LoadIntoBufferAsync() { }

	[Address(RVA = "0x160D230", Offset = "0x160C430", Length = "0xF0")]
	[AsyncStateMachine(typeof(<LoadIntoBufferAsync>d__17))]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.HttpClient+<SendAsyncWorker>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadAsStringAsync>d__20), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpContent), Member = "LoadIntoBufferAsync", ReturnType = typeof(Task))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadIntoBufferAsync>d__17)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadIntoBufferAsync>d__17&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000044")]
	public Task LoadIntoBufferAsync(long maxBufferSize) { }

	[Address(RVA = "0x160D330", Offset = "0x160C530", Length = "0xF6")]
	[AsyncStateMachine(typeof(<ReadAsStringAsync>d__20))]
	[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController+<GetMeshUrlAsync>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAsStringAsync>d__20)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAsStringAsync>d__20&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000045")]
	public Task<String> ReadAsStringAsync() { }

	[Token(Token = "0x6000048")]
	protected abstract Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	[Address(RVA = "0x160D430", Offset = "0x160C630", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000047")]
	private static int StartsWith(Byte[] array, int length, Byte[] value) { }

	[Token(Token = "0x6000049")]
	protected private abstract bool TryComputeLength(out long length) { }

}

