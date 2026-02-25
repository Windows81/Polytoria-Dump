namespace System.Xml.Schema;

[Token(Token = "0x2000141")]
public class ValidationEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005B6")]
	private XmlSchemaException ex; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005B7")]
	private XmlSeverityType severity; //Field offset: 0x18

	[Token(Token = "0x17000308")]
	public XmlSchemaException Exception
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B13")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000307")]
	public XmlSeverityType Severity
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B12")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B13")]
	public XmlSchemaException get_Exception() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B12")]
	public XmlSeverityType get_Severity() { }

}

