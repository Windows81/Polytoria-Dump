namespace System.Xml.Schema;

[Token(Token = "0x200010D")]
internal class Datatype_NMTOKEN : Datatype_token
{

	[Token(Token = "0x17000272")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x2FE8E0", Offset = "0x2FDAE0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009B3")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000271")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE310", Offset = "0x3CD510", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009B2")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A0DE0", Offset = "0x169FFE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B4")]
	public Datatype_NMTOKEN() { }

	[Address(RVA = "0x2FE8E0", Offset = "0x2FDAE0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B3")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x3CE310", Offset = "0x3CD510", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B2")]
	public virtual XmlTypeCode get_TypeCode() { }

}

