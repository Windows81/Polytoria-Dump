namespace System.Xml;

[Token(Token = "0x200001B")]
internal interface IDtdEntityInfo
{

	[Token(Token = "0x1700001A")]
	public string BaseUriString
	{
		[Token(Token = "0x6000089")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700001B")]
	public string DeclaredUriString
	{
		[Token(Token = "0x600008A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000017")]
	public bool IsDeclaredInExternal
	{
		[Token(Token = "0x6000086")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000016")]
	public bool IsExternal
	{
		[Token(Token = "0x6000085")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000019")]
	public bool IsParameterEntity
	{
		[Token(Token = "0x6000088")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000018")]
	public bool IsUnparsedEntity
	{
		[Token(Token = "0x6000087")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700001F")]
	public int LineNumber
	{
		[Token(Token = "0x600008E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000020")]
	public int LinePosition
	{
		[Token(Token = "0x600008F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000015")]
	public string Name
	{
		[Token(Token = "0x6000084")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700001D")]
	public string PublicId
	{
		[Token(Token = "0x600008C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700001C")]
	public string SystemId
	{
		[Token(Token = "0x600008B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700001E")]
	public string Text
	{
		[Token(Token = "0x600008D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000089")]
	public string get_BaseUriString() { }

	[Token(Token = "0x600008A")]
	public string get_DeclaredUriString() { }

	[Token(Token = "0x6000086")]
	public bool get_IsDeclaredInExternal() { }

	[Token(Token = "0x6000085")]
	public bool get_IsExternal() { }

	[Token(Token = "0x6000088")]
	public bool get_IsParameterEntity() { }

	[Token(Token = "0x6000087")]
	public bool get_IsUnparsedEntity() { }

	[Token(Token = "0x600008E")]
	public int get_LineNumber() { }

	[Token(Token = "0x600008F")]
	public int get_LinePosition() { }

	[Token(Token = "0x6000084")]
	public string get_Name() { }

	[Token(Token = "0x600008C")]
	public string get_PublicId() { }

	[Token(Token = "0x600008B")]
	public string get_SystemId() { }

	[Token(Token = "0x600008D")]
	public string get_Text() { }

}

