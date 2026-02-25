namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView`1))]
[Token(Token = "0x20005BC")]
public class ConcurrentQueue : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[CompilerGenerated]
	[Token(Token = "0x20005BF")]
	private sealed class <Enumerate>d__28 : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001810")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001811")]
		private T <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001812")]
		public Segment<T> head; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001813")]
		public Segment<T> tail; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001814")]
		public int tailTail; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001815")]
		public int headHead; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001816")]
		public ConcurrentQueue<T> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001817")]
		private int <headTail>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001818")]
		private int <i>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001819")]
		private Segment<T> <s>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400181A")]
		private int <i>5__5; //Field offset: 0x0

		[Token(Token = "0x1700067E")]
		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Address(RVA = "0x7F8A80", Offset = "0x7F7C80", Length = "0x13")]
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A07")]
			private get { } //Length: 19
		}

		[Token(Token = "0x1700067F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x7F8BE0", Offset = "0x7F7DE0", Length = "0x34")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A09")]
			private get { } //Length: 52
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A04")]
		public <Enumerate>d__28(int <>1__state) { }

		[Address(RVA = "0x7F7DC0", Offset = "0x7F6FC0", Length = "0x410")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(Segment), Member = "get_FreezeOffset", ReturnType = typeof(int))]
		[Calls(Type = typeof(ConcurrentQueue`1), Member = "GetItemWhenAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A06")]
		private override bool MoveNext() { }

		[Address(RVA = "0x7F8A80", Offset = "0x7F7C80", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A07")]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[Address(RVA = "0x7F8BE0", Offset = "0x7F7DE0", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A09")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A08")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A05")]
		private override void System.IDisposable.Dispose() { }

	}

	[DebuggerDisplay("Capacity = {Capacity}")]
	[Token(Token = "0x20005BD")]
	public sealed class Segment
	{
		[DebuggerDisplay("Item = {Item}, SequenceNumber = {SequenceNumber}")]
		[Token(Token = "0x20005BE")]
		public struct Slot
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400180E")]
			public T Item; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400180F")]
			public int SequenceNumber; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001808")]
		internal readonly Slot<T>[] _slots; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001809")]
		internal readonly int _slotsMask; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400180A")]
		internal PaddedHeadAndTail _headAndTail; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400180B")]
		internal bool _preservedForObservation; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400180C")]
		internal bool _frozenForEnqueues; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400180D")]
		internal Segment<T> _nextSegment; //Field offset: 0x0

		[Token(Token = "0x1700067C")]
		internal int Capacity
		{
			[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
			[CallerCount(Count = 83)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x60029FF")]
			internal get { } //Length: 26
		}

		[Token(Token = "0x1700067D")]
		internal int FreezeOffset
		{
			[Address(RVA = "0xF0FE60", Offset = "0xF0F060", Length = "0x1C")]
			[CalledBy(Type = "System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__28", Member = "MoveNext", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "ToArray", ReturnType = "T[]")]
			[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int), typeof(int)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int), "System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int)}, ReturnType = typeof(long))]
			[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
			[CallerCount(Count = 13)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A00")]
			internal get { } //Length: 28
		}

		[Address(RVA = "0xF0F970", Offset = "0xF0EB70", Length = "0xB7")]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "EnqueueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "Clear", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60029FE")]
		public Segment(int boundedLength) { }

		[Address(RVA = "0xF0DBD0", Offset = "0xF0CDD0", Length = "0xC8")]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "SnapForObservation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Segment<T>&", typeof(Int32&), "Segment<T>&", typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "EnqueueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "Clear", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A01")]
		internal void EnsureFrozenForEnqueues() { }

		[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60029FF")]
		internal int get_Capacity() { }

		[Address(RVA = "0xF0FE60", Offset = "0xF0F060", Length = "0x1C")]
		[CalledBy(Type = "System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__28", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "ToArray", ReturnType = "T[]")]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int), "System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A00")]
		internal int get_FreezeOffset() { }

		[Address(RVA = "0xF0E390", Offset = "0xF0D590", Length = "0x1E4")]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "TryDequeueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A02")]
		public bool TryDequeue(out T item) { }

		[Address(RVA = "0xF0ED30", Offset = "0xF0DF30", Length = "0x168")]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "EnqueueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A03")]
		public bool TryEnqueue(T item) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001805")]
	private object _crossSegmentLock; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001806")]
	private Segment<T> _tail; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001807")]
	private Segment<T> _head; //Field offset: 0x0

	[Token(Token = "0x1700067B")]
	public override int Count
	{
		[Address(RVA = "0x9DC910", Offset = "0x9DBB10", Length = "0x358")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800518D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[Calls(Type = typeof(ConcurrentQueue`1), Member = "SnapForObservation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Segment<T>&", typeof(Int32&), "Segment<T>&", typeof(Int32&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ConcurrentQueue`1), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int), "System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60029F1")]
		 get { } //Length: 856
	}

	[Token(Token = "0x1700067A")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x9B6380", Offset = "0x9B5580", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60029EE")]
		private get { } //Length: 73
	}

	[Address(RVA = "0x9DAD50", Offset = "0x9D9F50", Length = "0xE4")]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Segment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60029EC")]
	public ConcurrentQueue`1() { }

	[Address(RVA = "0x9D0CD0", Offset = "0x9CFED0", Length = "0x136")]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Segment), Member = "EnsureFrozenForEnqueues", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Segment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029FD")]
	public void Clear() { }

	[Address(RVA = "0x9D29E0", Offset = "0x9D1BE0", Length = "0x4CF")]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180051550")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Segment), Member = "get_FreezeOffset", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "SnapForObservation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Segment<T>&", typeof(Int32&), "Segment<T>&", typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60029F4")]
	public override void CopyTo(T[] array, int index) { }

	[Address(RVA = "0x9D4EA0", Offset = "0x9D40A0", Length = "0xA9")]
	[CalledBy(Type = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1", Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "EnqueueClientMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.ClientMainEventType", typeof(object), "System.Nullable`1<Int32>", "System.Nullable`1<TransportError>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Segment), Member = "TryEnqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "EnqueueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029F9")]
	public void Enqueue(T item) { }

	[Address(RVA = "0x9D3960", Offset = "0x9D2B60", Length = "0x241")]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Segment), Member = "EnsureFrozenForEnqueues", ReturnType = typeof(void))]
	[Calls(Type = typeof(Segment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Segment), Member = "TryEnqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60029FA")]
	private void EnqueueSlow(T item) { }

	[Address(RVA = "0x9D5000", Offset = "0x9D4200", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<Enumerate>d__28))]
	[Token(Token = "0x60029F8")]
	private IEnumerator<T> Enumerate(Segment<T> head, int headHead, Segment<T> tail, int tailTail) { }

	[Address(RVA = "0x9DC910", Offset = "0x9DBB10", Length = "0x358")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800518D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "SnapForObservation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Segment<T>&", typeof(Int32&), "Segment<T>&", typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int), "System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029F1")]
	public override int get_Count() { }

	[Address(RVA = "0x9D5870", Offset = "0x9D4A70", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Segment), Member = "get_FreezeOffset", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029F2")]
	private static int GetCount(Segment<T> s, int head, int tail) { }

	[Address(RVA = "0x9D5920", Offset = "0x9D4B20", Length = "0x170")]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "get_Count", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Segment), Member = "get_FreezeOffset", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029F3")]
	private static long GetCount(Segment<T> head, int headHead, Segment<T> tail, int tailTail) { }

	[Address(RVA = "0x9D5E90", Offset = "0x9D5090", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "SnapForObservation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Segment<T>&", typeof(Int32&), "Segment<T>&", typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180051550")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029F5")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0x9D6260", Offset = "0x9D5460", Length = "0x127")]
	[CalledBy(Type = typeof(<Enumerate>d__28), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029F7")]
	private T GetItemWhenAvailable(Segment<T> segment, int i) { }

	[Address(RVA = "0x9D6DC0", Offset = "0x9D5FC0", Length = "0x17F")]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "ToArray", ReturnType = "T[]")]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Segment), Member = "EnsureFrozenForEnqueues", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029F6")]
	private void SnapForObservation(out Segment<T> head, out int headHead, out Segment<T> tail, out int tailTail) { }

	[Address(RVA = "0x9D7640", Offset = "0x9D6840", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029ED")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x9B6380", Offset = "0x9B5580", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029EE")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x9D7D40", Offset = "0x9D6F40", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029EF")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x9D8970", Offset = "0x9D7B70", Length = "0x429")]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Segment), Member = "get_FreezeOffset", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "SnapForObservation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Segment<T>&", typeof(Int32&), "Segment<T>&", typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180051550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60029F0")]
	public override T[] ToArray() { }

	[Address(RVA = "0x9DACC0", Offset = "0x9D9EC0", Length = "0x87")]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "ClientEarlyUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Segment), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "TryDequeueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029FB")]
	public bool TryDequeue(out T result) { }

	[Address(RVA = "0x9DA780", Offset = "0x9D9980", Length = "0x149")]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Segment), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003B80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029FC")]
	private bool TryDequeueSlow(out T item) { }

}

