namespace System.Xml;

[Token(Token = "0x2000017")]
internal interface IDtdInfo
{

	[Token(Token = "0x17000007")]
	public bool HasDefaultAttributes
	{
		[Token(Token = "0x6000072")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000008")]
	public bool HasNonCDataAttributes
	{
		[Token(Token = "0x6000073")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000006")]
	public string InternalDtdSubset
	{
		[Token(Token = "0x6000071")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000005")]
	public XmlQualifiedName Name
	{
		[Token(Token = "0x6000070")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000072")]
	public bool get_HasDefaultAttributes() { }

	[Token(Token = "0x6000073")]
	public bool get_HasNonCDataAttributes() { }

	[Token(Token = "0x6000071")]
	public string get_InternalDtdSubset() { }

	[Token(Token = "0x6000070")]
	public XmlQualifiedName get_Name() { }

	[Token(Token = "0x6000074")]
	public IDtdAttributeListInfo LookupAttributeList(string prefix, string localName) { }

	[Token(Token = "0x6000075")]
	public IDtdEntityInfo LookupEntity(string name) { }

}

