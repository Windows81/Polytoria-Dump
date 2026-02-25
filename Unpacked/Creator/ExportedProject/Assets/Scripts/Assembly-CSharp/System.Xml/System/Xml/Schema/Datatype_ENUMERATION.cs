namespace System.Xml.Schema;

[Token(Token = "0x2000124")]
internal class Datatype_ENUMERATION : Datatype_NMTOKEN
{

	[Token(Token = "0x170002AD")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x149FBE0", Offset = "0x149EDE0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A2A")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A0DE0", Offset = "0x169FFE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A2B")]
	public Datatype_ENUMERATION() { }

	[Address(RVA = "0x149FBE0", Offset = "0x149EDE0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A2A")]
	public virtual XmlTokenizedType get_TokenizedType() { }

}

