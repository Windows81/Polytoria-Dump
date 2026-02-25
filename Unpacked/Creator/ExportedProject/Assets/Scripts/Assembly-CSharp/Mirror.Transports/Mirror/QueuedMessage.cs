namespace Mirror;

[Token(Token = "0x2000008")]
internal struct QueuedMessage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003F")]
	public int connectionId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000040")]
	public Byte[] bytes; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000041")]
	public double time; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000042")]
	public int channelId; //Field offset: 0x18

	[Address(RVA = "0x127D900", Offset = "0x127CB00", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600005C")]
	public QueuedMessage(int connectionId, Byte[] bytes, double time, int channelId) { }

}

