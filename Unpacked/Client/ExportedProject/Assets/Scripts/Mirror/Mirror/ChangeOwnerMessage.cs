namespace Mirror;

[Token(Token = "0x200002C")]
public struct ChangeOwnerMessage : NetworkMessage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006E")]
	public uint netId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400006F")]
	public SpawnFlags spawnFlags; //Field offset: 0x4

	[Token(Token = "0x1700001A")]
	public bool isLocalPlayer
	{
		[Address(RVA = "0x124D270", Offset = "0x124C470", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CA")]
		 get { } //Length: 9
		[Address(RVA = "0x124D290", Offset = "0x124C490", Length = "0x21")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CB")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000019")]
	public bool isOwner
	{
		[Address(RVA = "0x124D280", Offset = "0x124C480", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C8")]
		 get { } //Length: 7
		[Address(RVA = "0x124D2C0", Offset = "0x124C4C0", Length = "0x21")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C9")]
		 set { } //Length: 33
	}

	[Address(RVA = "0x124D270", Offset = "0x124C470", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CA")]
	public bool get_isLocalPlayer() { }

	[Address(RVA = "0x124D280", Offset = "0x124C480", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C8")]
	public bool get_isOwner() { }

	[Address(RVA = "0x124D290", Offset = "0x124C490", Length = "0x21")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CB")]
	public void set_isLocalPlayer(bool value) { }

	[Address(RVA = "0x124D2C0", Offset = "0x124C4C0", Length = "0x21")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C9")]
	public void set_isOwner(bool value) { }

}

