namespace System.Runtime.Remoting.Messaging;

[DefaultMember("Item")]
[Token(Token = "0x20003B0")]
internal class MessageDictionary : IDictionary, ICollection, IEnumerable
{
	[Token(Token = "0x20003B1")]
	private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000ED1")]
		private MessageDictionary _methodDictionary; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000ED2")]
		private IDictionaryEnumerator _hashtableEnum; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000ED3")]
		private int _posMethod; //Field offset: 0x20

		[Token(Token = "0x1700036A")]
		public override object Current
		{
			[Address(RVA = "0x137E200", Offset = "0x137D400", Length = "0x54")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Token(Token = "0x6001C57")]
			 get { } //Length: 84
		}

		[Token(Token = "0x1700036B")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x137E260", Offset = "0x137D460", Length = "0x1B3")]
			[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Current", ReturnType = typeof(object))]
			[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Key", ReturnType = typeof(object))]
			[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Value", ReturnType = typeof(object))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			[Token(Token = "0x6001C5A")]
			 get { } //Length: 435
		}

		[Token(Token = "0x1700036C")]
		public override object Key
		{
			[Address(RVA = "0x137E420", Offset = "0x137D620", Length = "0x1C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
			[Token(Token = "0x6001C5B")]
			 get { } //Length: 28
		}

		[Token(Token = "0x1700036D")]
		public override object Value
		{
			[Address(RVA = "0x137E440", Offset = "0x137D640", Length = "0x1D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
			[Token(Token = "0x6001C5C")]
			 get { } //Length: 29
		}

		[Address(RVA = "0x137E160", Offset = "0x137D360", Length = "0x96")]
		[CalledBy(Type = typeof(MessageDictionary), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = typeof(MessageDictionary), Member = "GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001C56")]
		public DictionaryEnumerator(MessageDictionary methodDictionary) { }

		[Address(RVA = "0x137E200", Offset = "0x137D400", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Token(Token = "0x6001C57")]
		public override object get_Current() { }

		[Address(RVA = "0x137E260", Offset = "0x137D460", Length = "0x1B3")]
		[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Current", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Key", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(DictionaryEnumerator), Member = "get_Value", ReturnType = typeof(object))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001C5A")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x137E420", Offset = "0x137D620", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
		[Token(Token = "0x6001C5B")]
		public override object get_Key() { }

		[Address(RVA = "0x137E440", Offset = "0x137D640", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
		[Token(Token = "0x6001C5C")]
		public override object get_Value() { }

		[Address(RVA = "0x137DFF0", Offset = "0x137D1F0", Length = "0x104")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(MessageDictionary), Member = "IsOverridenKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C58")]
		public override bool MoveNext() { }

		[Address(RVA = "0x137E100", Offset = "0x137D300", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C59")]
		public override void Reset() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000ECD")]
	private IDictionary _internalProperties; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000ECE")]
	protected IMethodMessage _message; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000ECF")]
	private String[] _methodKeys; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000ED0")]
	private bool _ownProperties; //Field offset: 0x28

	[Token(Token = "0x17000368")]
	public override int Count
	{
		[Address(RVA = "0x1384810", Offset = "0x1383A10", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C51")]
		 get { } //Length: 106
	}

	[Token(Token = "0x17000364")]
	internal IDictionary InternalDictionary
	{
		[Address(RVA = "0x1384880", Offset = "0x1383A80", Length = "0xA2")]
		[CalledBy(Type = typeof(CADMessageBase), Member = "MarshalProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(ArrayList&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6001C45")]
		internal get { } //Length: 162
	}

	[Token(Token = "0x17000366")]
	public override object Item
	{
		[Address(RVA = "0x1384930", Offset = "0x1383B30", Length = "0x11B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001C4A")]
		 get { } //Length: 283
		[Address(RVA = "0x1383AF0", Offset = "0x1382CF0", Length = "0x151")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C4B")]
		 set { } //Length: 337
	}

	[Token(Token = "0x17000365")]
	public String[] MethodKeys
	{
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C46")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000369")]
	public override object SyncRoot
	{
		[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
		[CallerCount(Count = 2057)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C52")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000367")]
	public override ICollection Values
	{
		[Address(RVA = "0x1384A50", Offset = "0x1383C50", Length = "0x409")]
		[CalledBy(Type = typeof(MessageDictionary), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001C4E")]
		 get { } //Length: 1033
	}

	[Address(RVA = "0x13847D0", Offset = "0x13839D0", Length = "0x31")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C43")]
	public MessageDictionary(IMethodMessage message) { }

	[Address(RVA = "0x1383AF0", Offset = "0x1382CF0", Length = "0x151")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C4F")]
	public override void Add(object key, object value) { }

	[Address(RVA = "0x1383C50", Offset = "0x1382E50", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001C47")]
	protected override IDictionary AllocInternalProperties() { }

	[Address(RVA = "0x1383CA0", Offset = "0x1382EA0", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MessageDictionary), Member = "get_Values", ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C53")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x1384810", Offset = "0x1383A10", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C51")]
	public override int get_Count() { }

	[Address(RVA = "0x1384880", Offset = "0x1383A80", Length = "0xA2")]
	[CalledBy(Type = typeof(CADMessageBase), Member = "MarshalProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(ArrayList&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001C45")]
	internal IDictionary get_InternalDictionary() { }

	[Address(RVA = "0x1384930", Offset = "0x1383B30", Length = "0x11B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001C4A")]
	public override object get_Item(object key) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C52")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x1384A50", Offset = "0x1383C50", Length = "0x409")]
	[CalledBy(Type = typeof(MessageDictionary), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001C4E")]
	public override ICollection get_Values() { }

	[Address(RVA = "0x1383D20", Offset = "0x1382F20", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DictionaryEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageDictionary)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001C55")]
	public override IDictionaryEnumerator GetEnumerator() { }

	[Address(RVA = "0x1383D80", Offset = "0x1382F80", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001C48")]
	public IDictionary GetInternalProperties() { }

	[Address(RVA = "0x1383DD0", Offset = "0x1382FD0", Length = "0x3B9")]
	[CalledBy(Type = typeof(ConstructionCallDictionary), Member = "GetMethodProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Token(Token = "0x6001C4C")]
	protected override object GetMethodProperty(string key) { }

	[Address(RVA = "0x1384190", Offset = "0x1383390", Length = "0xDF")]
	[CalledBy(Type = typeof(CADMessageBase), Member = "MarshalProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(ArrayList&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001C44")]
	internal bool HasUserData() { }

	[Address(RVA = "0x1384270", Offset = "0x1383470", Length = "0x7C")]
	[CalledBy(Type = typeof(DictionaryEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C49")]
	private bool IsOverridenKey(string key) { }

	[Address(RVA = "0x13842F0", Offset = "0x13834F0", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C50")]
	public override void Remove(object key) { }

	[Address(RVA = "0x1383AF0", Offset = "0x1382CF0", Length = "0x151")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C4B")]
	public override void set_Item(object key, object value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C46")]
	public void set_MethodKeys(String[] value) { }

	[Address(RVA = "0x1384440", Offset = "0x1383640", Length = "0x329")]
	[CalledBy(Type = typeof(ConstructionCallDictionary), Member = "SetMethodProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001C4D")]
	protected override void SetMethodProperty(string key, object value) { }

	[Address(RVA = "0x1384770", Offset = "0x1383970", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DictionaryEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageDictionary)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001C54")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

