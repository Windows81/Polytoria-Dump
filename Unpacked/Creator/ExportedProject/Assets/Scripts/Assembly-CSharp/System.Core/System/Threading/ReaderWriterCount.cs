namespace System.Threading;

[Token(Token = "0x2000251")]
internal class ReaderWriterCount
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003FD")]
	public long lockID; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003FE")]
	public int readercount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40003FF")]
	public int writercount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000400")]
	public int upgradecount; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000401")]
	public ReaderWriterCount next; //Field offset: 0x28

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B2F")]
	public ReaderWriterCount() { }

}

