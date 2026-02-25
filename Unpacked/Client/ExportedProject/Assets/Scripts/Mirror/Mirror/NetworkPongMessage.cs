namespace Mirror;

[Token(Token = "0x2000033")]
public struct NetworkPongMessage : NetworkMessage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000076")]
	public double localTime; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000077")]
	public double predictionErrorUnadjusted; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000078")]
	public double predictionErrorAdjusted; //Field offset: 0x10

	[Address(RVA = "0x1099460", Offset = "0x1098660", Length = "0xF")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CD")]
	public NetworkPongMessage(double localTime, double predictionErrorUnadjusted, double predictionErrorAdjusted) { }

}

