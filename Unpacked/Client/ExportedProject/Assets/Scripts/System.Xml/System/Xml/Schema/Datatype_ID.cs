namespace System.Xml.Schema;

[Token(Token = "0x2000110")]
internal class Datatype_ID : Datatype_NCName
{

	[Token(Token = "0x17000276")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009BB")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000275")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE320", Offset = "0x3CD520", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009BA")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A0DE0", Offset = "0x169FFE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BC")]
	public Datatype_ID() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BB")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x3CE320", Offset = "0x3CD520", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BA")]
	public virtual XmlTypeCode get_TypeCode() { }

}

