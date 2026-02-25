namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000487")]
public struct ConfiguredTaskAwaitable
{
	[IsReadOnly]
	[Token(Token = "0x2000488")]
	internal struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001262")]
		internal readonly Task m_task; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001263")]
		internal readonly bool m_continueOnCapturedContext; //Field offset: 0x8

		[Token(Token = "0x17000406")]
		public bool IsCompleted
		{
			[Address(RVA = "0x9DE820", Offset = "0x9DDA20", Length = "0x1C")]
			[CallerCount(Count = 143)]
			[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002060")]
			 get { } //Length: 28
		}

		[Address(RVA = "0x88C2E0", Offset = "0x88B4E0", Length = "0x28")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600205F")]
		internal ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext) { }

		[Address(RVA = "0x9DE820", Offset = "0x9DDA20", Length = "0x1C")]
		[CallerCount(Count = 143)]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002060")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x13B6710", Offset = "0x13B5910", Length = "0x48")]
		[CallerCount(Count = 64)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[StackTraceHidden]
		[Token(Token = "0x6002063")]
		public void GetResult() { }

		[Address(RVA = "0x13B6760", Offset = "0x13B5960", Length = "0xB8")]
		[CalledBy(Type = typeof(TaskToApm), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(TaskToApm), Member = "InvokeCallbackWhenTaskCompletes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
		[Calls(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002061")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x13B6820", Offset = "0x13B5A20", Length = "0xB8")]
		[CalledBy(Type = typeof(ForceAsyncAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConfiguredValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
		[Calls(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002062")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001261")]
	private readonly ConfiguredTaskAwaiter m_configuredTaskAwaiter; //Field offset: 0x0

	[Address(RVA = "0x13B66C0", Offset = "0x13B58C0", Length = "0x4A")]
	[CalledBy(Type = typeof(TaskToApm), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(TaskToApm), Member = "InvokeCallbackWhenTaskCompletes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForceAsyncAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600205D")]
	internal ConfiguredTaskAwaitable(Task task, bool continueOnCapturedContext) { }

	[Address(RVA = "0x702130", Offset = "0x701330", Length = "0xA")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600205E")]
	public ConfiguredTaskAwaiter GetAwaiter() { }

}

