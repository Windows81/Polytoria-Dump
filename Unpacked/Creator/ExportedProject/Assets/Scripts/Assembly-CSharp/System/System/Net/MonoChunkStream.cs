namespace System.Net;

[Token(Token = "0x2000295")]
internal class MonoChunkStream : WebReadStream
{
	[CompilerGenerated]
	[Token(Token = "0x2000297")]
	private struct <FinishReading>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AED")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AEE")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AEF")]
		public MonoChunkStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000AF0")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AF1")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000AF2")]
		private Byte[] <buffer>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000AF3")]
		private ConfiguredTaskAwaiter<Int32> <>u__2; //Field offset: 0x48

		[Address(RVA = "0x17FD110", Offset = "0x17FC310", Length = "0x451")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MonoChunkParser), Member = "ReadFromChunks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(MonoChunkStream), Member = "ThrowExpectingChunkTrailer", ReturnType = typeof(void))]
		[Calls(Type = typeof(MonoChunkParser), Member = "get_DataAvailable", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(WebReadStream), Member = "FinishReading", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60010B0")]
		private override void MoveNext() { }

		[Address(RVA = "0x17FD570", Offset = "0x17FC770", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60010B1")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000296")]
	private struct <ProcessReadAsync>d__7 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AE4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AE5")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AE6")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000AE7")]
		public MonoChunkStream <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AE8")]
		public Byte[] buffer; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000AE9")]
		public int offset; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000AEA")]
		public int size; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000AEB")]
		private Byte[] <moreBytes>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000AEC")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		[Address(RVA = "0x17FF770", Offset = "0x17FE970", Length = "0x3EB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180181C20")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MonoChunkParser), Member = "ReadFromChunks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MonoChunkParser), Member = "get_DataAvailable", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60010AE")]
		private override void MoveNext() { }

		[Address(RVA = "0x17FFB60", Offset = "0x17FED60", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60010AF")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000AE2")]
	private readonly WebHeaderCollection <Headers>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000AE3")]
	private readonly MonoChunkParser <Decoder>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x1700037C")]
	protected MonoChunkParser Decoder
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60010A8")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x17FB600", Offset = "0x17FA800", Length = "0x132")]
	[CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(WebReadStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010A9")]
	public MonoChunkStream(WebOperation operation, Stream innerStream, WebHeaderCollection headers) { }

	[Address(RVA = "0x17FB5F0", Offset = "0x17FA7F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebReadStream), Member = "FinishReading", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x60010AD")]
	private Task <>n__0(CancellationToken cancellationToken) { }

	[Address(RVA = "0x17FB320", Offset = "0x17FA520", Length = "0x102")]
	[AsyncStateMachine(typeof(<FinishReading>d__8))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FinishReading>d__8)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FinishReading>d__8&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010AB")]
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60010A8")]
	protected MonoChunkParser get_Decoder() { }

	[Address(RVA = "0x17FB430", Offset = "0x17FA630", Length = "0x14E")]
	[AsyncStateMachine(typeof(<ProcessReadAsync>d__7))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessReadAsync>d__7)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessReadAsync>d__7&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010AA")]
	protected virtual Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x17FB580", Offset = "0x17FA780", Length = "0x60")]
	[CalledBy(Type = typeof(<FinishReading>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60010AC")]
	private static void ThrowExpectingChunkTrailer() { }

}

