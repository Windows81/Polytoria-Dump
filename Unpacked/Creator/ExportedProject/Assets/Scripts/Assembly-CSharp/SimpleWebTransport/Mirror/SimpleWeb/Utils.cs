namespace Mirror.SimpleWeb;

[Token(Token = "0x2000026")]
internal static class Utils
{

	[Address(RVA = "0x155E190", Offset = "0x155D390", Length = "0xC")]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebSocketServer), Member = "acceptLoop", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000099")]
	public static void CheckForInterupt() { }

}

