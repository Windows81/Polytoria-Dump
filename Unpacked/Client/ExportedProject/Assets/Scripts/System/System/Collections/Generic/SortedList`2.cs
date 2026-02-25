namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
[Token(Token = "0x20001CA")]
public class SortedList : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>
{
	[Token(Token = "0x20001CB")]
	private struct Enumerator : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E3")]
		private SortedList<TKey, TValue> _sortedList; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E4")]
		private TKey _key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E5")]
		private TValue _value; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E6")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E7")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E8")]
		private int _getEnumeratorRetType; //Field offset: 0x0

		[Token(Token = "0x17000232")]
		public override KeyValuePair<TKey, TValue> Current
		{
			[Address(RVA = "0xB26B70", Offset = "0xB25D70", Length = "0x116")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.RigidbodyState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), "Mirror.RigidbodyState"}, ReturnType = typeof(void))]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B5B")]
			 get { } //Length: 278
		}

		[Token(Token = "0x17000231")]
		private override DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		{
			[Address(RVA = "0xB22930", Offset = "0xB21B30", Length = "0x17D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B5A")]
			private get { } //Length: 381
		}

		[Token(Token = "0x17000230")]
		private override object System.Collections.IDictionaryEnumerator.Key
		{
			[Address(RVA = "0xB22CD0", Offset = "0xB21ED0", Length = "0xDC")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B58")]
			private get { } //Length: 220
		}

		[Token(Token = "0x17000234")]
		private override object System.Collections.IDictionaryEnumerator.Value
		{
			[Address(RVA = "0xB23350", Offset = "0xB22550", Length = "0x122")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B5D")]
			private get { } //Length: 290
		}

		[Token(Token = "0x17000233")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xB24D50", Offset = "0xB23F50", Length = "0x366")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.RigidbodyState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), "Mirror.RigidbodyState"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B5C")]
			private get { } //Length: 870
		}

		[Address(RVA = "0xB26160", Offset = "0xB25360", Length = "0x6E")]
		[CalledBy(Type = typeof(SortedList`2), Member = "System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
		[CalledBy(Type = typeof(SortedList`2), Member = "System.Collections.IDictionary.GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
		[CalledBy(Type = typeof(SortedList`2), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B56")]
		internal Enumerator(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType) { }

		[Address(RVA = "0xB1F730", Offset = "0xB1E930", Length = "0x30")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B57")]
		public override void Dispose() { }

		[Address(RVA = "0xB26B70", Offset = "0xB25D70", Length = "0x116")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.RigidbodyState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), "Mirror.RigidbodyState"}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B5B")]
		public override KeyValuePair<TKey, TValue> get_Current() { }

		[Address(RVA = "0xB21D30", Offset = "0xB20F30", Length = "0x1BC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B59")]
		public override bool MoveNext() { }

		[Address(RVA = "0xB22930", Offset = "0xB21B30", Length = "0x17D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B5A")]
		private override DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

		[Address(RVA = "0xB22CD0", Offset = "0xB21ED0", Length = "0xDC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B58")]
		private override object System.Collections.IDictionaryEnumerator.get_Key() { }

		[Address(RVA = "0xB23350", Offset = "0xB22550", Length = "0x122")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B5D")]
		private override object System.Collections.IDictionaryEnumerator.get_Value() { }

		[Address(RVA = "0xB24D50", Offset = "0xB23F50", Length = "0x366")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.RigidbodyState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), "Mirror.RigidbodyState"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B5C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xB23560", Offset = "0xB22760", Length = "0x9D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B5E")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView`2))]
	[DefaultMember("Item")]
	[Token(Token = "0x20001CE")]
	private sealed class KeyList : IList<TKey>, ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006F1")]
		private SortedList<TKey, TValue> _dict; //Field offset: 0x0

		[Token(Token = "0x17000239")]
		public override int Count
		{
			[Address(RVA = "0x86E000", Offset = "0x86D200", Length = "0x1A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B6C")]
			 get { } //Length: 26
		}

		[Token(Token = "0x1700023A")]
		public override bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B6D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700023C")]
		public override TKey Item
		{
			[Address(RVA = "0xCDF220", Offset = "0xCDE420", Length = "0x2A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(SortedList`2), Member = "GetKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TKey")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B75")]
			 get { } //Length: 42
			[Address(RVA = "0xCDF250", Offset = "0xCDE450", Length = "0x49")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B76")]
			 set { } //Length: 73
		}

		[Token(Token = "0x1700023B")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0xCDF130", Offset = "0xCDE330", Length = "0x49")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B6E")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B6B")]
		internal KeyList(SortedList<TKey, TValue> dictionary) { }

		[Address(RVA = "0x86D500", Offset = "0x86C700", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B6F")]
		public override void Add(TKey key) { }

		[Address(RVA = "0x86D550", Offset = "0x86C750", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B70")]
		public override void Clear() { }

		[Address(RVA = "0xCDEB10", Offset = "0xCDDD10", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedList`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B71")]
		public override bool Contains(TKey key) { }

		[Address(RVA = "0xCDEBC0", Offset = "0xCDDDC0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B72")]
		public override void CopyTo(TKey[] array, int arrayIndex) { }

		[Address(RVA = "0x86E000", Offset = "0x86D200", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B6C")]
		public override int get_Count() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B6D")]
		public override bool get_IsReadOnly() { }

		[Address(RVA = "0xCDF220", Offset = "0xCDE420", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedList`2), Member = "GetKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TKey")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B75")]
		public override TKey get_Item(int index) { }

		[Address(RVA = "0x86D8E0", Offset = "0x86CAE0", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B77")]
		public override IEnumerator<TKey> GetEnumerator() { }

		[Address(RVA = "0xCDEC00", Offset = "0xCDDE00", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B79")]
		public override int IndexOf(TKey key) { }

		[Address(RVA = "0x86DBF0", Offset = "0x86CDF0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B74")]
		public override void Insert(int index, TKey value) { }

		[Address(RVA = "0x86D500", Offset = "0x86C700", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B7A")]
		public override bool Remove(TKey key) { }

		[Address(RVA = "0x86D500", Offset = "0x86C700", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B7B")]
		public override void RemoveAt(int index) { }

		[Address(RVA = "0xCDF250", Offset = "0xCDE450", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B76")]
		public override void set_Item(int index, TKey value) { }

		[Address(RVA = "0xCDEFB0", Offset = "0xCDE1B0", Length = "0x12C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B73")]
		private override void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

		[Address(RVA = "0xCDF130", Offset = "0xCDE330", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B6E")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0x86D8E0", Offset = "0x86CAE0", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B78")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x20001CC")]
	private sealed class SortedListKeyEnumerator : IEnumerator<TKey>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E9")]
		private SortedList<TKey, TValue> _sortedList; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006EA")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006EB")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006EC")]
		private TKey _currentKey; //Field offset: 0x0

		[Token(Token = "0x17000235")]
		public override TKey Current
		{
			[Address(RVA = "0x2F5B10", Offset = "0x2F4D10", Length = "0x6")]
			[CallerCount(Count = 4)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B62")]
			 get { } //Length: 6
		}

		[Token(Token = "0x17000236")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xF1C260", Offset = "0xF1B460", Length = "0x97")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B63")]
			private get { } //Length: 151
		}

		[Address(RVA = "0xF1C300", Offset = "0xF1B500", Length = "0x42")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B5F")]
		internal SortedListKeyEnumerator(SortedList<TKey, TValue> sortedList) { }

		[Address(RVA = "0xF1BAE0", Offset = "0xF1ACE0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B60")]
		public override void Dispose() { }

		[Address(RVA = "0x2F5B10", Offset = "0x2F4D10", Length = "0x6")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B62")]
		public override TKey get_Current() { }

		[Address(RVA = "0xF1BAF0", Offset = "0xF1ACF0", Length = "0xB6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B61")]
		public override bool MoveNext() { }

		[Address(RVA = "0xF1C260", Offset = "0xF1B460", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B63")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xF1C040", Offset = "0xF1B240", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B64")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[Token(Token = "0x20001CD")]
	private sealed class SortedListValueEnumerator : IEnumerator<TValue>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006ED")]
		private SortedList<TKey, TValue> _sortedList; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006EE")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006EF")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006F0")]
		private TValue _currentValue; //Field offset: 0x0

		[Token(Token = "0x17000237")]
		public override TValue Current
		{
			[Address(RVA = "0xF1CEC0", Offset = "0xF1C0C0", Length = "0x3E")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B68")]
			 get { } //Length: 62
		}

		[Token(Token = "0x17000238")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xF1CC70", Offset = "0xF1BE70", Length = "0xE1")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B69")]
			private get { } //Length: 225
		}

		[Address(RVA = "0xF1C300", Offset = "0xF1B500", Length = "0x42")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B65")]
		internal SortedListValueEnumerator(SortedList<TKey, TValue> sortedList) { }

		[Address(RVA = "0xF1C420", Offset = "0xF1B620", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B66")]
		public override void Dispose() { }

		[Address(RVA = "0xF1CEC0", Offset = "0xF1C0C0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B68")]
		public override TValue get_Current() { }

		[Address(RVA = "0xF1C480", Offset = "0xF1B680", Length = "0x134")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B67")]
		public override bool MoveNext() { }

		[Address(RVA = "0xF1CC70", Offset = "0xF1BE70", Length = "0xE1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B69")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xF1CAC0", Offset = "0xF1BCC0", Length = "0x95")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B6A")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView`2))]
	[DefaultMember("Item")]
	[Token(Token = "0x20001CF")]
	private sealed class ValueList : IList<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006F2")]
		private SortedList<TKey, TValue> _dict; //Field offset: 0x0

		[Token(Token = "0x1700023D")]
		public override int Count
		{
			[Address(RVA = "0x86E000", Offset = "0x86D200", Length = "0x1A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B7D")]
			 get { } //Length: 26
		}

		[Token(Token = "0x1700023E")]
		public override bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B7E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000240")]
		public override TValue Item
		{
			[Address(RVA = "0x86E140", Offset = "0x86D340", Length = "0x80")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(SortedList`2), Member = "GetByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B86")]
			 get { } //Length: 128
			[Address(RVA = "0x86DBF0", Offset = "0x86CDF0", Length = "0x49")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B87")]
			 set { } //Length: 73
		}

		[Token(Token = "0x1700023F")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x86DF60", Offset = "0x86D160", Length = "0x49")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B7F")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B7C")]
		internal ValueList(SortedList<TKey, TValue> dictionary) { }

		[Address(RVA = "0x86D500", Offset = "0x86C700", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B80")]
		public override void Add(TValue key) { }

		[Address(RVA = "0x86D550", Offset = "0x86C750", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B81")]
		public override void Clear() { }

		[Address(RVA = "0x86D730", Offset = "0x86C930", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedList`2), Member = "ContainsValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B82")]
		public override bool Contains(TValue value) { }

		[Address(RVA = "0x86D7B0", Offset = "0x86C9B0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B83")]
		public override void CopyTo(TValue[] array, int arrayIndex) { }

		[Address(RVA = "0x86E000", Offset = "0x86D200", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B7D")]
		public override int get_Count() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B7E")]
		public override bool get_IsReadOnly() { }

		[Address(RVA = "0x86E140", Offset = "0x86D340", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedList`2), Member = "GetByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B86")]
		public override TValue get_Item(int index) { }

		[Address(RVA = "0x86D8E0", Offset = "0x86CAE0", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B88")]
		public override IEnumerator<TValue> GetEnumerator() { }

		[Address(RVA = "0x86D9C0", Offset = "0x86CBC0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.RigidbodyState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RigidbodyState[]), "Mirror.RigidbodyState", typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B8A")]
		public override int IndexOf(TValue value) { }

		[Address(RVA = "0x86DBF0", Offset = "0x86CDF0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B85")]
		public override void Insert(int index, TValue value) { }

		[Address(RVA = "0x86D500", Offset = "0x86C700", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B8B")]
		public override bool Remove(TValue value) { }

		[Address(RVA = "0x86D500", Offset = "0x86C700", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B8C")]
		public override void RemoveAt(int index) { }

		[Address(RVA = "0x86DBF0", Offset = "0x86CDF0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B87")]
		public override void set_Item(int index, TValue value) { }

		[Address(RVA = "0x86DC40", Offset = "0x86CE40", Length = "0x12C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B84")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x86DF60", Offset = "0x86D160", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B7F")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0x86D8E0", Offset = "0x86CAE0", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B89")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x40006E1")]
	private const int DefaultCapacity = 4; //Field offset: 0x0
	[Token(Token = "0x40006E2")]
	private const int MaxArrayLength = 2146435071; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006D9")]
	private TKey[] keys; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006DA")]
	private TValue[] values; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006DB")]
	private int _size; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006DC")]
	private int version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006DD")]
	private IComparer<TKey> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006DE")]
	private KeyList<TKey, TValue> keyList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006DF")]
	private ValueList<TKey, TValue> valueList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006E0")]
	private object _syncRoot; //Field offset: 0x0

	[Token(Token = "0x17000224")]
	public int Capacity
	{
		[Address(RVA = "0xF269A0", Offset = "0xF25BA0", Length = "0x1CA")]
		[CalledBy(Type = typeof(SortedList`2), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SortedList`2), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "TKey", "TValue"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B32")]
		 set { } //Length: 458
	}

	[Token(Token = "0x17000225")]
	public override int Count
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B34")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700022E")]
	public override TValue Item
	{
		[Address(RVA = "0xF265F0", Offset = "0xF257F0", Length = "0x14D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
		[Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B4A")]
		 get { } //Length: 333
		[Address(RVA = "0xF27210", Offset = "0xF26410", Length = "0x149")]
		[CalledBy(Type = "Mirror.Prediction", Member = "CorrectHistory", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(int), "T", "T", "T", typeof(int)}, ReturnType = "T")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F6000")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B4B")]
		 set { } //Length: 329
	}

	[Token(Token = "0x17000226")]
	public IList<TKey> Keys
	{
		[Address(RVA = "0xF21170", Offset = "0xF20370", Length = "0x17")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5EC0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B35")]
		 get { } //Length: 23
	}

	[Token(Token = "0x1700022C")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B3D")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000227")]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0xF21170", Offset = "0xF20370", Length = "0x17")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5EC0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B36")]
		private get { } //Length: 23
	}

	[Token(Token = "0x1700022A")]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0xF211B0", Offset = "0xF203B0", Length = "0x17")]
		[CallerCount(Count = 26)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5F60")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B39")]
		private get { } //Length: 23
	}

	[Token(Token = "0x17000228")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0xF21170", Offset = "0xF20370", Length = "0x17")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5EC0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B37")]
		private get { } //Length: 23
	}

	[Token(Token = "0x1700022B")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0xF211B0", Offset = "0xF203B0", Length = "0x17")]
		[CallerCount(Count = 26)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5F60")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B3A")]
		private get { } //Length: 23
	}

	[Token(Token = "0x1700022D")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xF23130", Offset = "0xF22330", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B3E")]
		private get { } //Length: 107
	}

	[Token(Token = "0x1700022F")]
	private override object System.Collections.IDictionary.Item
	{
		[Address(RVA = "0xF24940", Offset = "0xF23B40", Length = "0x1EA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B4C")]
		private get { } //Length: 490
		[Address(RVA = "0xF25770", Offset = "0xF24970", Length = "0x3F3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F6000")]
		[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B4D")]
		private set { } //Length: 1011
	}

	[Token(Token = "0x17000229")]
	public IList<TValue> Values
	{
		[Address(RVA = "0xF211B0", Offset = "0xF203B0", Length = "0x17")]
		[CallerCount(Count = 26)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5F60")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B38")]
		 get { } //Length: 23
	}

	[Address(RVA = "0xF260E0", Offset = "0xF252E0", Length = "0x93")]
	[CalledBy(Type = "Mirror.NetworkClient", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkConnectionToClient", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkConnectionToClient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformHybrid", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Double>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Double>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B2C")]
	public SortedList`2() { }

	[Address(RVA = "0xF25F90", Offset = "0xF25190", Length = "0x146")]
	[CalledBy(Type = "Mirror.NetworkTransformBase", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Double>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Double>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B2D")]
	public SortedList`2(int capacity) { }

	[Address(RVA = "0xF1CF30", Offset = "0xF1C130", Length = "0x16C")]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "RecordState", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "ApplyState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Vector3", "UnityEngine.Vector3"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F6000")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B2E")]
	public override void Add(TKey key, TValue value) { }

	[Address(RVA = "0xF1D6D0", Offset = "0xF1C8D0", Length = "0xB")]
	[CalledBy(Type = "Mirror.LocalConnectionToServer", Member = "Disconnect", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkClient", Member = "OnTransportDisconnected", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkClient", Member = "InitTimeInterpolation", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformHybrid", Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformBase", Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "RewriteHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, TransformSnapshot>", typeof(double), typeof(double), typeof(double), "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Vector3"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "ApplyState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Vector3", "UnityEngine.Vector3"}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B3F")]
	public override void Clear() { }

	[Address(RVA = "0xF1D760", Offset = "0xF1C960", Length = "0x5D")]
	[CalledBy(Type = typeof(KeyList), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B40")]
	public override bool ContainsKey(TKey key) { }

	[Address(RVA = "0xF1DA80", Offset = "0xF1CC80", Length = "0x8F")]
	[CalledBy(Type = typeof(ValueList), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.RigidbodyState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RigidbodyState[]), "Mirror.RigidbodyState", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B41")]
	public bool ContainsValue(TValue value) { }

	[Address(RVA = "0xF1DB70", Offset = "0xF1CD70", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortedList`2), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B44")]
	private void EnsureCapacity(int min) { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B34")]
	public override int get_Count() { }

	[Address(RVA = "0xF265F0", Offset = "0xF257F0", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B4A")]
	public override TValue get_Item(TKey key) { }

	[Address(RVA = "0xF21170", Offset = "0xF20370", Length = "0x17")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5EC0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B35")]
	public IList<TKey> get_Keys() { }

	[Address(RVA = "0xF211B0", Offset = "0xF203B0", Length = "0x17")]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5F60")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B38")]
	public IList<TValue> get_Values() { }

	[Address(RVA = "0xF1DDF0", Offset = "0xF1CFF0", Length = "0xCA")]
	[CalledBy(Type = typeof(ValueList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180096810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B45")]
	private TValue GetByIndex(int index) { }

	[Address(RVA = "0xF1E110", Offset = "0xF1D310", Length = "0xCF")]
	[CalledBy(Type = typeof(KeyList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TKey")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B49")]
	private TKey GetKey(int index) { }

	[Address(RVA = "0xF1DFD0", Offset = "0xF1D1D0", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B3B")]
	private KeyList<TKey, TValue> GetKeyListHelper() { }

	[Address(RVA = "0xF1E320", Offset = "0xF1D520", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B3C")]
	private ValueList<TKey, TValue> GetValueListHelper() { }

	[Address(RVA = "0xF1E460", Offset = "0xF1D660", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B4E")]
	public int IndexOfKey(TKey key) { }

	[Address(RVA = "0xF1E6B0", Offset = "0xF1D8B0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.RigidbodyState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RigidbodyState[]), "Mirror.RigidbodyState", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B4F")]
	public int IndexOfValue(TValue value) { }

	[Address(RVA = "0xF1E8B0", Offset = "0xF1DAB0", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortedList`2), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B50")]
	private void Insert(int index, TKey key, TValue value) { }

	[Address(RVA = "0xF1EF40", Offset = "0xF1E140", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B55")]
	private static bool IsCompatibleKey(object key) { }

	[Address(RVA = "0xF1F560", Offset = "0xF1E760", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C7A0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B53")]
	public override bool Remove(TKey key) { }

	[Address(RVA = "0xF1EFE0", Offset = "0xF1E1E0", Length = "0xFE")]
	[CalledBy(Type = "Mirror.Prediction", Member = "CorrectHistory", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(int), "T", "T", "T", typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = "Mirror.SortedListExtensions", Member = "RemoveRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<T, U>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SnapshotInterpolation", Member = "StepInterpolation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(double), "T&", "T&", typeof(Double&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "RecordState", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B52")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0xF269A0", Offset = "0xF25BA0", Length = "0x1CA")]
	[CalledBy(Type = typeof(SortedList`2), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortedList`2), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "TKey", "TValue"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B32")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0xF27210", Offset = "0xF26410", Length = "0x149")]
	[CalledBy(Type = "Mirror.Prediction", Member = "CorrectHistory", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(int), "T", "T", "T", typeof(int)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F6000")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B4B")]
	public override void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0xF1F800", Offset = "0xF1EA00", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5AE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B2F")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0xF1F870", Offset = "0xF1EA70", Length = "0x19D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002E2B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B30")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0xF205A0", Offset = "0xF1F7A0", Length = "0x2C7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.RigidbodyState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), "Mirror.RigidbodyState"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B42")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B3D")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	[Address(RVA = "0xF20D00", Offset = "0xF1FF00", Length = "0x1BA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002E2B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C7A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B31")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0xF21170", Offset = "0xF20370", Length = "0x17")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5EC0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B36")]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0xF211B0", Offset = "0xF203B0", Length = "0x17")]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5F60")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B39")]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0xF21340", Offset = "0xF20540", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B46")]
	private override IEnumerator<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	[Address(RVA = "0xF21170", Offset = "0xF20370", Length = "0x17")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5EC0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B37")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0xF211B0", Offset = "0xF203B0", Length = "0x17")]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5F60")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B3A")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0xF21D70", Offset = "0xF20F70", Length = "0x736")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Double, Mirror.RigidbodyState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), "Mirror.RigidbodyState"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B43")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0xF23130", Offset = "0xF22330", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B3E")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xF23210", Offset = "0xF22410", Length = "0x3BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5AE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B33")]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[Address(RVA = "0xF24940", Offset = "0xF23B40", Length = "0x1EA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B4C")]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[Address(RVA = "0xF240E0", Offset = "0xF232E0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B47")]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[Address(RVA = "0xF24360", Offset = "0xF23560", Length = "0x179")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C7A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B54")]
	private override void System.Collections.IDictionary.Remove(object key) { }

	[Address(RVA = "0xF25770", Offset = "0xF24970", Length = "0x3F3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F6000")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B4D")]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[Address(RVA = "0xF21340", Offset = "0xF20540", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B48")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xF25E90", Offset = "0xF25090", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double[]), typeof(int), typeof(int), typeof(double), typeof(System.Collections.Generic.IComparer`1<System.Double>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B51")]
	public override bool TryGetValue(TKey key, out TValue value) { }

}

