namespace System.Linq.Expressions;

[Token(Token = "0x2000066")]
internal enum AnalyzeTypeIsResult
{
	KnownFalse = 0,
	KnownTrue = 1,
	KnownAssignable = 2,
	Unknown = 3,
}

