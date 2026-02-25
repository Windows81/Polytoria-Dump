namespace System.Xml;

[Token(Token = "0x200002E")]
internal class TextUtf8RawTextWriter : XmlUtf8RawTextWriter
{

	[Token(Token = "0x17000036")]
	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000103")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x1632500", Offset = "0x1631700", Length = "0x8")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000F8")]
	public TextUtf8RawTextWriter(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000103")]
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FF")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x16324C0", Offset = "0x16316C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000104")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000108")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x16324D0", Offset = "0x16316D0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600010C")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000105")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FB")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x1632410", Offset = "0x1631610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000101")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FD")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000107")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FE")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000102")]
	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000106")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x16324F0", Offset = "0x16316F0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600010E")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x16324D0", Offset = "0x16316D0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600010D")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1632490", Offset = "0x1631690", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000100")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FC")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x16324F0", Offset = "0x16316F0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600010B")]
	public virtual void WriteString(string textBlock) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000109")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x16324F0", Offset = "0x16316F0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600010A")]
	public virtual void WriteWhitespace(string ws) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F9")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FA")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

}

