namespace Edgegap;

[Token(Token = "0x200003C")]
public struct LobbyCreateRequest
{
	[Token(Token = "0x200003E")]
	internal struct Annotation
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000167")]
		public bool inject; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000168")]
		public string key; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000169")]
		public string value; //Field offset: 0x10

	}

	[Token(Token = "0x200003D")]
	internal struct Player
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000166")]
		public string id; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000160")]
	public Annotation[] annotations; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000161")]
	public int capacity; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000162")]
	public bool is_joinable; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000163")]
	public string name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000164")]
	public Player player; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000165")]
	public String[] tags; //Field offset: 0x20

}

