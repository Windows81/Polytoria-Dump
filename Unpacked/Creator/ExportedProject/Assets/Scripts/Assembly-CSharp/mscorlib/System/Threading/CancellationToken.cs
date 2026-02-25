namespace System.Threading;

[DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
[IsReadOnly]
[Token(Token = "0x20001FB")]
public struct CancellationToken
{
	[CompilerGenerated]
	[Token(Token = "0x20001FC")]
	private sealed class <>c
	{
		[Token(Token = "0x40009A7")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x151E380", Offset = "0x151D580", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600112F")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001130")]
		public <>c() { }

		[Address(RVA = "0x151E220", Offset = "0x151D420", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001131")]
		internal void <.cctor>b__26_0(object obj) { }

	}

	[Token(Token = "0x40009A6")]
	private static readonly Action<Object> s_actionToActionObjShunt; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009A5")]
	private readonly CancellationTokenSource _source; //Field offset: 0x0

	[Token(Token = "0x17000190")]
	public bool CanBeCanceled
	{
		[Address(RVA = "0x150B380", Offset = "0x150A580", Length = "0x8")]
		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001120")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700018F")]
	public bool IsCancellationRequested
	{
		[Address(RVA = "0x150B390", Offset = "0x150A590", Length = "0x31")]
		[CallerCount(Count = 36)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600111F")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700018E")]
	public static CancellationToken None
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600111E")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x150B210", Offset = "0x150A410", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600112E")]
	private static CancellationToken() { }

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001121")]
	internal CancellationToken(CancellationTokenSource source) { }

	[Address(RVA = "0x150B2E0", Offset = "0x150A4E0", Length = "0x96")]
	[CalledBy(Type = "System.Threading.Tasks.ValueTask+ValueTaskSourceAsTask+<>c", Member = "<.cctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueTask), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Tasks.ValueTask`1+ValueTaskSourceAsTask+<>c", Member = "<.cctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueTask`1), Member = "GetTaskForValueTaskSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Sources.IValueTaskSource`1<TResult>"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001122")]
	public CancellationToken(bool canceled) { }

	[Address(RVA = "0x150AC40", Offset = "0x1509E40", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001128")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x14A0AF0", Offset = "0x149FCF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001127")]
	public bool Equals(CancellationToken other) { }

	[Address(RVA = "0x150B380", Offset = "0x150A580", Length = "0x8")]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001120")]
	public bool get_CanBeCanceled() { }

	[Address(RVA = "0x150B390", Offset = "0x150A590", Length = "0x31")]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600111F")]
	public bool get_IsCancellationRequested() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600111E")]
	public static CancellationToken get_None() { }

	[Address(RVA = "0x150ACE0", Offset = "0x1509EE0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001129")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x150AD60", Offset = "0x1509F60", Length = "0xA2")]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(Task), typeof(TaskContinuation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[Token(Token = "0x6001125")]
	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<Object> callback, object state) { }

	[Address(RVA = "0x150B3D0", Offset = "0x150A5D0", Length = "0x52")]
	[CalledBy(Type = typeof(Task), Member = "HandleException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600112A")]
	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	[Address(RVA = "0x150B430", Offset = "0x150A630", Length = "0x52")]
	[CalledBy(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "RecordInternalCancellationRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "RecordInternalCancellationRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600112B")]
	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	[Address(RVA = "0x150AF20", Offset = "0x150A120", Length = "0xA2")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[Token(Token = "0x6001124")]
	public CancellationTokenRegistration Register(Action<Object> callback, object state) { }

	[Address(RVA = "0x150AE10", Offset = "0x150A010", Length = "0x10B")]
	[CalledBy(Type = "System.Net.WebOperation", Member = "RegisterRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePoint", "System.Net.WebConnection"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001123")]
	public CancellationTokenRegistration Register(Action callback) { }

	[Address(RVA = "0x150AFD0", Offset = "0x150A1D0", Length = "0x153")]
	[CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CalledBy(Type = typeof(CancellationToken), Member = "InternalRegisterWithoutEC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CalledBy(Type = "System.Threading.CancellationTokenSource+Linked1CancellationTokenSource", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.CancellationTokenSource+Linked2CancellationTokenSource", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(CancellationToken)}, ReturnType = typeof(CancellationTokenSource))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "InternalRegister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(SynchronizationContext), typeof(ExecutionContext)}, ReturnType = typeof(CancellationTokenRegistration))]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001126")]
	public CancellationTokenRegistration Register(Action<Object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	[Address(RVA = "0x150B130", Offset = "0x150A330", Length = "0x76")]
	[CalledBy(Type = "System.Net.MonoChunkStream+<ProcessReadAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsyncInner>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAsync>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.MonoChunkStream+<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FixedSizeReadStream+<ProcessReadAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream+<InnerWrite>d__67", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream+<InnerRead>d__66", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest+<ProcessOperation>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Threading.SemaphoreSlim+<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.BufferedReadStream+<ProcessReadAsync>d__2", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "ThrowOperationCanceledException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600112C")]
	public void ThrowIfCancellationRequested() { }

	[Address(RVA = "0x150B1B0", Offset = "0x150A3B0", Length = "0x58")]
	[CalledBy(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitUntilCountOrTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OperationCanceledException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600112D")]
	private void ThrowOperationCanceledException() { }

}

