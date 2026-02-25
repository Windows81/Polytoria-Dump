namespace System.Xml;

[Token(Token = "0x200009C")]
internal struct XmlCharType
{
	[Token(Token = "0x40003ED")]
	private static object s_Lock; //Field offset: 0x0
	[Token(Token = "0x40003EE")]
	private static Byte[] s_CharProperties; //Field offset: 0x8
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003EF")]
	internal Byte[] charProperties; //Field offset: 0x0

	[Token(Token = "0x170001BC")]
	public static XmlCharType Instance
	{
		[Address(RVA = "0x1691B00", Offset = "0x1690D00", Length = "0x79")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(XmlCharType), Member = "InitInstance", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600073B")]
		 get { } //Length: 121
	}

	[Token(Token = "0x170001BB")]
	private static object StaticLock
	{
		[Address(RVA = "0x1691B80", Offset = "0x1690D80", Length = "0x92")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000737")]
		private get { } //Length: 146
	}

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600073A")]
	private XmlCharType(Byte[] charProperties) { }

	[Address(RVA = "0x1690F00", Offset = "0x1690100", Length = "0x12")]
	[CalledBy(Type = typeof(CharEntityEncoderFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CharEntityEncoderFallbackBuffer), Member = "SurrogateCharToUtf32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(Byte*)}, ReturnType = typeof(Byte*))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x6000747")]
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	[Address(RVA = "0x1691B00", Offset = "0x1690D00", Length = "0x79")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(XmlCharType), Member = "InitInstance", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600073B")]
	public static XmlCharType get_Instance() { }

	[Address(RVA = "0x1691B80", Offset = "0x1690D80", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000737")]
	private static object get_StaticLock() { }

	[Address(RVA = "0x1690F20", Offset = "0x1690120", Length = "0x5C2")]
	[CalledBy(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[CalledBy(Type = typeof(XmlComplianceUtil), Member = "NonCDataNormalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000738")]
	private static void InitInstance() { }

	[Address(RVA = "0x131B800", Offset = "0x131AA00", Length = "0xC")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600074E")]
	private static bool InRange(int value, int start, int end) { }

	[Address(RVA = "0x16914F0", Offset = "0x16906F0", Length = "0x31")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000740")]
	public bool IsCharData(char ch) { }

	[Address(RVA = "0x148BAF0", Offset = "0x148ACF0", Length = "0xD")]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000743")]
	public static bool IsDigit(char ch) { }

	[Address(RVA = "0x1691530", Offset = "0x1690730", Length = "0xF")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), "System.Xml.XmlTextReaderImpl+NodeData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteSurrogateChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteRawWithSurrogateChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000744")]
	internal static bool IsHighSurrogate(int ch) { }

	[Address(RVA = "0x1691540", Offset = "0x1690740", Length = "0xF")]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteRawWithSurrogateChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteSurrogateChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), "System.Xml.XmlTextReaderImpl+NodeData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 17)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000745")]
	internal static bool IsLowSurrogate(int ch) { }

	[Address(RVA = "0x1691590", Offset = "0x1690790", Length = "0x3E")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection1", ReturnType = "System.Xml.DtdParser+Token")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600073F")]
	public bool IsNameSingleChar(char ch) { }

	[Address(RVA = "0x1691550", Offset = "0x1690750", Length = "0x31")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600073D")]
	public bool IsNCNameSingleChar(char ch) { }

	[Address(RVA = "0x16915D0", Offset = "0x16907D0", Length = "0xCF")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600074B")]
	internal int IsOnlyCharData(string str) { }

	[Address(RVA = "0x16916A0", Offset = "0x16908A0", Length = "0x77")]
	[CalledBy(Type = typeof(XmlDeclaration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDeclaration), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDeclaration), Member = "IsValidXmlVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600074C")]
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	[Address(RVA = "0x16917A0", Offset = "0x16909A0", Length = "0x80")]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteCData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "TextBlockCreatesWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlCharacterData), Member = "CheckOnData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSignificantWhitespace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSignificantWhitespace), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWhitespace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWhitespace), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000749")]
	internal bool IsOnlyWhitespace(string str) { }

	[Address(RVA = "0x1691720", Offset = "0x1690920", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600074A")]
	internal int IsOnlyWhitespaceWithPos(string str) { }

	[Address(RVA = "0x1691830", Offset = "0x1690A30", Length = "0x70")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+Token", "System.Xml.DtdParser+Token", typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlCharType), Member = "IsPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000741")]
	public bool IsPubidChar(char ch) { }

	[Address(RVA = "0x16918B0", Offset = "0x1690AB0", Length = "0x6F")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XmlCharType), Member = "IsPubidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600074D")]
	internal int IsPublicId(string str) { }

	[Address(RVA = "0x1691920", Offset = "0x1690B20", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600073E")]
	public bool IsStartNCNameSingleChar(char ch) { }

	[Address(RVA = "0x1691960", Offset = "0x1690B60", Length = "0xF")]
	[CallerCount(Count = 22)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000746")]
	internal static bool IsSurrogate(int ch) { }

	[Address(RVA = "0x1691970", Offset = "0x1690B70", Length = "0x31")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000742")]
	internal bool IsTextChar(char ch) { }

	[Address(RVA = "0x16919B0", Offset = "0x1690BB0", Length = "0x30")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.XmlWellFormedWriter+AttributeValueCache", Member = "Trim", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600073C")]
	public bool IsWhiteSpace(char ch) { }

	[Address(RVA = "0x16919F0", Offset = "0x1690BF0", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000739")]
	private static void SetProperties(Byte[] chProps, string ranges, byte value) { }

	[Address(RVA = "0x1691AC0", Offset = "0x1690CC0", Length = "0x37")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000748")]
	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

}

