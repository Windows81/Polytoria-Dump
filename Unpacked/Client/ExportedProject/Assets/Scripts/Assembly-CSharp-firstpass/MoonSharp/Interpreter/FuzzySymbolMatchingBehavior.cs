namespace MoonSharp.Interpreter;

[Flags]
[Token(Token = "0x200007A")]
public enum FuzzySymbolMatchingBehavior
{
	None = 0,
	UpperFirstLetter = 1,
	Camelify = 2,
	PascalCase = 4,
}

