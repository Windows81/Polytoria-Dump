namespace Edgegap;

[Token(Token = "0x2000040")]
public struct LobbyJoinOrLeaveRequest
{
	[Token(Token = "0x2000041")]
	internal struct Player
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016D")]
		public string id; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400016B")]
	public string lobby_id; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400016C")]
	public Player player; //Field offset: 0x8

}

