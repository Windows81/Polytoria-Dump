namespace System.Runtime.CompilerServices;

[Token(Token = "0x2000490")]
internal struct AsyncMethodBuilderCore
{
	[CompilerGenerated]
	[Token(Token = "0x2000494")]
	private sealed class <>c
	{
		[Token(Token = "0x400127C")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400127D")]
		public static SendOrPostCallback <>9__7_0; //Field offset: 0x8
		[Token(Token = "0x400127E")]
		public static WaitCallback <>9__7_1; //Field offset: 0x10

		[Address(RVA = "0x13CE670", Offset = "0x13CD870", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002096")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002097")]
		public <>c() { }

		[Address(RVA = "0x13CE280", Offset = "0x13CD480", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002190")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Token(Token = "0x6002098")]
		internal void <ThrowAsync>b__7_0(object state) { }

		[Address(RVA = "0x13CE2E0", Offset = "0x13CD4E0", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002190")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Token(Token = "0x6002099")]
		internal void <ThrowAsync>b__7_1(object state) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000493")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400127A")]
		public Task innerTask; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400127B")]
		public Action continuation; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002094")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x13CE530", Offset = "0x13CD730", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002095")]
		internal void <OutputAsyncCausalityEvents>b__0() { }

	}

	[Token(Token = "0x2000492")]
	private class ContinuationWrapper
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001277")]
		internal readonly Action m_continuation; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001278")]
		private readonly Action m_invokeAction; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001279")]
		internal readonly Task m_innerTask; //Field offset: 0x20

		[Address(RVA = "0x13B6E10", Offset = "0x13B6010", Length = "0xCC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002092")]
		internal ContinuationWrapper(Action continuation, Action invokeAction, Task innerTask) { }

		[Address(RVA = "0x13B6DE0", Offset = "0x13B5FE0", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002093")]
		internal void Invoke() { }

	}

	[Token(Token = "0x2000491")]
	public sealed class MoveNextRunner
	{
		[Token(Token = "0x4001276")]
		private static ContextCallback s_invokeMoveNext; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001274")]
		private readonly ExecutionContext m_context; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001275")]
		internal IAsyncStateMachine m_stateMachine; //Field offset: 0x18

		[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
		[CallerCount(Count = 37)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600208F")]
		internal MoveNextRunner(ExecutionContext context, IAsyncStateMachine stateMachine) { }

		[Address(RVA = "0x13BEF90", Offset = "0x13BE190", Length = "0x91")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6002091")]
		private static void InvokeMoveNext(object stateMachine) { }

		[Address(RVA = "0x13BF030", Offset = "0x13BE230", Length = "0x192")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6002090")]
		internal void Run() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001272")]
	internal IAsyncStateMachine m_stateMachine; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001273")]
	internal Action m_defaultContextAction; //Field offset: 0x8

	[Address(RVA = "0x13B5010", Offset = "0x13B4210", Length = "0x137")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600208D")]
	internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask = null) { }

	[Address(RVA = "0x13B5150", Offset = "0x13B4350", Length = "0x219")]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "FastCapture", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(ExecutionContext), Member = "get_IsPreAllocatedDefault", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncMethodBuilderCore), Member = "OutputAsyncCausalityEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6002089")]
	internal Action GetCompletionAction(Task taskForTracing, ref MoveNextRunner runnerToInitialize) { }

	[Address(RVA = "0x13B5370", Offset = "0x13B4570", Length = "0x1DC")]
	[CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "GetCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(MoveNextRunner&)}, ReturnType = typeof(Action))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600208A")]
	private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation) { }

	[Address(RVA = "0x13B5550", Offset = "0x13B4750", Length = "0x1D1")]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "AddToActiveTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600208B")]
	internal void PostBoxInitialization(IAsyncStateMachine stateMachine, MoveNextRunner runner, Task builtTask) { }

	[Address(RVA = "0x13B5730", Offset = "0x13B4930", Length = "0xC6")]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002088")]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[Address(RVA = "0x13B5800", Offset = "0x13B4A00", Length = "0x2E6")]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "NotifySynchronizationContextOfCompletion", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AggregateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600208C")]
	internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext) { }

	[Address(RVA = "0x13B5AF0", Offset = "0x13B4CF0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600208E")]
	internal static Task TryGetContinuationTask(Action action) { }

}

