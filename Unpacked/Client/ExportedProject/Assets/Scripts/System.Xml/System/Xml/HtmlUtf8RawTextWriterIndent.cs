namespace System.Xml;

[Token(Token = "0x2000016")]
internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter
{
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000047")]
	private int indentLevel; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000048")]
	private int endBlockPos; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000049")]
	private string indentChars; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400004A")]
	private bool newLineOnAttributes; //Field offset: 0xC8

	[Address(RVA = "0x162FAC0", Offset = "0x162ECC0", Length = "0x66")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000067")]
	public HtmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x162F390", Offset = "0x162E590", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "FlushBuffer", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006D")]
	protected virtual void FlushBuffer() { }

	[Address(RVA = "0x162F3B0", Offset = "0x162E5B0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600006E")]
	private void Init(XmlWriterSettings settings) { }

	[Address(RVA = "0x162F410", Offset = "0x162E610", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteMetaElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600006A")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x162F4D0", Offset = "0x162E6D0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000068")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x162F500", Offset = "0x162E700", Length = "0x1AA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006B")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x162F6B0", Offset = "0x162E8B0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600006F")]
	private void WriteIndent() { }

	[Address(RVA = "0x162F700", Offset = "0x162E900", Length = "0x1B3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TernaryTreeReadOnly), Member = "FindCaseInsensitiveString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600006C")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x162F8C0", Offset = "0x162EAC0", Length = "0x1FF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ByteStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TernaryTreeReadOnly), Member = "FindCaseInsensitiveString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000069")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

}

