namespace U8Xml;

[DebuggerDisplay("{ToString(),nq}")]
[Token(Token = "0x2000015")]
internal struct XmlNode_
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000015")]
	private readonly IntPtr _wholeNodes; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000016")]
	public readonly int NodeIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000017")]
	public readonly int Depth; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000018")]
	public readonly RawString Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000019")]
	public RawString InnerText; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400001A")]
	public readonly Byte* NodeStrPtr; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400001B")]
	public int NodeStrLength; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400001C")]
	public XmlNode_* Parent; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400001D")]
	public XmlNode_* FirstChild; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400001E")]
	public XmlNode_* LastChild; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400001F")]
	public XmlNode_* Sibling; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000020")]
	public int ChildCount; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000021")]
	public int ChildElementCount; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000022")]
	public int AttrIndex; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000023")]
	public int AttrCount; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000024")]
	public readonly CustomList<XmlAttribute_> WholeAttrs; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000025")]
	public bool HasXmlNamespaceAttr; //Field offset: 0x78

	[Token(Token = "0x17000016")]
	public int ChildTextCount
	{
		[Address(RVA = "0x180CB80", Offset = "0x180BD80", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000060")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000018")]
	public bool HasAttribute
	{
		[Address(RVA = "0x180CB90", Offset = "0x180BD90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000062")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000017")]
	public XmlNodeType NodeType
	{
		[Address(RVA = "0x180CBA0", Offset = "0x180BDA0", Length = "0x8")]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000061")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x180CB20", Offset = "0x180BD20", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000063")]
	private XmlNode_(CustomList<XmlNode_> wholeNodes, int nodeIndex, int depth, RawString name, Byte* nodeStrPtr, CustomList<XmlAttribute_> wholeAttrs) { }

	[Address(RVA = "0x180C970", Offset = "0x180BB70", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000067")]
	internal static void AddChildElementNode(XmlNode_* parent, XmlNode_* child) { }

	[Address(RVA = "0x180C9C0", Offset = "0x180BBC0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000068")]
	internal static void AddChildTextNode(XmlNode_* parent, XmlNode_* child) { }

	[Address(RVA = "0x180CA00", Offset = "0x180BC00", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000064")]
	internal static XmlNode_ CreateElementNode(CustomList<XmlNode_> wholeNodes, int nodeIndex, int depth, RawString name, Byte* nodeStrPtr, CustomList<XmlAttribute_> wholeAttrs) { }

	[Address(RVA = "0x180CA70", Offset = "0x180BC70", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000065")]
	internal static XmlNode_ CreateTextNode(CustomList<XmlNode_> wholeNodes, int nodeIndex, int depth, Byte* nodeStrPtr, CustomList<XmlAttribute_> wholeAttrs) { }

	[Address(RVA = "0x180CB80", Offset = "0x180BD80", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000060")]
	public int get_ChildTextCount() { }

	[Address(RVA = "0x180CB90", Offset = "0x180BD90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000062")]
	public bool get_HasAttribute() { }

	[Address(RVA = "0x180CBA0", Offset = "0x180BDA0", Length = "0x8")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000061")]
	public XmlNodeType get_NodeType() { }

	[Address(RVA = "0x180CAD0", Offset = "0x180BCD0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RawString), Member = "ToString", ReturnType = typeof(string))]
	[NullableContext(1)]
	[Token(Token = "0x6000066")]
	public virtual string ToString() { }

}

