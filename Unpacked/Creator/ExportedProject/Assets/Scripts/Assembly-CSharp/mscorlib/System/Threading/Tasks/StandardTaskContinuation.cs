namespace System.Threading.Tasks;

[Token(Token = "0x2000275")]
internal class StandardTaskContinuation : TaskContinuation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B2C")]
	internal readonly Task m_task; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B2D")]
	internal readonly TaskContinuationOptions m_options; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B2E")]
	private readonly TaskScheduler m_taskScheduler; //Field offset: 0x20

	[Address(RVA = "0x152D230", Offset = "0x152C430", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F76D0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600143F")]
	internal StandardTaskContinuation(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	[Address(RVA = "0x152D0F0", Offset = "0x152C2F0", Length = "0x13B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Task), Member = "InternalCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001440")]
	internal virtual void Run(Task completedTask, bool bCanInlineContinuationTask) { }

}

