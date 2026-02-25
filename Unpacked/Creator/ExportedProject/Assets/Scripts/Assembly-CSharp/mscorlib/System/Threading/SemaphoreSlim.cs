namespace System.Threading;

[ComVisible(False)]
[DebuggerDisplay("Current Count = {m_currentCount}")]
[Token(Token = "0x2000210")]
public class SemaphoreSlim : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000212")]
	private struct <WaitUntilCountOrTimeoutAsync>d__32 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009E6")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40009E7")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40009E8")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40009E9")]
		public TaskNode asyncWaiter; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40009EA")]
		public int millisecondsTimeout; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40009EB")]
		public SemaphoreSlim <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40009EC")]
		private CancellationTokenSource <cts>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40009ED")]
		private object <>7__wrap2; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40009EE")]
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40009EF")]
		private ConfiguredTaskAwaiter<Boolean> <>u__2; //Field offset: 0x60

		[Address(RVA = "0x151E460", Offset = "0x151D660", Length = "0x956")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D670")]
		[Calls(Type = typeof(SemaphoreSlim), Member = "RemoveAsyncWaiter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.SemaphoreSlim+TaskNode"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021E170")]
		[Calls(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(Task), Member = "WhenAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
		[Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(CancellationToken)}, ReturnType = typeof(CancellationTokenSource))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[Token(Token = "0x60011A8")]
		private override void MoveNext() { }

		[Address(RVA = "0x151EDC0", Offset = "0x151DFC0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60011A9")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x2000211")]
	private sealed class TaskNode : Task<Boolean>, IThreadPoolWorkItem
	{
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40009E4")]
		internal TaskNode Prev; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40009E5")]
		internal TaskNode Next; //Field offset: 0x60

		[Address(RVA = "0x1519970", Offset = "0x1518B70", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Boolean>), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60011A5")]
		internal TaskNode() { }

		[Address(RVA = "0x1519930", Offset = "0x1518B30", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Task`1), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(bool))]
		[Token(Token = "0x60011A6")]
		private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011A7")]
		private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	}

	[Token(Token = "0x40009E1")]
	private static readonly Task<Boolean> s_trueTask; //Field offset: 0x0
	[Token(Token = "0x40009E2")]
	private static readonly Task<Boolean> s_falseTask; //Field offset: 0x8
	[Token(Token = "0x40009E3")]
	private static Action<Object> s_cancellationTokenCanceledEventHandler; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009DA")]
	private int m_currentCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40009DB")]
	private readonly int m_maxCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009DC")]
	private int m_waitCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009DD")]
	private object m_lockObj; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009DE")]
	private ManualResetEvent m_waitHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009DF")]
	private TaskNode m_asyncHead; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009E0")]
	private TaskNode m_asyncTail; //Field offset: 0x38

	[Address(RVA = "0x1517C50", Offset = "0x1516E50", Length = "0x16A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(TaskCreationOptions), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011A4")]
	private static SemaphoreSlim() { }

	[Address(RVA = "0x1517DC0", Offset = "0x1516FC0", Length = "0x1C4")]
	[CalledBy(Type = "System.Security.Cryptography.CryptoStream+<>c", Member = "<get_AsyncActiveSemaphore>b__54_0", ReturnType = typeof(SemaphoreSlim))]
	[CalledBy(Type = "System.IO.Stream+<>c", Member = "<EnsureAsyncActiveSemaphoreInitialized>b__4_0", ReturnType = typeof(SemaphoreSlim))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.AddressFamily", "System.Net.Sockets.SocketType", "System.Net.Sockets.ProtocolType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.AddressFamily", "System.Net.Sockets.SocketType", "System.Net.Sockets.ProtocolType", "System.Net.Sockets.SafeSocketHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001193")]
	public SemaphoreSlim(int initialCount, int maxCount) { }

	[Address(RVA = "0x15163C0", Offset = "0x15155C0", Length = "0x1F9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021E170")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D860")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D670")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60011A1")]
	private static void CancellationTokenCanceledEventHandler(object obj) { }

	[Address(RVA = "0x15165C0", Offset = "0x15157C0", Length = "0x8F")]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60011A2")]
	private void CheckDispose() { }

	[Address(RVA = "0x1516650", Offset = "0x1515850", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Boolean>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001199")]
	private TaskNode CreateAndAddAsyncWaiter() { }

	[Address(RVA = "0x1516720", Offset = "0x1515920", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600119F")]
	public override void Dispose() { }

	[Address(RVA = "0x1516790", Offset = "0x1515990", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011A0")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1516840", Offset = "0x1515A40", Length = "0x7")]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "CheckDispose", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011A3")]
	private static string GetResourceString(string str) { }

	[Address(RVA = "0x1516850", Offset = "0x1515A50", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600119E")]
	private static void QueueWaiterTask(TaskNode waiterTask) { }

	[Address(RVA = "0x1516C30", Offset = "0x1515E30", Length = "0xD")]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "get_Preamble", ReturnType = typeof(System.ReadOnlySpan`1<System.Byte>))]
	[CalledBy(Type = "System.Security.Cryptography.CryptoStream+<ReadAsyncInternal>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.CryptoStream+<WriteAsyncInternal>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.SortedList+ValueList", Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Stream), Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Stream), Member = "FinishTrackingAsyncOperation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Stream), Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x600119C")]
	public int Release() { }

	[Address(RVA = "0x1516860", Offset = "0x1515A60", Length = "0x3C3")]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SemaphoreFullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "RemoveAsyncWaiter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskNode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D800")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D860")]
	[Calls(Type = typeof(Monitor), Member = "PulseAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021E170")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "CheckDispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D670")]
	[Token(Token = "0x600119D")]
	public int Release(int releaseCount) { }

	[Address(RVA = "0x1516C40", Offset = "0x1515E40", Length = "0xE3")]
	[CalledBy(Type = typeof(<WaitUntilCountOrTimeoutAsync>d__32), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600119A")]
	private bool RemoveAsyncWaiter(TaskNode task) { }

	[Address(RVA = "0x1517560", Offset = "0x1516760", Length = "0x6D2")]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815082C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeoutHelper), Member = "UpdateTimeOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CancellationToken), Member = "ThrowOperationCanceledException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181508050")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "CheckDispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001195")]
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1517C40", Offset = "0x1516E40", Length = "0x10")]
	[CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001194")]
	public void Wait() { }

	[Address(RVA = "0x1516D30", Offset = "0x1515F30", Length = "0x10")]
	[CalledBy(Type = "System.Security.Cryptography.CryptoStream+<ReadAsyncInternal>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.CryptoStream+<WriteAsyncInternal>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "QueueIOSelectorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SemaphoreSlim), typeof(IntPtr), "System.IOSelectorJob"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001197")]
	public Task WaitAsync() { }

	[Address(RVA = "0x1516D40", Offset = "0x1515F40", Length = "0x5AD")]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitUntilCountOrTimeoutAsync>d__32)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitUntilCountOrTimeoutAsync>d__32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SemaphoreSlim), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D670")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Boolean>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021E170")]
	[Calls(Type = typeof(Task), Member = "FromCancellation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SemaphoreSlim), Member = "CheckDispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001198")]
	public Task<Boolean> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1517440", Offset = "0x1516640", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeoutHelper), Member = "UpdateTimeOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CancellationToken), Member = "ThrowOperationCanceledException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001196")]
	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	[Address(RVA = "0x15172F0", Offset = "0x15164F0", Length = "0x149")]
	[AsyncStateMachine(typeof(<WaitUntilCountOrTimeoutAsync>d__32))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitUntilCountOrTimeoutAsync>d__32)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitUntilCountOrTimeoutAsync>d__32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600119B")]
	private Task<Boolean> WaitUntilCountOrTimeoutAsync(TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

}

