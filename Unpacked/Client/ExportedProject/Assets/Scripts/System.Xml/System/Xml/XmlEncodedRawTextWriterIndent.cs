namespace System.Xml;

[Token(Token = "0x2000034")]
internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter
{
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40000A8")]
	protected int indentLevel; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x40000A9")]
	protected bool newLineOnAttributes; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40000AA")]
	protected string indentChars; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40000AB")]
	protected bool mixedContent; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000AC")]
	private BitStack mixedContentStack; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40000AD")]
	protected ConformanceLevel conformanceLevel; //Field offset: 0xD8

	[Address(RVA = "0x1634920", Offset = "0x1633B20", Length = "0x30")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Token(Token = "0x600018A")]
	public XmlEncodedRawTextWriterIndent(TextWriter writer, XmlWriterSettings settings) { }

	[Address(RVA = "0x1634950", Offset = "0x1633B50", Length = "0x30")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Token(Token = "0x600018B")]
	public XmlEncodedRawTextWriterIndent(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x1633E60", Offset = "0x1633060", Length = "0x129")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600019F")]
	private void Init(XmlWriterSettings settings) { }

	[Address(RVA = "0x1633F90", Offset = "0x1633190", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600018F")]
	internal virtual void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	[Address(RVA = "0x1633FA0", Offset = "0x16331A0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600018E")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x1634010", Offset = "0x1633210", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Base64Encoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600019E")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1634120", Offset = "0x1633320", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000193")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x1634130", Offset = "0x1633330", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000197")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x1634140", Offset = "0x1633340", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600019B")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x16341E0", Offset = "0x16333E0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000194")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x1634220", Offset = "0x1633420", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600018C")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x1634290", Offset = "0x1633490", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000190")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1634370", Offset = "0x1633570", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000196")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x1634450", Offset = "0x1633650", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteFullEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000191")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1634530", Offset = "0x1633730", Length = "0x97")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteFullEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteProcessingInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001A0")]
	private void WriteIndent() { }

	[Address(RVA = "0x16345D0", Offset = "0x16337D0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteProcessingInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000195")]
	public virtual void WriteProcessingInstruction(string target, string text) { }

	[Address(RVA = "0x1634620", Offset = "0x1633820", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600019C")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x16346B0", Offset = "0x16338B0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600019D")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x1634720", Offset = "0x1633920", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000192")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1634780", Offset = "0x1633980", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitStack), Member = "PushBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600018D")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1634810", Offset = "0x1633A10", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600019A")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x1634890", Offset = "0x1633A90", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000198")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x16348A0", Offset = "0x1633AA0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000199")]
	public virtual void WriteWhitespace(string ws) { }

}

