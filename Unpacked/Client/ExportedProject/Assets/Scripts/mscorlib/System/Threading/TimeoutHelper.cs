namespace System.Threading;

[Token(Token = "0x2000201")]
internal static class TimeoutHelper
{

	[Address(RVA = "0x151BC80", Offset = "0x151AE80", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Token(Token = "0x6001153")]
	public static uint GetTime() { }

	[Address(RVA = "0x151BC90", Offset = "0x151AE90", Length = "0x3E")]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitUntilCountOrTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Token(Token = "0x6001154")]
	public static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout) { }

}

