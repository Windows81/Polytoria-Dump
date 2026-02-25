namespace U8Xml.Internal;

[Token(Token = "0x2000036")]
internal struct NodeStore : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005B")]
	private CustomList<XmlNode_> _allNodes; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400005C")]
	private CustomList<XmlAttribute_> _allAttrs; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400005D")]
	private int _elementNodeCount; //Field offset: 0x10

	[Token(Token = "0x17000035")]
	public CustomList<XmlAttribute_> AllAttrs
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000FC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000036")]
	public int NodeCount
	{
		[Address(RVA = "0x18081D0", Offset = "0x18073D0", Length = "0x14C")]
		[CalledBy(Type = typeof(XmlParser), Member = "StartStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(NodeStore&), typeof(OptionalNodeList), typeof(RawStringTable&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60000FD")]
		 get { } //Length: 332
	}

	[Token(Token = "0x17000037")]
	public XmlNode RootNode
	{
		[Address(RVA = "0x1808320", Offset = "0x1807520", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CustomList`1), Member = "get_FirstItem", ReturnType = "T*")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000FE")]
		 get { } //Length: 100
	}

	[Address(RVA = "0x1807D80", Offset = "0x1806F80", Length = "0x132")]
	[CalledBy(Type = typeof(XmlParser), Member = "StartStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(NodeStore&), typeof(OptionalNodeList), typeof(RawStringTable&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(U8Xml.Internal.CustomList`1<U8Xml.XmlNode_>), Member = "GetPointerToAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(XmlNode_*))]
	[Token(Token = "0x6000101")]
	public XmlNode_* AddElementNode(RawString name, int depth, Byte* nodeStrPtr) { }

	[Address(RVA = "0x1807EC0", Offset = "0x18070C0", Length = "0x121")]
	[CalledBy(Type = typeof(XmlParser), Member = "StartStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(NodeStore&), typeof(OptionalNodeList), typeof(RawStringTable&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(U8Xml.Internal.CustomList`1<U8Xml.XmlNode_>), Member = "GetPointerToAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(XmlNode_*))]
	[Token(Token = "0x6000100")]
	public XmlNode_* AddTextNode(int depth, Byte* nodeStrPtr) { }

	[Address(RVA = "0x1807FF0", Offset = "0x18071F0", Length = "0x13E")]
	[CalledBy(Type = typeof(XmlParser), Member = "ParseCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedBuffer&), typeof(int)}, ReturnType = typeof(XmlObjectCore))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(U8Xml.Internal.CustomList`1<U8Xml.XmlNode_>), Member = "Create", ReturnType = typeof(U8Xml.Internal.CustomList`1<U8Xml.XmlNode_>))]
	[Calls(Type = typeof(CustomList`1), Member = "Create", ReturnType = "U8Xml.Internal.CustomList`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180051F50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180051F60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60000FF")]
	public static NodeStore Create() { }

	[Address(RVA = "0x1808130", Offset = "0x1807330", Length = "0x97")]
	[CalledBy(Type = typeof(XmlParser), Member = "ParseCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedBuffer&), typeof(int)}, ReturnType = typeof(XmlObjectCore))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(U8Xml.Internal.CustomList`1<U8Xml.XmlNode_>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CustomList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x6000102")]
	public override void Dispose() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FC")]
	public CustomList<XmlAttribute_> get_AllAttrs() { }

	[Address(RVA = "0x18081D0", Offset = "0x18073D0", Length = "0x14C")]
	[CalledBy(Type = typeof(XmlParser), Member = "StartStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(NodeStore&), typeof(OptionalNodeList), typeof(RawStringTable&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000FD")]
	public int get_NodeCount() { }

	[Address(RVA = "0x1808320", Offset = "0x1807520", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CustomList`1), Member = "get_FirstItem", ReturnType = "T*")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000FE")]
	public XmlNode get_RootNode() { }

}

