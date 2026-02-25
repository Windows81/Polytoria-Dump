namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(QueueDebugView`1))]
[Token(Token = "0x20005EE")]
[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
public class Queue : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[Token(Token = "0x20005EF")]
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400187B")]
		private readonly Queue<T> _q; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400187C")]
		private readonly int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400187D")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400187E")]
		private T _currentElement; //Field offset: 0x0

		[Token(Token = "0x170006D7")]
		public override T Current
		{
			[Address(RVA = "0xAE5CA0", Offset = "0xAE4EA0", Length = "0x44")]
			[CalledBy(Type = "Mirror.HistoryBounds", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bounds"}, ReturnType = typeof(void))]
			[CalledBy(Type = "Mirror.GUIConsole", Member = "OnGUI", ReturnType = typeof(void))]
			[CalledBy(Type = "Telepathy.MagnificentSendPipe", Member = "DequeueAndSerializeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]&", typeof(Int32&)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BA0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800790A0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002B9A")]
			 get { } //Length: 68
		}

		[Token(Token = "0x170006D8")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xAE50C0", Offset = "0xAE42C0", Length = "0x99")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BA0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800790A0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002B9C")]
			private get { } //Length: 153
		}

		[Address(RVA = "0xAE5710", Offset = "0xAE4910", Length = "0x41")]
		[CalledBy(Type = typeof(Queue`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Queue`1<T>+Enumerator<T>")]
		[CalledBy(Type = typeof(Queue`1), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CalledBy(Type = typeof(Queue`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B97")]
		internal Enumerator(Queue<T> q) { }

		[Address(RVA = "0xAE34D0", Offset = "0xAE26D0", Length = "0xF")]
		[CalledBy(Type = "Mirror.HistoryBounds", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bounds"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.GUIConsole", Member = "OnGUI", ReturnType = typeof(void))]
		[CalledBy(Type = "Telepathy.MagnificentSendPipe", Member = "DequeueAndSerializeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]&", typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B98")]
		public override void Dispose() { }

		[Address(RVA = "0xAE5CA0", Offset = "0xAE4EA0", Length = "0x44")]
		[CalledBy(Type = "Mirror.HistoryBounds", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bounds"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.GUIConsole", Member = "OnGUI", ReturnType = typeof(void))]
		[CalledBy(Type = "Telepathy.MagnificentSendPipe", Member = "DequeueAndSerializeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]&", typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800790A0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B9A")]
		public override T get_Current() { }

		[Address(RVA = "0xAE3900", Offset = "0xAE2B00", Length = "0xEB")]
		[CalledBy(Type = "Mirror.GUIConsole", Member = "OnGUI", ReturnType = typeof(void))]
		[CalledBy(Type = "Telepathy.MagnificentSendPipe", Member = "DequeueAndSerializeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]&", typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B99")]
		public override bool MoveNext() { }

		[Address(RVA = "0xAE50C0", Offset = "0xAE42C0", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800790A0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B9C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xAE4E90", Offset = "0xAE4090", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B9D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0xAE5430", Offset = "0xAE4630", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B9B")]
		private void ThrowEnumerationNotStartedOrEnded() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001875")]
	private T[] _array; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001876")]
	private int _head; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001877")]
	private int _tail; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001878")]
	private int _size; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001879")]
	private int _version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400187A")]
	private object _syncRoot; //Field offset: 0x0

	[Token(Token = "0x170006D5")]
	public override int Count
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B87")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170006D6")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xEB9720", Offset = "0xEB8920", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B88")]
		private get { } //Length: 104
	}

	[Address(RVA = "0xEB9DF0", Offset = "0xEB8FF0", Length = "0x44")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B85")]
	public Queue`1() { }

	[Address(RVA = "0xEB9D00", Offset = "0xEB8F00", Length = "0xE4")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B86")]
	public Queue`1(int capacity) { }

	[Address(RVA = "0xEB7C50", Offset = "0xEB6E50", Length = "0x6F")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "InitInputProcessor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Batcher", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.HistoryBounds", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpPeer", Member = "HandleChoked", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Accessibility.AccessibilityManager", Member = "Internal_Update", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B89")]
	public void Clear() { }

	[Address(RVA = "0xEB8150", Offset = "0xEB7350", Length = "0x122")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B92")]
	public bool Contains(T item) { }

	[Address(RVA = "0xEB8550", Offset = "0xEB7750", Length = "0xD2")]
	[CalledBy(Type = "Telepathy.MagnificentReceivePipe", Member = "TryDequeue", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatcher", Member = "ProcessEventQueue", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerationDeferrer", Member = "ProcessDeferredWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.ImageSky", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.GUIConsole", Member = "OnLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "UnityEngine.LogType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.MagnificentReceivePipe", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.MagnificentSendPipe", Member = "DequeueAndSerializeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]&", typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Telepathy.MagnificentSendPipe", Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F1730")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B8F")]
	public T Dequeue() { }

	[Address(RVA = "0xEB8890", Offset = "0xEB7A90", Length = "0x1A1")]
	[CalledBy(Type = "Polytoria.Datamodel.ImageSky", Member = "Apply", ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.MagnificentSendPipe", Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.MagnificentReceivePipe", Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Telepathy.EventType", "System.ArraySegment`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.GUIConsole", Member = "OnLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "UnityEngine.LogType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController", Member = "LoadMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.MeshPartLoadRequest"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.ImageSky", Member = "set_BackId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.ImageSky", Member = "set_FrontId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.ImageSky", Member = "set_RightId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.ImageSky", Member = "set_LeftId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.ImageSky", Member = "set_BottomId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.ImageSky", Member = "set_TopId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerationDeferrer", Member = "AddMeshGenerationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerationCallback", typeof(object), "UnityEngine.UIElements.MeshGenerationCallbackType", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatcher", Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.BaseVisualElementPanel", "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B8B")]
	public void Enqueue(T item) { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B87")]
	public override int get_Count() { }

	[Address(RVA = "0xEB8E60", Offset = "0xEB8060", Length = "0x30")]
	[CalledBy(Type = "Mirror.HistoryBounds", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bounds"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.GUIConsole", Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.MagnificentSendPipe", Member = "DequeueAndSerializeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]&", typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Queue`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B8C")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xEB8ED0", Offset = "0xEB80D0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B95")]
	private void MoveNext(ref int index) { }

	[Address(RVA = "0xEB8F00", Offset = "0xEB8100", Length = "0x64")]
	[CalledBy(Type = "Telepathy.MagnificentReceivePipe", Member = "TryPeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), "Telepathy.EventType&", "System.ArraySegment`1<Byte>&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F1730")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B91")]
	public T Peek() { }

	[Address(RVA = "0xEB9050", Offset = "0xEB8250", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B94")]
	private void SetCapacity(int capacity) { }

	[Address(RVA = "0xEB9150", Offset = "0xEB8350", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Queue`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B8D")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xEB9330", Offset = "0xEB8530", Length = "0x302")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B8A")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0xEB9720", Offset = "0xEB8920", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B88")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xEB9150", Offset = "0xEB8350", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Queue`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B8E")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xEB9800", Offset = "0xEB8A00", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B96")]
	private void ThrowForEmptyQueue() { }

	[Address(RVA = "0xEB9850", Offset = "0xEB8A50", Length = "0xE3")]
	[CalledBy(Type = "UnityEngine.Accessibility.AccessibilityManager", Member = "Internal_Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B93")]
	public T[] ToArray() { }

	[Address(RVA = "0xEB9AE0", Offset = "0xEB8CE0", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B90")]
	public bool TryDequeue(out T result) { }

}

