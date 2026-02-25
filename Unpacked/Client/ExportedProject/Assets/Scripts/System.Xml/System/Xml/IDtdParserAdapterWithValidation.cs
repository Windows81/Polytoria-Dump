namespace System.Xml;

[Token(Token = "0x200001E")]
internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter
{

	[Token(Token = "0x1700002C")]
	public bool DtdValidation
	{
		[Token(Token = "0x60000AB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002D")]
	public IValidationEventHandling ValidationEventHandling
	{
		[Token(Token = "0x60000AC")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60000AB")]
	public bool get_DtdValidation() { }

	[Token(Token = "0x60000AC")]
	public IValidationEventHandling get_ValidationEventHandling() { }

}

