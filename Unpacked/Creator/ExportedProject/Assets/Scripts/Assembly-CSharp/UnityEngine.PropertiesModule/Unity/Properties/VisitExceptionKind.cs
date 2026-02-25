namespace Unity.Properties;

[Flags]
[Token(Token = "0x2000002")]
public enum VisitExceptionKind
{
	None = 0,
	Internal = 1,
	Visitor = 2,
	All = 3,
}

