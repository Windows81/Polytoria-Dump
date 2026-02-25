namespace System.Threading;

[Token(Token = "0x200022A")]
public sealed class Thread : CriticalFinalizerObject
{
	[ThreadStatic]
	[Token(Token = "0x4000A29")]
	private static LocalDataStoreHolder s_LocalDataStore; //Field offset: 0x80000000
	[ThreadStatic]
	[Token(Token = "0x4000A2A")]
	internal static CultureInfo m_CurrentCulture; //Field offset: 0x80000008
	[ThreadStatic]
	[Token(Token = "0x4000A2B")]
	internal static CultureInfo m_CurrentUICulture; //Field offset: 0x80000010
	[ThreadStatic]
	[Token(Token = "0x4000A31")]
	private static Thread current_thread; //Field offset: 0x80000018
	[Token(Token = "0x4000A28")]
	private static LocalDataStoreMgr s_LocalDataStoreMgr; //Field offset: 0x0
	[Token(Token = "0x4000A2C")]
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; //Field offset: 0x8
	[Token(Token = "0x4000A2D")]
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A2E")]
	private InternalThread internal_thread; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A2F")]
	private object m_ThreadStartArg; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A30")]
	private object pending_exception; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A32")]
	private MulticastDelegate m_Delegate; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A33")]
	private ExecutionContext m_ExecutionContext; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A34")]
	private bool m_ExecutionContextBelongsToOuterScope; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A35")]
	private IPrincipal principal; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A36")]
	private int principal_version; //Field offset: 0x48

	[Token(Token = "0x170001BC")]
	public static Context CurrentContext
	{
		[Address(RVA = "0x1364F40", Offset = "0x1364140", Length = "0x7")]
		[CallerCount(Count = 24)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001250")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001BA")]
	public CultureInfo CurrentCulture
	{
		[Address(RVA = "0x151B9C0", Offset = "0x151ABC0", Length = "0x34")]
		[CalledBy(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
		[CalledBy(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
		[CalledBy(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX", ReturnType = typeof(CultureInfo))]
		[Token(Token = "0x600124B")]
		 get { } //Length: 52
	}

	[Token(Token = "0x170001BD")]
	public static Thread CurrentThread
	{
		[Address(RVA = "0x151BA00", Offset = "0x151AC00", Length = "0x4E")]
		[CallerCount(Count = 45)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
		[Token(Token = "0x6001253")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170001B9")]
	public CultureInfo CurrentUICulture
	{
		[Address(RVA = "0x151BA50", Offset = "0x151AC50", Length = "0x34")]
		[CalledBy(Type = typeof(CultureInfo), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Thread), Member = "GetCurrentUICultureNoAppX", ReturnType = typeof(CultureInfo))]
		[Token(Token = "0x6001249")]
		 get { } //Length: 52
	}

	[Token(Token = "0x170001B7")]
	internal bool ExecutionContextBelongsToCurrentScope
	{
		[Address(RVA = "0x151BA90", Offset = "0x151AC90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600123B")]
		internal get { } //Length: 8
		[Address(RVA = "0x151BB40", Offset = "0x151AD40", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600123C")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170001BB")]
	private InternalThread Internal
	{
		[Address(RVA = "0x151BAA0", Offset = "0x151ACA0", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
		[Token(Token = "0x600124F")]
		private get { } //Length: 41
	}

	[Token(Token = "0x170001C0")]
	public bool IsAlive
	{
		[Address(RVA = "0x151BAD0", Offset = "0x151ACD0", Length = "0x2C")]
		[CalledBy(Type = "Mirror.WorkerThread", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.WorkerThread", Member = "StopBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.WorkerThread", Member = "get_IsAlive", ReturnType = typeof(bool))]
		[CalledBy(Type = "Telepathy.Server", Member = "get_Active", ReturnType = typeof(bool))]
		[CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Telepathy.Server", Member = "Stop", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D700")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001259")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001C1")]
	public bool IsBackground
	{
		[Address(RVA = "0x151BB50", Offset = "0x151AD50", Length = "0xC4")]
		[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "acceptLoop", ReturnType = typeof(void))]
		[CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Telepathy.Client", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Telepathy.ClientConnectionState", typeof(string), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "HandshakeAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebServer", Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "ConnectAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.WorkerThread", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.TimerThread", Member = "ThreadProc", ReturnType = typeof(void))]
		[CalledBy(Type = "System.IO.DefaultWatcher", Member = "StartDispatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "InitScheduler", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeThread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri"}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DAC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D700")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
		[Calls(Type = typeof(ThreadStateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D540")]
		[Token(Token = "0x600125A")]
		 set { } //Length: 196
	}

	[Token(Token = "0x170001BE")]
	public bool IsThreadPoolThread
	{
		[Address(RVA = "0x151BB00", Offset = "0x151AD00", Length = "0x30")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001257")]
		 get { } //Length: 48
	}

	[Token(Token = "0x170001BF")]
	internal bool IsThreadPoolThreadInternal
	{
		[Address(RVA = "0x151BB00", Offset = "0x151AD00", Length = "0x30")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001258")]
		internal get { } //Length: 48
	}

	[Token(Token = "0x170001C3")]
	public int ManagedThreadId
	{
		[Address(RVA = "0x151AE60", Offset = "0x151A060", Length = "0x2F")]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x6001267")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170001C2")]
	public string Name
	{
		[Address(RVA = "0x151BC20", Offset = "0x151AE20", Length = "0x60")]
		[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "SchedulerThread", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "HandshakeAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
		[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D910")]
		[Token(Token = "0x600125D")]
		 set { } //Length: 96
	}

	[Token(Token = "0x170001B8")]
	public ThreadPriority Priority
	{
		[Address(RVA = "0x151B0A0", Offset = "0x151A2A0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DAB0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001242")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x151B940", Offset = "0x151AB40", Length = "0x7F")]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Client", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Telepathy.ClientConnectionState", typeof(string), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "HandshakeAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "acceptLoop", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "ConnectAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebServer", Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.WorkerThread", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread", Member = "Prod", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread+TimerQueue", Member = "CreateTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.TimerThread+Callback", typeof(object)}, ReturnType = "System.Net.TimerThread+Timer")]
	[CalledBy(Type = "System.IO.DefaultWatcher", Member = "StartDispatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "InitScheduler", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri"}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001235")]
	public Thread(ThreadStart start) { }

	[Address(RVA = "0x151B840", Offset = "0x151AA40", Length = "0xF5")]
	[CalledBy(Type = typeof(RuntimeThread), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterizedThreadStart), typeof(int)}, ReturnType = typeof(RuntimeThread))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001236")]
	public Thread(ParameterizedThreadStart start, int maxStackSize) { }

	[Address(RVA = "0x151AB00", Offset = "0x1519D00", Length = "0x96")]
	[CalledBy(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "TryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "LocalPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&), typeof(Boolean&), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6001268")]
	public static void BeginCriticalRegion() { }

	[Address(RVA = "0x151ABA0", Offset = "0x1519DA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D540")]
	[Token(Token = "0x6001262")]
	private static void ClrState(InternalThread thread, ThreadState clr) { }

	[Address(RVA = "0x151ABB0", Offset = "0x1519DB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Token(Token = "0x600124E")]
	private void ConstructInternalThread() { }

	[Address(RVA = "0x151ABC0", Offset = "0x1519DC0", Length = "0x96")]
	[CalledBy(Type = "System.Console+WindowsConsole", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "Exit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001269")]
	public static void EndCriticalRegion() { }

	[Address(RVA = "0x151AC60", Offset = "0x1519E60", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CriticalFinalizerObject), Member = "Finalize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001256")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1364F40", Offset = "0x1364140", Length = "0x7")]
	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001250")]
	public static Context get_CurrentContext() { }

	[Address(RVA = "0x151B9C0", Offset = "0x151ABC0", Length = "0x34")]
	[CalledBy(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[CalledBy(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX", ReturnType = typeof(CultureInfo))]
	[Token(Token = "0x600124B")]
	public CultureInfo get_CurrentCulture() { }

	[Address(RVA = "0x151BA00", Offset = "0x151AC00", Length = "0x4E")]
	[CallerCount(Count = 45)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6001253")]
	public static Thread get_CurrentThread() { }

	[Address(RVA = "0x151BA50", Offset = "0x151AC50", Length = "0x34")]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Thread), Member = "GetCurrentUICultureNoAppX", ReturnType = typeof(CultureInfo))]
	[Token(Token = "0x6001249")]
	public CultureInfo get_CurrentUICulture() { }

	[Address(RVA = "0x151BA90", Offset = "0x151AC90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600123B")]
	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	[Address(RVA = "0x151BAA0", Offset = "0x151ACA0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Token(Token = "0x600124F")]
	private InternalThread get_Internal() { }

	[Address(RVA = "0x151BAD0", Offset = "0x151ACD0", Length = "0x2C")]
	[CalledBy(Type = "Mirror.WorkerThread", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.WorkerThread", Member = "StopBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.WorkerThread", Member = "get_IsAlive", ReturnType = typeof(bool))]
	[CalledBy(Type = "Telepathy.Server", Member = "get_Active", ReturnType = typeof(bool))]
	[CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Telepathy.Server", Member = "Stop", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D700")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001259")]
	public bool get_IsAlive() { }

	[Address(RVA = "0x151BB00", Offset = "0x151AD00", Length = "0x30")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001257")]
	public bool get_IsThreadPoolThread() { }

	[Address(RVA = "0x151BB00", Offset = "0x151AD00", Length = "0x30")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001258")]
	internal bool get_IsThreadPoolThreadInternal() { }

	[Address(RVA = "0x151AE60", Offset = "0x151A060", Length = "0x2F")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001267")]
	public int get_ManagedThreadId() { }

	[Address(RVA = "0x151ACA0", Offset = "0x1519EA0", Length = "0x99")]
	[CalledBy(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_DefaultThreadCurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "get_UserDefaultCulture", ReturnType = typeof(CultureInfo))]
	[Token(Token = "0x600124C")]
	private CultureInfo GetCurrentCultureNoAppX() { }

	[Address(RVA = "0x151AD50", Offset = "0x1519F50", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[Token(Token = "0x6001252")]
	private static Thread GetCurrentThread() { }

	[Address(RVA = "0x151AD40", Offset = "0x1519F40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[Token(Token = "0x6001251")]
	private static void GetCurrentThread_icall(ref Thread thread) { }

	[Address(RVA = "0x151AD80", Offset = "0x1519F80", Length = "0x99")]
	[CalledBy(Type = typeof(Thread), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_DefaultThreadCurrentUICulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "get_UserDefaultUICulture", ReturnType = typeof(CultureInfo))]
	[Token(Token = "0x600124A")]
	internal CultureInfo GetCurrentUICultureNoAppX() { }

	[Address(RVA = "0x151AE20", Offset = "0x151A020", Length = "0x5")]
	[CalledBy(Type = typeof(AppDomain), Member = "IsFinalizingForUnload", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AppDomain), Member = "getDomainID", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Context), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Context), Member = "CreateNewContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(Context))]
	[CalledBy(Type = typeof(CrossAppDomainChannel), Member = "get_ChannelData", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CADMessageBase), Member = "MarshalArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ArrayList&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6C0")]
	[Token(Token = "0x6001254")]
	public static int GetDomainID() { }

	[Address(RVA = "0x151AE30", Offset = "0x151A030", Length = "0x21")]
	[CalledBy(Type = typeof(RemotingServices), Member = "SerializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600123A")]
	internal Reader GetExecutionContextReader() { }

	[Address(RVA = "0x151AE60", Offset = "0x151A060", Length = "0x2F")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ComVisible(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x600126A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x151AE90", Offset = "0x151A090", Length = "0x9C")]
	[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[CalledBy(Type = typeof(RemotingServices), Member = "DeserializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CallContext), Member = "SetLogicalCallContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogicalCallContext)}, ReturnType = typeof(LogicalCallContext))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExecutionContext), Member = "CreateMutableCopy", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x600123D")]
	internal ExecutionContext GetMutableExecutionContext() { }

	[Address(RVA = "0x151AF30", Offset = "0x151A130", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "GetPageSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DBF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001265")]
	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	[Address(RVA = "0x151AFD0", Offset = "0x151A1D0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D700")]
	[Token(Token = "0x6001263")]
	private static ThreadState GetState(InternalThread thread) { }

	[Address(RVA = "0x151AFE0", Offset = "0x151A1E0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D7F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001240")]
	public void Interrupt() { }

	[Address(RVA = "0x151AFE0", Offset = "0x151A1E0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D7F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001241")]
	private void InterruptInternal() { }

	[Address(RVA = "0x151AFF0", Offset = "0x151A1F0", Length = "0x5")]
	[CalledBy(Type = typeof(Interlocked), Member = "MemoryBarrier", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_DateTimeFormat", ReturnType = typeof(DateTimeFormatInfo))]
	[CalledBy(Type = "System.Xml.XmlCharType", Member = "InitInstance", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XHashtable`1+XHashtableState", Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Linq.XHashtable`1", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801FB9A0")]
	[Token(Token = "0x600124D")]
	public static void MemoryBarrier() { }

	[Address(RVA = "0x151BB40", Offset = "0x151AD40", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600123C")]
	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[Address(RVA = "0x151BB50", Offset = "0x151AD50", Length = "0xC4")]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeThread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "InitScheduler", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.DefaultWatcher", Member = "StartDispatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread", Member = "ThreadProc", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.WorkerThread", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "ConnectAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "HandshakeAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Telepathy.ClientConnectionState", typeof(string), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebServer", Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Client", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "acceptLoop", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DAC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D700")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Calls(Type = typeof(ThreadStateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D540")]
	[Token(Token = "0x600125A")]
	public void set_IsBackground(bool value) { }

	[Address(RVA = "0x151BC20", Offset = "0x151AE20", Length = "0x60")]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "SchedulerThread", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "HandshakeAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D910")]
	[Token(Token = "0x600125D")]
	public void set_Name(string value) { }

	[Address(RVA = "0x151B0A0", Offset = "0x151A2A0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DAB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001242")]
	public void set_Priority(ThreadPriority value) { }

	[Address(RVA = "0x151B000", Offset = "0x151A200", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600123E")]
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[Address(RVA = "0x151B000", Offset = "0x151A200", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600123F")]
	internal void SetExecutionContext(Reader value, bool belongsToCurrentScope) { }

	[Address(RVA = "0x151B040", Offset = "0x151A240", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D910")]
	[Token(Token = "0x600125B")]
	private static void SetName_icall(InternalThread thread, Char* name, int nameLength) { }

	[Address(RVA = "0x151B050", Offset = "0x151A250", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D910")]
	[Token(Token = "0x600125C")]
	private static void SetName_internal(InternalThread thread, string name) { }

	[Address(RVA = "0x151B0A0", Offset = "0x151A2A0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DAB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001243")]
	private void SetPriorityNative(int priority) { }

	[Address(RVA = "0x151B390", Offset = "0x151A590", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001266")]
	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[Address(RVA = "0x151B0B0", Offset = "0x151A2B0", Length = "0x2DC")]
	[CalledBy(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterizedThreadStart), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "GetPageSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DBF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001248")]
	private void SetStartHelper(Delegate start, int maxStackSize) { }

	[Address(RVA = "0x151B3E0", Offset = "0x151A5E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DAC0")]
	[Token(Token = "0x6001261")]
	private static void SetState(InternalThread thread, ThreadState set) { }

	[Address(RVA = "0x151B400", Offset = "0x151A600", Length = "0x8A")]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "Shutdown", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Utils", Member = "CheckForInterupt", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.SendLoop", Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.SendLoop+Config"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.ReadHelper", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), "System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport", Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.WorkerThread", Member = "StopBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "ThreadTick", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.ReaderWriterLockSlim+TimeoutTracker"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecutePendingTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.TimerThread", Member = "ThreadProc", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.DefaultWatcher", Member = "Monitor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeThread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DBA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001245")]
	public static void Sleep(int millisecondsTimeout) { }

	[Address(RVA = "0x151B3F0", Offset = "0x151A5F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DBA0")]
	[Token(Token = "0x6001244")]
	private static void SleepInternal(int millisecondsTimeout) { }

	[Address(RVA = "0x151B490", Offset = "0x151A690", Length = "0x26")]
	[CalledBy(Type = typeof(RuntimeThread), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.LazyAsyncResult", Member = "WaitForCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.ReaderWriterLockSlim+TimeoutTracker"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600125F")]
	public static void SpinWait(int iterations) { }

	[Address(RVA = "0x13EA210", Offset = "0x13E9410", Length = "0x5")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
	[DeduplicatedMethod]
	[Token(Token = "0x600125E")]
	private static void SpinWait_nop() { }

	[Address(RVA = "0x151B560", Offset = "0x151A760", Length = "0x14A")]
	[CalledBy(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Thread), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DD60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001239")]
	private void Start(ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x151B6B0", Offset = "0x151A8B0", Length = "0xD2")]
	[CalledBy(Type = typeof(RuntimeThread), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Thread), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001238")]
	public void Start(object parameter) { }

	[Address(RVA = "0x151B540", Offset = "0x151A740", Length = "0x1E")]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "ConnectAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Client", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Telepathy.ClientConnectionState", typeof(string), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "HandshakeAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "acceptLoop", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebServer", Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread", Member = "Prod", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread+TimerQueue", Member = "CreateTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.TimerThread+Callback", typeof(object)}, ReturnType = "System.Net.TimerThread+Timer")]
	[CalledBy(Type = "System.IO.DefaultWatcher", Member = "StartDispatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "InitScheduler", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.WorkerThread", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Server", Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Thread), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001237")]
	public void Start() { }

	[Address(RVA = "0x151B4C0", Offset = "0x151A6C0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DD60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001260")]
	private void StartInternal(object principal, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x151B790", Offset = "0x151A990", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DBF0")]
	[Token(Token = "0x6001264")]
	private static int SystemMaxStackStize() { }

	[Address(RVA = "0x151B7A0", Offset = "0x151A9A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DD60")]
	[Token(Token = "0x6001255")]
	private bool Thread_internal(MulticastDelegate start) { }

	[Address(RVA = "0x151B7B0", Offset = "0x151A9B0", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D700")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ThreadStateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600126B")]
	private ThreadState ValidateThreadState() { }

	[Address(RVA = "0x151B830", Offset = "0x151AA30", Length = "0x5")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021E160")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001247")]
	public static bool Yield() { }

	[Address(RVA = "0x151B830", Offset = "0x151AA30", Length = "0x5")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021E160")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001246")]
	private static bool YieldInternal() { }

}

