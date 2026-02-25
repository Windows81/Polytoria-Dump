namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000486")]
public struct TaskAwaiter : ICriticalNotifyCompletion
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001260")]
	private readonly Task<TResult> m_task; //Field offset: 0x0

	[Token(Token = "0x17000405")]
	public bool IsCompleted
	{
		[Address(RVA = "0x9DE820", Offset = "0x9DDA20", Length = "0x1C")]
		[CallerCount(Count = 143)]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600205A")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002059")]
	internal TaskAwaiter`1(Task<TResult> task) { }

	[Address(RVA = "0x9DE820", Offset = "0x9DDA20", Length = "0x1C")]
	[CallerCount(Count = 143)]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600205A")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x9DE440", Offset = "0x9DD640", Length = "0x48")]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[StackTraceHidden]
	[Token(Token = "0x600205C")]
	public TResult GetResult() { }

	[Address(RVA = "0xF846F0", Offset = "0xF838F0", Length = "0x20")]
	[CalledBy(Type = typeof(ValueTaskAwaiter`1), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600205B")]
	public override void UnsafeOnCompleted(Action continuation) { }

}

