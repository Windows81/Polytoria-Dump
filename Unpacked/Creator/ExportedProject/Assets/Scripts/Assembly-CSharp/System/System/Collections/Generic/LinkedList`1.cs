namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[Token(Token = "0x20001B9")]
public class LinkedList : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	[Token(Token = "0x20001BA")]
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006BA")]
		private LinkedList<T> _list; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006BB")]
		private LinkedListNode<T> _node; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006BC")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006BD")]
		private T _current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006BE")]
		private int _index; //Field offset: 0x0

		[Token(Token = "0x17000205")]
		public override T Current
		{
			[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000ABD")]
			 get { } //Length: 11
		}

		[Token(Token = "0x17000206")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xB06F80", Offset = "0xB06180", Length = "0xD4")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000ABE")]
			private get { } //Length: 212
		}

		[Address(RVA = "0xB078C0", Offset = "0xB06AC0", Length = "0x52")]
		[CalledBy(Type = typeof(LinkedList`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.LinkedList`1<T>+Enumerator<T>")]
		[CalledBy(Type = typeof(LinkedList`1), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CalledBy(Type = typeof(LinkedList`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABB")]
		internal Enumerator(LinkedList<T> list) { }

		[Address(RVA = "0xAE53F0", Offset = "0xAE45F0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABC")]
		private Enumerator(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AC1")]
		public override void Dispose() { }

		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABD")]
		public override T get_Current() { }

		[Address(RVA = "0xB01280", Offset = "0xB00480", Length = "0x11E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABF")]
		public override bool MoveNext() { }

		[Address(RVA = "0xB06F80", Offset = "0xB06180", Length = "0xD4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xB056D0", Offset = "0xB048D0", Length = "0x94")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AC0")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0xAE53B0", Offset = "0xAE45B0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AC3")]
		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		[Address(RVA = "0xAE53F0", Offset = "0xAE45F0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AC2")]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	[Token(Token = "0x40006B7")]
	private const string VersionName = "Version"; //Field offset: 0x0
	[Token(Token = "0x40006B8")]
	private const string CountName = "Count"; //Field offset: 0x0
	[Token(Token = "0x40006B9")]
	private const string ValuesName = "Data"; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006B2")]
	internal LinkedListNode<T> head; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006B3")]
	internal int count; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006B4")]
	internal int version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006B5")]
	private object _syncRoot; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006B6")]
	private SerializationInfo _siInfo; //Field offset: 0x0

	[Token(Token = "0x17000200")]
	public override int Count
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A9D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000201")]
	public LinkedListNode<T> First
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A9E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000202")]
	public LinkedListNode<T> Last
	{
		[Address(RVA = "0xCF3B70", Offset = "0xCF2D70", Length = "0x13")]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandlePermanentCache", Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "RecycleTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "DataBind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "SetNextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "SetPrevSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "LastContainer", ReturnType = "UnityEngine.RectTransform")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A9F")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000203")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA0")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000204")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xCF36F0", Offset = "0xCF28F0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB8")]
		private get { } //Length: 104
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9B")]
	public LinkedList`1() { }

	[Address(RVA = "0x595670", Offset = "0x594870", Length = "0x31")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9C")]
	protected LinkedList`1(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0xCEBC80", Offset = "0xCEAE80", Length = "0x194")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA2")]
	public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value) { }

	[Address(RVA = "0xCEC4A0", Offset = "0xCEB6A0", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA3")]
	public LinkedListNode<T> AddFirst(T value) { }

	[Address(RVA = "0xCEC800", Offset = "0xCEBA00", Length = "0x180")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandlePermanentCache", Member = "RemoveTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "RefreshCaching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "RecycleTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA4")]
	public void AddFirst(LinkedListNode<T> node) { }

	[Address(RVA = "0xCECD60", Offset = "0xCEBF60", Length = "0x162")]
	[CalledBy(Type = typeof(TimerThread), Member = "ThreadProc", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "RemoveTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(bool), typeof(Boolean&)}, ReturnType = "UnityEngine.IMGUITextHandle")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA6")]
	public void AddLast(LinkedListNode<T> node) { }

	[Address(RVA = "0xCECED0", Offset = "0xCEC0D0", Length = "0x10F")]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup", typeof(WebOperation)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA5")]
	public LinkedListNode<T> AddLast(T value) { }

	[Address(RVA = "0xCED550", Offset = "0xCEC750", Length = "0xAD")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Table", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "ClearTemporaryCache", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "EmptyManagedCache", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA7")]
	public override void Clear() { }

	[Address(RVA = "0xCED690", Offset = "0xCEC890", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LinkedList`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA8")]
	public override bool Contains(T value) { }

	[Address(RVA = "0xCEDAC0", Offset = "0xCECCC0", Length = "0x211")]
	[CalledBy(Type = typeof(LinkedList`1), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LinkedList`1), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA9")]
	public override void CopyTo(T[] array, int index) { }

	[Address(RVA = "0xCEEA40", Offset = "0xCEDC40", Length = "0x1A1")]
	[CalledBy(Type = typeof(LinkedList`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.ValueTuple`2<System.Object, System.Object>>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.ValueTuple`2<System.Object, System.Object>>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAA")]
	public LinkedListNode<T> Find(T value) { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9D")]
	public override int get_Count() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9E")]
	public LinkedListNode<T> get_First() { }

	[Address(RVA = "0xCF3B70", Offset = "0xCF2D70", Length = "0x13")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandlePermanentCache", Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "RecycleTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "DataBind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "SetNextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "SetPrevSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "LastContainer", ReturnType = "UnityEngine.RectTransform")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9F")]
	public LinkedListNode<T> get_Last() { }

	[Address(RVA = "0xCEF000", Offset = "0xCEE200", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedList`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAB")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xCEF250", Offset = "0xCEE450", Length = "0x183")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(LinkedList`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB1")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0xCEFBE0", Offset = "0xCEEDE0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB3")]
	private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) { }

	[Address(RVA = "0xCEFC70", Offset = "0xCEEE70", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB4")]
	private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode) { }

	[Address(RVA = "0xCEFDB0", Offset = "0xCEEFB0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB5")]
	internal void InternalRemoveNode(LinkedListNode<T> node) { }

	[Address(RVA = "0xCF03B0", Offset = "0xCEF5B0", Length = "0x30B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB2")]
	public override void OnDeserialization(object sender) { }

	[Address(RVA = "0xCF1590", Offset = "0xCF0790", Length = "0x6B")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LinkedList`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CE3C0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAD")]
	public override bool Remove(T value) { }

	[Address(RVA = "0xCF1600", Offset = "0xCF0800", Length = "0xB3")]
	[CalledBy(Type = "TMPro.FastAction`2", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<A, B>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(bool), typeof(Boolean&)}, ReturnType = "UnityEngine.IMGUITextHandle")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "RefreshCaching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "RemoveTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.FastAction`3", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`3<A, B, C>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.FastAction`1", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<A>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.FastAction", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "RemoveOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "GetNextOperation", ReturnType = typeof(WebOperation))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimerThread), Member = "ThreadProc", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CE3C0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAE")]
	public void Remove(LinkedListNode<T> node) { }

	[Address(RVA = "0xCF12A0", Offset = "0xCF04A0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "ProcessDeviceFreeQueue", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ClearUnusedTextHandles", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CE3C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAF")]
	public void RemoveFirst() { }

	[Address(RVA = "0xCF13A0", Offset = "0xCF05A0", Length = "0x7A")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandlePermanentCache", Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "RecycleTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "DataBind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "SetNextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "SetPrevSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CE3C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB0")]
	public void RemoveLast() { }

	[Address(RVA = "0xCF1990", Offset = "0xCF0B90", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CDF60")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA1")]
	private override void System.Collections.Generic.ICollection<T>.Add(T value) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA0")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0xCF1AE0", Offset = "0xCF0CE0", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedList`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAC")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xCF2A00", Offset = "0xCF1C00", Length = "0x3FF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LinkedList`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB9")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0xCF36F0", Offset = "0xCF28F0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB8")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xCF1AE0", Offset = "0xCF0CE0", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedList`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ABA")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xCF38B0", Offset = "0xCF2AB0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB6")]
	internal void ValidateNewNode(LinkedListNode<T> node) { }

	[Address(RVA = "0xCF3A10", Offset = "0xCF2C10", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB7")]
	internal void ValidateNode(LinkedListNode<T> node) { }

}

