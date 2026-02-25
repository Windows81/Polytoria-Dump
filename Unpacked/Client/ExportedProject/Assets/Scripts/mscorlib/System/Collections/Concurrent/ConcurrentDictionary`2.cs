namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
[Token(Token = "0x20005C2")]
public class ConcurrentDictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>
{
	[CompilerGenerated]
	[Token(Token = "0x20005C6")]
	private sealed class <GetEnumerator>d__35 : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400182E")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400182F")]
		private KeyValuePair<TKey, TValue> <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001830")]
		public ConcurrentDictionary<TKey, TValue> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001831")]
		private Node<TKey, TValue>[] <buckets>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001832")]
		private int <i>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001833")]
		private Node<TKey, TValue> <current>5__4; //Field offset: 0x0

		[Token(Token = "0x1700068E")]
		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current
		{
			[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A55")]
			private get { } //Length: 11
		}

		[Token(Token = "0x1700068F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x811930", Offset = "0x810B30", Length = "0x2B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A57")]
			private get { } //Length: 43
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A52")]
		public <GetEnumerator>d__35(int <>1__state) { }

		[Address(RVA = "0x811720", Offset = "0x810920", Length = "0x152")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A54")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A55")]
		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }

		[Address(RVA = "0x811930", Offset = "0x810B30", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A57")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A56")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A53")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20005C5")]
	private sealed class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400182D")]
		private IEnumerator<KeyValuePair`2<TKey, TValue>> _enumerator; //Field offset: 0x0

		[Token(Token = "0x1700068D")]
		public override object Current
		{
			[Address(RVA = "0x9E7AE0", Offset = "0x9E6CE0", Length = "0x6F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A4F")]
			 get { } //Length: 111
		}

		[Token(Token = "0x1700068A")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x9E7D00", Offset = "0x9E6F00", Length = "0x1D2")]
			[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Current", ReturnType = typeof(object))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A4C")]
			 get { } //Length: 466
		}

		[Token(Token = "0x1700068B")]
		public override object Key
		{
			[Address(RVA = "0x9E8520", Offset = "0x9E7720", Length = "0xDE")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A4D")]
			 get { } //Length: 222
		}

		[Token(Token = "0x1700068C")]
		public override object Value
		{
			[Address(RVA = "0x9E8600", Offset = "0x9E7800", Length = "0xAB")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A4E")]
			 get { } //Length: 171
		}

		[Address(RVA = "0x9E78C0", Offset = "0x9E6AC0", Length = "0x5F")]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.IDictionary.GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A4B")]
		internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary) { }

		[Address(RVA = "0x9E7AE0", Offset = "0x9E6CE0", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A4F")]
		public override object get_Current() { }

		[Address(RVA = "0x9E7D00", Offset = "0x9E6F00", Length = "0x1D2")]
		[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Current", ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A4C")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x9E8520", Offset = "0x9E7720", Length = "0xDE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A4D")]
		public override object get_Key() { }

		[Address(RVA = "0x9E8600", Offset = "0x9E7800", Length = "0xAB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A4E")]
		public override object get_Value() { }

		[Address(RVA = "0x9E7690", Offset = "0x9E6890", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A50")]
		public override bool MoveNext() { }

		[Address(RVA = "0x9E7780", Offset = "0x9E6980", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A51")]
		public override void Reset() { }

	}

	[Token(Token = "0x20005C4")]
	private sealed class Node
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001829")]
		internal readonly TKey _key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400182A")]
		internal TValue _value; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400182B")]
		internal Node<TKey, TValue> _next; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400182C")]
		internal readonly int _hashcode; //Field offset: 0x0

		[Address(RVA = "0xE2B180", Offset = "0xE2A380", Length = "0x68")]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "TryUpdateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", "TValue"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GrowTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>+Tables<TKey, TValue>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A4A")]
		internal Node(TKey key, TValue value, int hashcode, Node<TKey, TValue> next) { }

	}

	[Token(Token = "0x20005C3")]
	private sealed class Tables
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001826")]
		internal readonly Node<TKey, TValue>[] _buckets; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001827")]
		internal readonly Object[] _locks; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001828")]
		internal Int32[] _countPerLock; //Field offset: 0x0

		[Address(RVA = "0xF84680", Offset = "0xF83880", Length = "0x70")]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GrowTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>+Tables<TKey, TValue>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "OnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A49")]
		internal Tables(Node<TKey, TValue>[] buckets, Object[] locks, Int32[] countPerLock) { }

	}

	[Token(Token = "0x4001825")]
	private static readonly bool s_isValueWriteAtomic; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400181E")]
	private Tables<TKey, TValue> _tables; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400181F")]
	private IEqualityComparer<TKey> _comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001820")]
	private readonly bool _growLockArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001821")]
	private int _budget; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001822")]
	private KeyValuePair<TKey, TValue>[] _serializationArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001823")]
	private int _serializationConcurrencyLevel; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001824")]
	private int _serializationCapacity; //Field offset: 0x0

	[Token(Token = "0x17000681")]
	public override int Count
	{
		[Address(RVA = "0x9C7080", Offset = "0x9C6280", Length = "0xED")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800507E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050E70")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A25")]
		 get { } //Length: 237
	}

	[Token(Token = "0x17000689")]
	private static int DefaultConcurrencyLevel
	{
		[Address(RVA = "0x9C71B0", Offset = "0x9C63B0", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A3F")]
		private get { } //Length: 64
	}

	[Token(Token = "0x17000680")]
	public override TValue Item
	{
		[Address(RVA = "0x9C7380", Offset = "0x9C6580", Length = "0x129")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FB0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A21")]
		 get { } //Length: 297
		[Address(RVA = "0x9C77F0", Offset = "0x9C69F0", Length = "0xB9")]
		[CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A22")]
		 set { } //Length: 185
	}

	[Token(Token = "0x17000682")]
	public override ICollection<TKey> Keys
	{
		[Address(RVA = "0x9BF370", Offset = "0x9BE570", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetKeys", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TKey>")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A2C")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000686")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A32")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000683")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0x9BF370", Offset = "0x9BE570", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetKeys", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TKey>")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A2D")]
		private get { } //Length: 23
	}

	[Token(Token = "0x17000685")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0x9BF3D0", Offset = "0x9BE5D0", Length = "0x17")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetValues", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TValue>")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A2F")]
		private get { } //Length: 23
	}

	[Token(Token = "0x17000688")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x9B6380", Offset = "0x9B5580", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A3B")]
		private get { } //Length: 73
	}

	[Token(Token = "0x17000687")]
	private override object System.Collections.IDictionary.Item
	{
		[Address(RVA = "0x9C12F0", Offset = "0x9C04F0", Length = "0x10E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800513C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A38")]
		private get { } //Length: 270
		[Address(RVA = "0x9C1AB0", Offset = "0x9C0CB0", Length = "0x290")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A39")]
		private set { } //Length: 656
	}

	[Token(Token = "0x17000684")]
	public override ICollection<TValue> Values
	{
		[Address(RVA = "0x9BF3D0", Offset = "0x9BE5D0", Length = "0x17")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetValues", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TValue>")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A2E")]
		 get { } //Length: 23
	}

	[Address(RVA = "0x9C5F00", Offset = "0x9C5100", Length = "0x124")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A48")]
	private static ConcurrentDictionary`2() { }

	[Address(RVA = "0x9C6D20", Offset = "0x9C5F20", Length = "0xB4")]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.TcpConfig", typeof(int), typeof(int), "Mirror.SimpleWeb.SslConfig", "Mirror.SimpleWeb.BufferPool"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Server", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A0E")]
	public ConcurrentDictionary`2() { }

	[Address(RVA = "0x9C6970", Offset = "0x9C5B70", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A0F")]
	public ConcurrentDictionary`2(IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x9C64D0", Offset = "0x9C56D0", Length = "0x3DC")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Tables), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Node<TKey, TValue>[]", typeof(Object[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A11")]
	internal ConcurrentDictionary`2(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x9B74C0", Offset = "0x9B66C0", Length = "0x167")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "AcquireLocks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A40")]
	private void AcquireAllLocks(ref int locksAcquired) { }

	[Address(RVA = "0x9B77A0", Offset = "0x9B69A0", Length = "0xF1")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GrowTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>+Tables<TKey, TValue>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "AcquireAllLocks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A41")]
	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired) { }

	[Address(RVA = "0x9B78A0", Offset = "0x9B6AA0", Length = "0x2C3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryUpdateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A29")]
	public TValue AddOrUpdate(TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory) { }

	[Address(RVA = "0x9B8180", Offset = "0x9B7380", Length = "0x2C2")]
	[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebServer", Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Server", Member = "Stop", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050F20")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Tables), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Node<TKey, TValue>[]", typeof(Object[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800507E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A19")]
	public override void Clear() { }

	[Address(RVA = "0x9B8AF0", Offset = "0x9B7CF0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A13")]
	public override bool ContainsKey(TKey key) { }

	[Address(RVA = "0x9B8F50", Offset = "0x9B8150", Length = "0x14C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A1D")]
	private void CopyToEntries(DictionaryEntry[] array, int index) { }

	[Address(RVA = "0x9B9400", Offset = "0x9B8600", Length = "0x1A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A1E")]
	private void CopyToObjects(Object[] array, int index) { }

	[Address(RVA = "0x9B95B0", Offset = "0x9B87B0", Length = "0x12F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A1C")]
	private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index) { }

	[Address(RVA = "0x9C7080", Offset = "0x9C6280", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800507E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050E70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A25")]
	public override int get_Count() { }

	[Address(RVA = "0x9C71B0", Offset = "0x9C63B0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A3F")]
	private static int get_DefaultConcurrencyLevel() { }

	[Address(RVA = "0x9C7380", Offset = "0x9C6580", Length = "0x129")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A21")]
	public override TValue get_Item(TKey key) { }

	[Address(RVA = "0x9BF370", Offset = "0x9BE570", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetKeys", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TKey>")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A2C")]
	public override ICollection<TKey> get_Keys() { }

	[Address(RVA = "0x9BF3D0", Offset = "0x9BE5D0", Length = "0x17")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetValues", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TValue>")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A2E")]
	public override ICollection<TValue> get_Values() { }

	[Address(RVA = "0x9B9980", Offset = "0x9B8B80", Length = "0x10")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A3D")]
	private static int GetBucket(int hashcode, int bucketCount) { }

	[Address(RVA = "0x9B9960", Offset = "0x9B8B60", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A3E")]
	private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount) { }

	[Address(RVA = "0x9B9990", Offset = "0x9B8B90", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A26")]
	private int GetCountInternal() { }

	[Address(RVA = "0x9B9A40", Offset = "0x9B8C40", Length = "0x8C")]
	[CalledBy(Type = typeof(DictionaryEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Server", Member = "Stop", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<GetEnumerator>d__35))]
	[Token(Token = "0x6002A1F")]
	public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	[Address(RVA = "0x9B9DA0", Offset = "0x9B8FA0", Length = "0x2CB")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "get_Keys", ReturnType = "System.Collections.Generic.ICollection`1<TKey>")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys", ReturnType = "System.Collections.Generic.IEnumerable`1<TKey>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050F20")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050E70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800507E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A43")]
	private ReadOnlyCollection<TKey> GetKeys() { }

	[Address(RVA = "0x9BA8A0", Offset = "0x9B9AA0", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FD0")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A28")]
	public TValue GetOrAdd(TKey key, TValue value) { }

	[Address(RVA = "0x9BA5C0", Offset = "0x9B97C0", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FD0")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A27")]
	public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory) { }

	[Address(RVA = "0x9BADF0", Offset = "0x9B9FF0", Length = "0x2CC")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "get_Values", ReturnType = "System.Collections.Generic.ICollection`1<TValue>")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values", ReturnType = "System.Collections.Generic.IEnumerable`1<TValue>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050F20")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050E70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800507E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A44")]
	private ReadOnlyCollection<TValue> GetValues() { }

	[Address(RVA = "0x9BB390", Offset = "0x9BA590", Length = "0x831")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050F20")]
	[Calls(Type = typeof(Tables), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Node<TKey, TValue>[]", typeof(Object[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Node), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(int), "System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>+Node<TKey, TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "AcquireLocks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A3C")]
	private void GrowTable(Tables<TKey, TValue> tables) { }

	[Address(RVA = "0x9BCF70", Offset = "0x9BC170", Length = "0x318")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "OnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A10")]
	private void InitializeFromCollection(IEnumerable<KeyValuePair`2<TKey, TValue>> collection) { }

	[Address(RVA = "0x9BD5F0", Offset = "0x9BC7F0", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A0D")]
	private static bool IsValueWriteAtomic() { }

	[Address(RVA = "0x9BD6E0", Offset = "0x9BC8E0", Length = "0x1FA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Tables), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Node<TKey, TValue>[]", typeof(Object[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "InitializeFromCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<KeyValuePair`2<TKey, TValue>>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[OnDeserialized]
	[Token(Token = "0x6002A47")]
	private void OnDeserialized(StreamingContext context) { }

	[Address(RVA = "0x3BD5C0", Offset = "0x3BC7C0", Length = "0x13")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[OnSerialized]
	[Token(Token = "0x6002A46")]
	private void OnSerialized(StreamingContext context) { }

	[Address(RVA = "0x9BDD70", Offset = "0x9BCF70", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "ToArray", ReturnType = "System.Collections.Generic.KeyValuePair`2<TKey, TValue>[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[OnSerializing]
	[Token(Token = "0x6002A45")]
	private void OnSerializing(StreamingContext context) { }

	[Address(RVA = "0x9BDE90", Offset = "0x9BD090", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A42")]
	private void ReleaseLocks(int fromInclusive, int toExclusive) { }

	[Address(RVA = "0x9C77F0", Offset = "0x9C69F0", Length = "0xB9")]
	[CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A22")]
	public override void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0x9BE000", Offset = "0x9BD200", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A30")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0x9BE070", Offset = "0x9BD270", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A31")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0x9BE6C0", Offset = "0x9BD8C0", Length = "0x2A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050AC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800507E0")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A1A")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A32")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	[Address(RVA = "0x9BEC20", Offset = "0x9BDE20", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryRemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", typeof(bool), "TValue"}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A33")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0x9BEDD0", Offset = "0x9BDFD0", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A2A")]
	private override void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	[Address(RVA = "0x9BF2E0", Offset = "0x9BE4E0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryRemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", typeof(bool), "TValue"}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A2B")]
	private override bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

	[Address(RVA = "0x9BF370", Offset = "0x9BE570", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetKeys", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TKey>")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A2D")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0x9BF3D0", Offset = "0x9BE5D0", Length = "0x17")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetValues", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TValue>")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A2F")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0x9BF3F0", Offset = "0x9BE5F0", Length = "0x65D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050AC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800507E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A3A")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x9B6380", Offset = "0x9B5580", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A3B")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x9C06E0", Offset = "0x9BF8E0", Length = "0x216")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A35")]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[Address(RVA = "0x9C12F0", Offset = "0x9C04F0", Length = "0x10E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800513C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A38")]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[Address(RVA = "0x9C0D50", Offset = "0x9BFF50", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DictionaryEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A36")]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[Address(RVA = "0x9C0F00", Offset = "0x9C0100", Length = "0x125")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryRemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", typeof(bool), "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A37")]
	private override void System.Collections.IDictionary.Remove(object key) { }

	[Address(RVA = "0x9C1AB0", Offset = "0x9C0CB0", Length = "0x290")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BC0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A39")]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[Address(RVA = "0x9C1D50", Offset = "0x9C0F50", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A34")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x9C1DF0", Offset = "0x9C0FF0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A23")]
	private static void ThrowKeyNotFoundException(object key) { }

	[Address(RVA = "0x9C1E70", Offset = "0x9C1070", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A24")]
	private static void ThrowKeyNullException() { }

	[Address(RVA = "0x9C24A0", Offset = "0x9C16A0", Length = "0x2E5")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "OnSerializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800507E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050AC0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A1B")]
	public KeyValuePair<TKey, TValue>[] ToArray() { }

	[Address(RVA = "0x9C3AF0", Offset = "0x9C2CF0", Length = "0xB9")]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "HandshakeAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(int), "TValue", typeof(bool), typeof(bool), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A12")]
	public bool TryAdd(TKey key, TValue value) { }

	[Address(RVA = "0x9C3470", Offset = "0x9C2670", Length = "0x674")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "AddOrUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", "System.Func`3<TKey, TValue, TValue>"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "InitializeFromCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<KeyValuePair`2<TKey, TValue>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GetOrAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "System.Func`2<TKey, TValue>"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GetOrAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.Generic.IDictionary<TKey,TValue>.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.IDictionary.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1809B05C0")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GrowTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>+Tables<TKey, TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Node), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(int), "System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>+Node<TKey, TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A20")]
	private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue) { }

	[Address(RVA = "0x9C42A0", Offset = "0x9C34A0", Length = "0xA8")]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "GetClientAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebServer", Member = "KickClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebServer", Member = "GetClientAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebServer", Member = "GetClientRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Mirror.SimpleWeb.Request")]
	[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebServer", Member = "ProcessMessageQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.MonoBehaviour"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mirror.SimpleWeb.ArrayBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "CloseConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "GetClientRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Mirror.SimpleWeb.Request")]
	[CalledBy(Type = "Telepathy.Server", Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Telepathy.Server", Member = "GetClientAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Telepathy.Server", Member = "Disconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180050FD0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A16")]
	public override bool TryGetValue(TKey key, out TValue value) { }

	[Address(RVA = "0x9C3DB0", Offset = "0x9C2FB0", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A17")]
	private bool TryGetValueInternal(TKey key, int hashcode, out TValue value) { }

	[Address(RVA = "0x9C5190", Offset = "0x9C4390", Length = "0x31")]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "AfterConnectionDisposed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Server", Member = "Tick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Func`1<Boolean>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryRemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", typeof(bool), "TValue"}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A14")]
	public bool TryRemove(TKey key, out TValue value) { }

	[Address(RVA = "0x9C4450", Offset = "0x9C3650", Length = "0x409")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "TryRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.Generic.IDictionary<TKey,TValue>.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.IDictionary.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A15")]
	private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue) { }

	[Address(RVA = "0x9C5AA0", Offset = "0x9C4CA0", Length = "0x45D")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "AddOrUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", "System.Func`3<TKey, TValue, TValue>"}, ReturnType = "TValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Node), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(int), "System.Collections.Concurrent.ConcurrentDictionary`2<TKey, TValue>+Node<TKey, TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023B10")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A18")]
	private bool TryUpdateInternal(TKey key, int hashcode, TValue newValue, TValue comparisonValue) { }

}

