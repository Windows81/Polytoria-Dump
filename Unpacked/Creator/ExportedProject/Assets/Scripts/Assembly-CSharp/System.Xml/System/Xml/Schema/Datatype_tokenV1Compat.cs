namespace System.Xml.Schema;

[Token(Token = "0x200010B")]
internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat
{

	[Token(Token = "0x1700026F")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE2D0", Offset = "0x3CD4D0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009AE")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A0DE0", Offset = "0x169FFE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009AF")]
	public Datatype_tokenV1Compat() { }

	[Address(RVA = "0x3CE2D0", Offset = "0x3CD4D0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009AE")]
	public virtual XmlTypeCode get_TypeCode() { }

}

