namespace System.Threading.Tasks;

[Token(Token = "0x2000267")]
internal sealed class CompletionActionInvoker : IThreadPoolWorkItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B02")]
	private readonly ITaskCompletionAction m_action; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B03")]
	private readonly Task m_completingTask; //Field offset: 0x18

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001423")]
	internal CompletionActionInvoker(ITaskCompletionAction action, Task completingTask) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001425")]
	public override void MarkAborted(ThreadAbortException e) { }

	[Address(RVA = "0x1524570", Offset = "0x1523770", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001424")]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

}

