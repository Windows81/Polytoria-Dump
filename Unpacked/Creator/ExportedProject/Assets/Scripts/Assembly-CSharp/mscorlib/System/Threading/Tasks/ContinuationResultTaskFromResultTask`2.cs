namespace System.Threading.Tasks;

[Token(Token = "0x2000273")]
internal sealed class ContinuationResultTaskFromResultTask : Task<TResult>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B2B")]
	private Task<TAntecedentResult> m_antecedent; //Field offset: 0x0

	[Address(RVA = "0x9DFC20", Offset = "0x9DEE20", Length = "0xD8")]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNewResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Task`1<TResult>, TNewResult>", typeof(TaskContinuationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNewResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Task`1<TResult>, TNewResult>", typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(Task), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600143A")]
	public ContinuationResultTaskFromResultTask`2(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	[Address(RVA = "0x9DF740", Offset = "0x9DE940", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600143B")]
	internal virtual void InnerInvoke() { }

}

