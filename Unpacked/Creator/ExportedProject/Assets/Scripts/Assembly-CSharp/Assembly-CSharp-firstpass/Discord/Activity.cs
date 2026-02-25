namespace Discord;

[Token(Token = "0x20001D8")]
public struct Activity
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006DF")]
	public ActivityType Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006E0")]
	public long ApplicationId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006E1")]
	public string Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006E2")]
	public string State; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006E3")]
	public string Details; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006E4")]
	public ActivityTimestamps Timestamps; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006E5")]
	public ActivityAssets Assets; //Field offset: 0x38
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40006E6")]
	public ActivityParty Party; //Field offset: 0x58
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40006E7")]
	public ActivitySecrets Secrets; //Field offset: 0x70
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40006E8")]
	public bool Instance; //Field offset: 0x88

}

