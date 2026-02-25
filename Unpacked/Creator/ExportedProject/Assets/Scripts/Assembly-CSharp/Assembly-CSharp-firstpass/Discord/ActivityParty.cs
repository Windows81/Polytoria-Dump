namespace Discord;

[Token(Token = "0x20001D6")]
public struct ActivityParty
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006D9")]
	public string Id; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006DA")]
	public PartySize Size; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006DB")]
	public ActivityPartyPrivacy Privacy; //Field offset: 0x10

}

