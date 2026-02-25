namespace Unity.Collections;

[Token(Token = "0x200003B")]
internal struct UnsafeQueueBlockHeader
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000078")]
	public UnsafeQueueBlockHeader* m_NextBlock; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000079")]
	public int m_NumItems; //Field offset: 0x8

}

