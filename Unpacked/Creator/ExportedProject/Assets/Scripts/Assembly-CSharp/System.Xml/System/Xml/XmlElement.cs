namespace System.Xml;

[Token(Token = "0x2000078")]
public class XmlElement : XmlLinkedNode
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000323")]
	private XmlName name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000324")]
	private XmlAttributeCollection attributes; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000325")]
	private XmlLinkedNode lastChild; //Field offset: 0x30

	[Token(Token = "0x17000147")]
	public virtual XmlAttributeCollection Attributes
	{
		[Address(RVA = "0x1676120", Offset = "0x1675320", Length = "0x12A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005A5")]
		 get { } //Length: 298
	}

	[Token(Token = "0x17000148")]
	public override bool HasAttributes
	{
		[Address(RVA = "0x1676250", Offset = "0x1675450", Length = "0x33")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005A6")]
		 get { } //Length: 51
	}

	[Token(Token = "0x1700014A")]
	public virtual string InnerText
	{
		[Address(RVA = "0x1676290", Offset = "0x1675490", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B2")]
		 get { } //Length: 7
		[Address(RVA = "0x16763A0", Offset = "0x16755A0", Length = "0xE8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x60005B3")]
		 set { } //Length: 232
	}

	[Token(Token = "0x17000149")]
	public virtual string InnerXml
	{
		[Address(RVA = "0x1676490", Offset = "0x1675690", Length = "0x1E3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
		[Calls(Type = typeof(XmlLoader), Member = "RemoveDuplicateNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[Token(Token = "0x60005B1")]
		 set { } //Length: 483
	}

	[Token(Token = "0x17000144")]
	internal virtual bool IsContainer
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600059E")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000145")]
	public bool IsEmpty
	{
		[Address(RVA = "0x16762A0", Offset = "0x16754A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005A0")]
		 get { } //Length: 8
		[Address(RVA = "0x1676680", Offset = "0x1675880", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
		[Token(Token = "0x60005A1")]
		 set { } //Length: 85
	}

	[Token(Token = "0x17000146")]
	internal virtual XmlLinkedNode LastNode
	{
		[Address(RVA = "0x16762B0", Offset = "0x16754B0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005A2")]
		internal get { } //Length: 14
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60005A3")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700013E")]
	public virtual string LocalName
	{
		[Address(RVA = "0x16762C0", Offset = "0x16754C0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000598")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700013D")]
	public virtual string Name
	{
		[Address(RVA = "0x16762E0", Offset = "0x16754E0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlName), Member = "get_Name", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000597")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700013F")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x1676300", Offset = "0x1675500", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000599")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700014B")]
	public virtual XmlNode NextSibling
	{
		[Address(RVA = "0x1676320", Offset = "0x1675520", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005B4")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000141")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600059B")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000143")]
	public virtual XmlDocument OwnerDocument
	{
		[Address(RVA = "0x1676360", Offset = "0x1675560", Length = "0x1B")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600059D")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000142")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600059C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000140")]
	public virtual string Prefix
	{
		[Address(RVA = "0x1676380", Offset = "0x1675580", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600059A")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700013C")]
	internal XmlName XmlName
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000594")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000595")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x1675F50", Offset = "0x1675150", Length = "0x1C8")]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlDocument), Member = "CheckName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000592")]
	internal XmlElement(XmlName name, bool empty, XmlDocument doc) { }

	[Address(RVA = "0x1675EE0", Offset = "0x16750E0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000593")]
	protected private XmlElement(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	[Address(RVA = "0x1674CC0", Offset = "0x1673EC0", Length = "0x1D3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600059F")]
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	[Address(RVA = "0x1674EA0", Offset = "0x16740A0", Length = "0x4EC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "InternalAppendAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000596")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x1676120", Offset = "0x1675320", Length = "0x12A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005A5")]
	public virtual XmlAttributeCollection get_Attributes() { }

	[Address(RVA = "0x1676250", Offset = "0x1675450", Length = "0x33")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005A6")]
	public override bool get_HasAttributes() { }

	[Address(RVA = "0x1676290", Offset = "0x1675490", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x60005B2")]
	public virtual string get_InnerText() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600059E")]
	internal virtual bool get_IsContainer() { }

	[Address(RVA = "0x16762A0", Offset = "0x16754A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005A0")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x16762B0", Offset = "0x16754B0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005A2")]
	internal virtual XmlLinkedNode get_LastNode() { }

	[Address(RVA = "0x16762C0", Offset = "0x16754C0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000598")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x16762E0", Offset = "0x16754E0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlName), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000597")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1676300", Offset = "0x1675500", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000599")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x1676320", Offset = "0x1675520", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005B4")]
	public virtual XmlNode get_NextSibling() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600059B")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x1676360", Offset = "0x1675560", Length = "0x1B")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600059D")]
	public virtual XmlDocument get_OwnerDocument() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600059C")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x1676380", Offset = "0x1675580", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600059A")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000594")]
	internal XmlName get_XmlName() { }

	[Address(RVA = "0x1675390", Offset = "0x1674590", Length = "0x1A0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60005A8")]
	public override XmlAttribute GetAttributeNode(string name) { }

	[Address(RVA = "0x1675540", Offset = "0x1674740", Length = "0x18")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60005A4")]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[Address(RVA = "0x16756C0", Offset = "0x16748C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005AF")]
	public virtual void RemoveAll() { }

	[Address(RVA = "0x16755A0", Offset = "0x16747A0", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60005AE")]
	public override void RemoveAllAttributes() { }

	[Address(RVA = "0x16756B0", Offset = "0x16748B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
	[Token(Token = "0x60005B0")]
	internal void RemoveAllChildren() { }

	[Address(RVA = "0x16763A0", Offset = "0x16755A0", Length = "0xE8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60005B3")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x1676490", Offset = "0x1675690", Length = "0x1E3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
	[Calls(Type = typeof(XmlLoader), Member = "RemoveDuplicateNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x60005B1")]
	public virtual void set_InnerXml(string value) { }

	[Address(RVA = "0x1676680", Offset = "0x1675880", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlNode), Member = "RemoveAll", ReturnType = typeof(void))]
	[Token(Token = "0x60005A1")]
	public void set_IsEmpty(bool value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005A3")]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000595")]
	internal void set_XmlName(XmlName value) { }

	[Address(RVA = "0x1675820", Offset = "0x1674A20", Length = "0x233")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "InternalAppendAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60005A7")]
	public override void SetAttribute(string name, string value) { }

	[Address(RVA = "0x16756F0", Offset = "0x16748F0", Length = "0x12E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60005A9")]
	public override XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005B5")]
	internal virtual void SetParent(XmlNode node) { }

	[Address(RVA = "0x166DDB0", Offset = "0x166CFB0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005AD")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x1675A60", Offset = "0x1674C60", Length = "0x224")]
	[CalledBy(Type = typeof(XmlElement), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlElement), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x60005AB")]
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	[Address(RVA = "0x1675C90", Offset = "0x1674E90", Length = "0x138")]
	[CalledBy(Type = typeof(XmlElement), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "WriteElementTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x60005AC")]
	private void WriteStartElement(XmlWriter w) { }

	[Address(RVA = "0x1675DD0", Offset = "0x1674FD0", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlElement), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlElement), Member = "WriteElementTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60005AA")]
	public virtual void WriteTo(XmlWriter w) { }

}

