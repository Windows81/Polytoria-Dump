namespace Mirror;

[Extension]
[Token(Token = "0x2000017")]
public static class ConnectionQualityHeuristics
{

	[Address(RVA = "0x124D490", Offset = "0x124C690", Length = "0x95")]
	[CalledBy(Type = "Mirror.NetworkPingDisplay", Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x600008B")]
	public static Color ColorCode(ConnectionQuality quality) { }

	[Address(RVA = "0x124D530", Offset = "0x124C730", Length = "0x38")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600008D")]
	public static ConnectionQuality Pragmatic(double targetBufferTime, double currentBufferTime) { }

	[Address(RVA = "0x124D570", Offset = "0x124C770", Length = "0x54")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600008C")]
	public static ConnectionQuality Simple(double rtt, double jitter) { }

}

