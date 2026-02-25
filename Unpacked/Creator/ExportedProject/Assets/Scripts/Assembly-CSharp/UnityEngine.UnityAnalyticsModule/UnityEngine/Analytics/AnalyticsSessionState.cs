namespace UnityEngine.Analytics;

[RequiredByNativeCode]
[Token(Token = "0x2000008")]
public enum AnalyticsSessionState
{
	kSessionStopped = 0,
	kSessionStarted = 1,
	kSessionPaused = 2,
	kSessionResumed = 3,
}

