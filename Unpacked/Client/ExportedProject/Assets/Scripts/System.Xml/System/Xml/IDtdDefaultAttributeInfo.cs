namespace System.Xml;

[Token(Token = "0x200001A")]
internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo
{

	[Token(Token = "0x17000011")]
	public string DefaultValueExpanded
	{
		[Token(Token = "0x6000080")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000012")]
	public object DefaultValueTyped
	{
		[Token(Token = "0x6000081")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000013")]
	public int ValueLineNumber
	{
		[Token(Token = "0x6000082")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000014")]
	public int ValueLinePosition
	{
		[Token(Token = "0x6000083")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000080")]
	public string get_DefaultValueExpanded() { }

	[Token(Token = "0x6000081")]
	public object get_DefaultValueTyped() { }

	[Token(Token = "0x6000082")]
	public int get_ValueLineNumber() { }

	[Token(Token = "0x6000083")]
	public int get_ValueLinePosition() { }

}

