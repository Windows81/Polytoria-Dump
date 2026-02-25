namespace Mirror;

[Token(Token = "0x2000032")]
public struct NetworkPingMessage : NetworkMessage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000074")]
	public double localTime; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000075")]
	public double predictedTimeAdjusted; //Field offset: 0x8

	[Address(RVA = "0x126F3F0", Offset = "0x126E5F0", Length = "0xA")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CC")]
	public NetworkPingMessage(double localTime, double predictedTimeAdjusted) { }

}

