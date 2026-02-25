namespace UnityEngine.Analytics;

[Flags]
[Token(Token = "0x20002A2")]
public enum SendEventOptions
{
	kAppendNone = 0,
	kAppendBuildGuid = 1,
	kAppendBuildTarget = 2,
}

