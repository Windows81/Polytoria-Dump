namespace System.Threading.Tasks;

[Token(Token = "0x2000271")]
internal sealed class ContinuationTaskFromTask : Task
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B29")]
	private Task m_antecedent; //Field offset: 0x50

	[Address(RVA = "0x15247E0", Offset = "0x15239E0", Length = "0x127")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001436")]
	public ContinuationTaskFromTask(Task antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	[Address(RVA = "0x15246D0", Offset = "0x15238D0", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletion", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001437")]
	internal virtual void InnerInvoke() { }

}

