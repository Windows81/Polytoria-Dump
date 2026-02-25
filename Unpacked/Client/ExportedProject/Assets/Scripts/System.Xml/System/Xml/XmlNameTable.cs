namespace System.Xml;

[Token(Token = "0x20000B4")]
public abstract class XmlNameTable
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080B")]
	protected XmlNameTable() { }

	[Token(Token = "0x6000809")]
	public abstract string Add(Char[] array, int offset, int length) { }

	[Token(Token = "0x600080A")]
	public abstract string Add(string array) { }

	[Token(Token = "0x6000808")]
	public abstract string Get(string array) { }

}

