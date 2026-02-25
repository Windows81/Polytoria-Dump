namespace System.Xml;

[Token(Token = "0x2000038")]
public class XmlParserContext
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D4")]
	private XmlNameTable _nt; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D5")]
	private XmlNamespaceManager _nsMgr; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D6")]
	private string _docTypeName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D7")]
	private string _pubId; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000D8")]
	private string _sysId; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000D9")]
	private string _internalSubset; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000DA")]
	private string _xmlLang; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000DB")]
	private XmlSpace _xmlSpace; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000DC")]
	private string _baseURI; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000DD")]
	private Encoding _encoding; //Field offset: 0x58

	[Token(Token = "0x17000045")]
	public string BaseURI
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001DA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000042")]
	public string DocTypeName
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000049")]
	public Encoding Encoding
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001DE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004A")]
	internal bool HasDtdInfo
	{
		[Address(RVA = "0x163A910", Offset = "0x1639B10", Length = "0x75")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInit", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = "System.Xml.XmlTextReaderImpl+EntityType")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60001DF")]
		internal get { } //Length: 117
	}

	[Token(Token = "0x17000046")]
	public string InternalSubset
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001DB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000041")]
	public XmlNamespaceManager NamespaceManager
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000040")]
	public XmlNameTable NameTable
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000043")]
	public string PublicId
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000044")]
	public string SystemId
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D9")]
		 get { } //Length: 95
	}

	[Token(Token = "0x17000047")]
	public string XmlLang
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001DC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000048")]
	public XmlSpace XmlSpace
	{
		[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001DD")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x163A5F0", Offset = "0x16397F0", Length = "0x62")]
	[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "GetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlParserContext))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlParserContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlNamespaceManager), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(XmlSpace), typeof(Encoding)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001D3")]
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	[Address(RVA = "0x163A660", Offset = "0x1639860", Length = "0x2AC")]
	[CalledBy(Type = typeof(XmlParserContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlNamespaceManager), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(XmlSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D4")]
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001DA")]
	public string get_BaseURI() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D7")]
	public string get_DocTypeName() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001DE")]
	public Encoding get_Encoding() { }

	[Address(RVA = "0x163A910", Offset = "0x1639B10", Length = "0x75")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = "System.Xml.XmlTextReaderImpl+EntityType")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60001DF")]
	internal bool get_HasDtdInfo() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001DB")]
	public string get_InternalSubset() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D6")]
	public XmlNamespaceManager get_NamespaceManager() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D5")]
	public XmlNameTable get_NameTable() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D8")]
	public string get_PublicId() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D9")]
	public string get_SystemId() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001DC")]
	public string get_XmlLang() { }

	[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001DD")]
	public XmlSpace get_XmlSpace() { }

}

