namespace System.Threading;

[Token(Token = "0x2000209")]
internal class CancellationCallbackInfo
{
	[Token(Token = "0x200020A")]
	public sealed class WithSyncContext : CancellationCallbackInfo
	{
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40009CF")]
		internal readonly SynchronizationContext TargetSyncContext; //Field offset: 0x30

		[Address(RVA = "0x151FEF0", Offset = "0x151F0F0", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001181")]
		internal WithSyncContext(Action<Object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource, SynchronizationContext targetSyncContext) { }

	}

	[Token(Token = "0x40009CE")]
	private static ContextCallback s_executionContextCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009CA")]
	internal readonly Action<Object> Callback; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009CB")]
	internal readonly object StateForCallback; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009CC")]
	internal readonly ExecutionContext TargetExecutionContext; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009CD")]
	internal readonly CancellationTokenSource CancellationTokenSource; //Field offset: 0x28

	[Address(RVA = "0x113F890", Offset = "0x113EA90", Length = "0x7D")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600117E")]
	internal CancellationCallbackInfo(Action<Object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	[Address(RVA = "0x1508D50", Offset = "0x1507F50", Length = "0x16C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600117F")]
	internal void ExecuteCallback() { }

	[Address(RVA = "0x1508EC0", Offset = "0x15080C0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001180")]
	private static void ExecutionContextCallback(object obj) { }

}

