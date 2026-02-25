namespace System.Threading;

[Token(Token = "0x2000224")]
public class SynchronizationContext
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A1D")]
	private SynchronizationContextProperties _props; //Field offset: 0x10

	[Token(Token = "0x170001B4")]
	public static SynchronizationContext Current
	{
		[Address(RVA = "0x1519830", Offset = "0x1518A30", Length = "0x89")]
		[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Object>", typeof(object), typeof(short), typeof(ValueTaskSourceOnCompletedFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
		[CalledBy(Type = typeof(SynchronizationContext), Member = "get_CurrentExplicit", ReturnType = typeof(SynchronizationContext))]
		[CalledBy(Type = typeof(WaitHandle), Member = "WaitOneNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(WaitHandle), Member = "WaitMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SynchronizationContextAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecuteTasks", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecutePendingTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Android.AndroidApplication", Member = "AcquireMainThreadSynchronizationContext", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SynchronizationContext), Member = "GetThreadLocalContext", ReturnType = typeof(SynchronizationContext))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Token(Token = "0x600121A")]
		 get { } //Length: 137
	}

	[Token(Token = "0x170001B6")]
	internal static SynchronizationContext CurrentExplicit
	{
		[Address(RVA = "0x1519790", Offset = "0x1518990", Length = "0x7")]
		[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextCallback), typeof(object), typeof(Task&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
		[Token(Token = "0x600121E")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x170001B5")]
	internal static SynchronizationContext CurrentNoFlow
	{
		[Address(RVA = "0x15197A0", Offset = "0x15189A0", Length = "0x89")]
		[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[CalledBy(Type = typeof(YieldAwaiter), Member = "QueueContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(SynchronizationContext), Member = "GetThreadLocalContext", ReturnType = typeof(SynchronizationContext))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[FriendAccessAllowed]
		[Token(Token = "0x600121B")]
		internal get { } //Length: 137
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001211")]
	public SynchronizationContext() { }

	[Address(RVA = "0x1519110", Offset = "0x1518310", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600121D")]
	public override SynchronizationContext CreateCopy() { }

	[Address(RVA = "0x1519830", Offset = "0x1518A30", Length = "0x89")]
	[CalledBy(Type = "UnityEngine.Android.AndroidApplication", Member = "AcquireMainThreadSynchronizationContext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecutePendingTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SynchronizationContextAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecuteTasks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitOneNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SynchronizationContext), Member = "get_CurrentExplicit", ReturnType = typeof(SynchronizationContext))]
	[CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Object>", typeof(object), typeof(short), typeof(ValueTaskSourceOnCompletedFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SynchronizationContext), Member = "GetThreadLocalContext", ReturnType = typeof(SynchronizationContext))]
	[Token(Token = "0x600121A")]
	public static SynchronizationContext get_Current() { }

	[Address(RVA = "0x1519790", Offset = "0x1518990", Length = "0x7")]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextCallback), typeof(object), typeof(Task&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[Token(Token = "0x600121E")]
	internal static SynchronizationContext get_CurrentExplicit() { }

	[Address(RVA = "0x15197A0", Offset = "0x15189A0", Length = "0x89")]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[CalledBy(Type = typeof(YieldAwaiter), Member = "QueueContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SynchronizationContext), Member = "GetThreadLocalContext", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[FriendAccessAllowed]
	[Token(Token = "0x600121B")]
	internal static SynchronizationContext get_CurrentNoFlow() { }

	[Address(RVA = "0x1519160", Offset = "0x1518360", Length = "0x1BF")]
	[CalledBy(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[CalledBy(Type = typeof(SynchronizationContext), Member = "get_CurrentNoFlow", ReturnType = typeof(SynchronizationContext))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "System.Runtime.CompilerServices.ConditionalWeakTable`2<TKey, TValue>+CreateValueCallback<TKey, TValue>"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600121C")]
	private static SynchronizationContext GetThreadLocalContext() { }

	[Address(RVA = "0x1519320", Offset = "0x1518520", Length = "0x7")]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitOneNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6001212")]
	public bool IsWaitNotificationRequired() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001216")]
	public override void OperationCompleted() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001215")]
	public override void OperationStarted() { }

	[Address(RVA = "0x1519330", Offset = "0x1518530", Length = "0x17B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001214")]
	public override void Post(SendOrPostCallback d, object state) { }

	[Address(RVA = "0x15194B0", Offset = "0x15186B0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001213")]
	public override void Send(SendOrPostCallback d, object state) { }

	[Address(RVA = "0x15194E0", Offset = "0x15186E0", Length = "0x107")]
	[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextCallback), typeof(object), typeof(Task&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "InitializeSynchronizationContext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[Calls(Type = typeof(ExecutionContext), Member = "CreateMutableCopy", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001219")]
	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	[Address(RVA = "0x15196A0", Offset = "0x15188A0", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WaitHandle), Member = "Wait_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr*), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CLSCompliant(False)]
	[PrePrepareMethod]
	[Token(Token = "0x6001217")]
	public override int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

	[Address(RVA = "0x15195F0", Offset = "0x15187F0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WaitHandle), Member = "Wait_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr*), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CLSCompliant(False)]
	[PrePrepareMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6001218")]
	protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

}

