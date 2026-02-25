namespace System.Xml;

[Token(Token = "0x2000022")]
internal abstract class IncrementalReadDecoder
{

	[Token(Token = "0x17000031")]
	internal abstract bool IsFull
	{
		[Token(Token = "0x60000B3")]
		internal get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B5")]
	protected IncrementalReadDecoder() { }

	[Token(Token = "0x60000B4")]
	internal abstract int Decode(Char[] chars, int startPos, int len) { }

	[Token(Token = "0x60000B3")]
	internal abstract bool get_IsFull() { }

}

