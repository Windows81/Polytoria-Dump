namespace System.Security.Cryptography;

[Token(Token = "0x2000117")]
internal enum AsnDecodeStatus
{
	NotDecoded = -1,
	Ok = 0,
	BadAsn = 1,
	BadTag = 2,
	BadLength = 3,
	InformationNotAvailable = 4,
}

