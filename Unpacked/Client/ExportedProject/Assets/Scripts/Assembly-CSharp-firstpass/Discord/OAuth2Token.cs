namespace Discord;

[Token(Token = "0x20001D0")]
public struct OAuth2Token
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006C9")]
	public string AccessToken; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006CA")]
	public string Scopes; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006CB")]
	public long Expires; //Field offset: 0x10

}

