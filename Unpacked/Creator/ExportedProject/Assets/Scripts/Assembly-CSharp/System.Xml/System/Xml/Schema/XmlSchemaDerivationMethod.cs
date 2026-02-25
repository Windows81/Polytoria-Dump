namespace System.Xml.Schema;

[Flags]
[Token(Token = "0x2000150")]
public enum XmlSchemaDerivationMethod
{
	Empty = 0,
	Substitution = 1,
	Extension = 2,
	Restriction = 4,
	List = 8,
	Union = 16,
	All = 255,
	None = 256,
}

