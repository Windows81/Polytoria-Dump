namespace U8Xml.Internal;

[IsReadOnly]
[Token(Token = "0x200001F")]
internal struct CustomList : IDisposable, IReference
{
	[Token(Token = "0x2000022")]
	public struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003A")]
		private readonly ListInfo<T>* _listInfo; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003B")]
		private readonly int _count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003C")]
		private int _i; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003D")]
		private int _lineNum; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003E")]
		private Line<T>* _line; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003F")]
		private T* _current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000040")]
		private int _posInLine; //Field offset: 0x0

		[Token(Token = "0x17000028")]
		public T* Current
		{
			[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000B7")]
			 get { } //Length: 5
		}

		[Address(RVA = "0xB1DED0", Offset = "0xB1D0D0", Length = "0xF1")]
		[CalledBy(Type = typeof(CustomList`1), Member = "GetEnumerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "U8Xml.Internal.CustomList`1<T>+Enumerator<T>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomList`1), Member = "GetLineNumAndIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Int32>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B6")]
		internal Enumerator(ListInfo<T>* listInfo, int start, int count) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B8")]
		public void Dispose() { }

		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B7")]
		public T* get_Current() { }

		[Address(RVA = "0xB17990", Offset = "0xB16B90", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(Enumerator), Member = "NewLine", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B9")]
		public bool MoveNext() { }

		[Address(RVA = "0xB187B0", Offset = "0xB179B0", Length = "0x30")]
		[CalledBy(Type = "U8Xml.XmlAttributeList+EnumeratorClass", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BA")]
		private void NewLine() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BB")]
		public void Reset() { }

	}

	[Token(Token = "0x2000021")]
	public struct Line
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000037")]
		public int Capacity; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000038")]
		public int Count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000039")]
		public T FirstItem; //Field offset: 0x0

		[Address(RVA = "0xCEA1C0", Offset = "0xCE93C0", Length = "0xB")]
		[CalledBy(Type = typeof(CustomList`1), Member = "NewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ListInfo<T>*"}, ReturnType = "Line<T>*")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B5")]
		public static int GetLineSizeToAllocate(int capacity) { }

	}

	[Token(Token = "0x2000020")]
	public struct ListInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000033")]
		public int Count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000034")]
		public int CurrentLineNum; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000035")]
		public Line<T>* CurrentLine; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000036")]
		public Line<T>* L0; //Field offset: 0x0

		[Address(RVA = "0xCF4940", Offset = "0xCF3B40", Length = "0x6")]
		[CalledBy(Type = typeof(CustomList`1), Member = "Create", ReturnType = "U8Xml.Internal.CustomList`1<T>")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B4")]
		public static int GetSizeToAllocate() { }

	}

	[Nullable(1)]
	[Token(Token = "0x4000031")]
	private static readonly Int32[] _lineCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000032")]
	private readonly IntPtr _p; //Field offset: 0x0

	[Token(Token = "0x17000026")]
	public int Count
	{
		[Address(RVA = "0x9E2BE0", Offset = "0x9E1DE0", Length = "0xF3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AA")]
		 get { } //Length: 243
	}

	[Token(Token = "0x17000027")]
	public T* FirstItem
	{
		[Address(RVA = "0x9E2CE0", Offset = "0x9E1EE0", Length = "0x94")]
		[CalledBy(Type = typeof(XmlObjectCore), Member = "get_Root", ReturnType = typeof(XmlNode))]
		[CalledBy(Type = typeof(NodeStore), Member = "get_RootNode", ReturnType = typeof(XmlNode))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AB")]
		 get { } //Length: 148
	}

	[Token(Token = "0x17000024")]
	private ListInfo<T>* Info
	{
		[Address(RVA = "0x9E2E90", Offset = "0x9E2090", Length = "0xA")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A8")]
		private get { } //Length: 10
	}

	[Token(Token = "0x17000025")]
	public override bool IsNull
	{
		[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A9")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x9E28A0", Offset = "0x9E1AA0", Length = "0x18D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AC")]
	private static CustomList`1() { }

	[Address(RVA = "0x9E2BC0", Offset = "0x9E1DC0", Length = "0x1F")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AD")]
	private CustomList`1(ListInfo<T>* listInfo) { }

	[Address(RVA = "0x9E0DC0", Offset = "0x9DFFC0", Length = "0x168")]
	[CalledBy(Type = typeof(NodeStore), Member = "Create", ReturnType = typeof(NodeStore))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ListInfo), Member = "GetSizeToAllocate", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CustomList`1), Member = "NewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ListInfo<T>*"}, ReturnType = "Line<T>*")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AE")]
	public static CustomList<T> Create() { }

	[Address(RVA = "0x9E12E0", Offset = "0x9E04E0", Length = "0x1A1")]
	[CalledBy(Type = typeof(XmlObjectCore), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NodeStore), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B0")]
	public override void Dispose() { }

	[Address(RVA = "0x9E2BE0", Offset = "0x9E1DE0", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AA")]
	public int get_Count() { }

	[Address(RVA = "0x9E2CE0", Offset = "0x9E1EE0", Length = "0x94")]
	[CalledBy(Type = typeof(XmlObjectCore), Member = "get_Root", ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(NodeStore), Member = "get_RootNode", ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AB")]
	public T* get_FirstItem() { }

	[Address(RVA = "0x9E2E90", Offset = "0x9E2090", Length = "0xA")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A8")]
	private ListInfo<T>* get_Info() { }

	[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A9")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x9E16A0", Offset = "0x9E08A0", Length = "0xEE")]
	[CalledBy(Type = typeof(XmlAttributeList), Member = "System.Collections.Generic.IEnumerable<U8Xml.XmlAttribute>.GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<U8Xml.XmlAttribute>))]
	[CalledBy(Type = typeof(XmlAttributeList), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ListInfo<T>*", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B1")]
	public Enumerator<T> GetEnumerator(int start, int count) { }

	[Address(RVA = "0x9E1790", Offset = "0x9E0990", Length = "0x6C")]
	[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ListInfo<T>*", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BitOperationHelper), Member = "Log2SoftwareFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B2")]
	private static ValueTuple<Int32, Int32> GetLineNumAndIndex(int i) { }

	[Address(RVA = "0x9E18E0", Offset = "0x9E0AE0", Length = "0x26D")]
	[CalledBy(Type = typeof(XmlParser), Member = "StartStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(NodeStore&), typeof(OptionalNodeList), typeof(RawStringTable&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlParser), Member = "GetXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(Int32&), typeof(U8Xml.Internal.CustomList`1<U8Xml.XmlAttribute_>), typeof(OptionalNodeList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CustomList`1), Member = "NewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ListInfo<T>*"}, ReturnType = "Line<T>*")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AF")]
	public T* GetPointerToAdd(out int index) { }

	[Address(RVA = "0x9E2210", Offset = "0x9E1410", Length = "0x15B")]
	[CalledBy(Type = typeof(CustomList`1), Member = "Create", ReturnType = "U8Xml.Internal.CustomList`1<T>")]
	[CalledBy(Type = typeof(CustomList`1), Member = "GetPointerToAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = "T*")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Line), Member = "GetLineSizeToAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B3")]
	private static Line<T>* NewLine(ListInfo<T>* listInfo) { }

}

