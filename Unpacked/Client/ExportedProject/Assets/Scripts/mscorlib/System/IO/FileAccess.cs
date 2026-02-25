namespace System.IO;

[Flags]
[Token(Token = "0x2000626")]
public enum FileAccess
{
	Read = 1,
	Write = 2,
	ReadWrite = 3,
}

