namespace System.IO;

[Flags]
[Token(Token = "0x20001EF")]
public enum NotifyFilters
{
	Attributes = 4,
	CreationTime = 64,
	DirectoryName = 2,
	FileName = 1,
	LastAccess = 32,
	LastWrite = 16,
	Security = 256,
	Size = 8,
}

