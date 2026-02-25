namespace System.IO;

[Token(Token = "0x200065F")]
internal struct MonoIOStat
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A00")]
	public FileAttributes fileAttributes; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001A01")]
	public long Length; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001A02")]
	public long CreationTime; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001A03")]
	public long LastAccessTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A04")]
	public long LastWriteTime; //Field offset: 0x20

}

