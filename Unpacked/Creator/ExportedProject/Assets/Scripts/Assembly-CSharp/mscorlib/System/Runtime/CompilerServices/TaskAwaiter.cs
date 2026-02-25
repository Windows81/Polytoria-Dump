namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000484")]
public struct TaskAwaiter : ICriticalNotifyCompletion
{
	[CompilerGenerated]
	[Token(Token = "0x2000485")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400125E")]
		public Task task; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400125F")]
		public Action continuation; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002057")]
		public <>c__DisplayClass11_0() { }

		[Address(RVA = "0x13CE3B0", Offset = "0x13CD5B0", Length = "0x17A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(TaskScheduler), Member = "get_Id", ReturnType = typeof(int))]
		[Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
		[Calls(Type = typeof(TaskTrace), Member = "TaskWaitEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002058")]
		internal void <OutputWaitEtwEvents>b__0() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400125D")]
	internal readonly Task m_task; //Field offset: 0x0

	[Token(Token = "0x17000404")]
	public bool IsCompleted
	{
		[Address(RVA = "0x9DE820", Offset = "0x9DDA20", Length = "0x1C")]
		[CallerCount(Count = 143)]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600204F")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600204E")]
	internal TaskAwaiter(Task task) { }

	[Address(RVA = "0x9DE820", Offset = "0x9DDA20", Length = "0x1C")]
	[CallerCount(Count = 143)]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600204F")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x13B6710", Offset = "0x13B5910", Length = "0x48")]
	[CallerCount(Count = 64)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[StackTraceHidden]
	[Token(Token = "0x6002051")]
	public void GetResult() { }

	[Address(RVA = "0x13CD110", Offset = "0x13CC310", Length = "0x186")]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Task), Member = "get_Status", ReturnType = typeof(TaskStatus))]
	[Calls(Type = typeof(Task), Member = "get_Exception", ReturnType = typeof(AggregateException))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(TaskCanceledException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Task), Member = "GetCancellationExceptionDispatchInfo", ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_IsCompletedSuccessfully", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "InternalWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "GetExceptionDispatchInfos", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Runtime.ExceptionServices.ExceptionDispatchInfo>))]
	[StackTraceHidden]
	[Token(Token = "0x6002053")]
	private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

	[Address(RVA = "0x13CD2A0", Offset = "0x13CC4A0", Length = "0xC6")]
	[CalledBy(Type = typeof(ConfiguredValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter`1), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfiguredTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
	[Calls(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002055")]
	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }

	[Address(RVA = "0x13CD370", Offset = "0x13CC570", Length = "0x1E3")]
	[CalledBy(Type = typeof(ConfiguredValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfiguredTaskAwaiter), Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfiguredTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TaskScheduler), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TaskTrace), Member = "TaskWaitBegin_Asynchronous", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002056")]
	private static Action OutputWaitEtwEvents(Task task, Action continuation) { }

	[Address(RVA = "0x13CD560", Offset = "0x13CC760", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Task), Member = "get_Exception", ReturnType = typeof(AggregateException))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(TaskCanceledException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180033950")]
	[Calls(Type = typeof(Task), Member = "GetExceptionDispatchInfos", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Runtime.ExceptionServices.ExceptionDispatchInfo>))]
	[Calls(Type = typeof(Task), Member = "GetCancellationExceptionDispatchInfo", ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(Task), Member = "get_Status", ReturnType = typeof(TaskStatus))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[StackTraceHidden]
	[Token(Token = "0x6002054")]
	private static void ThrowForNonSuccess(Task task) { }

	[Address(RVA = "0x13CD6C0", Offset = "0x13CC8C0", Length = "0xA9")]
	[CalledBy(Type = typeof(ValueTaskAwaiter`1), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
	[Calls(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002050")]
	public override void UnsafeOnCompleted(Action continuation) { }

	[Address(RVA = "0x13CD770", Offset = "0x13CC970", Length = "0x48")]
	[CalledBy(Type = typeof(ValueTask), Member = "ThrowIfCompletedUnsuccessfully", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueTask`1), Member = "get_Result", ReturnType = "TResult")]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "get_Preamble", ReturnType = typeof(System.ReadOnlySpan`1<System.Byte>))]
	[CalledBy(Type = typeof(TaskAwaiter`1), Member = "GetResult", ReturnType = "TResult")]
	[CalledBy(Type = typeof(ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
	[CalledBy(Type = "System.IO.Stream+<CopyToAsyncInternal>d__28", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[StackTraceHidden]
	[Token(Token = "0x6002052")]
	internal static void ValidateEnd(Task task) { }

}

