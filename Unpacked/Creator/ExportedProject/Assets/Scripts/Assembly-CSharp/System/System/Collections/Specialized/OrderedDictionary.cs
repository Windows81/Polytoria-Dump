namespace System.Collections.Specialized;

[DefaultMember("Item")]
[Token(Token = "0x20001A5")]
public class OrderedDictionary : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback
{
	[Token(Token = "0x20001A6")]
	private class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000682")]
		private int _objectReturnType; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000683")]
		private IEnumerator _arrayEnumerator; //Field offset: 0x18

		[Token(Token = "0x170001E3")]
		public override object Current
		{
			[Address(RVA = "0x17C97A0", Offset = "0x17C89A0", Length = "0x20B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[CallsDeduplicatedMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000A20")]
			 get { } //Length: 523
		}

		[Token(Token = "0x170001E4")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x17C99B0", Offset = "0x17C8BB0", Length = "0x10D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[CallsDeduplicatedMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000A21")]
			 get { } //Length: 269
		}

		[Token(Token = "0x170001E5")]
		public override object Key
		{
			[Address(RVA = "0x17C9AC0", Offset = "0x17C8CC0", Length = "0x83")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Token(Token = "0x6000A22")]
			 get { } //Length: 131
		}

		[Token(Token = "0x170001E6")]
		public override object Value
		{
			[Address(RVA = "0x17C9B50", Offset = "0x17C8D50", Length = "0x84")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Token(Token = "0x6000A23")]
			 get { } //Length: 132
		}

		[Address(RVA = "0x17C9730", Offset = "0x17C8930", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A1F")]
		internal OrderedDictionaryEnumerator(ArrayList array, int objectReturnType) { }

		[Address(RVA = "0x17C97A0", Offset = "0x17C89A0", Length = "0x20B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A20")]
		public override object get_Current() { }

		[Address(RVA = "0x17C99B0", Offset = "0x17C8BB0", Length = "0x10D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A21")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x17C9AC0", Offset = "0x17C8CC0", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000A22")]
		public override object get_Key() { }

		[Address(RVA = "0x17C9B50", Offset = "0x17C8D50", Length = "0x84")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000A23")]
		public override object get_Value() { }

		[Address(RVA = "0x17C9690", Offset = "0x17C8890", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000A24")]
		public override bool MoveNext() { }

		[Address(RVA = "0x17C96E0", Offset = "0x17C88E0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000A25")]
		public override void Reset() { }

	}

	[Token(Token = "0x20001A7")]
	private class OrderedDictionaryKeyValueCollection : ICollection, IEnumerable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000684")]
		private ArrayList _objects; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000685")]
		private bool _isKeys; //Field offset: 0x18

		[Token(Token = "0x170001E7")]
		private override int System.Collections.ICollection.Count
		{
			[Address(RVA = "0x143D440", Offset = "0x143C640", Length = "0x2A")]
			[CallerCount(Count = 21)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000A28")]
			private get { } //Length: 42
		}

		[Token(Token = "0x170001E8")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x143CC20", Offset = "0x143BE20", Length = "0x2A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000A29")]
			private get { } //Length: 42
		}

		[Address(RVA = "0x3E7A20", Offset = "0x3E6C20", Length = "0x44")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A26")]
		public OrderedDictionaryKeyValueCollection(ArrayList array, bool isKeys) { }

		[Address(RVA = "0x17C9BE0", Offset = "0x17C8DE0", Length = "0x32B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000A27")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x143D440", Offset = "0x143C640", Length = "0x2A")]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A28")]
		private override int System.Collections.ICollection.get_Count() { }

		[Address(RVA = "0x143CC20", Offset = "0x143BE20", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A29")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0x17C9F10", Offset = "0x17C9110", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A2A")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400067B")]
	private ArrayList _objectsArray; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400067C")]
	private Hashtable _objectsTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400067D")]
	private int _initialCapacity; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400067E")]
	private IEqualityComparer _comparer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400067F")]
	private bool _readOnly; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000680")]
	private object _syncRoot; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000681")]
	private SerializationInfo _siInfo; //Field offset: 0x40

	[Token(Token = "0x170001DD")]
	public override int Count
	{
		[Address(RVA = "0x17CABF0", Offset = "0x17C9DF0", Length = "0x30")]
		[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A0E")]
		 get { } //Length: 48
	}

	[Token(Token = "0x170001E1")]
	public override object Item
	{
		[Address(RVA = "0x17CAC30", Offset = "0x17C9E30", Length = "0x39")]
		[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A12")]
		 get { } //Length: 57
		[Address(RVA = "0x17CAE00", Offset = "0x17CA000", Length = "0x2A5")]
		[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
		[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
		[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
		[Calls(Type = typeof(OrderedDictionary), Member = "IndexOfKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6000A13")]
		 set { } //Length: 677
	}

	[Token(Token = "0x170001DE")]
	private ArrayList objectsArray
	{
		[Address(RVA = "0x17CACF0", Offset = "0x17C9EF0", Length = "0x79")]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "get_Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "get_Values", ReturnType = typeof(ICollection))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "IndexOfKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000A0F")]
		private get { } //Length: 121
	}

	[Token(Token = "0x170001DF")]
	private Hashtable objectsTable
	{
		[Address(RVA = "0x17CAD70", Offset = "0x17C9F70", Length = "0x8A")]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OrderedDictionary), Member = "OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IEqualityComparer)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000A10")]
		private get { } //Length: 138
	}

	[Token(Token = "0x170001E0")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x17CAA30", Offset = "0x17C9C30", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000A11")]
		private get { } //Length: 107
	}

	[Token(Token = "0x170001E2")]
	public override ICollection Values
	{
		[Address(RVA = "0x17CAC70", Offset = "0x17C9E70", Length = "0x71")]
		[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
		[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000A14")]
		 get { } //Length: 113
	}

	[Address(RVA = "0x17CAB80", Offset = "0x17C9D80", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A0A")]
	public OrderedDictionary() { }

	[Address(RVA = "0x17CAB40", Offset = "0x17C9D40", Length = "0x36")]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A0B")]
	public OrderedDictionary(int capacity) { }

	[Address(RVA = "0x17CABB0", Offset = "0x17C9DB0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A0C")]
	public OrderedDictionary(int capacity, IEqualityComparer comparer) { }

	[Address(RVA = "0x358330", Offset = "0x357530", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A0D")]
	protected OrderedDictionary(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x17C9FB0", Offset = "0x17C91B0", Length = "0x12F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A15")]
	public override void Add(object key, object value) { }

	[Address(RVA = "0x17CA0E0", Offset = "0x17C92E0", Length = "0x39")]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A16")]
	public override bool Contains(object key) { }

	[Address(RVA = "0x17CA120", Offset = "0x17C9320", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A17")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x17CABF0", Offset = "0x17C9DF0", Length = "0x30")]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A0E")]
	public override int get_Count() { }

	[Address(RVA = "0x17CAC30", Offset = "0x17C9E30", Length = "0x39")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A12")]
	public override object get_Item(object key) { }

	[Address(RVA = "0x17CACF0", Offset = "0x17C9EF0", Length = "0x79")]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "IndexOfKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "get_Values", ReturnType = typeof(ICollection))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000A0F")]
	private ArrayList get_objectsArray() { }

	[Address(RVA = "0x17CAD70", Offset = "0x17C9F70", Length = "0x8A")]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IEqualityComparer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000A10")]
	private Hashtable get_objectsTable() { }

	[Address(RVA = "0x17CAC70", Offset = "0x17C9E70", Length = "0x71")]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A14")]
	public override ICollection get_Values() { }

	[Address(RVA = "0x17CA170", Offset = "0x17C9370", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A1A")]
	public override IDictionaryEnumerator GetEnumerator() { }

	[Address(RVA = "0x17CA210", Offset = "0x17C9410", Length = "0x1C6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A1C")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x17CA3E0", Offset = "0x17C95E0", Length = "0x167")]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OrderedDictionary), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000A18")]
	private int IndexOfKey(object key) { }

	[Address(RVA = "0x17CA550", Offset = "0x17C9750", Length = "0x399")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A1E")]
	protected override void OnDeserialization(object sender) { }

	[Address(RVA = "0x17CA8F0", Offset = "0x17C9AF0", Length = "0x132")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OrderedDictionary), Member = "IndexOfKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A19")]
	public override void Remove(object key) { }

	[Address(RVA = "0x17CAE00", Offset = "0x17CA000", Length = "0x2A5")]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(OrderedDictionary), Member = "IndexOfKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000A13")]
	public override void set_Item(object key, object value) { }

	[Address(RVA = "0x17CAA30", Offset = "0x17C9C30", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A11")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x17CAAA0", Offset = "0x17C9CA0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A1B")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x12A4030", Offset = "0x12A3230", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A1D")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

}

