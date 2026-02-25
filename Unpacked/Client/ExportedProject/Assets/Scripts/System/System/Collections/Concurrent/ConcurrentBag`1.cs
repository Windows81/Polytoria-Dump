namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView`1))]
[Token(Token = "0x20001B0")]
public class ConcurrentBag : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[Token(Token = "0x20001B2")]
	private sealed class Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A8")]
		private readonly T[] _array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A9")]
		private T _current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006AA")]
		private int _index; //Field offset: 0x0

		[Token(Token = "0x170001FC")]
		public override T Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000A8A")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170001FD")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xB0FEE0", Offset = "0xB0F0E0", Length = "0x77")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000A8B")]
			private get { } //Length: 119
		}

		[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A88")]
		public Enumerator(T[] array) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A8D")]
		public override void Dispose() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A8A")]
		public override T get_Current() { }

		[Address(RVA = "0xB0BFB0", Offset = "0xB0B1B0", Length = "0x5C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A89")]
		public override bool MoveNext() { }

		[Address(RVA = "0xB0EF20", Offset = "0xB0E120", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A8C")]
		public override void Reset() { }

		[Address(RVA = "0xB0FEE0", Offset = "0xB0F0E0", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A8B")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x20001B1")]
	private sealed class WorkStealingQueue
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400069E")]
		private int _headIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400069F")]
		private int _tailIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A0")]
		private T[] _array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A1")]
		private int _mask; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A2")]
		private int _addTakeCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A3")]
		private int _stealCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A4")]
		internal int _currentOp; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A5")]
		internal bool _frozen; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A6")]
		internal readonly WorkStealingQueue<T> _nextQueue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A7")]
		internal readonly int _ownerThreadId; //Field offset: 0x0

		[Token(Token = "0x170001FB")]
		internal int DangerousCount
		{
			[Address(RVA = "0x93A730", Offset = "0x939930", Length = "0x7")]
			[CalledBy(Type = typeof(ConcurrentBag`1), Member = "get_DangerousCount", ReturnType = typeof(int))]
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000A87")]
			internal get { } //Length: 7
		}

		[Address(RVA = "0x93A690", Offset = "0x939890", Length = "0x98")]
		[CalledBy(Type = typeof(ConcurrentBag`1), Member = "CreateWorkStealingQueueForCurrentThread", ReturnType = "System.Collections.Concurrent.ConcurrentBag`1<T>+WorkStealingQueue<T>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A82")]
		internal WorkStealingQueue(WorkStealingQueue<T> nextQueue) { }

		[Address(RVA = "0x939A90", Offset = "0x938C90", Length = "0xC9")]
		[CalledBy(Type = typeof(ConcurrentBag`1), Member = "CopyFromEachQueueToArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A86")]
		internal int DangerousCopyTo(T[] array, int arrayIndex) { }

		[Address(RVA = "0x93A730", Offset = "0x939930", Length = "0x7")]
		[CalledBy(Type = typeof(ConcurrentBag`1), Member = "get_DangerousCount", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A87")]
		internal int get_DangerousCount() { }

		[Address(RVA = "0x939B60", Offset = "0x938D60", Length = "0x583")]
		[CalledBy(Type = typeof(ConcurrentBag`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180928670")]
		[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A83")]
		internal void LocalPush(T item, ref long emptyToNonEmptyListTransitionCount) { }

		[Address(RVA = "0x93A0F0", Offset = "0x9392F0", Length = "0x2F4")]
		[CalledBy(Type = typeof(ConcurrentBag`1), Member = "TryTake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180928670")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A84")]
		internal bool TryLocalPop(out T result) { }

		[Address(RVA = "0x93A3F0", Offset = "0x9395F0", Length = "0x296")]
		[CalledBy(Type = typeof(ConcurrentBag`1), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ConcurrentBag`1), Member = "TryStealFromTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentBag`1<T>+WorkStealingQueue<T>", "System.Collections.Concurrent.ConcurrentBag`1<T>+WorkStealingQueue<T>", "T&", typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A85")]
		internal bool TrySteal(out T result, bool take) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400069B")]
	private readonly ThreadLocal<WorkStealingQueue<T>> _locals; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400069C")]
	private WorkStealingQueue<T> _workStealingQueues; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400069D")]
	private long _emptyToNonEmptyListTransitionCount; //Field offset: 0x0

	[Token(Token = "0x170001F7")]
	public override int Count
	{
		[Address(RVA = "0x9B7030", Offset = "0x9B6230", Length = "0xDB")]
		[CalledBy(Type = "Mirror.ConcurrentPool`1", Member = "get_Count", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800504F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800505E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1809B0550")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A7C")]
		 get { } //Length: 219
	}

	[Token(Token = "0x170001F8")]
	private int DangerousCount
	{
		[Address(RVA = "0x9B7230", Offset = "0x9B6430", Length = "0x8A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(WorkStealingQueue), Member = "get_DangerousCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A7D")]
		private get { } //Length: 138
	}

	[Token(Token = "0x170001FA")]
	private object GlobalQueuesLock
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A7F")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170001F9")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x9B6380", Offset = "0x9B5580", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A7E")]
		private get { } //Length: 73
	}

	[Address(RVA = "0x9B6FB0", Offset = "0x9B61B0", Length = "0x7C")]
	[CalledBy(Type = "Mirror.ConcurrentPool`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ThreadLocal`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A6E")]
	public ConcurrentBag`1() { }

	[Address(RVA = "0x9B5110", Offset = "0x9B4310", Length = "0xA4")]
	[CalledBy(Type = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1", Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
	[CalledBy(Type = "Mirror.ConcurrentNetworkWriterPool", Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.ConcurrentNetworkWriterPooled"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ConcurrentNetworkWriterPooled", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ConcurrentPool`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ConcurrentPool`1", Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "ClientEarlyUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "ServerEarlyUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "CreateWorkStealingQueueForCurrentThread", ReturnType = "System.Collections.Concurrent.ConcurrentBag`1<T>+WorkStealingQueue<T>")]
	[Calls(Type = typeof(WorkStealingQueue), Member = "LocalPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Int64&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A6F")]
	public void Add(T item) { }

	[Address(RVA = "0x9B52D0", Offset = "0x9B44D0", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(WorkStealingQueue), Member = "DangerousCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A77")]
	private int CopyFromEachQueueToArray(T[] array, int index) { }

	[Address(RVA = "0x9B56F0", Offset = "0x9B48F0", Length = "0x296")]
	[CalledBy(Type = typeof(ConcurrentBag`1), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1809B0550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050460")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800505E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800504F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A76")]
	public override void CopyTo(T[] array, int index) { }

	[Address(RVA = "0x9B5990", Offset = "0x9B4B90", Length = "0x16E")]
	[CalledBy(Type = typeof(ConcurrentBag`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentBag`1), Member = "GetCurrentThreadWorkStealingQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Collections.Concurrent.ConcurrentBag`1<T>+WorkStealingQueue<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WorkStealingQueue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentBag`1<T>+WorkStealingQueue<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThreadLocal`1), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A72")]
	private WorkStealingQueue<T> CreateWorkStealingQueueForCurrentThread() { }

	[Address(RVA = "0x9B5DC0", Offset = "0x9B4FC0", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Interlocked), Member = "MemoryBarrier", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A80")]
	private void FreezeBag(ref bool lockTaken) { }

	[Address(RVA = "0x9B7030", Offset = "0x9B6230", Length = "0xDB")]
	[CalledBy(Type = "Mirror.ConcurrentPool`1", Member = "get_Count", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800504F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800505E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1809B0550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A7C")]
	public override int get_Count() { }

	[Address(RVA = "0x9B7230", Offset = "0x9B6430", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(WorkStealingQueue), Member = "get_DangerousCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A7D")]
	private int get_DangerousCount() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A7F")]
	private object get_GlobalQueuesLock() { }

	[Address(RVA = "0x9B5EB0", Offset = "0x9B50B0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "CreateWorkStealingQueueForCurrentThread", ReturnType = "System.Collections.Concurrent.ConcurrentBag`1<T>+WorkStealingQueue<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A71")]
	private WorkStealingQueue<T> GetCurrentThreadWorkStealingQueue(bool forceCreate) { }

	[Address(RVA = "0x9B5FD0", Offset = "0x9B51D0", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A7A")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0x9B60F0", Offset = "0x9B52F0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A73")]
	private WorkStealingQueue<T> GetUnownedWorkStealingQueue() { }

	[Address(RVA = "0x9B6260", Offset = "0x9B5460", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A78")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x9B6380", Offset = "0x9B5580", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A7E")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x9B63D0", Offset = "0x9B55D0", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A7B")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x9B6650", Offset = "0x9B5850", Length = "0x1AB")]
	[CalledBy(Type = typeof(ConcurrentBag`1), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentBag`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[CalledBy(Type = typeof(ConcurrentBag`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800504F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050460")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800505E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1809B0550")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A79")]
	public override T[] ToArray() { }

	[Address(RVA = "0x9B6B00", Offset = "0x9B5D00", Length = "0x27D")]
	[CalledBy(Type = typeof(ConcurrentBag`1), Member = "TryTake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CDSCollectionETWBCLProvider), Member = "ConcurrentBag_TryPeekSteals", ReturnType = typeof(void))]
	[Calls(Type = typeof(CDSCollectionETWBCLProvider), Member = "ConcurrentBag_TryTakeSteals", ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(WorkStealingQueue), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A74")]
	private bool TrySteal(out T result, bool take) { }

	[Address(RVA = "0x9B6800", Offset = "0x9B5A00", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WorkStealingQueue), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A75")]
	private bool TryStealFromTo(WorkStealingQueue<T> startInclusive, WorkStealingQueue<T> endExclusive, out T result, bool take) { }

	[Address(RVA = "0x9B6D80", Offset = "0x9B5F80", Length = "0xAE")]
	[CalledBy(Type = "Mirror.ConcurrentNetworkWriterPool", Member = "Get", ReturnType = "Mirror.ConcurrentNetworkWriterPooled")]
	[CalledBy(Type = "Mirror.ConcurrentPool`1", Member = "Get", ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(WorkStealingQueue), Member = "TryLocalPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A70")]
	public override bool TryTake(out T result) { }

	[Address(RVA = "0x9B6ED0", Offset = "0x9B60D0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A81")]
	private void UnfreezeBag(bool lockTaken) { }

}

