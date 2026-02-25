namespace System.Xml;

[Token(Token = "0x2000033")]
internal class XmlEncodedRawTextWriter : XmlRawWriter
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000088")]
	private readonly bool useAsync; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000089")]
	protected Byte[] bufBytes; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400008A")]
	protected Stream stream; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400008B")]
	protected Encoding encoding; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400008C")]
	protected XmlCharType xmlCharType; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400008D")]
	protected int bufPos; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400008E")]
	protected int textPos; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400008F")]
	protected int contentPos; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000090")]
	protected int cdataPos; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000091")]
	protected int attrEndPos; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000092")]
	protected int bufLen; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000093")]
	protected bool writeToNull; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4000094")]
	protected bool hadDoubleBracket; //Field offset: 0x61
	[FieldOffset(Offset = "0x62")]
	[Token(Token = "0x4000095")]
	protected bool inAttributeValue; //Field offset: 0x62
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000096")]
	protected int bufBytesUsed; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000097")]
	protected Char[] bufChars; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000098")]
	protected Encoder encoder; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000099")]
	protected TextWriter writer; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400009A")]
	protected bool trackTextContent; //Field offset: 0x80
	[FieldOffset(Offset = "0x81")]
	[Token(Token = "0x400009B")]
	protected bool inTextContent; //Field offset: 0x81
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x400009C")]
	private int lastMarkPos; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400009D")]
	private Int32[] textContentMarks; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400009E")]
	private CharEntityEncoderFallback charEntityFallback; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400009F")]
	protected NewLineHandling newLineHandling; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40000A0")]
	protected bool closeOutput; //Field offset: 0x9C
	[FieldOffset(Offset = "0x9D")]
	[Token(Token = "0x40000A1")]
	protected bool omitXmlDeclaration; //Field offset: 0x9D
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000A2")]
	protected string newLineChars; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000A3")]
	protected bool checkCharacters; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x40000A4")]
	protected XmlStandalone standalone; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40000A5")]
	protected XmlOutputMethod outputMethod; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x40000A6")]
	protected bool autoXmlDeclaration; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB5")]
	[Token(Token = "0x40000A7")]
	protected bool mergeCDataSections; //Field offset: 0xB5

	[Token(Token = "0x1700003A")]
	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015F")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x1638670", Offset = "0x1637870", Length = "0x10D")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000152")]
	protected XmlEncodedRawTextWriter(XmlWriterSettings settings) { }

	[Address(RVA = "0x1638B00", Offset = "0x1637D00", Length = "0xF6")]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000153")]
	public XmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings) { }

	[Address(RVA = "0x1638780", Offset = "0x1637980", Length = "0x37B")]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Encoding), Member = "set_EncoderFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderFallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000154")]
	public XmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x1634980", Offset = "0x1633B80", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000181")]
	protected static Char* AmpEntity(Char* pDst) { }

	[Address(RVA = "0x16349A0", Offset = "0x1633BA0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000185")]
	protected static Char* CarriageReturnEntity(Char* pDst) { }

	[Address(RVA = "0x16349C0", Offset = "0x1633BC0", Length = "0xEC")]
	[CallerCount(Count = 43)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600017C")]
	protected void ChangeTextContentMark(bool value) { }

	[Address(RVA = "0x1634AB0", Offset = "0x1633CB0", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Token(Token = "0x6000186")]
	private static Char* CharEntity(Char* pDst, char ch) { }

	[Address(RVA = "0x1634B60", Offset = "0x1633D60", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "FlushEncoder", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18162ADF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600016D")]
	public virtual void Close() { }

	[Address(RVA = "0x1634BD0", Offset = "0x1633DD0", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(Char*)}, ReturnType = typeof(Char*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600017B")]
	internal void EncodeChar(ref Char* pSrc, Char* pSrcEnd, ref Char* pDst) { }

	[Address(RVA = "0x1634CB0", Offset = "0x1633EB0", Length = "0x17A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000170")]
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	[Address(RVA = "0x1634E30", Offset = "0x1634030", Length = "0x16D")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(Char*&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCDataSection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteHtmlAttributeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidHighSurrogateCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidSurrogatePairException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000179")]
	private static Char* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Char* pDst) { }

	[Address(RVA = "0x1635460", Offset = "0x1634660", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "FlushEncoder", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600016E")]
	public virtual void Flush() { }

	[Address(RVA = "0x1634FA0", Offset = "0x16341A0", Length = "0x3DF")]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = "FlushBuffer", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18162AF90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600016F")]
	protected override void FlushBuffer() { }

	[Address(RVA = "0x1635380", Offset = "0x1634580", Length = "0xD0")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "Flush", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000171")]
	private void FlushEncoder() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015F")]
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	[Address(RVA = "0x16354E0", Offset = "0x16346E0", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600017D")]
	private void GrowTextContentMarks() { }

	[Address(RVA = "0x1635580", Offset = "0x1634780", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000180")]
	protected static Char* GtEntity(Char* pDst) { }

	[Address(RVA = "0x16355A0", Offset = "0x16347A0", Length = "0x105")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600017A")]
	private Char* InvalidXmlChar(int ch, Char* pDst, bool entitize) { }

	[Address(RVA = "0x16356B0", Offset = "0x16348B0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000184")]
	protected static Char* LineFeedEntity(Char* pDst) { }

	[Address(RVA = "0x16356D0", Offset = "0x16348D0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600017F")]
	protected static Char* LtEntity(Char* pDst) { }

	[Address(RVA = "0x16356F0", Offset = "0x16348F0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000182")]
	protected static Char* QuoteEntity(Char* pDst) { }

	[Address(RVA = "0x1635710", Offset = "0x1634910", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000188")]
	protected static Char* RawEndCData(Char* pDst) { }

	[Address(RVA = "0x1635730", Offset = "0x1634930", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000187")]
	protected static Char* RawStartCData(Char* pDst) { }

	[Address(RVA = "0x1635760", Offset = "0x1634960", Length = "0x1A2")]
	[CallerCount(Count = 64)]
	[Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(Char*)}, ReturnType = typeof(Char*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000175")]
	protected void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	[Address(RVA = "0x1635910", Offset = "0x1634B10", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000174")]
	protected void RawText(string s) { }

	[Address(RVA = "0x1635960", Offset = "0x1634B60", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000159")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x16359A0", Offset = "0x1634BA0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000183")]
	protected static Char* TabEntity(Char* pDst) { }

	[Address(RVA = "0x16359C0", Offset = "0x1634BC0", Length = "0x38E")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsTextChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000189")]
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

	[Address(RVA = "0x1635D50", Offset = "0x1634F50", Length = "0x314")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteHtmlAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "InvalidXmlChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char*), typeof(bool)}, ReturnType = typeof(Char*))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(Char*)}, ReturnType = typeof(Char*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000172")]
	protected void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x1636450", Offset = "0x1635650", Length = "0x23B")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteCData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCDataSection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000162")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x1636070", Offset = "0x1635270", Length = "0x3D4")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(Char*)}, ReturnType = typeof(Char*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000178")]
	protected void WriteCDataSection(string text) { }

	[Address(RVA = "0x1636690", Offset = "0x1635890", Length = "0x1D9")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlCharType), Member = "IsCharData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000166")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x162DC20", Offset = "0x162CE20", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600016A")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1636C50", Offset = "0x1635E50", Length = "0x153")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000163")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x1636870", Offset = "0x1635A70", Length = "0x3D3")]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteProcessingInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteProcessingInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(Char*)}, ReturnType = typeof(Char*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000177")]
	protected void WriteCommentOrPi(string text, int stopChar) { }

	[Address(RVA = "0x1636DB0", Offset = "0x1635FB0", Length = "0x2CA")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000157")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x1637080", Offset = "0x1636280", Length = "0x34F")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "InvalidXmlChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char*), typeof(bool)}, ReturnType = typeof(Char*))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(Char*)}, ReturnType = typeof(Char*))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000173")]
	protected void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x16373D0", Offset = "0x16365D0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600015D")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x1637430", Offset = "0x1636630", Length = "0x17F")]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600015A")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x16375B0", Offset = "0x16367B0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000161")]
	internal virtual void WriteEndNamespaceDeclaration() { }

	[Address(RVA = "0x1637610", Offset = "0x1636810", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000165")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x16376F0", Offset = "0x16368F0", Length = "0x12B")]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteFullEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteFullEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600015B")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1637820", Offset = "0x1636A20", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015E")]
	internal virtual void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	[Address(RVA = "0x1637880", Offset = "0x1636A80", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600017E")]
	protected Char* WriteNewLine(Char* pDst) { }

	[Address(RVA = "0x1637910", Offset = "0x1636B10", Length = "0x14E")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteProcessingInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000164")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x1637D10", Offset = "0x1636F10", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600016B")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1632310", Offset = "0x1631510", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600016C")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x1637A60", Offset = "0x1636C60", Length = "0x2AB")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEncodedRawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEncodedRawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEncodedRawTextWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEncodedRawTextWriter), Member = "WriteWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEncodedRawTextWriter), Member = "WriteCData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEncodedRawTextWriter), Member = "WriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(Char*)}, ReturnType = typeof(Char*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000176")]
	protected void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	[Address(RVA = "0x1637DA0", Offset = "0x1636FA0", Length = "0x136")]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600015C")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1637EE0", Offset = "0x16370E0", Length = "0xEB")]
	[CalledBy(Type = typeof(HtmlEncodedRawTextWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000158")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x1637FD0", Offset = "0x16371D0", Length = "0x171")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000160")]
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	[Address(RVA = "0x1638150", Offset = "0x1637350", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000168")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x16381D0", Offset = "0x16373D0", Length = "0x15F")]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlCharType), Member = "CombineSurrogateChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000169")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x1638330", Offset = "0x1637530", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteElementTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteAttributeTextBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000167")]
	public virtual void WriteWhitespace(string ws) { }

	[Address(RVA = "0x1638600", Offset = "0x1637800", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000156")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	[Address(RVA = "0x16383B0", Offset = "0x16375B0", Length = "0x240")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000155")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

}

