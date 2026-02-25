namespace System;

[Token(Token = "0x200018C")]
internal enum TypeNameFormatFlags
{
	FormatBasic = 0,
	FormatNamespace = 1,
	FormatFullInst = 2,
	FormatAssembly = 4,
	FormatSignature = 8,
	FormatNoVersion = 16,
	FormatAngleBrackets = 64,
	FormatStubInfo = 128,
	FormatGenericParam = 256,
	FormatSerialization = 259,
}

