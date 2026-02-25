namespace Edgegap;

[Token(Token = "0x200003B")]
public struct LobbyBrief
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000159")]
	public string lobby_id; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400015A")]
	public string name; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400015B")]
	public bool is_joinable; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400015C")]
	public bool is_started; //Field offset: 0x11
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400015D")]
	public int player_count; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400015E")]
	public int capacity; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400015F")]
	public String[] tags; //Field offset: 0x20

	[Token(Token = "0x17000018")]
	public int available_slots
	{
		[Address(RVA = "0x127D8E0", Offset = "0x127CAE0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001BB")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x127D8E0", Offset = "0x127CAE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001BB")]
	public int get_available_slots() { }

}

