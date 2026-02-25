namespace System.Xml.Schema;

[Flags]
[Token(Token = "0x2000163")]
public enum XmlSchemaValidationFlags
{
	None = 0,
	ProcessInlineSchema = 1,
	ProcessSchemaLocation = 2,
	ReportValidationWarnings = 4,
	ProcessIdentityConstraints = 8,
	AllowXmlAttributes = 16,
}

