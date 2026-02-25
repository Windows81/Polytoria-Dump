namespace System.Reflection;

[Flags]
[Token(Token = "0x20004D0")]
public enum ExceptionHandlingClauseOptions
{
	Clause = 0,
	Filter = 1,
	Finally = 2,
	Fault = 4,
}

