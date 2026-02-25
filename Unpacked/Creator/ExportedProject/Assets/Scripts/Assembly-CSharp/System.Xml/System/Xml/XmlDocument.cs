namespace System.Xml;

[Token(Token = "0x2000074")]
public class XmlDocument : XmlNode
{
	[Token(Token = "0x4000316")]
	internal static EmptyEnumerator EmptyEnumerator; //Field offset: 0x0
	[Token(Token = "0x4000317")]
	internal static IXmlSchemaInfo NotKnownSchemaInfo; //Field offset: 0x8
	[Token(Token = "0x4000318")]
	internal static IXmlSchemaInfo ValidSchemaInfo; //Field offset: 0x10
	[Token(Token = "0x4000319")]
	internal static IXmlSchemaInfo InvalidSchemaInfo; //Field offset: 0x18
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002EE")]
	private XmlImplementation implementation; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002EF")]
	private DomNameTable domNameTable; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002F0")]
	private XmlLinkedNode lastChild; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002F1")]
	private XmlNamedNodeMap entities; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002F2")]
	private Hashtable htElementIdMap; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002F3")]
	private Hashtable htElementIDAttrDecl; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002F4")]
	private SchemaInfo schemaInfo; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002F5")]
	private XmlSchemaSet schemas; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002F6")]
	private bool reportValidity; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x40002F7")]
	private bool actualLoadingStatus; //Field offset: 0x59
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002F8")]
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002F9")]
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002FA")]
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002FB")]
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40002FC")]
	private XmlNodeChangedEventHandler onNodeChangingDelegate; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40002FD")]
	private XmlNodeChangedEventHandler onNodeChangedDelegate; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40002FE")]
	internal bool fEntRefNodesPresent; //Field offset: 0x90
	[FieldOffset(Offset = "0x91")]
	[Token(Token = "0x40002FF")]
	internal bool fCDataNodesPresent; //Field offset: 0x91
	[FieldOffset(Offset = "0x92")]
	[Token(Token = "0x4000300")]
	private bool preserveWhitespace; //Field offset: 0x92
	[FieldOffset(Offset = "0x93")]
	[Token(Token = "0x4000301")]
	private bool isLoading; //Field offset: 0x93
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000302")]
	internal string strDocumentName; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000303")]
	internal string strDocumentFragmentName; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000304")]
	internal string strCommentName; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000305")]
	internal string strTextName; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000306")]
	internal string strCDataSectionName; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000307")]
	internal string strEntityName; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000308")]
	internal string strID; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000309")]
	internal string strXmlns; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400030A")]
	internal string strXml; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400030B")]
	internal string strSpace; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400030C")]
	internal string strLang; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400030D")]
	internal string strEmpty; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400030E")]
	internal string strNonSignificantWhitespaceName; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400030F")]
	internal string strSignificantWhitespaceName; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000310")]
	internal string strReservedXmlns; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000311")]
	internal string strReservedXml; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000312")]
	internal string baseURI; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000313")]
	private XmlResolver resolver; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000314")]
	internal bool bSetResolver; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000315")]
	internal object objLock; //Field offset: 0x130

	[Token(Token = "0x17000124")]
	internal bool ActualLoadingStatus
	{
		[Address(RVA = "0x13961C0", Offset = "0x13953C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600055B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000128")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600056B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700011E")]
	internal bool CanReportValidity
	{
		[Address(RVA = "0x3F5830", Offset = "0x3F4A30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000537")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000115")]
	internal override XmlDeclaration Declaration
	{
		[Address(RVA = "0x1674970", Offset = "0x1673B70", Length = "0xA9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600052D")]
		internal get { } //Length: 169
	}

	[Token(Token = "0x17000119")]
	public XmlElement DocumentElement
	{
		[Address(RVA = "0x1674A20", Offset = "0x1673C20", Length = "0x82")]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveModelToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(string))]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveModelToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance", typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveToString", ReturnType = typeof(string))]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDocument), Member = "IsValidChildType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlDocument), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000531")]
		 get { } //Length: 130
	}

	[Token(Token = "0x17000114")]
	public override XmlDocumentType DocumentType
	{
		[Address(RVA = "0x1674AB0", Offset = "0x1673CB0", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600052C")]
		 get { } //Length: 130
	}

	[Token(Token = "0x17000111")]
	internal SchemaInfo DtdSchemaInfo
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600051D")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600051E")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000122")]
	internal XmlNamedNodeMap Entities
	{
		[Address(RVA = "0x1674B40", Offset = "0x1673D40", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000557")]
		internal get { } //Length: 121
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000558")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700011F")]
	internal bool HasSetResolver
	{
		[Address(RVA = "0x420950", Offset = "0x41FB50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000538")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000116")]
	public XmlImplementation Implementation
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600052E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000126")]
	public virtual string InnerText
	{
		[Address(RVA = "0x1674C40", Offset = "0x1673E40", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000560")]
		 set { } //Length: 95
	}

	[Token(Token = "0x17000127")]
	public virtual string InnerXml
	{
		[Address(RVA = "0x1674CA0", Offset = "0x1673EA0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000561")]
		 set { } //Length: 20
	}

	[Token(Token = "0x1700011A")]
	internal virtual bool IsContainer
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000532")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000123")]
	internal bool IsLoading
	{
		[Address(RVA = "0x1674BC0", Offset = "0x1673DC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000559")]
		internal get { } //Length: 8
		[Address(RVA = "0x16697C0", Offset = "0x16689C0", Length = "0x7")]
		[CalledBy(Type = typeof(XmlLoader), Member = "ExpandEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEntityReference)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x600055A")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000121")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000556")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700011B")]
	internal virtual XmlLinkedNode LastNode
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000533")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000534")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000118")]
	public virtual string LocalName
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000530")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000117")]
	public virtual string Name
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600052F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000120")]
	public XmlNameTable NameTable
	{
		[Address(RVA = "0x166E250", Offset = "0x166D450", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000552")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000112")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x149FBE0", Offset = "0x149EDE0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600052A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700011C")]
	public virtual XmlDocument OwnerDocument
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000535")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000113")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600052B")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700011D")]
	public XmlSchemaSet Schemas
	{
		[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000536")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000125")]
	internal Encoding TextEncoding
	{
		[Address(RVA = "0x1674BD0", Offset = "0x1673DD0", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600055F")]
		internal get { } //Length: 100
	}

	[Address(RVA = "0x16741D0", Offset = "0x16733D0", Length = "0x15D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlSchemaInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidity)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600056E")]
	private static XmlDocument() { }

	[Address(RVA = "0x1674330", Offset = "0x1673530", Length = "0xA9")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveModelToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveModelToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveToString", ReturnType = typeof(string))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600051B")]
	public XmlDocument() { }

	[Address(RVA = "0x16743E0", Offset = "0x16735E0", Length = "0x582")]
	[CalledBy(Type = typeof(XmlImplementation), Member = "CreateDocument", ReturnType = typeof(XmlDocument))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	[Token(Token = "0x600051C")]
	protected private XmlDocument(XmlImplementation imp) { }

	[Address(RVA = "0x16701B0", Offset = "0x166F3B0", Length = "0x133")]
	[CalledBy(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeNode", ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDefaultAttribute", ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeNodeDirect", ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000522")]
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x16702F0", Offset = "0x166F4F0", Length = "0x322")]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "GetSchemaElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_Prefix", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlDocument), Member = "PrepareDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000546")]
	internal void AddDefaultAttributes(XmlElement elem) { }

	[Address(RVA = "0x1670620", Offset = "0x166F820", Length = "0x20B")]
	[CalledBy(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "InsertParentIntoElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "ResetParentInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "GetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlElement)}, ReturnType = typeof(WeakReference))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000527")]
	internal void AddElementWithId(string id, XmlElement elem) { }

	[Address(RVA = "0x1670830", Offset = "0x166FA30", Length = "0xDF")]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000523")]
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	[Address(RVA = "0x1670910", Offset = "0x166FB10", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000520")]
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x1670940", Offset = "0x166FB40", Length = "0x72")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000568")]
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	[Address(RVA = "0x16709C0", Offset = "0x166FBC0", Length = "0x264")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x600056D")]
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	[Address(RVA = "0x1670C30", Offset = "0x166FE30", Length = "0x72")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000567")]
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	[Address(RVA = "0x1670CB0", Offset = "0x166FEB0", Length = "0xE4")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600053E")]
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x1670E00", Offset = "0x1670000", Length = "0x1B6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "HasNodeTypeInPrevSiblings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(XmlNode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600053D")]
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x1670FC0", Offset = "0x16701C0", Length = "0xC1")]
	[CalledBy(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName), typeof(bool), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ValidateNames), Member = "ParseNmtoken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600051F")]
	internal static void CheckName(string name) { }

	[Address(RVA = "0x1671090", Offset = "0x1670290", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlDocument), Member = "ImportNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000529")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x1671220", Offset = "0x1670420", Length = "0x17B")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "UnityEngine.Color"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveNumberRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveColorRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "Polytoria.Types.ColorRange"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "UnityEngine.Vector3"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "UnityEngine.Vector2"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), "Polytoria.Datamodel.Instance", typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600053F")]
	public XmlAttribute CreateAttribute(string name) { }

	[Address(RVA = "0x1671180", Offset = "0x1670380", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000553")]
	public override XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	[Address(RVA = "0x16713A0", Offset = "0x16705A0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000541")]
	public override XmlCDataSection CreateCDataSection(string data) { }

	[Address(RVA = "0x1671440", Offset = "0x1670640", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000542")]
	public override XmlComment CreateComment(string data) { }

	[Address(RVA = "0x1671530", Offset = "0x1670730", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000554")]
	protected private override XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	[Address(RVA = "0x16715E0", Offset = "0x16707E0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000544")]
	public override XmlDocumentFragment CreateDocumentFragment() { }

	[Address(RVA = "0x16716A0", Offset = "0x16708A0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlDocumentType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000543")]
	public override XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	[Address(RVA = "0x1671840", Offset = "0x1670A40", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName), typeof(bool), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000555")]
	public override XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	[Address(RVA = "0x1671740", Offset = "0x1670940", Length = "0xF7")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "UnityEngine.Color"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveNumberRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveColorRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "Polytoria.Types.ColorRange"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "UnityEngine.Vector3"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "UnityEngine.Vector2"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), "Polytoria.Datamodel.Instance", typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000545")]
	public XmlElement CreateElement(string name) { }

	[Address(RVA = "0x1671910", Offset = "0x1670B10", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlEntityReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000549")]
	public override XmlEntityReference CreateEntityReference(string name) { }

	[Address(RVA = "0x1671980", Offset = "0x1670B80", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600054A")]
	public override XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	[Address(RVA = "0x1671A90", Offset = "0x1670C90", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSignificantWhitespace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Token(Token = "0x600054D")]
	public override XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	[Address(RVA = "0x1671B00", Offset = "0x1670D00", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600054C")]
	public override XmlText CreateTextNode(string text) { }

	[Address(RVA = "0x1671BF0", Offset = "0x1670DF0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlWhitespace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Token(Token = "0x600054E")]
	public override XmlWhitespace CreateWhitespace(string text) { }

	[Address(RVA = "0x1671C60", Offset = "0x1670E60", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlDeclaration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Token(Token = "0x600054B")]
	public override XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[Address(RVA = "0x13961C0", Offset = "0x13953C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600055B")]
	internal bool get_ActualLoadingStatus() { }

	[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600056B")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x3F5830", Offset = "0x3F4A30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000537")]
	internal bool get_CanReportValidity() { }

	[Address(RVA = "0x1674970", Offset = "0x1673B70", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600052D")]
	internal override XmlDeclaration get_Declaration() { }

	[Address(RVA = "0x1674A20", Offset = "0x1673C20", Length = "0x82")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveModelToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveModelToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveToString", ReturnType = typeof(string))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDocument), Member = "IsValidChildType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlDocument), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000531")]
	public XmlElement get_DocumentElement() { }

	[Address(RVA = "0x1674AB0", Offset = "0x1673CB0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600052C")]
	public override XmlDocumentType get_DocumentType() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600051D")]
	internal SchemaInfo get_DtdSchemaInfo() { }

	[Address(RVA = "0x1674B40", Offset = "0x1673D40", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000557")]
	internal XmlNamedNodeMap get_Entities() { }

	[Address(RVA = "0x420950", Offset = "0x41FB50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000538")]
	internal bool get_HasSetResolver() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052E")]
	public XmlImplementation get_Implementation() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000532")]
	internal virtual bool get_IsContainer() { }

	[Address(RVA = "0x1674BC0", Offset = "0x1673DC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000559")]
	internal bool get_IsLoading() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000556")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000533")]
	internal virtual XmlLinkedNode get_LastNode() { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000530")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052F")]
	public virtual string get_Name() { }

	[Address(RVA = "0x166E250", Offset = "0x166D450", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000552")]
	public XmlNameTable get_NameTable() { }

	[Address(RVA = "0x149FBE0", Offset = "0x149EDE0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052A")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000535")]
	public virtual XmlDocument get_OwnerDocument() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052B")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x1674BD0", Offset = "0x1673DD0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600055F")]
	internal Encoding get_TextEncoding() { }

	[Address(RVA = "0x1671CF0", Offset = "0x1670EF0", Length = "0x23D")]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "GetSchemaElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(XmlDocument), Member = "PrepareDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000569")]
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	[Address(RVA = "0x1671F30", Offset = "0x1671130", Length = "0x464")]
	[CalledBy(Type = typeof(XmlDocument), Member = "AddElementWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDocument), Member = "RemoveElementWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000526")]
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	[Address(RVA = "0x16723A0", Offset = "0x16715A0", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocumentType), Member = "get_Entities", ReturnType = typeof(XmlNamedNodeMap))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600056A")]
	internal XmlEntity GetEntityNode(string name) { }

	[Address(RVA = "0x1672480", Offset = "0x1671680", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlNodeChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode), typeof(XmlNode), typeof(string), typeof(string), typeof(XmlNodeChangedAction)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000565")]
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	[Address(RVA = "0x1672680", Offset = "0x1671880", Length = "0x104")]
	[CalledBy(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "InsertParentIntoElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveParentFromElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "PrepareParentInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DomNameTable), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000525")]
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	[Address(RVA = "0x1672580", Offset = "0x1671780", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DomNameTable), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000524")]
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	[Address(RVA = "0x1672790", Offset = "0x1671990", Length = "0xC9")]
	[CalledBy(Type = typeof(XmlAttribute), Member = "AppendChildForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlDocument)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlDocument), Member = "AppendChildForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlDocument)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlElement), Member = "AppendChildForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlDocument)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "AddNodeForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlDocument)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlNode), Member = "AppendChildForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlDocument)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlNodeChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode), typeof(XmlNode), typeof(string), typeof(string), typeof(XmlNodeChangedAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000566")]
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000539")]
	internal XmlResolver GetResolver() { }

	[Address(RVA = "0x1672860", Offset = "0x1671A60", Length = "0x11E")]
	[CalledBy(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000547")]
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	[Address(RVA = "0x1672980", Offset = "0x1671B80", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DomNameTable), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000521")]
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x16729B0", Offset = "0x1671BB0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600053C")]
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	[Address(RVA = "0x1672A30", Offset = "0x1671C30", Length = "0xE7")]
	[CalledBy(Type = typeof(XmlDocument), Member = "CanInsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600053B")]
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	[Address(RVA = "0x1672B20", Offset = "0x1671D20", Length = "0x164")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlDocument), Member = "ImportNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000550")]
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	[Address(RVA = "0x1672C90", Offset = "0x1671E90", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "ImportNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000551")]
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	[Address(RVA = "0x1672D50", Offset = "0x1671F50", Length = "0x8C")]
	[CalledBy(Type = typeof(XmlDocument), Member = "CloneNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlDocument), Member = "ImportAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDocument), Member = "ImportChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600054F")]
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	[Address(RVA = "0x1673480", Offset = "0x1672680", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1816734E0")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600053A")]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[Address(RVA = "0x16737D0", Offset = "0x16729D0", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlLoader), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600055D")]
	public override void Load(XmlReader reader) { }

	[Address(RVA = "0x1673650", Offset = "0x1672850", Length = "0x172")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_EntityHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600055E")]
	public override void LoadXml(string xml) { }

	[Address(RVA = "0x1673900", Offset = "0x1672B00", Length = "0x150")]
	[CalledBy(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_DefaultValueRaw", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000548")]
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	[Address(RVA = "0x1673A60", Offset = "0x1672C60", Length = "0x155")]
	[CalledBy(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveParentFromElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "ResetParentInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "GetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlElement)}, ReturnType = typeof(WeakReference))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000528")]
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	[Address(RVA = "0x1673BC0", Offset = "0x1672DC0", Length = "0x249")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlTextWriter), Member = "set_Formatting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Formatting)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000562")]
	public override void Save(string filename) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600051E")]
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000558")]
	internal void set_Entities(XmlNamedNodeMap value) { }

	[Address(RVA = "0x1674C40", Offset = "0x1673E40", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000560")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x1674CA0", Offset = "0x1673EA0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000561")]
	public virtual void set_InnerXml(string value) { }

	[Address(RVA = "0x16697C0", Offset = "0x16689C0", Length = "0x7")]
	[CalledBy(Type = typeof(XmlLoader), Member = "ExpandEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEntityReference)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600055A")]
	internal void set_IsLoading(bool value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000534")]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000536")]
	public void set_Schemas(XmlSchemaSet value) { }

	[Address(RVA = "0x1673E10", Offset = "0x1673010", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600056C")]
	internal void SetBaseURI(string inBaseURI) { }

	[Address(RVA = "0x1673E30", Offset = "0x1673030", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000540")]
	internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	[Address(RVA = "0x1673EE0", Offset = "0x16730E0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReader), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_EntityHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600055C")]
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	[Address(RVA = "0x1673F50", Offset = "0x1673150", Length = "0x270")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000564")]
	public virtual void WriteContentTo(XmlWriter xw) { }

	[Address(RVA = "0x166FC40", Offset = "0x166EE40", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000563")]
	public virtual void WriteTo(XmlWriter w) { }

}

