namespace System.Xml.Schema;

[Token(Token = "0x200010C")]
internal class Datatype_language : Datatype_token
{

	[Token(Token = "0x17000270")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE2F0", Offset = "0x3CD4F0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009B0")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A0DE0", Offset = "0x169FFE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B1")]
	public Datatype_language() { }

	[Address(RVA = "0x3CE2F0", Offset = "0x3CD4F0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B0")]
	public virtual XmlTypeCode get_TypeCode() { }

}

