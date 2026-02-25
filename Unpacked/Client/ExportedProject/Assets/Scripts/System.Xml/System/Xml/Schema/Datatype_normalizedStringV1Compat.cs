namespace System.Xml.Schema;

[Token(Token = "0x2000109")]
internal class Datatype_normalizedStringV1Compat : Datatype_string
{

	[Token(Token = "0x1700026C")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE1E0", Offset = "0x3CD3E0", Length = "0x6")]
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009A9")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A0DE0", Offset = "0x169FFE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009AA")]
	public Datatype_normalizedStringV1Compat() { }

	[Address(RVA = "0x3CE1E0", Offset = "0x3CD3E0", Length = "0x6")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009A9")]
	public virtual XmlTypeCode get_TypeCode() { }

}

