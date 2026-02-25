namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000483")]
public struct ValueTaskAwaiter : ICriticalNotifyCompletion
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400125C")]
	private readonly ValueTask<TResult> _value; //Field offset: 0x0

	[Token(Token = "0x17000403")]
	public bool IsCompleted
	{
		[Address(RVA = "0x86FC90", Offset = "0x86EE90", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036E40")]
		[DeduplicatedMethod]
		[Token(Token = "0x600204B")]
		 get { } //Length: 54
	}

	[Address(RVA = "0x86FBD0", Offset = "0x86EDD0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600204A")]
	internal ValueTaskAwaiter`1(ValueTask<TResult> value) { }

	[Address(RVA = "0x86FC90", Offset = "0x86EE90", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036E40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600204B")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x865B70", Offset = "0x864D70", Length = "0x36")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036F40")]
	[DeduplicatedMethod]
	[StackTraceHidden]
	[Token(Token = "0x600204C")]
	public TResult GetResult() { }

	[Address(RVA = "0x86F600", Offset = "0x86E800", Length = "0x1ED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(TaskAwaiter`1), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180036B60")]
	[Calls(Type = typeof(ValueTask), Member = "get_CompletedTask", ReturnType = typeof(Task))]
	[Calls(Type = typeof(TaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600204D")]
	public override void UnsafeOnCompleted(Action continuation) { }

}

