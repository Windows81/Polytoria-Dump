namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x200023B")]
public abstract class WaitHandle : MarshalByRefObject, IDisposable
{
	[Token(Token = "0x4000A56")]
	public const int WaitTimeout = 258; //Field offset: 0x0
	[Token(Token = "0x4000A57")]
	private const int MAX_WAITHANDLES = 64; //Field offset: 0x0
	[Token(Token = "0x4000A5B")]
	private const int WAIT_OBJECT_0 = 0; //Field offset: 0x0
	[Token(Token = "0x4000A5C")]
	private const int WAIT_ABANDONED = 128; //Field offset: 0x0
	[Token(Token = "0x4000A5D")]
	private const int WAIT_FAILED = 2147483647; //Field offset: 0x0
	[Token(Token = "0x4000A5E")]
	private const int ERROR_TOO_MANY_POSTS = 298; //Field offset: 0x0
	[Token(Token = "0x4000A5F")]
	private const int ERROR_NOT_OWNED_BY_CALLER = 299; //Field offset: 0x0
	[Token(Token = "0x4000A60")]
	protected static readonly IntPtr InvalidHandle; //Field offset: 0x0
	[Token(Token = "0x4000A61")]
	internal const int MaxWaitHandles = 64; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A58")]
	private IntPtr waitHandle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A59")]
	internal SafeWaitHandle safeWaitHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A5A")]
	internal bool hasThreadAffinity; //Field offset: 0x28

	[Obsolete("Use the SafeWaitHandle property instead.")]
	[Token(Token = "0x170001C6")]
	public override IntPtr Handle
	{
		[Address(RVA = "0x153CAD0", Offset = "0x153BCD0", Length = "0xF1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(SafeHandle), Member = "SetHandleAsInvalid", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012B0")]
		 set { } //Length: 241
	}

	[Token(Token = "0x170001C7")]
	public SafeWaitHandle SafeWaitHandle
	{
		[Address(RVA = "0x153CA00", Offset = "0x153BC00", Length = "0xC1")]
		[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WaitHandle), Member = "WaitMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(RegisteredWaitHandle), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
		[Token(Token = "0x60012B1")]
		 get { } //Length: 193
	}

	[Address(RVA = "0x153C930", Offset = "0x153BB30", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60012C2")]
	private static WaitHandle() { }

	[Address(RVA = "0x153C980", Offset = "0x153BB80", Length = "0x7B")]
	[CalledBy(Type = typeof(AutoResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "LazyInitializeEvent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EventResetMode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Diagnostics.ProcessWaitHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Microsoft.Win32.SafeHandles.SafeProcessHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60012AE")]
	protected WaitHandle() { }

	[Address(RVA = "0x153B780", Offset = "0x153A980", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012BC")]
	public override void Close() { }

	[Address(RVA = "0x153B7F0", Offset = "0x153A9F0", Length = "0x61")]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "LazyInitializeEvent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012BE")]
	public override void Dispose() { }

	[Address(RVA = "0x153B860", Offset = "0x153AA60", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60012BD")]
	protected override void Dispose(bool explicitDisposing) { }

	[Address(RVA = "0x153CA00", Offset = "0x153BC00", Length = "0xC1")]
	[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RegisteredWaitHandle), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x60012B1")]
	public SafeWaitHandle get_SafeWaitHandle() { }

	[Address(RVA = "0x153B8B0", Offset = "0x153AAB0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60012AF")]
	private void Init() { }

	[Address(RVA = "0x153B930", Offset = "0x153AB30", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WaitHandle), Member = "WaitOneNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(WaitHandle), Member = "ThrowAbandonedMutexException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60012B7")]
	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	[Address(RVA = "0x153CAD0", Offset = "0x153BCD0", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SafeHandle), Member = "SetHandleAsInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60012B0")]
	public override void set_Handle(IntPtr value) { }

	[Address(RVA = "0x153BA50", Offset = "0x153AC50", Length = "0x42")]
	[CalledBy(Type = typeof(AutoResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "LazyInitializeEvent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EventResetMode), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012B2")]
	internal void SetHandleInternal(SafeWaitHandle handle) { }

	[Address(RVA = "0x153BAA0", Offset = "0x153ACA0", Length = "0x52")]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AbandonedMutexException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(WaitHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60012BB")]
	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	[Address(RVA = "0x153BB00", Offset = "0x153AD00", Length = "0x3E")]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WaitHandle), Member = "InternalWaitOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(long), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AbandonedMutexException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60012BA")]
	private static void ThrowAbandonedMutexException() { }

	[Address(RVA = "0x153C920", Offset = "0x153BB20", Length = "0x5")]
	[CalledBy(Type = typeof(SynchronizationContext), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr[]), typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SynchronizationContext), Member = "WaitHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr[]), typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DFA0")]
	[Token(Token = "0x60012C1")]
	internal static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	[Address(RVA = "0x153BB40", Offset = "0x153AD40", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x60012B9")]
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	[Address(RVA = "0x153BC60", Offset = "0x153AE60", Length = "0x3D8")]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RegisteredWaitHandle), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread", Member = "ThreadProc", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WaitHandle), Member = "ThrowAbandonedMutexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(WaitHandle), Member = "ThrowAbandonedMutexException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(WaitHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WaitHandle), Member = "WaitMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x60012B8")]
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	[Address(RVA = "0x153C040", Offset = "0x153B240", Length = "0x38D")]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WaitHandle), Member = "get_SafeWaitHandle", ReturnType = typeof(SafeWaitHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DFA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181521370")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SynchronizationContext), Member = "IsWaitNotificationRequired", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815214C0")]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012C0")]
	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	[Address(RVA = "0x153C5D0", Offset = "0x153B7D0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012B5")]
	public override bool WaitOne(int millisecondsTimeout) { }

	[Address(RVA = "0x153C5F0", Offset = "0x153B7F0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012B4")]
	public override bool WaitOne() { }

	[Address(RVA = "0x153C610", Offset = "0x153B810", Length = "0x1BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WaitHandle), Member = "WaitOneNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(WaitHandle), Member = "ThrowAbandonedMutexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60012B3")]
	public override bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	[Address(RVA = "0x153C7D0", Offset = "0x153B9D0", Length = "0x14B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WaitHandle), Member = "WaitOneNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(WaitHandle), Member = "ThrowAbandonedMutexException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60012B6")]
	private bool WaitOne(long timeout, bool exitContext) { }

	[Address(RVA = "0x153C3D0", Offset = "0x153B5D0", Length = "0x1FA")]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WaitHandle), Member = "InternalWaitOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(long), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(SynchronizationContext), Member = "IsWaitNotificationRequired", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DFA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012BF")]
	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

}

