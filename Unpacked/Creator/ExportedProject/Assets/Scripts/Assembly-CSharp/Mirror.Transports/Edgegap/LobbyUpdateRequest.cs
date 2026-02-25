namespace Edgegap;

[Token(Token = "0x2000042")]
public struct LobbyUpdateRequest
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400016E")]
	public int capacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400016F")]
	public bool is_joinable; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000170")]
	public String[] tags; //Field offset: 0x8

}

