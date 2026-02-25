namespace MS.Internal.Xml.Cache;

[Token(Token = "0x200017B")]
internal sealed class XPathDocumentNavigator : XPathNavigator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006DB")]
	private XPathNode[] _pageCurrent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006DC")]
	private XPathNode[] _pageParent; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006DD")]
	private int _idxCurrent; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40006DE")]
	private int _idxParent; //Field offset: 0x24

	[Token(Token = "0x17000353")]
	public virtual string LocalName
	{
		[Address(RVA = "0x16E4840", Offset = "0x16E3A40", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D1E")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000354")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x16E48D0", Offset = "0x16E3AD0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D1F")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000356")]
	public virtual XmlNameTable NameTable
	{
		[Address(RVA = "0x16E4880", Offset = "0x16E3A80", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D21")]
		 get { } //Length: 67
	}

	[Token(Token = "0x17000352")]
	public virtual XPathNodeType NodeType
	{
		[Address(RVA = "0x16E4910", Offset = "0x16E3B10", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D1D")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000355")]
	public virtual string Prefix
	{
		[Address(RVA = "0x16E4950", Offset = "0x16E3B50", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000D20")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000357")]
	public virtual object UnderlyingObject
	{
		[Address(RVA = "0x123F830", Offset = "0x123EA30", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D26")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000351")]
	public virtual string Value
	{
		[Address(RVA = "0x16E4990", Offset = "0x16E3B90", Length = "0x2E9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(XPathNodeHelper), Member = "GetTextFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&), typeof(Int32&), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000D1B")]
		 get { } //Length: 745
	}

	[Address(RVA = "0x16E47A0", Offset = "0x16E39A0", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D1A")]
	public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	[Address(RVA = "0x16E40B0", Offset = "0x16E32B0", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D1C")]
	public virtual XPathNavigator Clone() { }

	[Address(RVA = "0x16E4840", Offset = "0x16E3A40", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D1E")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x16E48D0", Offset = "0x16E3AD0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D1F")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x16E4880", Offset = "0x16E3A80", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D21")]
	public virtual XmlNameTable get_NameTable() { }

	[Address(RVA = "0x16E4910", Offset = "0x16E3B10", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D1D")]
	public virtual XPathNodeType get_NodeType() { }

	[Address(RVA = "0x16E4950", Offset = "0x16E3B50", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D20")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x123F830", Offset = "0x123EA30", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D26")]
	public virtual object get_UnderlyingObject() { }

	[Address(RVA = "0x16E4990", Offset = "0x16E3B90", Length = "0x2E9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XPathNodeHelper), Member = "GetTextFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&), typeof(Int32&), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D1B")]
	public virtual string get_Value() { }

	[Address(RVA = "0x16E4190", Offset = "0x16E3390", Length = "0x7")]
	[CalledBy(Type = typeof(XPathNavigatorKeyComparer), Member = "System.Collections.IEqualityComparer.GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000D27")]
	public int GetPositionHashCode() { }

	[Address(RVA = "0x16E41A0", Offset = "0x16E33A0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D25")]
	public virtual bool IsSamePosition(XPathNavigator other) { }

	[Address(RVA = "0x16E4230", Offset = "0x16E3430", Length = "0x2AE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XPathDocument), Member = "GetXmlNamespaceNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XPathDocument), Member = "LookupNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XPathNode), Member = "get_IsXmlNamespaceNode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D22")]
	public virtual bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	[Address(RVA = "0x16E44E0", Offset = "0x16E36E0", Length = "0x1C4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D23")]
	public virtual bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	[Address(RVA = "0x16E46B0", Offset = "0x16E38B0", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D24")]
	public virtual bool MoveToParent() { }

}

