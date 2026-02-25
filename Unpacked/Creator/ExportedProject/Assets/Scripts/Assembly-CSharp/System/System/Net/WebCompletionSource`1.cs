namespace System.Net;

[Token(Token = "0x20002A2")]
internal class WebCompletionSource
{
	[CompilerGenerated]
	[Token(Token = "0x20002A5")]
	private struct <WaitForCompletion>d__15 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B4C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B4D")]
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B4E")]
		public WebCompletionSource<T> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B4F")]
		private ConfiguredTaskAwaiter<Result<T>> <>u__1; //Field offset: 0x0

		[Address(RVA = "0x81B080", Offset = "0x81A280", Length = "0x3B2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800035F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Object>), "System.Net.WebCompletionSource`1<ValueTuple`2<Boolean, Object>>+<WaitForCompletion>d__15<ValueTuple`2<Boolean, Object>>"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Object>&), typeof(<WaitForCompletion>d__15<ValueTuple`2<Boolean, Object>>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Boolean, System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600111A")]
		private override void MoveNext() { }

		[Address(RVA = "0x81B8B0", Offset = "0x81AAB0", Length = "0x98")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600111B")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x20002A4")]
	public class Result
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B49")]
		private readonly Status<T> <Status>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B4A")]
		private readonly ExceptionDispatchInfo <Error>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B4B")]
		private readonly T <Argument>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000398")]
		public T Argument
		{
			[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001117")]
			 get { } //Length: 11
		}

		[Token(Token = "0x17000397")]
		public ExceptionDispatchInfo Error
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001116")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000395")]
		public Status<T> Status
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001114")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000396")]
		public bool Success
		{
			[Address(RVA = "0x557180", Offset = "0x556380", Length = "0x8")]
			[CallerCount(Count = 13)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6001115")]
			 get { } //Length: 8
		}

		[Address(RVA = "0xF0D060", Offset = "0xF0C260", Length = "0x3A")]
		[CalledBy(Type = typeof(WebCompletionSource`1), Member = "TrySetCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001118")]
		public Result(T argument) { }

		[Address(RVA = "0x2BE0F0", Offset = "0x2BD2F0", Length = "0x40")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001119")]
		public Result(Status<T> state, ExceptionDispatchInfo error) { }

		[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001117")]
		public T get_Argument() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001116")]
		public ExceptionDispatchInfo get_Error() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001114")]
		public Status<T> get_Status() { }

		[Address(RVA = "0x557180", Offset = "0x556380", Length = "0x8")]
		[CallerCount(Count = 13)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001115")]
		public bool get_Success() { }

	}

	[Token(Token = "0x20002A3")]
	public enum Status
	{
		Running = 0,
		Completed = 1,
		Canceled = 2,
		Faulted = 3,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B42")]
	private TaskCompletionSource<Result<T>> completion; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B43")]
	private Result<T> currentResult; //Field offset: 0x0

	[Token(Token = "0x17000393")]
	internal Result<T> CurrentResult
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600110B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000394")]
	internal Task Task
	{
		[Address(RVA = "0x4A2FB0", Offset = "0x4A21B0", Length = "0x1B")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600110C")]
		internal get { } //Length: 27
	}

	[Address(RVA = "0x930C40", Offset = "0x92FE40", Length = "0x98")]
	[CalledBy(Type = typeof(WebCompletionSource), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest), typeof(BufferOffsetSize), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600110A")]
	public WebCompletionSource`1(bool runAsync = true) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600110B")]
	internal Result<T> get_CurrentResult() { }

	[Address(RVA = "0x4A2FB0", Offset = "0x4A21B0", Length = "0x1B")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600110C")]
	internal Task get_Task() { }

	[Address(RVA = "0x92FD40", Offset = "0x92EF40", Length = "0x78")]
	[CalledBy(Type = "System.Net.HttpWebRequest+<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001112")]
	public void ThrowOnError() { }

	[Address(RVA = "0x9301F0", Offset = "0x92F3F0", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OperationCanceledException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600110F")]
	public bool TrySetCanceled() { }

	[Address(RVA = "0x92FF90", Offset = "0x92F190", Length = "0xC6")]
	[CalledBy(Type = typeof(WebOperation), Member = "SetCanceled", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001110")]
	public bool TrySetCanceled(OperationCanceledException error) { }

	[Address(RVA = "0x9306D0", Offset = "0x92F8D0", Length = "0xBF")]
	[CalledBy(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Result), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600110D")]
	public bool TrySetCompleted(T argument) { }

	[Address(RVA = "0x9303C0", Offset = "0x92F5C0", Length = "0xB9")]
	[CalledBy(Type = "System.Net.HttpWebRequest+<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteAsyncInner>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAsync>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600110E")]
	public bool TrySetCompleted() { }

	[Address(RVA = "0x930870", Offset = "0x92FA70", Length = "0xC6")]
	[CalledBy(Type = typeof(WebOperation), Member = "SetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001111")]
	public bool TrySetException(Exception error) { }

	[Address(RVA = "0x930A40", Offset = "0x92FC40", Length = "0xF6")]
	[AsyncStateMachine(typeof(<WaitForCompletion>d__15))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebCompletionSource`1<ValueTuple`2<Boolean, Object>>+<WaitForCompletion>d__15<ValueTuple`2<Boolean, Object>>"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitForCompletion>d__15<ValueTuple`2<Boolean, Object>>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, System.Object>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001113")]
	public Task<T> WaitForCompletion() { }

}

