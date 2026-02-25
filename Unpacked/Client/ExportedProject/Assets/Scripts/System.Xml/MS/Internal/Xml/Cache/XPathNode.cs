namespace MS.Internal.Xml.Cache;

[Token(Token = "0x200017C")]
internal struct XPathNode
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006DF")]
	private XPathNodeInfoAtom _info; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006E0")]
	private ushort _idxSibling; //Field offset: 0x8
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x40006E1")]
	private ushort _idxParent; //Field offset: 0xA
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40006E2")]
	private ushort _idxSimilar; //Field offset: 0xC
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x40006E3")]
	private ushort _posOffset; //Field offset: 0xE
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006E4")]
	private uint _props; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006E5")]
	private string _value; //Field offset: 0x18

	[Token(Token = "0x1700035C")]
	public XPathDocument Document
	{
		[Address(RVA = "0x16E52F0", Offset = "0x16E44F0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000D2C")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000360")]
	public bool HasCollapsedText
	{
		[Address(RVA = "0x16E5310", Offset = "0x16E4510", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D32")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000362")]
	public bool HasNamespaceDecls
	{
		[Address(RVA = "0x16E5320", Offset = "0x16E4520", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D34")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700035F")]
	public bool HasSibling
	{
		[Address(RVA = "0x16E5330", Offset = "0x16E4530", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D31")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000361")]
	public bool IsText
	{
		[Address(RVA = "0x16E5340", Offset = "0x16E4540", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(XPathNavigator), Member = "IsText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000D33")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700035E")]
	public bool IsXmlNamespaceNode
	{
		[Address(RVA = "0x16E5390", Offset = "0x16E4590", Length = "0x67")]
		[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFirstNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D30")]
		 get { } //Length: 103
	}

	[Token(Token = "0x1700035A")]
	public string LocalName
	{
		[Address(RVA = "0x12DDFD0", Offset = "0x12DD1D0", Length = "0x1A")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D2A")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700035B")]
	public string NamespaceUri
	{
		[Address(RVA = "0x16E5400", Offset = "0x16E4600", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000D2B")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000358")]
	public XPathNodeType NodeType
	{
		[Address(RVA = "0x16E5420", Offset = "0x16E4620", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000D28")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700035D")]
	public XPathNodePageInfo PageInfo
	{
		[Address(RVA = "0x16E5430", Offset = "0x16E4630", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000D2D")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000359")]
	public string Prefix
	{
		[Address(RVA = "0x16E5450", Offset = "0x16E4650", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000D29")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000363")]
	public string Value
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D35")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x16E52F0", Offset = "0x16E44F0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D2C")]
	public XPathDocument get_Document() { }

	[Address(RVA = "0x16E5310", Offset = "0x16E4510", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D32")]
	public bool get_HasCollapsedText() { }

	[Address(RVA = "0x16E5320", Offset = "0x16E4520", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D34")]
	public bool get_HasNamespaceDecls() { }

	[Address(RVA = "0x16E5330", Offset = "0x16E4530", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D31")]
	public bool get_HasSibling() { }

	[Address(RVA = "0x16E5340", Offset = "0x16E4540", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XPathNavigator), Member = "IsText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000D33")]
	public bool get_IsText() { }

	[Address(RVA = "0x16E5390", Offset = "0x16E4590", Length = "0x67")]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFirstNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D30")]
	public bool get_IsXmlNamespaceNode() { }

	[Address(RVA = "0x12DDFD0", Offset = "0x12DD1D0", Length = "0x1A")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D2A")]
	public string get_LocalName() { }

	[Address(RVA = "0x16E5400", Offset = "0x16E4600", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D2B")]
	public string get_NamespaceUri() { }

	[Address(RVA = "0x16E5420", Offset = "0x16E4620", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000D28")]
	public XPathNodeType get_NodeType() { }

	[Address(RVA = "0x16E5430", Offset = "0x16E4630", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D2D")]
	public XPathNodePageInfo get_PageInfo() { }

	[Address(RVA = "0x16E5450", Offset = "0x16E4650", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D29")]
	public string get_Prefix() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D35")]
	public string get_Value() { }

	[Address(RVA = "0x16E5270", Offset = "0x16E4470", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D2E")]
	public int GetParent(out XPathNode[] pageNode) { }

	[Address(RVA = "0x16E52B0", Offset = "0x16E44B0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D2F")]
	public int GetSibling(out XPathNode[] pageNode) { }

}

