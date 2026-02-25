namespace System.Xml.Schema;

[Token(Token = "0x2000108")]
internal class Datatype_normalizedString : Datatype_string
{

	[Token(Token = "0x1700026B")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009A7")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700026A")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE1E0", Offset = "0x3CD3E0", Length = "0x6")]
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009A6")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A0DE0", Offset = "0x169FFE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009A8")]
	public Datatype_normalizedString() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009A7")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x3CE1E0", Offset = "0x3CD3E0", Length = "0x6")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009A6")]
	public virtual XmlTypeCode get_TypeCode() { }

}

