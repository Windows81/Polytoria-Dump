namespace System.Threading;

[Flags]
[Token(Token = "0x2000223")]
internal enum SynchronizationContextProperties
{
	None = 0,
	RequireWaitNotification = 1,
}

