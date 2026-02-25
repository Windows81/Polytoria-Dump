namespace Discord;

[Token(Token = "0x20001D7")]
public struct ActivitySecrets
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006DC")]
	public string Match; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006DD")]
	public string Join; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006DE")]
	public string Spectate; //Field offset: 0x10

}

