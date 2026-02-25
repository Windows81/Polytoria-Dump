namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003B5")]
internal enum CallType
{
	Sync = 0,
	BeginInvoke = 1,
	EndInvoke = 2,
	OneWay = 3,
}

