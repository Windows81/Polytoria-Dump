namespace System.IO;

[Flags]
[Token(Token = "0x20001F4")]
public enum WatcherChangeTypes
{
	All = 15,
	Changed = 4,
	Created = 1,
	Deleted = 2,
	Renamed = 8,
}

