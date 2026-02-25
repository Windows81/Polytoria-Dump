namespace Discord;

[Token(Token = "0x20001C5")]
public enum RelationshipType
{
	None = 0,
	Friend = 1,
	Blocked = 2,
	PendingIncoming = 3,
	PendingOutgoing = 4,
	Implicit = 5,
}

