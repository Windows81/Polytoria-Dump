namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000051")]
internal struct UnsafeStreamRange
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B6")]
	internal UnsafeStreamBlock* Block; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000B7")]
	internal int OffsetInFirstBlock; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000B8")]
	internal int ElementCount; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B9")]
	internal int LastOffset; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000BA")]
	internal int NumberOfBlocks; //Field offset: 0x14

}

