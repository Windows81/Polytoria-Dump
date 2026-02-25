namespace System.Xml;

[Token(Token = "0x2000031")]
internal class XmlAsyncCheckWriter : XmlWriter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000080")]
	private readonly XmlWriter coreWriter; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000081")]
	private Task lastTask; //Field offset: 0x18

	[Token(Token = "0x17000037")]
	public virtual WriteState WriteState
	{
		[Address(RVA = "0x1632F10", Offset = "0x1632110", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000127")]
		 get { } //Length: 55
	}

	[Address(RVA = "0x1632E80", Offset = "0x1632080", Length = "0x86")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600010F")]
	public XmlAsyncCheckWriter(XmlWriter writer) { }

	[Address(RVA = "0x1632510", Offset = "0x1631710", Length = "0x8B")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000110")]
	private void CheckAsync() { }

	[Address(RVA = "0x16325A0", Offset = "0x16317A0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000128")]
	public virtual void Close() { }

	[Address(RVA = "0x16325E0", Offset = "0x16317E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600012C")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1632610", Offset = "0x1631810", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000129")]
	public virtual void Flush() { }

	[Address(RVA = "0x1632F10", Offset = "0x1632110", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000127")]
	public virtual WriteState get_WriteState() { }

	[Address(RVA = "0x1632650", Offset = "0x1631850", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600012A")]
	public virtual string LookupPrefix(string ns) { }

	[Address(RVA = "0x16326A0", Offset = "0x16318A0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000125")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1632710", Offset = "0x1631910", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000126")]
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1632780", Offset = "0x1631980", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600011A")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x16327D0", Offset = "0x16319D0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600011E")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x1632820", Offset = "0x1631A20", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000122")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1632890", Offset = "0x1631A90", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600011B")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x16328E0", Offset = "0x1631AE0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000114")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x1632950", Offset = "0x1631B50", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000119")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x1632990", Offset = "0x1631B90", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000113")]
	public virtual void WriteEndDocument() { }

	[Address(RVA = "0x16329D0", Offset = "0x1631BD0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000116")]
	public virtual void WriteEndElement() { }

	[Address(RVA = "0x1632A10", Offset = "0x1631C10", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600011D")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x1632A60", Offset = "0x1631C60", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000117")]
	public virtual void WriteFullEndElement() { }

	[Address(RVA = "0x1632AA0", Offset = "0x1631CA0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600011C")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x1632B00", Offset = "0x1631D00", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000123")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1632B70", Offset = "0x1631D70", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000124")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x1632BC0", Offset = "0x1631DC0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000118")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1632C30", Offset = "0x1631E30", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000112")]
	public virtual void WriteStartDocument(bool standalone) { }

	[Address(RVA = "0x1632C80", Offset = "0x1631E80", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000111")]
	public virtual void WriteStartDocument() { }

	[Address(RVA = "0x1632CC0", Offset = "0x1631EC0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000115")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1632D30", Offset = "0x1631F30", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000120")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x1632D80", Offset = "0x1631F80", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000121")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x1632DE0", Offset = "0x1631FE0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600012B")]
	public virtual void WriteValue(string value) { }

	[Address(RVA = "0x1632E30", Offset = "0x1632030", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600011F")]
	public virtual void WriteWhitespace(string ws) { }

}

