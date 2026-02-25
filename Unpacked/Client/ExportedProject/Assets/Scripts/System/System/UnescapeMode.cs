namespace System;

[Flags]
[Token(Token = "0x20000C8")]
internal enum UnescapeMode
{
	CopyOnly = 0,
	Escape = 1,
	Unescape = 2,
	EscapeUnescape = 3,
	V1ToStringFlag = 4,
	UnescapeAll = 8,
	UnescapeAllOrThrow = 24,
}

