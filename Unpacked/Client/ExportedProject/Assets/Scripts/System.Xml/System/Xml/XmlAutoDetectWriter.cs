namespace System.Xml;

[Token(Token = "0x2000032")]
internal class XmlAutoDetectWriter : XmlRawWriter
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000082")]
	private XmlRawWriter wrapped; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000083")]
	private OnRemoveWriter onRemove; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000084")]
	private XmlWriterSettings writerSettings; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000085")]
	private XmlEventCache eventCache; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000086")]
	private TextWriter textWriter; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000087")]
	private Stream strm; //Field offset: 0x48

	[Token(Token = "0x17000038")]
	internal virtual IXmlNamespaceResolver NamespaceResolver
	{
		[Address(RVA = "0x1633E00", Offset = "0x1633000", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000144")]
		internal set { } //Length: 87
	}

	[Token(Token = "0x17000039")]
	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		[Address(RVA = "0x1631D80", Offset = "0x1630F80", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014B")]
		internal get { } //Length: 42
	}

	[Address(RVA = "0x1633D20", Offset = "0x1632F20", Length = "0xD0")]
	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlWriterSettings), Member = "Clone", ReturnType = typeof(XmlWriterSettings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600012D")]
	private XmlAutoDetectWriter(XmlWriterSettings writerSettings) { }

	[Address(RVA = "0x1633CE0", Offset = "0x1632EE0", Length = "0x38")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600012E")]
	public XmlAutoDetectWriter(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	[Address(RVA = "0x1633CA0", Offset = "0x1632EA0", Length = "0x38")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600012F")]
	public XmlAutoDetectWriter(Stream strm, XmlWriterSettings writerSettings) { }

	[Address(RVA = "0x1632F50", Offset = "0x1632150", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000141")]
	public virtual void Close() { }

	[Address(RVA = "0x1632FA0", Offset = "0x16321A0", Length = "0x1CE")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_Indent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEventCache), Member = "EventsToWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000151")]
	private void CreateWrappedWriter(XmlOutputMethod outMethod) { }

	[Address(RVA = "0x1633170", Offset = "0x1632370", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Token(Token = "0x600014F")]
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	[Address(RVA = "0x1633180", Offset = "0x1632380", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000142")]
	public virtual void Flush() { }

	[Address(RVA = "0x1631D80", Offset = "0x1630F80", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014B")]
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	[Address(RVA = "0x16331D0", Offset = "0x16323D0", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600014E")]
	private static bool IsHtmlTag(string tagName) { }

	[Address(RVA = "0x1633E00", Offset = "0x1633000", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000144")]
	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	[Address(RVA = "0x16311E0", Offset = "0x16303E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000147")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x16332B0", Offset = "0x16324B0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000150")]
	private bool TextBlockCreatesWriter(string textBlock) { }

	[Address(RVA = "0x1633310", Offset = "0x1632510", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013F")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1633390", Offset = "0x1632590", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000140")]
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1633410", Offset = "0x1632610", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000134")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x1633490", Offset = "0x1632690", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013D")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x16334F0", Offset = "0x16326F0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000139")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1633530", Offset = "0x1632730", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000135")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x1633570", Offset = "0x1632770", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000130")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x5C47C0", Offset = "0x5C39C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000133")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x16335F0", Offset = "0x16327F0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000148")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1631460", Offset = "0x1630660", Length = "0x2A")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014D")]
	internal virtual void WriteEndNamespaceDeclaration() { }

	[Address(RVA = "0x1633620", Offset = "0x1632820", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013C")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x1633680", Offset = "0x1632880", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000149")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x16336B0", Offset = "0x16328B0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600014A")]
	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	[Address(RVA = "0x1633720", Offset = "0x1632920", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000136")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x1633760", Offset = "0x1632960", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013A")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x16337A0", Offset = "0x16329A0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013B")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x1633820", Offset = "0x1632A20", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000132")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x16338A0", Offset = "0x1632AA0", Length = "0x159")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000131")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1633A00", Offset = "0x1632C00", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600014C")]
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	[Address(RVA = "0x1633A60", Offset = "0x1632C60", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000138")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x1633AE0", Offset = "0x1632CE0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013E")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x1633B50", Offset = "0x1632D50", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000143")]
	public virtual void WriteValue(string value) { }

	[Address(RVA = "0x1633BB0", Offset = "0x1632DB0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000137")]
	public virtual void WriteWhitespace(string ws) { }

	[Address(RVA = "0x1633BF0", Offset = "0x1632DF0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000145")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	[Address(RVA = "0x1633C40", Offset = "0x1632E40", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000146")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

}

