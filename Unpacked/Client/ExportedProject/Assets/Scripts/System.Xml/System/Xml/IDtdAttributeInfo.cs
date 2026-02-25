namespace System.Xml;

[Token(Token = "0x2000019")]
internal interface IDtdAttributeInfo
{

	[Token(Token = "0x1700000F")]
	public bool IsDeclaredInExternal
	{
		[Token(Token = "0x600007E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700000E")]
	public bool IsNonCDataType
	{
		[Token(Token = "0x600007D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000010")]
	public bool IsXmlAttribute
	{
		[Token(Token = "0x600007F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700000C")]
	public int LineNumber
	{
		[Token(Token = "0x600007B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700000D")]
	public int LinePosition
	{
		[Token(Token = "0x600007C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700000B")]
	public string LocalName
	{
		[Token(Token = "0x600007A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700000A")]
	public string Prefix
	{
		[Token(Token = "0x6000079")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600007E")]
	public bool get_IsDeclaredInExternal() { }

	[Token(Token = "0x600007D")]
	public bool get_IsNonCDataType() { }

	[Token(Token = "0x600007F")]
	public bool get_IsXmlAttribute() { }

	[Token(Token = "0x600007B")]
	public int get_LineNumber() { }

	[Token(Token = "0x600007C")]
	public int get_LinePosition() { }

	[Token(Token = "0x600007A")]
	public string get_LocalName() { }

	[Token(Token = "0x6000079")]
	public string get_Prefix() { }

}

