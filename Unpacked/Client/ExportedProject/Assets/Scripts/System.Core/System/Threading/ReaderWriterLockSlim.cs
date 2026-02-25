namespace System.Threading;

[Token(Token = "0x2000252")]
public class ReaderWriterLockSlim : IDisposable
{
	[Token(Token = "0x2000253")]
	private struct TimeoutTracker
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000415")]
		private int m_total; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000416")]
		private int m_start; //Field offset: 0x4

		[Token(Token = "0x17000241")]
		public bool IsExpired
		{
			[Address(RVA = "0x15EC730", Offset = "0x15EB930", Length = "0x4C")]
			[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000B56")]
			 get { } //Length: 76
		}

		[Token(Token = "0x17000240")]
		public int RemainingMilliseconds
		{
			[Address(RVA = "0x15EC780", Offset = "0x15EB980", Length = "0x753")]
			[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "WaitOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle), typeof(UInt32&), typeof(TimeoutTracker), typeof(bool)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
			[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
			[Calls(Type = "Mono.Btls.MonoBtlsBio", Member = "get_Handle", ReturnType = "Mono.Btls.MonoBtlsBio+BoringBioHandle")]
			[Calls(Type = "Mono.Unity.UnityTls", Member = "get_NativeInterface", ReturnType = "Mono.Unity.UnityTls+unitytls_interface_struct")]
			[Calls(Type = "Mono.Net.Security.BufferOffsetSize2", Member = "Reset", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = "Mono.Btls.MonoBtlsObject", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[CallsUnknownMethods(Count = 4)]
			[Token(Token = "0x6000B55")]
			 get { } //Length: 1875
		}

		[Address(RVA = "0x15EC6B0", Offset = "0x15EB8B0", Length = "0x7D")]
		[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "EnterReadLock", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000B54")]
		public TimeoutTracker(int millisecondsTimeout) { }

		[Address(RVA = "0x15EC730", Offset = "0x15EB930", Length = "0x4C")]
		[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000B56")]
		public bool get_IsExpired() { }

		[Address(RVA = "0x15EC780", Offset = "0x15EB980", Length = "0x753")]
		[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "WaitOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle), typeof(UInt32&), typeof(TimeoutTracker), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = "Mono.Btls.MonoBtlsObject", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = "Mono.Net.Security.BufferOffsetSize2", Member = "Reset", ReturnType = typeof(void))]
		[Calls(Type = "Mono.Unity.UnityTls", Member = "get_NativeInterface", ReturnType = "Mono.Unity.UnityTls+unitytls_interface_struct")]
		[Calls(Type = "Mono.Btls.MonoBtlsBio", Member = "get_Handle", ReturnType = "Mono.Btls.MonoBtlsBio+BoringBioHandle")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6000B55")]
		public int get_RemainingMilliseconds() { }

	}

	[ThreadStatic]
	[Token(Token = "0x4000411")]
	private static ReaderWriterCount t_rwc; //Field offset: 0x80000000
	[Token(Token = "0x400040F")]
	private static long s_nextLockID; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000402")]
	private bool fIsReentrant; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000403")]
	private int myLock; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000404")]
	private uint numWriteWaiters; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000405")]
	private uint numReadWaiters; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000406")]
	private uint numWriteUpgradeWaiters; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000407")]
	private uint numUpgradeWaiters; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000408")]
	private bool fNoWaiters; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000409")]
	private int upgradeLockOwnerId; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400040A")]
	private int writeLockOwnerId; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400040B")]
	private EventWaitHandle writeEvent; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400040C")]
	private EventWaitHandle readEvent; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400040D")]
	private EventWaitHandle upgradeEvent; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400040E")]
	private EventWaitHandle waitUpgradeEvent; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000410")]
	private long lockID; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000412")]
	private bool fUpgradeThreadHoldingRead; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000413")]
	private uint owners; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000414")]
	private bool fDisposed; //Field offset: 0x68

	[Token(Token = "0x17000237")]
	public bool IsReadLockHeld
	{
		[Address(RVA = "0x15E2600", Offset = "0x15E1800", Length = "0x74")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000B4B")]
		 get { } //Length: 116
	}

	[Token(Token = "0x17000238")]
	public bool IsUpgradeableReadLockHeld
	{
		[Address(RVA = "0x15E2680", Offset = "0x15E1880", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000B4C")]
		 get { } //Length: 155
	}

	[Token(Token = "0x17000239")]
	public bool IsWriteLockHeld
	{
		[Address(RVA = "0x15E2720", Offset = "0x15E1920", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000B4D")]
		 get { } //Length: 155
	}

	[Token(Token = "0x1700023A")]
	public int RecursiveReadCount
	{
		[Address(RVA = "0x15E27C0", Offset = "0x15E19C0", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Token(Token = "0x6000B4E")]
		 get { } //Length: 112
	}

	[Token(Token = "0x1700023B")]
	public int RecursiveUpgradeCount
	{
		[Address(RVA = "0x15E2830", Offset = "0x15E1A30", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000B4F")]
		 get { } //Length: 180
	}

	[Token(Token = "0x1700023C")]
	public int RecursiveWriteCount
	{
		[Address(RVA = "0x15E28F0", Offset = "0x15E1AF0", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000B50")]
		 get { } //Length: 180
	}

	[Token(Token = "0x1700023D")]
	public int WaitingReadCount
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B51")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700023E")]
	public int WaitingUpgradeCount
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B52")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700023F")]
	public int WaitingWriteCount
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B53")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x15E25A0", Offset = "0x15E17A0", Length = "0x5A")]
	[CalledBy(Type = "UnityEngine.Playables.PlayableSystems", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B31")]
	public ReaderWriterLockSlim() { }

	[Address(RVA = "0x15E2530", Offset = "0x15E1730", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B32")]
	public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy) { }

	[Address(RVA = "0x15E1370", Offset = "0x15E0570", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B43")]
	private void ClearUpgraderWaiting() { }

	[Address(RVA = "0x15E1380", Offset = "0x15E0580", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B41")]
	private void ClearWritersWaiting() { }

	[Address(RVA = "0x15E16C0", Offset = "0x15E08C0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B49")]
	public override void Dispose() { }

	[Address(RVA = "0x15E1390", Offset = "0x15E0590", Length = "0x323")]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000B4A")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x15E1790", Offset = "0x15E0990", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[Token(Token = "0x6000B45")]
	private void EnterMyLock() { }

	[Address(RVA = "0x15E16D0", Offset = "0x15E08D0", Length = "0xBC")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LabelInfo+<>c", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitReadLock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "LazyCreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLock", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "System.Threading.PlatformHelper", Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Thread), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000B46")]
	private void EnterMyLockSpin() { }

	[Address(RVA = "0x15E17D0", Offset = "0x15E09D0", Length = "0x3A")]
	[CalledBy(Type = "UnityEngine.Playables.PlayableSystems", Member = "Internal_CallSystemDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Playables.PlayableSystems+PlayableSystemStage", typeof(IntPtr), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeoutTracker), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B36")]
	public void EnterReadLock() { }

	[Address(RVA = "0x15E1810", Offset = "0x15E0A10", Length = "0x92")]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitReadLock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitAndWakeUpAppropriateWaiters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitAndWakeUpAppropriateWaitersPreferringWriters", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B3F")]
	private void ExitAndWakeUpAppropriateReadWaiters() { }

	[Address(RVA = "0x15E1940", Offset = "0x15E0B40", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitAndWakeUpAppropriateReadWaiters", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B3D")]
	private void ExitAndWakeUpAppropriateWaiters() { }

	[Address(RVA = "0x15E18B0", Offset = "0x15E0AB0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitAndWakeUpAppropriateReadWaiters", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B3E")]
	private void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }

	[Address(RVA = "0x15E19E0", Offset = "0x15E0BE0", Length = "0x1B")]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "ExitReadLock", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x6000B47")]
	private void ExitMyLock() { }

	[Address(RVA = "0x15E1A00", Offset = "0x15E0C00", Length = "0x1D3")]
	[CalledBy(Type = "UnityEngine.Playables.PlayableSystems", Member = "Internal_CallSystemDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Playables.PlayableSystems+PlayableSystemStage", typeof(IntPtr), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitMyLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitAndWakeUpAppropriateReadWaiters", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000B3A")]
	public void ExitReadLock() { }

	[Address(RVA = "0x15E2600", Offset = "0x15E1800", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B4B")]
	public bool get_IsReadLockHeld() { }

	[Address(RVA = "0x15E2680", Offset = "0x15E1880", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B4C")]
	public bool get_IsUpgradeableReadLockHeld() { }

	[Address(RVA = "0x15E2720", Offset = "0x15E1920", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B4D")]
	public bool get_IsWriteLockHeld() { }

	[Address(RVA = "0x15E27C0", Offset = "0x15E19C0", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Token(Token = "0x6000B4E")]
	public int get_RecursiveReadCount() { }

	[Address(RVA = "0x15E2830", Offset = "0x15E1A30", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B4F")]
	public int get_RecursiveUpgradeCount() { }

	[Address(RVA = "0x15E28F0", Offset = "0x15E1AF0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B50")]
	public int get_RecursiveWriteCount() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B51")]
	public int get_WaitingReadCount() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B52")]
	public int get_WaitingUpgradeCount() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B53")]
	public int get_WaitingWriteCount() { }

	[Address(RVA = "0x15E1BE0", Offset = "0x15E0DE0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B44")]
	private uint GetNumReaders() { }

	[Address(RVA = "0x15E1BF0", Offset = "0x15E0DF0", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B35")]
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	[Address(RVA = "0x15E1D30", Offset = "0x15E0F30", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B30")]
	private void InitializeThreadCounts() { }

	[Address(RVA = "0x15E1D40", Offset = "0x15E0F40", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B33")]
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	[Address(RVA = "0x15E1D80", Offset = "0x15E0F80", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B34")]
	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	[Address(RVA = "0x15E1DA0", Offset = "0x15E0FA0", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AutoResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B3B")]
	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	[Address(RVA = "0x15E1EB0", Offset = "0x15E10B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B42")]
	private void SetUpgraderWaiting() { }

	[Address(RVA = "0x15E1EC0", Offset = "0x15E10C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B40")]
	private void SetWritersWaiting() { }

	[Address(RVA = "0x15E1ED0", Offset = "0x15E10D0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "System.Threading.PlatformHelper", Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Thread), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B48")]
	private static void SpinWait(int SpinCount) { }

	[Address(RVA = "0x15E2410", Offset = "0x15E1610", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B38")]
	private bool TryEnterReadLock(TimeoutTracker timeout) { }

	[Address(RVA = "0x15E23D0", Offset = "0x15E15D0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeoutTracker), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B37")]
	public bool TryEnterReadLock(int millisecondsTimeout) { }

	[Address(RVA = "0x15E1F50", Offset = "0x15E1150", Length = "0x47A")]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "EnterReadLock", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitMyLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "System.Threading.PlatformHelper", Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeoutTracker), Member = "get_IsExpired", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LockRecursionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "WaitOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle), typeof(UInt32&), typeof(TimeoutTracker), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815CD880")]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B39")]
	private bool TryEnterReadLockCore(TimeoutTracker timeout) { }

	[Address(RVA = "0x15E2420", Offset = "0x15E1620", Length = "0x10C")]
	[CalledBy(Type = typeof(ReaderWriterLockSlim), Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeoutTracker)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(TimeoutTracker), Member = "get_RemainingMilliseconds", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815CD620")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B3C")]
	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, TimeoutTracker timeout, bool isWriteWaiter) { }

}

