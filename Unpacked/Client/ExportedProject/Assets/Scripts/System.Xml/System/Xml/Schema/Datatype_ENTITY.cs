namespace System.Xml.Schema;

[Token(Token = "0x2000112")]
internal class Datatype_ENTITY : Datatype_NCName
{

	[Token(Token = "0x1700027A")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x2FFDE0", Offset = "0x2FEFE0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C1")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000279")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE230", Offset = "0x3CD430", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C0")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A0DE0", Offset = "0x169FFE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C2")]
	public Datatype_ENTITY() { }

	[Address(RVA = "0x2FFDE0", Offset = "0x2FEFE0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C1")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x3CE230", Offset = "0x3CD430", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C0")]
	public virtual XmlTypeCode get_TypeCode() { }

}

