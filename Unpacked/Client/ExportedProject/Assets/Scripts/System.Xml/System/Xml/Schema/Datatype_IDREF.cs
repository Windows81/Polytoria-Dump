namespace System.Xml.Schema;

[Token(Token = "0x2000111")]
internal class Datatype_IDREF : Datatype_NCName
{

	[Token(Token = "0x17000278")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009BE")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000277")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE210", Offset = "0x3CD410", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009BD")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A0DE0", Offset = "0x169FFE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BF")]
	public Datatype_IDREF() { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BE")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x3CE210", Offset = "0x3CD410", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BD")]
	public virtual XmlTypeCode get_TypeCode() { }

}

