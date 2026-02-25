namespace System.Net;

[Token(Token = "0x200029C")]
internal class ServicePointScheduler
{
	[CompilerGenerated]
	[Token(Token = "0x20002A0")]
	private struct <RunScheduler>d__32 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B32")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B33")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B34")]
		public ServicePointScheduler <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B35")]
		private ValueTuple<ConnectionGroup, WebOperation>[] <operationArray>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B36")]
		private ValueTuple<ConnectionGroup, WebConnection, Task>[] <idleArray>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000B37")]
		private List<Task> <taskList>5__4; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B38")]
		private Task<Boolean> <schedulerTask>5__5; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000B39")]
		private bool <finalCleanup>5__6; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000B3A")]
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x50

		[Address(RVA = "0x170A4C0", Offset = "0x17096C0", Length = "0x1056")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+<WaitAsync>d__46"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitAsync>d__46&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "WhenAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
		[Calls(Type = typeof(ServicePoint), Member = "FreeServicePoint", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup", typeof(WebOperation)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ServicePointScheduler), Member = "RunSchedulerIteration", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.ValueTuple`3<System.Object, System.Object, System.Object>>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<System.Object, System.Object, System.Object>)}, ReturnType = typeof(bool))]
		[Calls(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "RemoveConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.ValueTuple`3<System.Object, System.Object, System.Object>>), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTuple`3<Object, Object, Object>[]), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(TimeSpan), Member = "FromDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
		[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(KeyCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[Calls(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "IsEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LinkedList`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001106")]
		private override void MoveNext() { }

		[Address(RVA = "0x170B520", Offset = "0x170A720", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6001107")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002A1")]
	private struct <WaitAsync>d__46 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B3B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B3C")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B3D")]
		public int millisecondTimeout; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B3E")]
		public Task workerTask; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B3F")]
		private CancellationTokenSource <cts>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000B40")]
		private Task <timeoutTask>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B41")]
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x170C970", Offset = "0x170BB70", Length = "0x528")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "WhenAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1816FCC80")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Object>), typeof(<WaitAsync>d__46)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Object>&), typeof(<WaitAsync>d__46&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001108")]
		private override void MoveNext() { }

		[Address(RVA = "0x170CEA0", Offset = "0x170C0A0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6001109")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x200029E")]
	private class AsyncManualResetEvent
	{
		[CompilerGenerated]
		[Token(Token = "0x200029F")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B30")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000B31")]
			public static Func<Object, Boolean> <>9__4_0; //Field offset: 0x8

			[Address(RVA = "0x170C900", Offset = "0x170BB00", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001103")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001104")]
			public <>c() { }

			[Address(RVA = "0x170C6C0", Offset = "0x170B8C0", Length = "0x85")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(TaskCompletionSource`1), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Token(Token = "0x6001105")]
			internal bool <Set>b__4_0(object s) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B2F")]
		private TaskCompletionSource<Boolean> m_tcs; //Field offset: 0x10

		[Address(RVA = "0x16FD250", Offset = "0x16FC450", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TaskCompletionSource`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AsyncManualResetEvent), Member = "Set", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001102")]
		public AsyncManualResetEvent(bool state) { }

		[Address(RVA = "0x16FCDD0", Offset = "0x16FBFD0", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TaskCompletionSource`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001101")]
		public void Reset() { }

		[Address(RVA = "0x16FCE90", Offset = "0x16FC090", Length = "0x255")]
		[CalledBy(Type = typeof(AsyncManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "Run", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Object, TResult>", typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[Calls(Type = typeof(Task), Member = "Wait", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001100")]
		public void Set() { }

		[Address(RVA = "0x16FD0F0", Offset = "0x16FC2F0", Length = "0x153")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+<WaitAsync>d__46"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitAsync>d__46&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60010FF")]
		public Task<Boolean> WaitAsync(int millisecondTimeout) { }

	}

	[Token(Token = "0x200029D")]
	private class ConnectionGroup
	{
		[Token(Token = "0x4000B2B")]
		private static int nextId; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B29")]
		private readonly ServicePointScheduler <Scheduler>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B2A")]
		private readonly string <Name>k__BackingField; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B2C")]
		public readonly int ID; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B2D")]
		private LinkedList<WebConnection> connections; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B2E")]
		private LinkedList<WebOperation> queue; //Field offset: 0x30

		[Token(Token = "0x17000392")]
		public ServicePointScheduler Scheduler
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60010F5")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x16FDE80", Offset = "0x16FD080", Length = "0x110")]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServicePoint), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "GetConnectionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ConnectionGroup))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60010F6")]
		public ConnectionGroup(ServicePointScheduler scheduler, string name) { }

		[Address(RVA = "0x16FD2F0", Offset = "0x16FC4F0", Length = "0xED")]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConnectionGroup), typeof(WebOperation)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConnectionGroup)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LinkedListNode`1), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[Calls(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010F9")]
		public void Cleanup() { }

		[Address(RVA = "0x16FD3E0", Offset = "0x16FC5E0", Length = "0x34B")]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "CloseConnectionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WebOperation), Member = "SetCanceled", ReturnType = typeof(void))]
		[Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(LinkedList`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(ServicePointScheduler), Member = "RemoveOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebOperation), Member = "Close", ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionDispatchInfo&)}, ReturnType = typeof(System.ValueTuple`2<System.Runtime.ExceptionServices.ExceptionDispatchInfo, System.Boolean>))]
		[Calls(Type = typeof(System.Collections.Generic.LinkedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.LinkedList`1+Enumerator<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x60010FA")]
		public void Close() { }

		[Address(RVA = "0x16FD730", Offset = "0x16FC930", Length = "0x1CB")]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConnectionGroup), typeof(WebOperation)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConnectionGroup)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ConnectionGroup), Member = "FindIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(WebConnection))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(WebConnection), Member = "StartOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
		[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60010FE")]
		public ValueTuple<WebConnection, Boolean> CreateOrReuseConnection(WebOperation operation, bool force) { }

		[Address(RVA = "0x16FD900", Offset = "0x16FCB00", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010FB")]
		public void EnqueueOperation(WebOperation operation) { }

		[Address(RVA = "0x16FD960", Offset = "0x16FCB60", Length = "0x2ED")]
		[CalledBy(Type = typeof(ConnectionGroup), Member = "CreateOrReuseConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<System.Net.WebConnection, System.Boolean>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.LinkedList`1+Enumerator<System.Object>))]
		[Calls(Type = typeof(System.Collections.Generic.LinkedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(WebConnection), Member = "CanReuseConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(WebConnection), Member = "StartOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 5)]
		[Token(Token = "0x60010FD")]
		public WebConnection FindIdleConnection(WebOperation operation) { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60010F5")]
		public ServicePointScheduler get_Scheduler() { }

		[Address(RVA = "0x16FDC50", Offset = "0x16FCE50", Length = "0x11A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LinkedListNode`1), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ServicePointScheduler), Member = "RemoveOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010FC")]
		public WebOperation GetNextOperation() { }

		[Address(RVA = "0x16FDD70", Offset = "0x16FCF70", Length = "0x63")]
		[CalledBy(Type = "System.Net.ServicePointScheduler+<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "Cleanup", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010F7")]
		public bool IsEmpty() { }

		[Address(RVA = "0x16FDDE0", Offset = "0x16FCFE0", Length = "0x9F")]
		[CalledBy(Type = "System.Net.ServicePointScheduler+<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConnectionGroup), typeof(WebOperation)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "CloseIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConnectionGroup), typeof(WebConnection)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(WebConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010F8")]
		public void RemoveConnection(WebConnection connection) { }

	}

	[Token(Token = "0x4000B27")]
	private static int nextId; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B1C")]
	private ServicePoint <ServicePoint>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B1D")]
	private int running; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000B1E")]
	private int maxIdleTime; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B1F")]
	private AsyncManualResetEvent schedulerEvent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B20")]
	private ConnectionGroup defaultGroup; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B21")]
	private Dictionary<String, ConnectionGroup> groups; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B22")]
	private LinkedList<ValueTuple`2<ConnectionGroup, WebOperation>> operations; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B23")]
	private LinkedList<ValueTuple`3<ConnectionGroup, WebConnection, Task>> idleConnections; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B24")]
	private int currentConnections; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000B25")]
	private int connectionLimit; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B26")]
	private DateTime idleSince; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B28")]
	public readonly int ID; //Field offset: 0x58

	[Token(Token = "0x17000391")]
	public int MaxIdleTime
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010E2")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000390")]
	private ServicePoint ServicePoint
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60010E0")]
		private get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60010E1")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x17035E0", Offset = "0x17027E0", Length = "0x224")]
	[CalledBy(Type = typeof(ServicePoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SPKey), typeof(Uri), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TaskCompletionSource`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ConnectionGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServicePointScheduler), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60010E3")]
	public ServicePointScheduler(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }

	[Address(RVA = "0x1703000", Offset = "0x1702200", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RunScheduler>d__32)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RunScheduler>d__32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60010F4")]
	private Task <Run>b__31_0() { }

	[Address(RVA = "0x17022C0", Offset = "0x17014C0", Length = "0x1CF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(KeyCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ConnectionGroup), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010E6")]
	private void Cleanup() { }

	[Address(RVA = "0x1702490", Offset = "0x1701690", Length = "0x112")]
	[CalledBy(Type = typeof(ServicePoint), Member = "CloseConnectionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ConnectionGroup), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(ServicePointScheduler), Member = "Run", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010EF")]
	public bool CloseConnectionGroup(string groupName) { }

	[Address(RVA = "0x17025B0", Offset = "0x17017B0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConnectionGroup), Member = "RemoveConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010E9")]
	private void CloseIdleConnection(ConnectionGroup group, WebConnection connection) { }

	[Address(RVA = "0x1702600", Offset = "0x1701800", Length = "0x132")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ServicePoint), Member = "FreeServicePoint", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010ED")]
	private void FinalCleanup() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010E2")]
	public int get_MaxIdleTime() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60010E0")]
	private ServicePoint get_ServicePoint() { }

	[Address(RVA = "0x1702740", Offset = "0x1701940", Length = "0x1F7")]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "SendRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConnectionGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServicePointScheduler), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60010F0")]
	private ConnectionGroup GetConnectionGroup(string name) { }

	[Address(RVA = "0x1702940", Offset = "0x1701B40", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Token(Token = "0x60010F2")]
	private void OnConnectionClosed(WebConnection connection) { }

	[Address(RVA = "0x1702970", Offset = "0x1701B70", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Token(Token = "0x60010F1")]
	private void OnConnectionCreated(WebConnection connection) { }

	[Address(RVA = "0x1702980", Offset = "0x1701B80", Length = "0x287")]
	[CalledBy(Type = typeof(<RunScheduler>d__32), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(WebConnection), Member = "Continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.ValueTuple`3<System.Object, System.Object, System.Object>>), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<System.Object, System.Object, System.Object>)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.ValueTuple`3<System.Object, System.Object, System.Object>>))]
	[Calls(Type = typeof(ConnectionGroup), Member = "RemoveConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(ConnectionGroup), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ConnectionGroup), Member = "CreateOrReuseConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<System.Net.WebConnection, System.Boolean>))]
	[Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60010E8")]
	private bool OperationCompleted(ConnectionGroup group, WebOperation operation) { }

	[Address(RVA = "0x1702C10", Offset = "0x1701E10", Length = "0xC2")]
	[CalledBy(Type = typeof(ConnectionGroup), Member = "RemoveConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConnectionGroup), Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConnectionGroup), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<RunScheduler>d__32), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConnectionGroup), typeof(WebOperation)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "CloseIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConnectionGroup), typeof(WebConnection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConnectionGroup)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "OnConnectionClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LinkedListNode`1), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010EC")]
	private void RemoveIdleConnection(WebConnection connection) { }

	[Address(RVA = "0x1702CE0", Offset = "0x1701EE0", Length = "0xC2")]
	[CalledBy(Type = typeof(ConnectionGroup), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConnectionGroup), Member = "GetNextOperation", ReturnType = typeof(WebOperation))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConnectionGroup)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LinkedListNode`1), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010EB")]
	private void RemoveOperation(WebOperation operation) { }

	[Address(RVA = "0x17030E0", Offset = "0x17022E0", Length = "0xC3")]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "SendRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "CloseConnectionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncManualResetEvent), Member = "Set", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010E4")]
	public void Run() { }

	[Address(RVA = "0x1703000", Offset = "0x1702200", Length = "0xE0")]
	[AsyncStateMachine(typeof(<RunScheduler>d__32))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RunScheduler>d__32)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RunScheduler>d__32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010E5")]
	private Task RunScheduler() { }

	[Address(RVA = "0x1702DB0", Offset = "0x1701FB0", Length = "0x243")]
	[CalledBy(Type = typeof(<RunScheduler>d__32), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(TaskCompletionSource`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConnectionGroup)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010E7")]
	private void RunSchedulerIteration() { }

	[Address(RVA = "0x17031B0", Offset = "0x17023B0", Length = "0x202")]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "RunSchedulerIteration", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ConnectionGroup), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedListNode`1), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ServicePointScheduler), Member = "RemoveOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConnectionGroup), Member = "CreateOrReuseConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<System.Net.WebConnection, System.Boolean>))]
	[Calls(Type = typeof(LinkedList`1), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010EA")]
	private bool SchedulerIteration(ConnectionGroup group) { }

	[Address(RVA = "0x17033C0", Offset = "0x17025C0", Length = "0xFA")]
	[CalledBy(Type = typeof(ServicePoint), Member = "SendRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ServicePointScheduler), Member = "GetConnectionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ConnectionGroup))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(ServicePointScheduler), Member = "Run", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60010EE")]
	public void SendRequest(WebOperation operation, string groupName) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60010E1")]
	private void set_ServicePoint(ServicePoint value) { }

	[Address(RVA = "0x17034C0", Offset = "0x17026C0", Length = "0x11C")]
	[AsyncStateMachine(typeof(<WaitAsync>d__46))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<RunWithTimeoutWorker>d__241`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitAsync>d__46)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitAsync>d__46&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010F3")]
	public static Task<Boolean> WaitAsync(Task workerTask, int millisecondTimeout) { }

}

