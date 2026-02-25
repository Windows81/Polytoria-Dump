namespace System.Threading;

[Token(Token = "0x2000232")]
internal sealed class ThreadPoolWorkQueue
{
	[Token(Token = "0x2000235")]
	public class QueueSegment
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A4A")]
		internal readonly IThreadPoolWorkItem[] nodes; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A4B")]
		private int indexes; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A4C")]
		public QueueSegment Next; //Field offset: 0x20

		[Address(RVA = "0x152B610", Offset = "0x152A810", Length = "0x55")]
		[CalledBy(Type = typeof(ThreadPoolGlobals), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
		[Token(Token = "0x600128C")]
		public QueueSegment() { }

		[Address(RVA = "0x152B2C0", Offset = "0x152A4C0", Length = "0x7C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A90")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600128B")]
		private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

		[Address(RVA = "0x152B340", Offset = "0x152A540", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Token(Token = "0x600128A")]
		private void GetIndexes(out int upper, out int lower) { }

		[Address(RVA = "0x152B380", Offset = "0x152A580", Length = "0x51")]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueueThreadLocals), typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600128D")]
		public bool IsUsedUp() { }

		[Address(RVA = "0x152B3E0", Offset = "0x152A5E0", Length = "0x152")]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueueThreadLocals), typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A90")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600128F")]
		public bool TryDequeue(out IThreadPoolWorkItem node) { }

		[Address(RVA = "0x152B540", Offset = "0x152A740", Length = "0xC0")]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A90")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600128E")]
		public bool TryEnqueue(IThreadPoolWorkItem node) { }

	}

	[Token(Token = "0x2000233")]
	public class SparseArray
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A44")]
		private T[] m_array; //Field offset: 0x0

		[Token(Token = "0x170001C4")]
		internal T[] Current
		{
			[Address(RVA = "0xF5D6A0", Offset = "0xF5C8A0", Length = "0x18")]
			[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueueThreadLocals), typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001281")]
			internal get { } //Length: 24
		}

		[Address(RVA = "0xF5D630", Offset = "0xF5C830", Length = "0x6E")]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001280")]
		internal SparseArray`1(int initialSize) { }

		[Address(RVA = "0xF5D290", Offset = "0xF5C490", Length = "0x23D")]
		[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueue)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001282")]
		internal int Add(T e) { }

		[Address(RVA = "0xF5D6A0", Offset = "0xF5C8A0", Length = "0x18")]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueueThreadLocals), typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001281")]
		internal T[] get_Current() { }

		[Address(RVA = "0xF5D4D0", Offset = "0xF5C6D0", Length = "0x156")]
		[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "CleanUp", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001283")]
		internal void Remove(T e) { }

	}

	[Token(Token = "0x2000234")]
	public class WorkStealingQueue
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A45")]
		internal IThreadPoolWorkItem[] m_array; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A46")]
		private int m_mask; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000A47")]
		private int m_headIndex; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A48")]
		private int m_tailIndex; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000A49")]
		private SpinLock m_foreignLock; //Field offset: 0x24

		[Address(RVA = "0x1520E40", Offset = "0x1520040", Length = "0x88")]
		[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueue)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001289")]
		public WorkStealingQueue() { }

		[Address(RVA = "0x151FF80", Offset = "0x151F180", Length = "0x312")]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "LocalFindAndPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181508110")]
		[Calls(Type = typeof(WorkStealingQueue), Member = "LocalPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001285")]
		public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

		[Address(RVA = "0x15202A0", Offset = "0x151F4A0", Length = "0x390")]
		[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WorkStealingQueue), Member = "LocalFindAndPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueueThreadLocals), typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181508110")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
		[Token(Token = "0x6001286")]
		public bool LocalPop(out IThreadPoolWorkItem obj) { }

		[Address(RVA = "0x1520640", Offset = "0x151F840", Length = "0x4ED")]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815081C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181508110")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Token(Token = "0x6001284")]
		public void LocalPush(IThreadPoolWorkItem obj) { }

		[Address(RVA = "0x1520E20", Offset = "0x1520020", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WorkStealingQueue), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&), typeof(Boolean&), typeof(int)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6001287")]
		public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

		[Address(RVA = "0x1520B30", Offset = "0x151FD30", Length = "0x2EA")]
		[CalledBy(Type = typeof(WorkStealingQueue), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueueThreadLocals), typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181508110")]
		[Calls(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001288")]
		private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

	}

	[Token(Token = "0x4000A42")]
	internal static SparseArray<WorkStealingQueue> allThreadQueues; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A40")]
	internal QueueSegment queueHead; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A41")]
	internal QueueSegment queueTail; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A43")]
	private int numOutstandingThreadRequests; //Field offset: 0x20

	[Address(RVA = "0x151A980", Offset = "0x1519B80", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SparseArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600127F")]
	private static ThreadPoolWorkQueue() { }

	[Address(RVA = "0x151AA10", Offset = "0x1519C10", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(QueueSegment), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001277")]
	public ThreadPoolWorkQueue() { }

	[Address(RVA = "0x1519F70", Offset = "0x1519170", Length = "0x20F")]
	[CalledBy(Type = "System.Console+WindowsConsole", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WorkStealingQueue), Member = "LocalPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(QueueSegment), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QueueSegment), Member = "IsUsedUp", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SparseArray`1), Member = "get_Current", ReturnType = "T[]")]
	[Calls(Type = typeof(WorkStealingQueue), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&), typeof(Boolean&), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600127D")]
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	[Address(RVA = "0x151A180", Offset = "0x1519380", Length = "0x4B5")]
	[CalledBy(Type = typeof(_ThreadPoolWaitCallback), Member = "PerformWaitCallback", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ThreadPoolWorkQueue), Member = "EnsureThreadRequested", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadPool), Member = "NotifyWorkItemComplete", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181508370")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600127E")]
	internal static bool Dispatch() { }

	[Address(RVA = "0x151A640", Offset = "0x1519840", Length = "0x149")]
	[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(WorkStealingQueue), Member = "LocalPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadPoolWorkQueue), Member = "EnsureThreadRequested", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(QueueSegment), Member = "TryEnqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(QueueSegment), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600127B")]
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	[Address(RVA = "0x151A790", Offset = "0x1519990", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001278")]
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	[Address(RVA = "0x151A830", Offset = "0x1519A30", Length = "0x9B")]
	[CalledBy(Type = "System.Console+WindowsConsole", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dispatch", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThreadPool), Member = "RequestWorkerThread", ReturnType = typeof(bool))]
	[Token(Token = "0x6001279")]
	internal void EnsureThreadRequested() { }

	[Address(RVA = "0x151A8D0", Offset = "0x1519AD0", Length = "0x5F")]
	[CalledBy(Type = typeof(ThreadPool), Member = "TryPopCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(WorkStealingQueue), Member = "LocalFindAndPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600127C")]
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	[Address(RVA = "0x151A930", Offset = "0x1519B30", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x600127A")]
	internal void MarkThreadRequestSatisfied() { }

}

