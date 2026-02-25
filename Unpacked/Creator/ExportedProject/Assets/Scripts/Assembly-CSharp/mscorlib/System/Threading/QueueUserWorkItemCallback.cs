namespace System.Threading;

[Token(Token = "0x2000238")]
internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem
{
	[Token(Token = "0x4000A54")]
	internal static ContextCallback ccb; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A51")]
	private WaitCallback callback; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A52")]
	private ExecutionContext context; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A53")]
	private object state; //Field offset: 0x20

	[Address(RVA = "0x152B7E0", Offset = "0x152A9E0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001298")]
	private static QueueUserWorkItemCallback() { }

	[Address(RVA = "0x152B870", Offset = "0x152AA70", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "IsFlowSuppressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001294")]
	internal QueueUserWorkItemCallback(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x152B670", Offset = "0x152A870", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001295")]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001296")]
	private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	[Address(RVA = "0x152B760", Offset = "0x152A960", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001297")]
	private static void WaitCallback_Context(object state) { }

}

