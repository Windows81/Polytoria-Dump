namespace System.Xml.Schema;

[Token(Token = "0x200010E")]
internal class Datatype_Name : Datatype_token
{

	[Token(Token = "0x17000273")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE2E0", Offset = "0x3CD4E0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009B5")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A0DE0", Offset = "0x169FFE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B6")]
	public Datatype_Name() { }

	[Address(RVA = "0x3CE2E0", Offset = "0x3CD4E0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B5")]
	public virtual XmlTypeCode get_TypeCode() { }

}

