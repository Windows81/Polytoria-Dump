namespace Discord;

[Token(Token = "0x20001E2")]
public struct InputMode
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000709")]
	public InputModeType Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400070A")]
	public string Shortcut; //Field offset: 0x8

}

