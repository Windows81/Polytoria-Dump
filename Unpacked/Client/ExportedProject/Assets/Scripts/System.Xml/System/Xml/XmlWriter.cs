namespace System.Xml;

[Token(Token = "0x2000066")]
public abstract class XmlWriter : IDisposable
{

	[Token(Token = "0x170000CC")]
	public abstract WriteState WriteState
	{
		[Token(Token = "0x6000479")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000484")]
	protected XmlWriter() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600047A")]
	public override void Close() { }

	[Address(RVA = "0x1682DA0", Offset = "0x1681FA0", Length = "0x64")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveModelToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000482")]
	public static XmlWriter Create(TextWriter output) { }

	[Address(RVA = "0x1682E80", Offset = "0x1682080", Length = "0x6C")]
	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XAttribute", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000483")]
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	[Address(RVA = "0x1682E10", Offset = "0x1682010", Length = "0x6C")]
	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000481")]
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	[Address(RVA = "0x1682EF0", Offset = "0x16820F0", Length = "0x6C")]
	[CalledBy(Type = "System.Xml.Linq.XDocument", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Linq.SaveOptions"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000480")]
	public static XmlWriter Create(string outputFileName, XmlWriterSettings settings) { }

	[Address(RVA = "0x1682F60", Offset = "0x1682160", Length = "0x40")]
	[CalledBy(Type = typeof(XmlEventCache), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600047F")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1682FA0", Offset = "0x16821A0", Length = "0x16")]
	[CalledBy(Type = typeof(XmlAsyncCheckWriter), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600047E")]
	public override void Dispose() { }

	[Token(Token = "0x600047B")]
	public abstract void Flush() { }

	[Token(Token = "0x6000479")]
	public abstract WriteState get_WriteState() { }

	[Token(Token = "0x600047C")]
	public abstract string LookupPrefix(string ns) { }

	[Address(RVA = "0x1682FC0", Offset = "0x16821C0", Length = "0x59")]
	[CalledBy(Type = "System.Xml.Linq.XAttribute", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.ElementWriter", Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.XElement"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000469")]
	public void WriteAttributeString(string prefix, string localName, string ns, string value) { }

	[Token(Token = "0x6000477")]
	public abstract void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1683020", Offset = "0x1682220", Length = "0x23")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteBinHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinHexEncoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000478")]
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	[Token(Token = "0x600046C")]
	public abstract void WriteCData(string text) { }

	[Token(Token = "0x6000470")]
	public abstract void WriteCharEntity(char ch) { }

	[Token(Token = "0x6000474")]
	public abstract void WriteChars(Char[] buffer, int index, int count) { }

	[Token(Token = "0x600046D")]
	public abstract void WriteComment(string text) { }

	[Token(Token = "0x6000465")]
	public abstract void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Token(Token = "0x600046B")]
	public abstract void WriteEndAttribute() { }

	[Token(Token = "0x6000464")]
	public abstract void WriteEndDocument() { }

	[Token(Token = "0x6000467")]
	public abstract void WriteEndElement() { }

	[Token(Token = "0x600046F")]
	public abstract void WriteEntityRef(string name) { }

	[Token(Token = "0x6000468")]
	public abstract void WriteFullEndElement() { }

	[Token(Token = "0x600046E")]
	public abstract void WriteProcessingInstruction(string name, string text) { }

	[Token(Token = "0x6000475")]
	public abstract void WriteRaw(Char[] buffer, int index, int count) { }

	[Token(Token = "0x6000476")]
	public abstract void WriteRaw(string data) { }

	[Token(Token = "0x600046A")]
	public abstract void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Token(Token = "0x6000462")]
	public abstract void WriteStartDocument() { }

	[Token(Token = "0x6000463")]
	public abstract void WriteStartDocument(bool standalone) { }

	[Token(Token = "0x6000466")]
	public abstract void WriteStartElement(string prefix, string localName, string ns) { }

	[Token(Token = "0x6000472")]
	public abstract void WriteString(string text) { }

	[Token(Token = "0x6000473")]
	public abstract void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x1683050", Offset = "0x1682250", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600047D")]
	public override void WriteValue(string value) { }

	[Token(Token = "0x6000471")]
	public abstract void WriteWhitespace(string ws) { }

}

