namespace Discord;

[Token(Token = "0x20001DE")]
public struct FileStat
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006FD")]
	public string Filename; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006FE")]
	public ulong Size; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006FF")]
	public ulong LastModified; //Field offset: 0x10

}

