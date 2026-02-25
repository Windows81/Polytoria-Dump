namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000489")]
public struct ConfiguredTaskAwaitable
{
	[IsReadOnly]
	[Token(Token = "0x200048A")]
	internal struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001265")]
		private readonly Task<TResult> m_task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001266")]
		private readonly bool m_continueOnCapturedContext; //Field offset: 0x0

		[Token(Token = "0x17000407")]
		public bool IsCompleted
		{
			[Address(RVA = "0x9DE820", Offset = "0x9DDA20", Length = "0x1C")]
			[CallerCount(Count = 143)]
			[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002067")]
			 get { } //Length: 28
		}

		[Address(RVA = "0x88C2E0", Offset = "0x88B4E0", Length = "0x28")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002066")]
		internal ConfiguredTaskAwaiter(Task<TResult> task, bool continueOnCapturedContext) { }

		[Address(RVA = "0x9DE820", Offset = "0x9DDA20", Length = "0x1C")]
		[CallerCount(Count = 143)]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002067")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x9DE440", Offset = "0x9DD640", Length = "0x48")]
		[CallerCount(Count = 35)]
		[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[StackTraceHidden]
		[Token(Token = "0x6002069")]
		public TResult GetResult() { }

		[Address(RVA = "0x9DE7F0", Offset = "0x9DD9F0", Length = "0x22")]
		[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002068")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001264")]
	private readonly ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter; //Field offset: 0x0

	[Address(RVA = "0x9DE3D0", Offset = "0x9DD5D0", Length = "0x6D")]
	[CalledBy(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002064")]
	internal ConfiguredTaskAwaitable`1(Task<TResult> task, bool continueOnCapturedContext) { }

	[Address(RVA = "0x702130", Offset = "0x701330", Length = "0xA")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002065")]
	public ConfiguredTaskAwaiter<TResult> GetAwaiter() { }

}

