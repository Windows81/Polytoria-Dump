namespace System.Xml;

[Token(Token = "0x200001F")]
internal interface IDtdParserAdapterV1 : IDtdParserAdapterWithValidation, IDtdParserAdapter
{

	[Token(Token = "0x17000030")]
	public bool Namespaces
	{
		[Token(Token = "0x60000AF")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002F")]
	public bool Normalization
	{
		[Token(Token = "0x60000AE")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002E")]
	public bool V1CompatibilityMode
	{
		[Token(Token = "0x60000AD")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60000AF")]
	public bool get_Namespaces() { }

	[Token(Token = "0x60000AE")]
	public bool get_Normalization() { }

	[Token(Token = "0x60000AD")]
	public bool get_V1CompatibilityMode() { }

}

