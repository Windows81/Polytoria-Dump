namespace System.IO;

[Flags]
[Token(Token = "0x200062B")]
public enum FileShare
{
	None = 0,
	Read = 1,
	Write = 2,
	ReadWrite = 3,
	Delete = 4,
	Inheritable = 16,
}

