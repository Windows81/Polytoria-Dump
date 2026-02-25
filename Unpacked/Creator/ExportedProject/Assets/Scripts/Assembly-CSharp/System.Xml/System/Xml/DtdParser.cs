namespace System.Xml;

[Token(Token = "0x2000094")]
internal class DtdParser : IDtdParser
{
	[Token(Token = "0x2000097")]
	private enum LiteralType
	{
		AttributeValue = 0,
		EntityReplText = 1,
		SystemOrPublicID = 2,
	}

	[Token(Token = "0x2000099")]
	private class ParseElementOnlyContent_LocalFrame
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003DC")]
		public int startParenEntityId; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40003DD")]
		public Token parsingSchema; //Field offset: 0x14

		[Address(RVA = "0x168FA30", Offset = "0x168EC30", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600072B")]
		public ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam) { }

	}

	[Token(Token = "0x2000096")]
	private enum ScanningFunction
	{
		SubsetContent = 0,
		Name = 1,
		QName = 2,
		Nmtoken = 3,
		Doctype1 = 4,
		Doctype2 = 5,
		Element1 = 6,
		Element2 = 7,
		Element3 = 8,
		Element4 = 9,
		Element5 = 10,
		Element6 = 11,
		Element7 = 12,
		Attlist1 = 13,
		Attlist2 = 14,
		Attlist3 = 15,
		Attlist4 = 16,
		Attlist5 = 17,
		Attlist6 = 18,
		Attlist7 = 19,
		Entity1 = 20,
		Entity2 = 21,
		Entity3 = 22,
		Notation1 = 23,
		CondSection1 = 24,
		CondSection2 = 25,
		CondSection3 = 26,
		Literal = 27,
		SystemId = 28,
		PublicId1 = 29,
		PublicId2 = 30,
		ClosingTag = 31,
		ParamEntitySpace = 32,
		None = 33,
	}

	[Token(Token = "0x2000095")]
	private enum Token
	{
		CDATA = 0,
		ID = 1,
		IDREF = 2,
		IDREFS = 3,
		ENTITY = 4,
		ENTITIES = 5,
		NMTOKEN = 6,
		NMTOKENS = 7,
		NOTATION = 8,
		None = 9,
		PERef = 10,
		AttlistDecl = 11,
		ElementDecl = 12,
		EntityDecl = 13,
		NotationDecl = 14,
		Comment = 15,
		PI = 16,
		CondSectionStart = 17,
		CondSectionEnd = 18,
		Eof = 19,
		REQUIRED = 20,
		IMPLIED = 21,
		FIXED = 22,
		QName = 23,
		Name = 24,
		Nmtoken = 25,
		Quote = 26,
		LeftParen = 27,
		RightParen = 28,
		GreaterThan = 29,
		Or = 30,
		LeftBracket = 31,
		RightBracket = 32,
		PUBLIC = 33,
		SYSTEM = 34,
		Literal = 35,
		DOCTYPE = 36,
		NData = 37,
		Percent = 38,
		Star = 39,
		QMark = 40,
		Plus = 41,
		PCDATA = 42,
		Comma = 43,
		ANY = 44,
		EMPTY = 45,
		IGNORE = 46,
		INCLUDE = 47,
	}

	[Token(Token = "0x2000098")]
	private class UndeclaredNotation
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003D8")]
		internal string name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003D9")]
		internal int lineNo; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40003DA")]
		internal int linePos; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003DB")]
		internal UndeclaredNotation next; //Field offset: 0x20

		[Address(RVA = "0x1690310", Offset = "0x168F510", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600072A")]
		internal UndeclaredNotation(string name, int lineNo, int linePos) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400035F")]
	private IDtdParserAdapter readerAdapter; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000360")]
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000361")]
	private XmlNameTable nameTable; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000362")]
	private SchemaInfo schemaInfo; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000363")]
	private XmlCharType xmlCharType; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000364")]
	private string systemId; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000365")]
	private string publicId; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000366")]
	private bool normalize; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x4000367")]
	private bool validate; //Field offset: 0x49
	[FieldOffset(Offset = "0x4A")]
	[Token(Token = "0x4000368")]
	private bool supportNamespaces; //Field offset: 0x4A
	[FieldOffset(Offset = "0x4B")]
	[Token(Token = "0x4000369")]
	private bool v1Compat; //Field offset: 0x4B
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400036A")]
	private Char[] chars; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400036B")]
	private int charsUsed; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400036C")]
	private int curPos; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400036D")]
	private ScanningFunction scanningFunction; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400036E")]
	private ScanningFunction nextScaningFunction; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400036F")]
	private ScanningFunction savedScanningFunction; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000370")]
	private bool whitespaceSeen; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000371")]
	private int tokenStartPos; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000372")]
	private int colonPos; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000373")]
	private StringBuilder internalSubsetValueSb; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000374")]
	private int externalEntitiesDepth; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000375")]
	private int currentEntityId; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000376")]
	private bool freeFloatingDtd; //Field offset: 0x88
	[FieldOffset(Offset = "0x89")]
	[Token(Token = "0x4000377")]
	private bool hasFreeFloatingInternalSubset; //Field offset: 0x89
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000378")]
	private StringBuilder stringBuilder; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000379")]
	private int condSectionDepth; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x400037A")]
	private LineInfo literalLineInfo; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x400037B")]
	private char literalQuoteChar; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400037C")]
	private string documentBaseUri; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400037D")]
	private string externalDtdBaseUri; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400037E")]
	private Dictionary<String, UndeclaredNotation> undeclaredNotations; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400037F")]
	private Int32[] condSectionEntityIds; //Field offset: 0xC0

	[Token(Token = "0x170001BA")]
	private string BaseUriStr
	{
		[Address(RVA = "0x168EDA0", Offset = "0x168DFA0", Length = "0xB1")]
		[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600071E")]
		private get { } //Length: 177
	}

	[Token(Token = "0x170001B3")]
	private bool IgnoreEntityReferences
	{
		[Address(RVA = "0x168EE60", Offset = "0x168E060", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60006C9")]
		private get { } //Length: 8
	}

	[Token(Token = "0x170001B8")]
	private int LineNo
	{
		[Address(RVA = "0x168EE70", Offset = "0x168E070", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600071C")]
		private get { } //Length: 73
	}

	[Token(Token = "0x170001B9")]
	private int LinePos
	{
		[Address(RVA = "0x168EEC0", Offset = "0x168E0C0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600071D")]
		private get { } //Length: 90
	}

	[Token(Token = "0x170001B7")]
	private bool Normalize
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006CD")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170001B2")]
	private bool ParsingInternalSubset
	{
		[Address(RVA = "0x168EF20", Offset = "0x168E120", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60006C8")]
		private get { } //Length: 11
	}

	[Token(Token = "0x170001B5")]
	private bool ParsingTopLevelMarkup
	{
		[Address(RVA = "0x168EF30", Offset = "0x168E130", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60006CB")]
		private get { } //Length: 26
	}

	[Token(Token = "0x170001B4")]
	private bool SaveInternalSubsetValue
	{
		[Address(RVA = "0x168EF50", Offset = "0x168E150", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60006CA")]
		private get { } //Length: 94
	}

	[Token(Token = "0x170001B6")]
	private bool SupportNamespaces
	{
		[Address(RVA = "0x168EFB0", Offset = "0x168E1B0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006CC")]
		private get { } //Length: 5
	}

	[Address(RVA = "0x168ECC0", Offset = "0x168DEC0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006C2")]
	private DtdParser() { }

	[Address(RVA = "0x1683070", Offset = "0x1682270", Length = "0x222")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006DD")]
	private void AddUndeclaredNotation(string notationName) { }

	[Address(RVA = "0x16832A0", Offset = "0x16824A0", Length = "0xFD")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDtd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDtdFromParserContext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006C3")]
	internal static IDtdParser Create() { }

	[Address(RVA = "0x16833A0", Offset = "0x16825A0", Length = "0xB9")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanDoctype1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanNotation1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntity2", ReturnType = typeof(Token))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000709")]
	private bool EatPublicKeyword() { }

	[Address(RVA = "0x1683460", Offset = "0x1682660", Length = "0xB9")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanDoctype1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanNotation1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntity2", ReturnType = typeof(Token))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600070A")]
	private bool EatSystemKeyword() { }

	[Address(RVA = "0x168EDA0", Offset = "0x168DFA0", Length = "0xB1")]
	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600071E")]
	private string get_BaseUriStr() { }

	[Address(RVA = "0x168EE60", Offset = "0x168E060", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006C9")]
	private bool get_IgnoreEntityReferences() { }

	[Address(RVA = "0x168EE70", Offset = "0x168E070", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600071C")]
	private int get_LineNo() { }

	[Address(RVA = "0x168EEC0", Offset = "0x168E0C0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600071D")]
	private int get_LinePos() { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CD")]
	private bool get_Normalize() { }

	[Address(RVA = "0x168EF20", Offset = "0x168E120", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006C8")]
	private bool get_ParsingInternalSubset() { }

	[Address(RVA = "0x168EF30", Offset = "0x168E130", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006CB")]
	private bool get_ParsingTopLevelMarkup() { }

	[Address(RVA = "0x168EF50", Offset = "0x168E150", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006CA")]
	private bool get_SaveInternalSubsetValue() { }

	[Address(RVA = "0x168EFB0", Offset = "0x168E1B0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CC")]
	private bool get_SupportNamespaces() { }

	[Address(RVA = "0x1683520", Offset = "0x1682720", Length = "0x1AA")]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600070B")]
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	[Address(RVA = "0x16836D0", Offset = "0x16828D0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x600070C")]
	private string GetNameString() { }

	[Address(RVA = "0x16836D0", Offset = "0x16828D0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x600070D")]
	private string GetNmtokenString() { }

	[Address(RVA = "0x1683700", Offset = "0x1682900", Length = "0x12B8")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseCondSection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseHowMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 48)]
	[Calls(Type = typeof(DtdParser), Member = "ScanElement2", ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "EatSystemKeyword", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "EatPublicKeyword", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "ScanElement1", ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(DtdParser), Member = "ScanAttlist6", ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(DtdParser), Member = "ScanCondSection1", ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ScanAttlist2", ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "ScanSubsetContent", ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "ParseUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60006E2")]
	private Token GetToken(bool needWhiteSpace) { }

	[Address(RVA = "0x1684AD0", Offset = "0x1683CD0", Length = "0x73")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600070E")]
	private string GetValue() { }

	[Address(RVA = "0x1684A40", Offset = "0x1683C40", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdParser), Member = "StripSpaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600070F")]
	private string GetValueWithStrippedSpaces() { }

	[Address(RVA = "0x1684B50", Offset = "0x1683D50", Length = "0x15A")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = typeof(Token))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000716")]
	private bool HandleEntityEnd(bool inLiteral) { }

	[Address(RVA = "0x1684FA0", Offset = "0x16841A0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000714")]
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	[Address(RVA = "0x1684CB0", Offset = "0x1683EB0", Length = "0x2E1")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000715")]
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	[Address(RVA = "0x1685500", Offset = "0x1684700", Length = "0x2B7")]
	[CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "System.Xml.IDtdParser.ParseInternalDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdParserAdapter), typeof(bool)}, ReturnType = typeof(IDtdInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60006C4")]
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	[Address(RVA = "0x1685010", Offset = "0x1684210", Length = "0x4E8")]
	[CalledBy(Type = typeof(DtdParser), Member = "System.Xml.IDtdParser.ParseFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(IDtdInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidNameArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(ArgumentException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(XmlCharType), Member = "IsPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyCharData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidNameCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ValidateNames), Member = "ParseNameNoNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DtdParser), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60006C5")]
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	[Address(RVA = "0x16857C0", Offset = "0x16849C0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600071B")]
	private bool IsAttributeValueType(Token token) { }

	[Address(RVA = "0x16857D0", Offset = "0x16849D0", Length = "0x10E")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000711")]
	private void LoadParsingBuffer() { }

	[Address(RVA = "0x16858E0", Offset = "0x1684AE0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600071F")]
	private void OnUnexpectedError() { }

	[Address(RVA = "0x1689140", Offset = "0x1688340", Length = "0x27A")]
	[CalledBy(Type = typeof(DtdParser), Member = "System.Xml.IDtdParser.ParseInternalDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdParserAdapter), typeof(bool)}, ReturnType = typeof(IDtdInfo))]
	[CalledBy(Type = typeof(DtdParser), Member = "System.Xml.IDtdParser.ParseFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(IDtdInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaInfo), Member = "Finish", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "ParseExternalSubset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60006CE")]
	private void Parse(bool saveInternalSubset) { }

	[Address(RVA = "0x1685940", Offset = "0x1684B40", Length = "0x614")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(SchemaAttDef), Member = "get_DefaultValueExpanded", ReturnType = typeof(string))]
	[Calls(Type = typeof(SchemaAttDef), Member = "CheckXmlSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_Prefix", ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "GetAttDef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(SchemaAttDef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "AddAttDef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006D4")]
	private void ParseAttlistDecl() { }

	[Address(RVA = "0x1685F60", Offset = "0x1685160", Length = "0x26D")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "GetValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdParser), Member = "StripSpaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DtdValidator), Member = "SetDefaultTypedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60006D6")]
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	[Address(RVA = "0x16861D0", Offset = "0x16853D0", Length = "0x705")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaInfo), Member = "get_Notations", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.Xml.Schema.SchemaNotation>))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "GetAttDef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "AddUndeclaredNotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlSchemaType), Member = "GetBuiltInSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Calls(Type = typeof(SchemaAttDef), Member = "set_TokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60006D5")]
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	[Address(RVA = "0x16868E0", Offset = "0x1685AE0", Length = "0x190")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006DE")]
	private void ParseComment() { }

	[Address(RVA = "0x1686A80", Offset = "0x1685C80", Length = "0x2B0")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006E0")]
	private void ParseCondSection() { }

	[Address(RVA = "0x1686D40", Offset = "0x1685F40", Length = "0x455")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[Calls(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "OpenGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006D7")]
	private void ParseElementDecl() { }

	[Address(RVA = "0x16871A0", Offset = "0x16863A0", Length = "0x2D1")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddChoice", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "CloseGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006DA")]
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	[Address(RVA = "0x1687480", Offset = "0x1686680", Length = "0x3F6")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddPlus", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "CloseGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "OpenGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddQMark", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddChoice", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60006D8")]
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	[Address(RVA = "0x1687880", Offset = "0x1686A80", Length = "0x3E7")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaInfo), Member = "get_GeneralEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(DtdParser), Member = "GetValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdParser), Member = "AddUndeclaredNotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = "get_Notations", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.Xml.Schema.SchemaNotation>))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaEntity), Member = "set_Url", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = "get_ParameterEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SchemaEntity), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
	[Calls(Type = typeof(SchemaEntity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006DB")]
	private void ParseEntityDecl() { }

	[Address(RVA = "0x1687C70", Offset = "0x1686E70", Length = "0x4C3")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DtdParser), Member = "GetValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009410")]
	[Calls(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlCharType), Member = "IsPubidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60006E1")]
	private void ParseExternalId(Token idTokenType, Token declType, out string publicId, out string systemId) { }

	[Address(RVA = "0x1688140", Offset = "0x1687340", Length = "0x192")]
	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseFreeFloatingDtd", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60006D2")]
	private void ParseExternalSubset() { }

	[Address(RVA = "0x16882E0", Offset = "0x16874E0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseExternalSubset", ReturnType = typeof(void))]
	[Token(Token = "0x60006D0")]
	private void ParseFreeFloatingDtd() { }

	[Address(RVA = "0x1688340", Offset = "0x1687540", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddPlus", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddQMark", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006D9")]
	private void ParseHowMany(ParticleContentValidator pcv) { }

	[Address(RVA = "0x16883B0", Offset = "0x16875B0", Length = "0x1F3")]
	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DtdParser), Member = "ParseExternalSubset", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60006CF")]
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	[Address(RVA = "0x16885B0", Offset = "0x16877B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[Token(Token = "0x60006D1")]
	private void ParseInternalSubset() { }

	[Address(RVA = "0x16885C0", Offset = "0x16877C0", Length = "0x2E3")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaInfo), Member = "get_Notations", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.Xml.Schema.SchemaNotation>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006DC")]
	private void ParseNotationDecl() { }

	[Address(RVA = "0x16888B0", Offset = "0x1687AB0", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006DF")]
	private void ParsePI() { }

	[Address(RVA = "0x16889B0", Offset = "0x1687BB0", Length = "0x67C")]
	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseFreeFloatingDtd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseInternalSubset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalSubset", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DtdParser), Member = "ParseComment", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseCondSection", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60006D3")]
	private void ParseSubset() { }

	[Address(RVA = "0x1689050", Offset = "0x1688250", Length = "0xE1")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000728")]
	private string ParseUnexpectedToken(int startPos) { }

	[Address(RVA = "0x1689400", Offset = "0x1688600", Length = "0x70")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntity3", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ReadDataInName", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdParser), Member = "EatPublicKeyword", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdParser), Member = "EatSystemKeyword", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000710")]
	private int ReadData() { }

	[Address(RVA = "0x16893C0", Offset = "0x16885C0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000707")]
	private bool ReadDataInName() { }

	[Address(RVA = "0x1689570", Offset = "0x1688770", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000712")]
	private void SaveParsingBuffer() { }

	[Address(RVA = "0x1689480", Offset = "0x1688680", Length = "0xE2")]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdParser), Member = "SaveParsingBuffer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist6", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist2", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanElement1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanSubsetContent", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParsePI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseComment", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseFreeFloatingDtd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanElement2", ReturnType = typeof(Token))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000713")]
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	[Address(RVA = "0x1689580", Offset = "0x1688780", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "ParseUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006F1")]
	private Token ScanAttlist1() { }

	[Address(RVA = "0x1689650", Offset = "0x1688850", Length = "0x7A2")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006F2")]
	private Token ScanAttlist2() { }

	[Address(RVA = "0x1689E00", Offset = "0x1689000", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006F3")]
	private Token ScanAttlist3() { }

	[Address(RVA = "0x1689EA0", Offset = "0x16890A0", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006F4")]
	private Token ScanAttlist4() { }

	[Address(RVA = "0x1689F70", Offset = "0x1689170", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006F5")]
	private Token ScanAttlist5() { }

	[Address(RVA = "0x168A040", Offset = "0x1689240", Length = "0x480")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006F6")]
	private Token ScanAttlist6() { }

	[Address(RVA = "0x168A4D0", Offset = "0x16896D0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006F7")]
	private Token ScanAttlist7() { }

	[Address(RVA = "0x168A580", Offset = "0x1689780", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006E9")]
	private Token ScanClosingTag() { }

	[Address(RVA = "0x168A600", Offset = "0x1689800", Length = "0x35B")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlCharType), Member = "IsNameSingleChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000701")]
	private Token ScanCondSection1() { }

	[Address(RVA = "0x168A960", Offset = "0x1689B60", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000702")]
	private Token ScanCondSection2() { }

	[Address(RVA = "0x168A9E0", Offset = "0x1689BE0", Length = "0x61B")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000703")]
	private Token ScanCondSection3() { }

	[Address(RVA = "0x168B000", Offset = "0x168A200", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "EatSystemKeyword", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "EatPublicKeyword", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006E7")]
	private Token ScanDoctype1() { }

	[Address(RVA = "0x168B180", Offset = "0x168A380", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006E8")]
	private Token ScanDoctype2() { }

	[Address(RVA = "0x168B240", Offset = "0x168A440", Length = "0x275")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006EA")]
	private Token ScanElement1() { }

	[Address(RVA = "0x168B4C0", Offset = "0x168A6C0", Length = "0x218")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006EB")]
	private Token ScanElement2() { }

	[Address(RVA = "0x168B6E0", Offset = "0x168A8E0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006EC")]
	private Token ScanElement3() { }

	[Address(RVA = "0x168B760", Offset = "0x168A960", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006ED")]
	private Token ScanElement4() { }

	[Address(RVA = "0x168B840", Offset = "0x168AA40", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006EE")]
	private Token ScanElement5() { }

	[Address(RVA = "0x168B940", Offset = "0x168AB40", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006EF")]
	private Token ScanElement6() { }

	[Address(RVA = "0x168BA10", Offset = "0x168AC10", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006F0")]
	private Token ScanElement7() { }

	[Address(RVA = "0x168BA60", Offset = "0x168AC60", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006FC")]
	private Token ScanEntity1() { }

	[Address(RVA = "0x168BAD0", Offset = "0x168ACD0", Length = "0x17C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "EatPublicKeyword", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "EatSystemKeyword", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006FD")]
	private Token ScanEntity2() { }

	[Address(RVA = "0x168BC50", Offset = "0x168AE50", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006FE")]
	private Token ScanEntity3() { }

	[Address(RVA = "0x168BD50", Offset = "0x168AF50", Length = "0x100")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006F9")]
	private XmlQualifiedName ScanEntityName() { }

	[Address(RVA = "0x168BE60", Offset = "0x168B060", Length = "0xE08")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist6", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist7", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanSystemId", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntity2", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanPublicId1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanPublicId2", ReturnType = typeof(Token))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DtdParser), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(SchemaInfo), Member = "get_GeneralEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180182D70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x60006F8")]
	private Token ScanLiteral(LiteralType literalType) { }

	[Address(RVA = "0x168CCB0", Offset = "0x168BEB0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000704")]
	private void ScanName() { }

	[Address(RVA = "0x168CC80", Offset = "0x168BE80", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006E4")]
	private Token ScanNameExpected() { }

	[Address(RVA = "0x168CCF0", Offset = "0x168BEF0", Length = "0x1C9")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanNmtokenExpected", ReturnType = typeof(Token))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000708")]
	private void ScanNmtoken() { }

	[Address(RVA = "0x168CCC0", Offset = "0x168BEC0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
	[Token(Token = "0x60006E6")]
	private Token ScanNmtokenExpected() { }

	[Address(RVA = "0x168CEC0", Offset = "0x168C0C0", Length = "0x13E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "EatPublicKeyword", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "EatSystemKeyword", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006FA")]
	private Token ScanNotation1() { }

	[Address(RVA = "0x168D000", Offset = "0x168C200", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006FF")]
	private Token ScanPublicId1() { }

	[Address(RVA = "0x168D0B0", Offset = "0x168C2B0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000700")]
	private Token ScanPublicId2() { }

	[Address(RVA = "0x168D150", Offset = "0x168C350", Length = "0x276")]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanName", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanNameExpected", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanQNameExpected", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanElement3", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntity1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanQName", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000706")]
	private void ScanQName(bool isQName) { }

	[Address(RVA = "0x168D3D0", Offset = "0x168C5D0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000705")]
	private void ScanQName() { }

	[Address(RVA = "0x168D120", Offset = "0x168C320", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006E5")]
	private Token ScanQNameExpected() { }

	[Address(RVA = "0x168D3E0", Offset = "0x168C5E0", Length = "0x85F")]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006E3")]
	private Token ScanSubsetContent() { }

	[Address(RVA = "0x168DC40", Offset = "0x168CE40", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006FB")]
	private Token ScanSystemId() { }

	[Address(RVA = "0x168DE50", Offset = "0x168D050", Length = "0x132")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseComment", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000719")]
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	[Address(RVA = "0x168DCF0", Offset = "0x168CEF0", Length = "0x152")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseCondSection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
	[Token(Token = "0x6000718")]
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	[Address(RVA = "0x168DF90", Offset = "0x168D190", Length = "0xF4")]
	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600071A")]
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	[Address(RVA = "0x168E090", Offset = "0x168D290", Length = "0x1DA")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetValueWithStrippedSpaces", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000729")]
	internal static string StripSpaces(string value) { }

	[Address(RVA = "0x168E270", Offset = "0x168D470", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C7")]
	private override IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	[Address(RVA = "0x168E2C0", Offset = "0x168D4C0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006C6")]
	private override IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	[Address(RVA = "0x168E590", Offset = "0x168D790", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000720")]
	private void Throw(int curPos, string res) { }

	[Address(RVA = "0x168E5C0", Offset = "0x168D7C0", Length = "0x1BC")]
	[CallerCount(Count = 93)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000721")]
	private void Throw(int curPos, string res, string arg) { }

	[Address(RVA = "0x168E8C0", Offset = "0x168DAC0", Length = "0x1BC")]
	[CalledBy(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LiteralType)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = typeof(Token))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000722")]
	private void Throw(int curPos, string res, String[] args) { }

	[Address(RVA = "0x168E780", Offset = "0x168D980", Length = "0x13B")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000723")]
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	[Address(RVA = "0x168E380", Offset = "0x168D580", Length = "0x79")]
	[CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000724")]
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	[Address(RVA = "0x168E300", Offset = "0x168D500", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000725")]
	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	[Address(RVA = "0x168E400", Offset = "0x168D600", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000726")]
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	[Address(RVA = "0x168E420", Offset = "0x168D620", Length = "0x16B")]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist7", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection2", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanPublicId1", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanSystemId", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist5", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist4", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist3", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanClosingTag", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleContentValidator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanElement6", ReturnType = typeof(Token))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DtdParser), Member = "ParseUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000727")]
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	[Address(RVA = "0x168EA80", Offset = "0x168DC80", Length = "0x234")]
	[CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SchemaInfo), Member = "get_GeneralEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(SchemaInfo), Member = "get_ParameterEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSeverityType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000717")]
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

}

