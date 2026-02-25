namespace System.Xml;

[Token(Token = "0x200001D")]
internal interface IDtdParserAdapter
{

	[Token(Token = "0x17000023")]
	public Uri BaseUri
	{
		[Token(Token = "0x6000094")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000026")]
	public int CurrentPosition
	{
		[Token(Token = "0x6000097")]
		 get { } //Length: 0
		[Token(Token = "0x6000098")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700002A")]
	public int EntityStackLength
	{
		[Token(Token = "0x600009C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002B")]
	public bool IsEntityEolNormalized
	{
		[Token(Token = "0x600009D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000029")]
	public bool IsEof
	{
		[Token(Token = "0x600009B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000027")]
	public int LineNo
	{
		[Token(Token = "0x6000099")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000028")]
	public int LineStartPosition
	{
		[Token(Token = "0x600009A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000022")]
	public IXmlNamespaceResolver NamespaceResolver
	{
		[Token(Token = "0x6000093")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000021")]
	public XmlNameTable NameTable
	{
		[Token(Token = "0x6000092")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000024")]
	public Char[] ParsingBuffer
	{
		[Token(Token = "0x6000095")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000025")]
	public int ParsingBufferLength
	{
		[Token(Token = "0x6000096")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000094")]
	public Uri get_BaseUri() { }

	[Token(Token = "0x6000097")]
	public int get_CurrentPosition() { }

	[Token(Token = "0x600009C")]
	public int get_EntityStackLength() { }

	[Token(Token = "0x600009D")]
	public bool get_IsEntityEolNormalized() { }

	[Token(Token = "0x600009B")]
	public bool get_IsEof() { }

	[Token(Token = "0x6000099")]
	public int get_LineNo() { }

	[Token(Token = "0x600009A")]
	public int get_LineStartPosition() { }

	[Token(Token = "0x6000093")]
	public IXmlNamespaceResolver get_NamespaceResolver() { }

	[Token(Token = "0x6000092")]
	public XmlNameTable get_NameTable() { }

	[Token(Token = "0x6000095")]
	public Char[] get_ParsingBuffer() { }

	[Token(Token = "0x6000096")]
	public int get_ParsingBufferLength() { }

	[Token(Token = "0x600009F")]
	public void OnNewLine(int pos) { }

	[Token(Token = "0x60000A9")]
	public void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	[Token(Token = "0x60000A8")]
	public void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	[Token(Token = "0x60000A3")]
	public void ParseComment(StringBuilder sb) { }

	[Token(Token = "0x60000A1")]
	public int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	[Token(Token = "0x60000A0")]
	public int ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	[Token(Token = "0x60000A2")]
	public void ParsePI(StringBuilder sb) { }

	[Token(Token = "0x60000A5")]
	public bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	[Token(Token = "0x60000A4")]
	public bool PushEntity(IDtdEntityInfo entity, out int entityId) { }

	[Token(Token = "0x60000A6")]
	public bool PushExternalSubset(string systemId, string publicId) { }

	[Token(Token = "0x60000A7")]
	public void PushInternalDtd(string baseUri, string internalDtd) { }

	[Token(Token = "0x600009E")]
	public int ReadData() { }

	[Token(Token = "0x6000098")]
	public void set_CurrentPosition(int value) { }

	[Token(Token = "0x60000AA")]
	public void Throw(Exception e) { }

}

