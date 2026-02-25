namespace System.Xml;

[Token(Token = "0x2000057")]
internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter
{
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400022F")]
	protected int indentLevel; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000230")]
	protected bool newLineOnAttributes; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000231")]
	protected string indentChars; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000232")]
	protected bool mixedContent; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000233")]
	private BitStack mixedContentStack; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000234")]
	protected ConformanceLevel conformanceLevel; //Field offset: 0xA8

	[Address(RVA = "0x165FF00", Offset = "0x165F100", Length = "0x121")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BitStack), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003F9")]
	public XmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x165F310", Offset = "0x165E510", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BitStack), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600040D")]
	private void Init(XmlWriterSettings settings) { }

	[Address(RVA = "0x165F430", Offset = "0x165E630", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003FD")]
	internal virtual void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	[Address(RVA = "0x165F440", Offset = "0x165E640", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003FC")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x165F4B0", Offset = "0x165E6B0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlRawWriter), Member = "WriteBase64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600040C")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x165F4D0", Offset = "0x165E6D0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000401")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x165F4E0", Offset = "0x165E6E0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000405")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x165F4F0", Offset = "0x165E6F0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000409")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x165F540", Offset = "0x165E740", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000402")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x165F580", Offset = "0x165E780", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60003FA")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x165F5F0", Offset = "0x165E7F0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitStack), Member = "PopBit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003FE")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x165F680", Offset = "0x165E880", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000404")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x165F740", Offset = "0x165E940", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitStack), Member = "PopBit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003FF")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x165F890", Offset = "0x165EA90", Length = "0x97")]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteFullEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteProcessingInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600040E")]
	private void WriteIndent() { }

	[Address(RVA = "0x165F930", Offset = "0x165EB30", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000403")]
	public virtual void WriteProcessingInstruction(string target, string text) { }

	[Address(RVA = "0x165FAD0", Offset = "0x165ECD0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600040A")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x165FA70", Offset = "0x165EC70", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600040B")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x165FB20", Offset = "0x165ED20", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000400")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x165FC40", Offset = "0x165EE40", Length = "0x108")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitStack), Member = "PushBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003FB")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x165FD50", Offset = "0x165EF50", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000408")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x165FDC0", Offset = "0x165EFC0", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlCharType), Member = "CombineSurrogateChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000406")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x165FD50", Offset = "0x165EF50", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000407")]
	public virtual void WriteWhitespace(string ws) { }

}

