namespace System.Xml;

[Token(Token = "0x2000018")]
internal interface IDtdAttributeListInfo
{

	[Token(Token = "0x17000009")]
	public bool HasNonCDataAttributes
	{
		[Token(Token = "0x6000076")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000076")]
	public bool get_HasNonCDataAttributes() { }

	[Token(Token = "0x6000077")]
	public IDtdAttributeInfo LookupAttribute(string prefix, string localName) { }

	[Token(Token = "0x6000078")]
	public IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes() { }

}

