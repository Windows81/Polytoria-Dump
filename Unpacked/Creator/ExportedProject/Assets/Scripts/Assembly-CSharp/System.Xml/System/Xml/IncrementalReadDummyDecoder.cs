namespace System.Xml;

[Token(Token = "0x2000023")]
internal class IncrementalReadDummyDecoder : IncrementalReadDecoder
{

	[Token(Token = "0x17000032")]
	internal virtual bool IsFull
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B6")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B8")]
	public IncrementalReadDummyDecoder() { }

	[Address(RVA = "0x390F70", Offset = "0x390170", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B7")]
	internal virtual int Decode(Char[] chars, int startPos, int len) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B6")]
	internal virtual bool get_IsFull() { }

}

