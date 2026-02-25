namespace U8Xml;

[Token(Token = "0x2000012")]
internal struct XmlDeclaration_
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000E")]
	public RawString Body; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000F")]
	public XmlAttribute_* Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000010")]
	public XmlAttribute_* Encoding; //Field offset: 0x18

}

