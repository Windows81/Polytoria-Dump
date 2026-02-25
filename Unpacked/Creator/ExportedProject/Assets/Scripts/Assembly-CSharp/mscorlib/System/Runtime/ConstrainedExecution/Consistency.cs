namespace System.Runtime.ConstrainedExecution;

[Token(Token = "0x200045C")]
public enum Consistency
{
	MayCorruptProcess = 0,
	MayCorruptAppDomain = 1,
	MayCorruptInstance = 2,
	WillNotCorruptState = 3,
}

