namespace System.Threading.Tasks;

[Token(Token = "0x200024A")]
public class TaskCompletionSource
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AA4")]
	private readonly Task<TResult> _task; //Field offset: 0x0

	[Token(Token = "0x170001CA")]
	public Task<TResult> Task
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001310")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xF854F0", Offset = "0xF846F0", Length = "0x96")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+AsyncManualResetEvent", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+AsyncManualResetEvent", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePoint", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler", Member = "RunSchedulerIteration", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600130C")]
	public TaskCompletionSource`1() { }

	[Address(RVA = "0xF85330", Offset = "0xF84530", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800FE470")]
	[DeduplicatedMethod]
	[Token(Token = "0x600130D")]
	public TaskCompletionSource`1(TaskCreationOptions creationOptions) { }

	[Address(RVA = "0xF852D0", Offset = "0xF844D0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800FE470")]
	[DeduplicatedMethod]
	[Token(Token = "0x600130E")]
	public TaskCompletionSource`1(object state) { }

	[Address(RVA = "0xF85370", Offset = "0xF84570", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800FE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600130F")]
	public TaskCompletionSource`1(object state, TaskCreationOptions creationOptions) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001310")]
	public Task<TResult> get_Task() { }

	[Address(RVA = "0xF84750", Offset = "0xF83950", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800FE3F0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001316")]
	public void SetCanceled() { }

	[Address(RVA = "0xF84A00", Offset = "0xF83C00", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001311")]
	private void SpinUntilCompleted() { }

	[Address(RVA = "0xF84CD0", Offset = "0xF83ED0", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800FE3F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001314")]
	public bool TrySetCanceled() { }

	[Address(RVA = "0xF84BF0", Offset = "0xF83DF0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800FE3F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001315")]
	public bool TrySetCanceled(CancellationToken cancellationToken) { }

	[Address(RVA = "0xF84EF0", Offset = "0xF840F0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800FE3F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001312")]
	public bool TrySetException(Exception exception) { }

	[Address(RVA = "0xF850A0", Offset = "0xF842A0", Length = "0x5A")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+AsyncManualResetEvent+<>c", Member = "<Set>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180022190")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800FE3F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001313")]
	public bool TrySetResult(TResult result) { }

}

