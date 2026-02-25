namespace System.Xml.Schema;

[Token(Token = "0x20000E4")]
internal class XsdSimpleValue
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004A5")]
	private XmlSchemaSimpleType xmlType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004A6")]
	private object typedValue; //Field offset: 0x18

	[Token(Token = "0x1700020D")]
	public object TypedValue
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008E4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700020C")]
	public XmlSchemaSimpleType XmlType
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008E3")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008E4")]
	public object get_TypedValue() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008E3")]
	public XmlSchemaSimpleType get_XmlType() { }

}

