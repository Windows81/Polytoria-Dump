namespace System.Threading;

[Token(Token = "0x200022B")]
internal enum StackCrawlMark
{
	LookForMe = 0,
	LookForMyCaller = 1,
	LookForMyCallersCaller = 2,
	LookForThread = 3,
}

