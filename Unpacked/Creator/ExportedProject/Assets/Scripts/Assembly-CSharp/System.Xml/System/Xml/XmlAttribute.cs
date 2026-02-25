namespace System.Xml;

[Token(Token = "0x200006C")]
public class XmlAttribute : XmlNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002E4")]
	private XmlName name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E5")]
	private XmlLinkedNode lastChild; //Field offset: 0x20

	[Token(Token = "0x170000F6")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x166E0F0", Offset = "0x166D2F0", Length = "0x74")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60004D1")]
		 get { } //Length: 116
	}

	[Token(Token = "0x170000F0")]
	public virtual string InnerText
	{
		[Address(RVA = "0x166E270", Offset = "0x166D470", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XmlNode), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
		[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x60004BF")]
		 set { } //Length: 109
	}

	[Token(Token = "0x170000F5")]
	public virtual string InnerXml
	{
		[Address(RVA = "0x166E2E0", Offset = "0x166D4E0", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60004CE")]
		 set { } //Length: 151
	}

	[Token(Token = "0x170000F1")]
	internal virtual bool IsContainer
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C2")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170000F2")]
	internal virtual XmlLinkedNode LastNode
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C4")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C5")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170000EA")]
	public virtual string LocalName
	{
		[Address(RVA = "0x166E190", Offset = "0x166D390", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B8")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170000E6")]
	internal int LocalNameHash
	{
		[Address(RVA = "0x166E170", Offset = "0x166D370", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004B1")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x170000E9")]
	public virtual string Name
	{
		[Address(RVA = "0x166E1B0", Offset = "0x166D3B0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlName), Member = "get_Name", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004B7")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170000EB")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x50FBD0", Offset = "0x50EDD0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B9")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170000ED")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BB")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000EE")]
	public virtual XmlDocument OwnerDocument
	{
		[Address(RVA = "0x3B6AF0", Offset = "0x3B5CF0", Length = "0x1B")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BC")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170000F4")]
	public override XmlElement OwnerElement
	{
		[Address(RVA = "0x166E1D0", Offset = "0x166D3D0", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60004CD")]
		 get { } //Length: 114
	}

	[Token(Token = "0x170000E8")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B6")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000EC")]
	public virtual string Prefix
	{
		[Address(RVA = "0x166E250", Offset = "0x166D450", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BA")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170000F3")]
	public override bool Specified
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C7")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000EF")]
	public virtual string Value
	{
		[Address(RVA = "0x121B9D0", Offset = "0x121ABD0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BD")]
		 get { } //Length: 20
		[Address(RVA = "0x166E380", Offset = "0x166D580", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BE")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170000E7")]
	internal XmlName XmlName
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B3")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B4")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x166DF60", Offset = "0x166D160", Length = "0x18D")]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeNodeDirect", ReturnType = typeof(XmlAttribute))]
	[CallerCount(Count = 4)]
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
	[Token(Token = "0x60004B0")]
	internal XmlAttribute(XmlName name, XmlDocument doc) { }

	[Address(RVA = "0x166DF10", Offset = "0x166D110", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B2")]
	protected private XmlAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	[Address(RVA = "0x166D6D0", Offset = "0x166C8D0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004CC")]
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	[Address(RVA = "0x166D500", Offset = "0x166C700", Length = "0x1C9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60004C3")]
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	[Address(RVA = "0x166D750", Offset = "0x166C950", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60004B5")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x166E0F0", Offset = "0x166D2F0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60004D1")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C2")]
	internal virtual bool get_IsContainer() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C4")]
	internal virtual XmlLinkedNode get_LastNode() { }

	[Address(RVA = "0x166E190", Offset = "0x166D390", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B8")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x166E170", Offset = "0x166D370", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004B1")]
	internal int get_LocalNameHash() { }

	[Address(RVA = "0x166E1B0", Offset = "0x166D3B0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlName), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004B7")]
	public virtual string get_Name() { }

	[Address(RVA = "0x50FBD0", Offset = "0x50EDD0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B9")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004BB")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x3B6AF0", Offset = "0x3B5CF0", Length = "0x1B")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004BC")]
	public virtual XmlDocument get_OwnerDocument() { }

	[Address(RVA = "0x166E1D0", Offset = "0x166D3D0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004CD")]
	public override XmlElement get_OwnerElement() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B6")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x166E250", Offset = "0x166D450", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004BA")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C7")]
	public override bool get_Specified() { }

	[Address(RVA = "0x121B9D0", Offset = "0x121ABD0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004BD")]
	public virtual string get_Value() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B3")]
	internal XmlName get_XmlName() { }

	[Address(RVA = "0x166D840", Offset = "0x166CA40", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004C9")]
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x166D8E0", Offset = "0x166CAE0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004C8")]
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x166D980", Offset = "0x166CB80", Length = "0xF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004C6")]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[Address(RVA = "0x166D990", Offset = "0x166CB90", Length = "0x191")]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "PrependChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlDocument), Member = "GetIDInfoByElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60004C0")]
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	[Address(RVA = "0x166DB30", Offset = "0x166CD30", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60004CB")]
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	[Address(RVA = "0x166DC00", Offset = "0x166CE00", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004CA")]
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	[Address(RVA = "0x166DC80", Offset = "0x166CE80", Length = "0x12D")]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "PrependChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlDocument), Member = "RemoveElementWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "AddElementWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60004C1")]
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	[Address(RVA = "0x166E270", Offset = "0x166D470", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004BF")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x166E2E0", Offset = "0x166D4E0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004CE")]
	public virtual void set_InnerXml(string value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C5")]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[Address(RVA = "0x166E380", Offset = "0x166D580", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004BE")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B4")]
	internal void set_XmlName(XmlName value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D2")]
	internal virtual void SetParent(XmlNode node) { }

	[Address(RVA = "0x166DDB0", Offset = "0x166CFB0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D0")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x166DE30", Offset = "0x166D030", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60004CF")]
	public virtual void WriteTo(XmlWriter w) { }

}

