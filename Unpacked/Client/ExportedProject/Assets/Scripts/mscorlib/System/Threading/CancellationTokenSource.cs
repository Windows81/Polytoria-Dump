namespace System.Threading;

[Token(Token = "0x2000203")]
public class CancellationTokenSource : IDisposable
{
	[Token(Token = "0x2000204")]
	private sealed class Linked1CancellationTokenSource : CancellationTokenSource
	{
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40009C3")]
		private readonly CancellationTokenRegistration _reg1; //Field offset: 0x40

		[Address(RVA = "0x1512F60", Offset = "0x1512160", Length = "0x13A")]
		[CalledBy(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(CancellationToken)}, ReturnType = typeof(CancellationTokenSource))]
		[CalledBy(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(CancellationTokenSource))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001175")]
		internal Linked1CancellationTokenSource(CancellationToken token1) { }

		[Address(RVA = "0x1512F20", Offset = "0x1512120", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001176")]
		protected virtual void Dispose(bool disposing) { }

	}

	[Token(Token = "0x2000205")]
	private sealed class Linked2CancellationTokenSource : CancellationTokenSource
	{
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40009C4")]
		private readonly CancellationTokenRegistration _reg1; //Field offset: 0x40
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40009C5")]
		private readonly CancellationTokenRegistration _reg2; //Field offset: 0x58

		[Address(RVA = "0x15130F0", Offset = "0x15122F0", Length = "0x1C8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001177")]
		internal Linked2CancellationTokenSource(CancellationToken token1, CancellationToken token2) { }

		[Address(RVA = "0x15130A0", Offset = "0x15122A0", Length = "0x4A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001178")]
		protected virtual void Dispose(bool disposing) { }

	}

	[Token(Token = "0x2000206")]
	private sealed class LinkedNCancellationTokenSource : CancellationTokenSource
	{
		[CompilerGenerated]
		[Token(Token = "0x2000207")]
		private sealed class <>c
		{
			[Token(Token = "0x40009C7")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x151E310", Offset = "0x151D510", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600117A")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600117B")]
			public <>c() { }

			[Address(RVA = "0x151E290", Offset = "0x151D490", Length = "0x75")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Token(Token = "0x600117C")]
			internal void <.cctor>b__4_0(object s) { }

		}

		[Token(Token = "0x40009C6")]
		internal static readonly Action<Object> s_linkedTokenCancelDelegate; //Field offset: 0x0

		[Address(RVA = "0x15132C0", Offset = "0x15124C0", Length = "0xC8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001179")]
		private static LinkedNCancellationTokenSource() { }

	}

	[Token(Token = "0x40009B8")]
	internal static readonly CancellationTokenSource s_canceledSource; //Field offset: 0x0
	[Token(Token = "0x40009B9")]
	internal static readonly CancellationTokenSource s_neverCanceledSource; //Field offset: 0x8
	[Token(Token = "0x40009BA")]
	private static readonly int s_nLists; //Field offset: 0x10
	[Token(Token = "0x40009C2")]
	private static readonly TimerCallback s_timerCallback; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009BB")]
	private ManualResetEvent _kernelEvent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009BC")]
	private SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009BD")]
	private int _state; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40009BE")]
	private int _threadIDExecutingCallbacks; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009BF")]
	private bool _disposed; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009C0")]
	private CancellationCallbackInfo _executingCallback; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009C1")]
	private Timer _timer; //Field offset: 0x38

	[Token(Token = "0x1700019D")]
	internal CancellationCallbackInfo ExecutingCallback
	{
		[Address(RVA = "0x1428020", Offset = "0x1427220", Length = "0x18")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001161")]
		internal get { } //Length: 24
	}

	[Token(Token = "0x17000199")]
	internal bool IsCancellationCompleted
	{
		[Address(RVA = "0x150AB50", Offset = "0x1509D50", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600115C")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x17000198")]
	public bool IsCancellationRequested
	{
		[Address(RVA = "0x150AB70", Offset = "0x1509D70", Length = "0x1A")]
		[CalledBy(Type = "System.Net.WebOperation", Member = "CheckDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[CalledBy(Type = "UnityEngine.Application", Member = "Internal_InitializeExitCancellationToken", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "GetNextOperation", ReturnType = "System.Net.WebOperation")]
		[CalledBy(Type = "System.Net.ServicePointScheduler", Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.WebConnectionStream", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
		[CalledBy(Type = "System.Net.WebOperation", Member = "get_Aborted", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.WebOperation", Member = "get_Closed", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebOperation", Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebReadStream", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
		[CalledBy(Type = "System.Net.WebResponseStream+<>c__DisplayClass41_0", Member = "<ProcessRead>b__2", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.WebResponseStream", Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebExceptionStatus", typeof(Exception), typeof(string)}, ReturnType = "System.Net.WebException")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600115B")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700019A")]
	internal bool IsDisposed
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600115D")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700019B")]
	internal int ThreadIDExecutingCallbacks
	{
		[Address(RVA = "0x150AB90", Offset = "0x1509D90", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Token(Token = "0x600115E")]
		internal get { } //Length: 22
		[Address(RVA = "0x150AC10", Offset = "0x1509E10", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Token(Token = "0x600115F")]
		internal set { } //Length: 34
	}

	[Token(Token = "0x1700019C")]
	public CancellationToken Token
	{
		[Address(RVA = "0x150ABB0", Offset = "0x1509DB0", Length = "0x5B")]
		[CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>", typeof(int), typeof(Action), "System.Func`1<Boolean>", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[CalledBy(Type = "System.Net.ServicePointScheduler+<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebOperation+<Run>d__58", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebOperation", Member = "RegisterRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePoint", "System.Net.WebConnection"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebRequestStream+<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "get_destroyCancellationToken", ReturnType = typeof(CancellationToken))]
		[CalledBy(Type = "System.Net.Http.HttpClient+<SendAsyncWorker>d__47", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
		[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
		[Token(Token = "0x6001160")]
		 get { } //Length: 91
	}

	[Address(RVA = "0x150A950", Offset = "0x1509B50", Length = "0x1BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001174")]
	private static CancellationTokenSource() { }

	[Address(RVA = "0x150AB10", Offset = "0x1509D10", Length = "0x31")]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Application", Member = "Internal_InitializeExitCancellationToken", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Application", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.AsyncInstantiateOperation", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "get_destroyCancellationToken", ReturnType = typeof(CancellationToken))]
	[CalledBy(Type = "System.Net.Http.HttpClient", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.HttpClient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpMessageHandler", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001162")]
	public CancellationTokenSource() { }

	[Address(RVA = "0x1509630", Offset = "0x1508830", Length = "0x50")]
	[CalledBy(Type = "System.Net.WebOperation", Member = "CheckThrowDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ExceptionDispatchInfo&)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "RaiseCancellation", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Application", Member = "Internal_RaiseExitCancellationToken", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<>c__DisplayClass41_0", Member = "<ProcessRead>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.HttpClient", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "Abort", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<RunWithTimeoutWorker>d__241`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Uri", Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri", "System.Uri"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "CheckDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001163")]
	public void Cancel() { }

	[Address(RVA = "0x15095D0", Offset = "0x15087D0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
	[Token(Token = "0x6001164")]
	public void Cancel(bool throwOnFirstException) { }

	[Address(RVA = "0x1509350", Offset = "0x1508550", Length = "0xB6")]
	[CalledBy(Type = "System.Net.Http.HttpClient+<SendAsyncWorker>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001165")]
	public void CancelAfter(TimeSpan delay) { }

	[Address(RVA = "0x1509410", Offset = "0x1508610", Length = "0x1BF")]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Timer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerCallback), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Token(Token = "0x6001166")]
	public void CancelAfter(int millisecondsDelay) { }

	[Address(RVA = "0x1509710", Offset = "0x1508910", Length = "0x1FE")]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork_OnSyncContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(SparselyPopulatedArrayFragment`1), Member = "SafeAtomicRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001170")]
	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	[Address(RVA = "0x1509690", Offset = "0x1508890", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationCallbackCoreWorkArguments)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600116F")]
	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	[Address(RVA = "0x1509C80", Offset = "0x1508E80", Length = "0xC1")]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>", typeof(int), typeof(Action), "System.Func`1<Boolean>", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CalledBy(Type = "System.Net.WebOperation", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.HttpWebRequest", "System.Net.BufferOffsetSize", typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Linked1CancellationTokenSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001172")]
	internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token) { }

	[Address(RVA = "0x1509910", Offset = "0x1508B10", Length = "0x363")]
	[CalledBy(Type = "System.Threading.SemaphoreSlim+<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.HttpClient+<SendAsyncWorker>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Linked1CancellationTokenSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001171")]
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	[Address(RVA = "0x1509D50", Offset = "0x1508F50", Length = "0x61")]
	[CalledBy(Type = "System.Uri", Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri", "System.Uri"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<RunWithTimeoutWorker>d__241`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "<>f__AnonymousType1`2", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Http.HttpClient", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001168")]
	public override void Dispose() { }

	[Address(RVA = "0x1509DC0", Offset = "0x1508FC0", Length = "0xA5")]
	[CalledBy(Type = typeof(Linked1CancellationTokenSource), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Linked2CancellationTokenSource), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BD0")]
	[Calls(Type = typeof(WaitHandle), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x6001169")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1509E70", Offset = "0x1509070", Length = "0x464")]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181508320")]
	[Calls(Type = typeof(Interlocked), Member = "MemoryBarrier", ReturnType = typeof(void))]
	[Calls(Type = typeof(LowLevelList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LowLevelListWithIList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationCallbackCoreWorkArguments)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AggregateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Exception>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SparselyPopulatedArrayFragment`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(SparselyPopulatedArray`1), Member = "get_Tail", ReturnType = "System.Threading.SparselyPopulatedArrayFragment`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600116E")]
	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	[Address(RVA = "0x1428020", Offset = "0x1427220", Length = "0x18")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001161")]
	internal CancellationCallbackInfo get_ExecutingCallback() { }

	[Address(RVA = "0x150AB50", Offset = "0x1509D50", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600115C")]
	internal bool get_IsCancellationCompleted() { }

	[Address(RVA = "0x150AB70", Offset = "0x1509D70", Length = "0x1A")]
	[CalledBy(Type = "System.Net.WebResponseStream", Member = "GetReadException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebExceptionStatus", typeof(Exception), typeof(string)}, ReturnType = "System.Net.WebException")]
	[CalledBy(Type = "System.Net.WebResponseStream+<>c__DisplayClass41_0", Member = "<ProcessRead>b__2", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.WebReadStream", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfClosedOrDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "get_Closed", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "ThrowIfDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnectionStream", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Net.ServicePointScheduler", Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "GetNextOperation", ReturnType = "System.Net.WebOperation")]
	[CalledBy(Type = "UnityEngine.Application", Member = "Internal_InitializeExitCancellationToken", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "CheckDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "get_Aborted", ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600115B")]
	public bool get_IsCancellationRequested() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600115D")]
	internal bool get_IsDisposed() { }

	[Address(RVA = "0x150AB90", Offset = "0x1509D90", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x600115E")]
	internal int get_ThreadIDExecutingCallbacks() { }

	[Address(RVA = "0x150ABB0", Offset = "0x1509DB0", Length = "0x5B")]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>", typeof(int), typeof(Action), "System.Func`1<Boolean>", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "RunWithTimeout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<CancellationToken, Task`1<T>>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation+<Run>d__58", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "RegisterRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePoint", "System.Net.WebConnection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "get_destroyCancellationToken", ReturnType = typeof(CancellationToken))]
	[CalledBy(Type = "System.Net.Http.HttpClient+<SendAsyncWorker>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
	[Token(Token = "0x6001160")]
	public CancellationToken get_Token() { }

	[Address(RVA = "0x150A2E0", Offset = "0x15094E0", Length = "0x34F")]
	[CalledBy(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(SparselyPopulatedArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SparselyPopulatedArray`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Threading.SparselyPopulatedArrayAddInfo`1<T>")]
	[Calls(Type = typeof(CancellationTokenRegistration), Member = "Unregister", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600116C")]
	internal CancellationTokenRegistration InternalRegister(Action<Object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	[Address(RVA = "0x150A630", Offset = "0x1509830", Length = "0xA3")]
	[CalledBy(Type = "System.Threading.CancellationTokenSource+LinkedNCancellationTokenSource+<>c", Member = "<.cctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "Cancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "TimerCallbackLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.SemaphoreSlim+<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600116D")]
	private void NotifyCancellation(bool throwOnFirstException) { }

	[Address(RVA = "0x150AC10", Offset = "0x1509E10", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x600115F")]
	internal void set_ThreadIDExecutingCallbacks(int value) { }

	[Address(RVA = "0x150A6E0", Offset = "0x15098E0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
	[Token(Token = "0x600116A")]
	internal void ThrowIfDisposed() { }

	[Address(RVA = "0x150A730", Offset = "0x1509930", Length = "0x50")]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "Cancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "TimerCallbackLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.SemaphoreSlim+<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600116B")]
	private static void ThrowObjectDisposedException() { }

	[Address(RVA = "0x150A790", Offset = "0x1509990", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "NotifyCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "ThrowObjectDisposedException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001167")]
	private static void TimerCallbackLogic(object obj) { }

	[Address(RVA = "0x150A880", Offset = "0x1509A80", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001173")]
	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

}

