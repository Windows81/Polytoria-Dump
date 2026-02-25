namespace System.Net;

[Token(Token = "0x200027A")]
internal class BufferedReadStream : WebReadStream
{
	[CompilerGenerated]
	[Token(Token = "0x200027B")]
	private struct <ProcessReadAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A32")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A33")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A34")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A35")]
		public BufferedReadStream <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A36")]
		public int size; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000A37")]
		public Byte[] buffer; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A38")]
		public int offset; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000A39")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		[Address(RVA = "0x17FF0F0", Offset = "0x17FE2F0", Length = "0x2D5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180181C20")]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000FD5")]
		private override void MoveNext() { }

		[Address(RVA = "0x17FF3D0", Offset = "0x17FE5D0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6000FD6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A31")]
	private readonly BufferOffsetSize readBuffer; //Field offset: 0x40

	[Address(RVA = "0x17E9B70", Offset = "0x17E8D70", Length = "0x32")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(WebReadStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FD2")]
	public BufferedReadStream(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) { }

	[Address(RVA = "0x17E9980", Offset = "0x17E8B80", Length = "0x14E")]
	[AsyncStateMachine(typeof(<ProcessReadAsync>d__2))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessReadAsync>d__2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessReadAsync>d__2&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000FD3")]
	protected virtual Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x17E9AD0", Offset = "0x17E8CD0", Length = "0x9F")]
	[CalledBy(Type = typeof(WebResponseStream), Member = "TryReadFromBufferedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FD4")]
	internal bool TryReadFromBuffer(Byte[] buffer, int offset, int size, out int result) { }

}

