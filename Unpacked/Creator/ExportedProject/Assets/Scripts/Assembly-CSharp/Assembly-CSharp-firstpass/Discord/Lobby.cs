namespace Discord;

[Token(Token = "0x20001DB")]
public struct Lobby
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006EE")]
	public long Id; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006EF")]
	public LobbyType Type; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006F0")]
	public long OwnerId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006F1")]
	public string Secret; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006F2")]
	public uint Capacity; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40006F3")]
	public bool Locked; //Field offset: 0x24

}

