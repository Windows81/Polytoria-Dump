namespace System.Xml;

[Token(Token = "0x200008F")]
public interface IXmlNamespaceResolver
{

	[Token(Token = "0x60006B5")]
	public string LookupNamespace(string prefix) { }

	[Token(Token = "0x60006B6")]
	public string LookupPrefix(string namespaceName) { }

}

