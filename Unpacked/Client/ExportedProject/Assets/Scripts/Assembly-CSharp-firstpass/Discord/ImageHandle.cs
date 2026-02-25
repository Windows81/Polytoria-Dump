namespace Discord;

[Token(Token = "0x20001D1")]
public struct ImageHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006CC")]
	public ImageType Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006CD")]
	public long Id; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006CE")]
	public uint Size; //Field offset: 0x10

	[Address(RVA = "0x397EE0", Offset = "0x3970E0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000FB3")]
	public static ImageHandle User(long id) { }

	[Address(RVA = "0x397EC0", Offset = "0x3970C0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000FB4")]
	public static ImageHandle User(long id, uint size) { }

}

