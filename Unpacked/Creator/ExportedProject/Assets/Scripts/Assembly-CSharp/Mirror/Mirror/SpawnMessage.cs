namespace Mirror;

[Token(Token = "0x200002B")]
public struct SpawnMessage : NetworkMessage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000066")]
	public uint netId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000067")]
	public SpawnFlags spawnFlags; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000068")]
	public ulong sceneId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000069")]
	public uint assetId; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400006A")]
	public Vector3 position; //Field offset: 0x14
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400006B")]
	public Quaternion rotation; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400006C")]
	public Vector3 scale; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400006D")]
	public ArraySegment<Byte> payload; //Field offset: 0x40

	[Token(Token = "0x17000018")]
	public bool isLocalPlayer
	{
		[Address(RVA = "0x124D270", Offset = "0x124C470", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C6")]
		 get { } //Length: 9
		[Address(RVA = "0x124D290", Offset = "0x124C490", Length = "0x21")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C7")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000017")]
	public bool isOwner
	{
		[Address(RVA = "0x124D280", Offset = "0x124C480", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C4")]
		 get { } //Length: 7
		[Address(RVA = "0x124D2C0", Offset = "0x124C4C0", Length = "0x21")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C5")]
		 set { } //Length: 33
	}

	[Address(RVA = "0x124D270", Offset = "0x124C470", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C6")]
	public bool get_isLocalPlayer() { }

	[Address(RVA = "0x124D280", Offset = "0x124C480", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C4")]
	public bool get_isOwner() { }

	[Address(RVA = "0x124D290", Offset = "0x124C490", Length = "0x21")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C7")]
	public void set_isLocalPlayer(bool value) { }

	[Address(RVA = "0x124D2C0", Offset = "0x124C4C0", Length = "0x21")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C5")]
	public void set_isOwner(bool value) { }

}

