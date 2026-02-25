namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000495")]
public struct YieldAwaitable
{
	[IsReadOnly]
	[Token(Token = "0x2000496")]
	internal struct YieldAwaiter : ICriticalNotifyCompletion
	{
		[Token(Token = "0x400127F")]
		private static readonly WaitCallback s_waitCallbackRunAction; //Field offset: 0x0
		[Token(Token = "0x4001280")]
		private static readonly SendOrPostCallback s_sendOrPostCallbackRunAction; //Field offset: 0x8

		[Token(Token = "0x1700040B")]
		public bool IsCompleted
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600209B")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x13CF270", Offset = "0x13CE470", Length = "0x13E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60020A0")]
		private static YieldAwaiter() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600209B")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x600209F")]
		public void GetResult() { }

		[Address(RVA = "0x13CEEE0", Offset = "0x13CE0E0", Length = "0x2C4")]
		[CalledBy(Type = typeof(YieldAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TaskScheduler), Member = "get_Current", ReturnType = typeof(TaskScheduler))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(SynchronizationContext), Member = "get_CurrentNoFlow", ReturnType = typeof(SynchronizationContext))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600209D")]
		private static void QueueContinuation(Action continuation, bool flowContext) { }

		[Address(RVA = "0x13CF1B0", Offset = "0x13CE3B0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600209E")]
		private static void RunAction(object state) { }

		[Address(RVA = "0x13CF220", Offset = "0x13CE420", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(YieldAwaiter), Member = "QueueContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x600209C")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}


	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600209A")]
	public YieldAwaiter GetAwaiter() { }

}

