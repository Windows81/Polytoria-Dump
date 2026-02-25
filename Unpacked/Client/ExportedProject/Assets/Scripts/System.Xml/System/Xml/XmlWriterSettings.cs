namespace System.Xml;

[Token(Token = "0x200006A")]
public sealed class XmlWriterSettings
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002C8")]
	private bool useAsync; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002C9")]
	private Encoding encoding; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002CA")]
	private bool omitXmlDecl; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40002CB")]
	private NewLineHandling newLineHandling; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002CC")]
	private string newLineChars; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002CD")]
	private TriState indent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002CE")]
	private string indentChars; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002CF")]
	private bool newLineOnAttributes; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x40002D0")]
	private bool closeOutput; //Field offset: 0x41
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40002D1")]
	private NamespaceHandling namespaceHandling; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002D2")]
	private ConformanceLevel conformanceLevel; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40002D3")]
	private bool checkCharacters; //Field offset: 0x4C
	[FieldOffset(Offset = "0x4D")]
	[Token(Token = "0x40002D4")]
	private bool writeEndDocumentOnClose; //Field offset: 0x4D
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002D5")]
	private XmlOutputMethod outputMethod; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002D6")]
	private List<XmlQualifiedName> cdataSections; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002D7")]
	private bool doNotEscapeUriAttributes; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x40002D8")]
	private bool mergeCDataSections; //Field offset: 0x61
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002D9")]
	private string mediaType; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002DA")]
	private string docTypeSystem; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002DB")]
	private string docTypePublic; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40002DC")]
	private XmlStandalone standalone; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40002DD")]
	private bool autoXmlDecl; //Field offset: 0x84
	[FieldOffset(Offset = "0x85")]
	[Token(Token = "0x40002DE")]
	private bool isReadOnly; //Field offset: 0x85

	[Token(Token = "0x170000CD")]
	public bool Async
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000486")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000E2")]
	internal bool AutoXmlDeclaration
	{
		[Address(RVA = "0x1682A70", Offset = "0x1681C70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60004A3")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000DB")]
	internal List<XmlQualifiedName> CDataSectionElements
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600049C")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000D7")]
	public bool CheckCharacters
	{
		[Address(RVA = "0x3095E0", Offset = "0x3087E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000495")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000D5")]
	public bool CloseOutput
	{
		[Address(RVA = "0x145D760", Offset = "0x145C960", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000491")]
		 get { } //Length: 5
		[Address(RVA = "0x1682AF0", Offset = "0x1681CF0", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000492")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000D6")]
	public ConformanceLevel ConformanceLevel
	{
		[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000493")]
		 get { } //Length: 4
		[Address(RVA = "0x1682B40", Offset = "0x1681D40", Length = "0x98")]
		[CalledBy(Type = "System.Xml.Linq.XAttribute", Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000494")]
		 set { } //Length: 152
	}

	[Token(Token = "0x170000E0")]
	internal string DocTypePublic
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A1")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000DF")]
	internal string DocTypeSystem
	{
		[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A0")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000DC")]
	public bool DoNotEscapeUriAttributes
	{
		[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600049D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000CE")]
	public Encoding Encoding
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000487")]
		 get { } //Length: 5
		[Address(RVA = "0x1682BE0", Offset = "0x1681DE0", Length = "0x58")]
		[CalledBy(Type = "System.Xml.Linq.XDocument", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Linq.SaveOptions"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000488")]
		 set { } //Length: 88
	}

	[Token(Token = "0x170000D2")]
	public bool Indent
	{
		[Address(RVA = "0x2F94D0", Offset = "0x2F86D0", Length = "0x8")]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600048D")]
		 get { } //Length: 8
		[Address(RVA = "0x1682C40", Offset = "0x1681E40", Length = "0x56")]
		[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Linq.XDocument", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Linq.SaveOptions"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlWriterSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(XmlWriterSettings))]
		[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600048E")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170000D3")]
	public string IndentChars
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600048F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000E3")]
	internal TriState IndentInternal
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A4")]
		internal get { } //Length: 174
	}

	[Token(Token = "0x170000E4")]
	internal bool IsQuerySpecific
	{
		[Address(RVA = "0x1682A80", Offset = "0x1681C80", Length = "0x5F")]
		[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
		[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60004A5")]
		internal get { } //Length: 95
	}

	[Token(Token = "0x170000DE")]
	internal string MediaType
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600049F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000DD")]
	internal bool MergeCDataSections
	{
		[Address(RVA = "0x3D0200", Offset = "0x3CF400", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600049E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000D8")]
	public NamespaceHandling NamespaceHandling
	{
		[Address(RVA = "0x1060130", Offset = "0x105F330", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000496")]
		 get { } //Length: 4
		[Address(RVA = "0x1682CA0", Offset = "0x1681EA0", Length = "0x98")]
		[CalledBy(Type = "System.Xml.Linq.XDocument", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Linq.SaveOptions"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlWriterSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(XmlWriterSettings))]
		[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000497")]
		 set { } //Length: 152
	}

	[Token(Token = "0x170000D1")]
	public string NewLineChars
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600048C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000D0")]
	public NewLineHandling NewLineHandling
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600048B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000D4")]
	public bool NewLineOnAttributes
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000490")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000CF")]
	public bool OmitXmlDeclaration
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000489")]
		 get { } //Length: 5
		[Address(RVA = "0x1682D40", Offset = "0x1681F40", Length = "0x4D")]
		[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x600048A")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000DA")]
	public internal XmlOutputMethod OutputMethod
	{
		[Address(RVA = "0x33C7D0", Offset = "0x33B9D0", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000499")]
		 get { } //Length: 4
		[Address(RVA = "0x33C7F0", Offset = "0x33B9F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600049A")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170000E5")]
	internal bool ReadOnly
	{
		[Address(RVA = "0x1682D90", Offset = "0x1681F90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60004A9")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170000E1")]
	internal XmlStandalone Standalone
	{
		[Address(RVA = "0x504720", Offset = "0x503920", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A2")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x170000D9")]
	public bool WriteEndDocumentOnClose
	{
		[Address(RVA = "0x1682AE0", Offset = "0x1681CE0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000498")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x16828F0", Offset = "0x1681AF0", Length = "0x17D")]
	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XDocument", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Linq.SaveOptions"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XAttribute", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlWriterSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(XmlWriterSettings))]
	[CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000485")]
	public XmlWriterSettings() { }

	[Address(RVA = "0x1681CB0", Offset = "0x1680EB0", Length = "0xAF")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "set_Encoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "set_OmitXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "set_Indent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "set_CloseOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "set_NamespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceHandling)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Token(Token = "0x60004AA")]
	private void CheckReadOnly(string propertyName) { }

	[Address(RVA = "0x1681D60", Offset = "0x1680F60", Length = "0xE0")]
	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600049B")]
	public XmlWriterSettings Clone() { }

	[Address(RVA = "0x16824F0", Offset = "0x16816F0", Length = "0x2C7")]
	[CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QueryOutputWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRawWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "get_IsQuerySpecific", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004A8")]
	internal XmlWriter CreateWriter(TextWriter output) { }

	[Address(RVA = "0x16820B0", Offset = "0x16812B0", Length = "0x437")]
	[CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QueryOutputWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRawWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "get_IsQuerySpecific", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtf8RawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004A7")]
	internal XmlWriter CreateWriter(Stream output) { }

	[Address(RVA = "0x1681E50", Offset = "0x1681050", Length = "0x25B")]
	[CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004A6")]
	internal XmlWriter CreateWriter(string outputFileName) { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000486")]
	public bool get_Async() { }

	[Address(RVA = "0x1682A70", Offset = "0x1681C70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004A3")]
	internal bool get_AutoXmlDeclaration() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600049C")]
	internal List<XmlQualifiedName> get_CDataSectionElements() { }

	[Address(RVA = "0x3095E0", Offset = "0x3087E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000495")]
	public bool get_CheckCharacters() { }

	[Address(RVA = "0x145D760", Offset = "0x145C960", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000491")]
	public bool get_CloseOutput() { }

	[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000493")]
	public ConformanceLevel get_ConformanceLevel() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A1")]
	internal string get_DocTypePublic() { }

	[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A0")]
	internal string get_DocTypeSystem() { }

	[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600049D")]
	public bool get_DoNotEscapeUriAttributes() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000487")]
	public Encoding get_Encoding() { }

	[Address(RVA = "0x2F94D0", Offset = "0x2F86D0", Length = "0x8")]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600048D")]
	public bool get_Indent() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600048F")]
	public string get_IndentChars() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A4")]
	internal TriState get_IndentInternal() { }

	[Address(RVA = "0x1682A80", Offset = "0x1681C80", Length = "0x5F")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004A5")]
	internal bool get_IsQuerySpecific() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600049F")]
	internal string get_MediaType() { }

	[Address(RVA = "0x3D0200", Offset = "0x3CF400", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600049E")]
	internal bool get_MergeCDataSections() { }

	[Address(RVA = "0x1060130", Offset = "0x105F330", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000496")]
	public NamespaceHandling get_NamespaceHandling() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600048C")]
	public string get_NewLineChars() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600048B")]
	public NewLineHandling get_NewLineHandling() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000490")]
	public bool get_NewLineOnAttributes() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000489")]
	public bool get_OmitXmlDeclaration() { }

	[Address(RVA = "0x33C7D0", Offset = "0x33B9D0", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000499")]
	public XmlOutputMethod get_OutputMethod() { }

	[Address(RVA = "0x504720", Offset = "0x503920", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A2")]
	internal XmlStandalone get_Standalone() { }

	[Address(RVA = "0x1682AE0", Offset = "0x1681CE0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000498")]
	public bool get_WriteEndDocumentOnClose() { }

	[Address(RVA = "0x16827C0", Offset = "0x16819C0", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004AB")]
	private void Initialize() { }

	[Address(RVA = "0x1682AF0", Offset = "0x1681CF0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000492")]
	public void set_CloseOutput(bool value) { }

	[Address(RVA = "0x1682B40", Offset = "0x1681D40", Length = "0x98")]
	[CalledBy(Type = "System.Xml.Linq.XAttribute", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000494")]
	public void set_ConformanceLevel(ConformanceLevel value) { }

	[Address(RVA = "0x1682BE0", Offset = "0x1681DE0", Length = "0x58")]
	[CalledBy(Type = "System.Xml.Linq.XDocument", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Linq.SaveOptions"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000488")]
	public void set_Encoding(Encoding value) { }

	[Address(RVA = "0x1682C40", Offset = "0x1681E40", Length = "0x56")]
	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XDocument", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Linq.SaveOptions"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlWriterSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(XmlWriterSettings))]
	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600048E")]
	public void set_Indent(bool value) { }

	[Address(RVA = "0x1682CA0", Offset = "0x1681EA0", Length = "0x98")]
	[CalledBy(Type = "System.Xml.Linq.XDocument", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Linq.SaveOptions"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlWriterSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(XmlWriterSettings))]
	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000497")]
	public void set_NamespaceHandling(NamespaceHandling value) { }

	[Address(RVA = "0x1682D40", Offset = "0x1681F40", Length = "0x4D")]
	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600048A")]
	public void set_OmitXmlDeclaration(bool value) { }

	[Address(RVA = "0x33C7F0", Offset = "0x33B9F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600049A")]
	internal void set_OutputMethod(XmlOutputMethod value) { }

	[Address(RVA = "0x1682D90", Offset = "0x1681F90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004A9")]
	internal void set_ReadOnly(bool value) { }

}

