namespace System.Xml.Schema;

[Token(Token = "0x200014A")]
public class XmlSchemaChoice : XmlSchemaGroupBase
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005CA")]
	private XmlSchemaObjectCollection items; //Field offset: 0x38

	[Token(Token = "0x17000315")]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	public virtual XmlSchemaObjectCollection Items
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B37")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B37")]
	public virtual XmlSchemaObjectCollection get_Items() { }

}

