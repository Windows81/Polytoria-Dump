namespace Discord;

[Token(Token = "0x20001DA")]
public struct Relationship
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006EB")]
	public RelationshipType Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006EC")]
	public User User; //Field offset: 0x8
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006ED")]
	public Presence Presence; //Field offset: 0x30

}

