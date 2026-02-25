namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000154")]
internal enum LabelScopeKind
{
	Statement = 0,
	Block = 1,
	Switch = 2,
	Lambda = 3,
	Try = 4,
	Catch = 5,
	Finally = 6,
	Filter = 7,
	Expression = 8,
}

