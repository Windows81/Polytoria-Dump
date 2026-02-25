namespace Edgegap;

[Token(Token = "0x2000037")]
public struct Lobby
{
	[Token(Token = "0x200003A")]
	internal struct Assignment
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000155")]
		public uint authorization_token; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000156")]
		public string host; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000157")]
		public string ip; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000158")]
		public Port[] ports; //Field offset: 0x18

	}

	[Token(Token = "0x2000038")]
	internal struct Player
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014F")]
		public uint authorization_token; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000150")]
		public string id; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000151")]
		public bool is_host; //Field offset: 0x10

	}

	[Token(Token = "0x2000039")]
	internal struct Port
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000152")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000153")]
		public int port; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000154")]
		public string protocol; //Field offset: 0x10

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000146")]
	public Assignment assignment; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000147")]
	public string name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000148")]
	public string lobby_id; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000149")]
	public bool is_joinable; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400014A")]
	public bool is_started; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400014B")]
	public int player_count; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400014C")]
	public int capacity; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400014D")]
	public String[] tags; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400014E")]
	public Player[] players; //Field offset: 0x48

	[Token(Token = "0x17000017")]
	public int available_slots
	{
		[Address(RVA = "0x127D8F0", Offset = "0x127CAF0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001BA")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x127D8F0", Offset = "0x127CAF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001BA")]
	public int get_available_slots() { }

}

