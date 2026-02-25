namespace System.Net;

[Token(Token = "0x2000251")]
internal static class TimerThread
{
	[Token(Token = "0x2000254")]
	public sealed class Callback : MulticastDelegate
	{

		[Address(RVA = "0x17CD5F0", Offset = "0x17CC7F0", Length = "0x125")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EE4")]
		public Callback(object object, IntPtr method) { }

		[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EE5")]
		public override void Invoke(Timer timer, int timeNoticed, object context) { }

	}

	[Token(Token = "0x2000259")]
	private class InfiniteTimer : Timer
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009A2")]
		private int cancelled; //Field offset: 0x18

		[Token(Token = "0x170002FD")]
		internal virtual bool HasExpired
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000EF5")]
			internal get { } //Length: 3
		}

		[Address(RVA = "0x17DD760", Offset = "0x17DC960", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000EF4")]
		internal InfiniteTimer() { }

		[Address(RVA = "0x17DD740", Offset = "0x17DC940", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000EF6")]
		internal virtual bool Cancel() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EF5")]
		internal virtual bool get_HasExpired() { }

	}

	[Token(Token = "0x2000256")]
	private class InfiniteTimerQueue : Queue
	{

		[Address(RVA = "0x17DD720", Offset = "0x17DC920", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000EE9")]
		internal InfiniteTimerQueue() { }

		[Address(RVA = "0x17DD6C0", Offset = "0x17DC8C0", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000EEA")]
		internal virtual Timer CreateTimer(Callback callback, object context) { }

	}

	[Token(Token = "0x2000252")]
	public abstract class Queue
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000992")]
		private readonly int m_DurationMilliseconds; //Field offset: 0x10

		[Token(Token = "0x170002F6")]
		internal int Duration
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000EDC")]
			internal get { } //Length: 4
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EDB")]
		internal Queue(int durationMilliseconds) { }

		[Token(Token = "0x6000EDD")]
		internal abstract Timer CreateTimer(Callback callback, object context) { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EDC")]
		internal int get_Duration() { }

	}

	[Token(Token = "0x2000253")]
	public abstract class Timer : IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000993")]
		private readonly int m_StartTimeMilliseconds; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000994")]
		private readonly int m_DurationMilliseconds; //Field offset: 0x14

		[Token(Token = "0x170002F8")]
		internal int Expiration
		{
			[Address(RVA = "0x17E2930", Offset = "0x17E1B30", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6000EE0")]
			internal get { } //Length: 7
		}

		[Token(Token = "0x170002F9")]
		internal abstract bool HasExpired
		{
			[Token(Token = "0x6000EE2")]
			internal get { } //Length: 0
		}

		[Token(Token = "0x170002F7")]
		internal int StartTime
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000EDF")]
			internal get { } //Length: 4
		}

		[Address(RVA = "0x17E2900", Offset = "0x17E1B00", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000EDE")]
		internal Timer(int durationMilliseconds) { }

		[Token(Token = "0x6000EE1")]
		internal abstract bool Cancel() { }

		[Address(RVA = "0x16B6350", Offset = "0x16B5550", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EE3")]
		public override void Dispose() { }

		[Address(RVA = "0x17E2930", Offset = "0x17E1B30", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000EE0")]
		internal int get_Expiration() { }

		[Token(Token = "0x6000EE2")]
		internal abstract bool get_HasExpired() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EDF")]
		internal int get_StartTime() { }

	}

	[Token(Token = "0x2000257")]
	private class TimerNode : Timer
	{
		[Token(Token = "0x2000258")]
		private enum TimerState
		{
			Ready = 0,
			Fired = 1,
			Cancelled = 2,
			Sentinel = 3,
		}

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000997")]
		private TimerState m_TimerState; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000998")]
		private Callback m_Callback; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000999")]
		private object m_Context; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400099A")]
		private object m_QueueLock; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400099B")]
		private TimerNode next; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400099C")]
		private TimerNode prev; //Field offset: 0x40

		[Token(Token = "0x170002FA")]
		internal virtual bool HasExpired
		{
			[Address(RVA = "0x17E0B50", Offset = "0x17DFD50", Length = "0x8")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000EED")]
			internal get { } //Length: 8
		}

		[Token(Token = "0x170002FB")]
		internal TimerNode Next
		{
			[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
			[CallerCount(Count = 16)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000EEE")]
			internal get { } //Length: 5
			[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000EEF")]
			internal set { } //Length: 13
		}

		[Token(Token = "0x170002FC")]
		internal TimerNode Prev
		{
			[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000EF0")]
			internal get { } //Length: 5
			[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000EF1")]
			internal set { } //Length: 13
		}

		[Address(RVA = "0x17E0AC0", Offset = "0x17DFCC0", Length = "0x86")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000EEB")]
		internal TimerNode(Callback callback, object context, int durationMilliseconds, object queueLock) { }

		[Address(RVA = "0x17E0A90", Offset = "0x17DFC90", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000EEC")]
		internal TimerNode() { }

		[Address(RVA = "0x17E06E0", Offset = "0x17DF8E0", Length = "0x143")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x6000EF2")]
		internal virtual bool Cancel() { }

		[Address(RVA = "0x17E0830", Offset = "0x17DFA30", Length = "0x25D")]
		[CalledBy(Type = "System.Net.TimerThread+TimerQueue", Member = "Fire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NclUtilities), Member = "IsFatal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000EF3")]
		internal bool Fire() { }

		[Address(RVA = "0x17E0B50", Offset = "0x17DFD50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000EED")]
		internal virtual bool get_HasExpired() { }

		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EEE")]
		internal TimerNode get_Next() { }

		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EF0")]
		internal TimerNode get_Prev() { }

		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EEF")]
		internal void set_Next(TimerNode value) { }

		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EF1")]
		internal void set_Prev(TimerNode value) { }

	}

	[Token(Token = "0x2000255")]
	private class TimerQueue : Queue
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000995")]
		private IntPtr m_ThisHandle; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000996")]
		private readonly TimerNode m_Timers; //Field offset: 0x20

		[Address(RVA = "0x17E1050", Offset = "0x17E0250", Length = "0xBA")]
		[CalledBy(Type = typeof(TimerThread), Member = "CreateQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Queue))]
		[CalledBy(Type = typeof(TimerThread), Member = "GetOrCreateQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Queue))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000EE6")]
		internal TimerQueue(int durationMilliseconds) { }

		[Address(RVA = "0x17E0B60", Offset = "0x17DFD60", Length = "0x340")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000EE7")]
		internal virtual Timer CreateTimer(Callback callback, object context) { }

		[Address(RVA = "0x17E0EB0", Offset = "0x17E00B0", Length = "0x197")]
		[CalledBy(Type = typeof(TimerThread), Member = "ThreadProc", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
		[Calls(Type = "System.Net.TimerThread+TimerNode", Member = "Fire", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000EE8")]
		internal bool Fire(out int nextExpiration) { }

	}

	[Token(Token = "0x400098A")]
	private static LinkedList<WeakReference> s_Queues; //Field offset: 0x0
	[Token(Token = "0x400098B")]
	private static LinkedList<WeakReference> s_NewQueues; //Field offset: 0x8
	[Token(Token = "0x400098C")]
	private static int s_ThreadState; //Field offset: 0x10
	[Token(Token = "0x400098D")]
	private static AutoResetEvent s_ThreadReadyEvent; //Field offset: 0x18
	[Token(Token = "0x400098E")]
	private static ManualResetEvent s_ThreadShutdownEvent; //Field offset: 0x20
	[Token(Token = "0x400098F")]
	private static WaitHandle[] s_ThreadEvents; //Field offset: 0x28
	[Token(Token = "0x4000990")]
	private static int s_CacheScanIteration; //Field offset: 0x30
	[Token(Token = "0x4000991")]
	private static Hashtable s_QueuesCache; //Field offset: 0x38

	[Address(RVA = "0x17E25B0", Offset = "0x17E17B0", Length = "0x34F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AutoResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(AppDomain), Member = "add_DomainUnload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000ED3")]
	private static TimerThread() { }

	[Address(RVA = "0x17E1110", Offset = "0x17E0310", Length = "0x215")]
	[CalledBy(Type = typeof(WebRequest), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimerQueue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ED4")]
	internal static Queue CreateQueue(int durationMilliseconds) { }

	[Address(RVA = "0x17E1330", Offset = "0x17E0530", Length = "0x85F")]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "TimedSubmitRequestHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "get_TimerQueue", ReturnType = typeof(Queue))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimerQueue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000ED5")]
	internal static Queue GetOrCreateQueue(int durationMilliseconds) { }

	[Address(RVA = "0x17E1B90", Offset = "0x17E0D90", Length = "0x16")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000ED9")]
	private static bool IsTickBetween(int start, int end, int comparand) { }

	[Address(RVA = "0x17E1BB0", Offset = "0x17E0DB0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EDA")]
	private static void OnDomainUnload(object sender, EventArgs e) { }

	[Address(RVA = "0x17E1C70", Offset = "0x17E0E70", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ED6")]
	private static void Prod() { }

	[Address(RVA = "0x17E1D90", Offset = "0x17E0F90", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000ED8")]
	private static void StopTimerThread() { }

	[Address(RVA = "0x17E1E10", Offset = "0x17E1010", Length = "0x796")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NclUtilities), Member = "IsFatal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TimerQueue), Member = "Fire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LinkedListNode`1), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(LinkedList`1), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000ED7")]
	private static void ThreadProc() { }

}

