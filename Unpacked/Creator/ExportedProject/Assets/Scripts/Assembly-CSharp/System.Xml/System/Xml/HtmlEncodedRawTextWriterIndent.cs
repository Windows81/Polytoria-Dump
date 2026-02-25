namespace System.Xml;

[Token(Token = "0x2000013")]
internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter
{
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000038")]
	private int indentLevel; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000039")]
	private int endBlockPos; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400003A")]
	private string indentChars; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400003B")]
	private bool newLineOnAttributes; //Field offset: 0xF8

	[Address(RVA = "0x162D800", Offset = "0x162CA00", Length = "0x66")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000045")]
	public HtmlEncodedRawTextWriterIndent(TextWriter writer, XmlWriterSettings settings) { }

	[Address(RVA = "0x162D790", Offset = "0x162C990", Length = "0x66")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000046")]
	public HtmlEncodedRawTextWriterIndent(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x162D270", Offset = "0x162C470", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "FlushBuffer", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004C")]
	protected virtual void FlushBuffer() { }

	[Address(RVA = "0x162D290", Offset = "0x162C490", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600004D")]
	private void Init(XmlWriterSettings settings) { }

	[Address(RVA = "0x162D2F0", Offset = "0x162C4F0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteMetaElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000049")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x162D370", Offset = "0x162C570", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000047")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x162D3A0", Offset = "0x162C5A0", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004A")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x162D450", Offset = "0x162C650", Length = "0x97")]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "StartElementContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600004E")]
	private void WriteIndent() { }

	[Address(RVA = "0x162D4F0", Offset = "0x162C6F0", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600004B")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x162D5A0", Offset = "0x162C7A0", Length = "0x1ED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ByteStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "WriteIndent", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TernaryTreeReadOnly), Member = "FindCaseInsensitiveString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000048")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

}

