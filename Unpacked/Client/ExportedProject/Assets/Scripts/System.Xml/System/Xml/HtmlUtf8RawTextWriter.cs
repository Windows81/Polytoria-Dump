namespace System.Xml;

[Token(Token = "0x2000015")]
internal class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter
{
	[Token(Token = "0x4000045")]
	protected static TernaryTreeReadOnly elementPropertySearch; //Field offset: 0x0
	[Token(Token = "0x4000046")]
	protected static TernaryTreeReadOnly attributePropertySearch; //Field offset: 0x8
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400003E")]
	protected ByteStack elementScope; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400003F")]
	protected ElementProperties currentElementProperties; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000040")]
	private AttributeProperties currentAttributeProperties; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000041")]
	private bool endsWithAmpersand; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000042")]
	private Byte[] uriEscapingBuffer; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000043")]
	private string mediaType; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000044")]
	private bool doNotEscapeUriAttributes; //Field offset: 0xB0

	[Address(RVA = "0x1631090", Offset = "0x1630290", Length = "0x30")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000050")]
	public HtmlUtf8RawTextWriter(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x162FB30", Offset = "0x162ED30", Length = "0x248")]
	[CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000060")]
	private void Init(XmlWriterSettings settings) { }

	[Address(RVA = "0x162FD80", Offset = "0x162EF80", Length = "0x94")]
	[CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteEndAttribute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlAttributeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteUriAttributeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000066")]
	private void OutputRestAmps() { }

	[Address(RVA = "0x162FE20", Offset = "0x162F020", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteMetaElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000055")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x162FE70", Offset = "0x162F070", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600005D")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x162FED0", Offset = "0x162F0D0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600005F")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x162FF20", Offset = "0x162F120", Length = "0x1EC")]
	[CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000053")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x1630110", Offset = "0x162F310", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "OutputRestAmps", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000059")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x1630180", Offset = "0x162F380", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000056")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1630290", Offset = "0x162F490", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600005C")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x16302F0", Offset = "0x162F4F0", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteFullEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000057")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1630450", Offset = "0x162F650", Length = "0x2B6")]
	[CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "OutputRestAmps", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(Byte*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "QuoteEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*)}, ReturnType = typeof(Byte*))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "AmpEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*)}, ReturnType = typeof(Byte*))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "CarriageReturnEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*)}, ReturnType = typeof(Byte*))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "LineFeedEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*)}, ReturnType = typeof(Byte*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000064")]
	private void WriteHtmlAttributeText(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x1630400", Offset = "0x162F600", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteUriAttributeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000063")]
	protected void WriteHtmlAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x1630710", Offset = "0x162F910", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000062")]
	protected void WriteHtmlElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x1630730", Offset = "0x162F930", Length = "0x10E")]
	[CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "StartElementContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = "StartElementContent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000061")]
	protected void WriteMetaElement() { }

	[Address(RVA = "0x1630840", Offset = "0x162FA40", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005A")]
	public virtual void WriteProcessingInstruction(string target, string text) { }

	[Address(RVA = "0x1630940", Offset = "0x162FB40", Length = "0x159")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TernaryTreeReadOnly), Member = "FindCaseInsensitiveString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000058")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1630AA0", Offset = "0x162FCA0", Length = "0x10B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ByteStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TernaryTreeReadOnly), Member = "FindCaseInsensitiveString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000054")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1630BB0", Offset = "0x162FDB0", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlAttributeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600005B")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x1630C90", Offset = "0x162FE90", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600005E")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x1630CF0", Offset = "0x162FEF0", Length = "0x397")]
	[CalledBy(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteHtmlAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "OutputRestAmps", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "QuoteEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*)}, ReturnType = typeof(Byte*))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "AmpEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*)}, ReturnType = typeof(Byte*))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "CarriageReturnEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*)}, ReturnType = typeof(Byte*))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "CharToUTF8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(Byte*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "LineFeedEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*)}, ReturnType = typeof(Byte*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000065")]
	private void WriteUriAttributeText(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000052")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000051")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

}

