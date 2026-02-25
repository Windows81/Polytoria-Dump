namespace System.Globalization;

[Token(Token = "0x200053F")]
internal enum HebrewNumberParsingState
{
	InvalidHebrewNumber = 0,
	NotHebrewDigit = 1,
	FoundEndOfHebrewNumber = 2,
	ContinueParsing = 3,
}

