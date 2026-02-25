namespace System.IO;

[Token(Token = "0x20001E7")]
internal enum FileAction
{
	Added = 1,
	Removed = 2,
	Modified = 3,
	RenamedOldName = 4,
	RenamedNewName = 5,
}

