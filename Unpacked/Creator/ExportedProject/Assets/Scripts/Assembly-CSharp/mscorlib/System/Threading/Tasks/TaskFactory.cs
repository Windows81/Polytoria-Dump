namespace System.Threading.Tasks;

[Token(Token = "0x200027C")]
public class TaskFactory
{
	[Token(Token = "0x200027D")]
	public sealed class CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction
	{
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000B42")]
		private IList<Task> _tasks; //Field offset: 0x58

		[Token(Token = "0x170001FC")]
		public override bool InvokeMayRunArbitraryCode
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001477")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x15244C0", Offset = "0x15236C0", Length = "0xA1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F76D0")]
		[Token(Token = "0x6001475")]
		public CompleteOnInvokePromise(IList<Task> tasks) { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001477")]
		public override bool get_InvokeMayRunArbitraryCode() { }

		[Address(RVA = "0x15242F0", Offset = "0x15234F0", Length = "0x1C0")]
		[CalledBy(Type = typeof(TaskFactory), Member = "CommonCWAnyLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F7760")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "RemoveContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001476")]
		public override void Invoke(Task completingTask) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B3E")]
	private readonly CancellationToken m_defaultCancellationToken; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B3F")]
	private readonly TaskScheduler m_defaultScheduler; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B40")]
	private readonly TaskCreationOptions m_defaultCreationOptions; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000B41")]
	private readonly TaskContinuationOptions m_defaultContinuationOptions; //Field offset: 0x24

	[Address(RVA = "0x152EE70", Offset = "0x152E070", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001467")]
	public TaskFactory() { }

	[Address(RVA = "0x152EEC0", Offset = "0x152E0C0", Length = "0x1DC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001468")]
	public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0x152E5B0", Offset = "0x152D7B0", Length = "0x63")]
	[CalledBy(Type = typeof(Task`1), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
	[CalledBy(Type = typeof(TaskFactory`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskFactory`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskContinuationOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001469")]
	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	[Address(RVA = "0x152E620", Offset = "0x152D820", Length = "0x12D")]
	[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<System.AsyncCallback, System.Object, System.IAsyncResult>), "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1", "TArg2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", "TArg2", typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1", "TArg2", "TArg3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`6<TArg1, TArg2, TArg3, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", "TArg2", "TArg3", typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001472")]
	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod) { }

	[Address(RVA = "0x152E750", Offset = "0x152D950", Length = "0x135")]
	[CalledBy(Type = typeof(Task`1), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
	[CalledBy(Type = typeof(TaskFactory`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskFactory`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskContinuationOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001474")]
	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }

	[Address(RVA = "0x152E890", Offset = "0x152DA90", Length = "0x24E")]
	[CalledBy(Type = typeof(Task), Member = "WhenAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
	[CalledBy(Type = typeof(Task), Member = "WhenAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F76D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CompleteOnInvokePromise), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "RemoveContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(Task), Member = "AddTaskContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Token(Token = "0x6001473")]
	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	[Address(RVA = "0x76A7F0", Offset = "0x7699F0", Length = "0x9A")]
	[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Threading.Tasks.VoidTaskResult>), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`4<System.Object, System.AsyncCallback, System.Object, System.IAsyncResult>), typeof(System.Func`2<System.IAsyncResult, System.Threading.Tasks.VoidTaskResult>), typeof(System.Action`1<System.IAsyncResult>), typeof(object), typeof(object), typeof(TaskCreationOptions)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>))]
	[DeduplicatedMethod]
	[Token(Token = "0x600146E")]
	public Task FromAsync(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state) { }

	[Address(RVA = "0x76A780", Offset = "0x769980", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Threading.Tasks.VoidTaskResult>), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`4<System.Object, System.AsyncCallback, System.Object, System.IAsyncResult>), typeof(System.Func`2<System.IAsyncResult, System.Threading.Tasks.VoidTaskResult>), typeof(System.Action`1<System.IAsyncResult>), typeof(object), typeof(object), typeof(TaskCreationOptions)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>))]
	[DeduplicatedMethod]
	[Token(Token = "0x600146F")]
	public Task FromAsync(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }

	[Address(RVA = "0x76A6D0", Offset = "0x7698D0", Length = "0xA5")]
	[CalledBy(Type = "System.Net.Sockets.TcpClient", Member = "ConnectAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1", "TArg2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", "TArg2", typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001470")]
	public Task FromAsync(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }

	[Address(RVA = "0x76A660", Offset = "0x769860", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1", "TArg2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", "TArg2", typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001471")]
	public Task FromAsync(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }

	[Address(RVA = "0x152ECB0", Offset = "0x152DEB0", Length = "0x1B3")]
	[CalledBy(Type = typeof(YieldAwaiter), Member = "QueueContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600146A")]
	public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0x152EAE0", Offset = "0x152DCE0", Length = "0x1C6")]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "InvokeContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Object>", typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600146B")]
	public Task StartNew(Action<Object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0x76AAC0", Offset = "0x769CC0", Length = "0xA7")]
	[CalledBy(Type = typeof(Task), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Threading.Tasks.Task>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(System.Func`1<System.Object>), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[DeduplicatedMethod]
	[Token(Token = "0x600146C")]
	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0x76A890", Offset = "0x769A90", Length = "0xBE")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+AsyncManualResetEvent", Member = "Set", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Boolean>), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(System.Func`2<System.Object, System.Boolean>), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[DeduplicatedMethod]
	[Token(Token = "0x600146D")]
	public Task<TResult> StartNew(Func<Object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

}

