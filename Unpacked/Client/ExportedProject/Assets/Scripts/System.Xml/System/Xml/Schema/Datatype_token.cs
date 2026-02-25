namespace System.Xml.Schema;

[Token(Token = "0x200010A")]
internal class Datatype_token : Datatype_normalizedString
{

	[Token(Token = "0x1700026E")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009AC")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700026D")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE2D0", Offset = "0x3CD4D0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009AB")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A0DE0", Offset = "0x169FFE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009AD")]
	public Datatype_token() { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009AC")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x3CE2D0", Offset = "0x3CD4D0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009AB")]
	public virtual XmlTypeCode get_TypeCode() { }

}

