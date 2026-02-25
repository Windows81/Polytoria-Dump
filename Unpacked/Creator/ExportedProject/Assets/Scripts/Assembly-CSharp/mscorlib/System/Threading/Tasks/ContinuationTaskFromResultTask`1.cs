namespace System.Threading.Tasks;

[Token(Token = "0x2000272")]
internal sealed class ContinuationTaskFromResultTask : Task
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B2A")]
	private Task<TAntecedentResult> m_antecedent; //Field offset: 0x0

	[Address(RVA = "0x9E0710", Offset = "0x9DF910", Length = "0xC2")]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Task`1<TResult>>", typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Task`1<TResult>>", typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(Task), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001438")]
	public ContinuationTaskFromResultTask`1(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	[Address(RVA = "0x9DFE60", Offset = "0x9DF060", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001439")]
	internal virtual void InnerInvoke() { }

}

