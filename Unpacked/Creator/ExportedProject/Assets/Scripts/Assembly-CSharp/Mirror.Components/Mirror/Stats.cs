namespace Mirror;

[Token(Token = "0x200004D")]
internal struct Stats
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001A5")]
	public int connections; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001A6")]
	public double uptime; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001A7")]
	public int configuredTickRate; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40001A8")]
	public int actualTickRate; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001A9")]
	public long sentBytesPerSecond; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001AA")]
	public long receiveBytesPerSecond; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001AB")]
	public float serverTickInterval; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001AC")]
	public double fullUpdateAvg; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001AD")]
	public double serverEarlyAvg; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001AE")]
	public double serverLateAvg; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001AF")]
	public double transportEarlyAvg; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001B0")]
	public double transportLateAvg; //Field offset: 0x50

	[Address(RVA = "0x1245960", Offset = "0x1244B60", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000268")]
	public Stats(int connections, double uptime, int configuredTickRate, int actualTickRate, long sentBytesPerSecond, long receiveBytesPerSecond, float serverTickInterval, double fullUpdateAvg, double serverEarlyAvg, double serverLateAvg, double transportEarlyAvg, double transportLateAvg) { }

}

