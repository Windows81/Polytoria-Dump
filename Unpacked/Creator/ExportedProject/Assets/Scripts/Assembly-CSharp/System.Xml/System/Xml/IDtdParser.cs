namespace System.Xml;

[Token(Token = "0x200001C")]
internal interface IDtdParser
{

	[Token(Token = "0x6000091")]
	public IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	[Token(Token = "0x6000090")]
	public IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

}

