namespace System.Xml;

[Token(Token = "0x200002D")]
internal class TextEncodedRawTextWriter : XmlEncodedRawTextWriter
{

	[Token(Token = "0x17000035")]
	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EC")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x16324A0", Offset = "0x16316A0", Length = "0x8")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000E0")]
	public TextEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings) { }

	[Address(RVA = "0x16324B0", Offset = "0x16316B0", Length = "0x8")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000E1")]
	public TextEncodedRawTextWriter(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EC")]
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E8")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x1632310", Offset = "0x1631510", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000ED")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F1")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x1632380", Offset = "0x1631580", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F5")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EE")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E4")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x1632410", Offset = "0x1631610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EA")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E6")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F0")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E7")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EB")]
	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EF")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x1632380", Offset = "0x1631580", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F6")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1632420", Offset = "0x1631620", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F7")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x1632490", Offset = "0x1631690", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E9")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E5")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1632420", Offset = "0x1631620", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F4")]
	public virtual void WriteString(string textBlock) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F2")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x1632420", Offset = "0x1631620", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F3")]
	public virtual void WriteWhitespace(string ws) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E3")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E2")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

}

