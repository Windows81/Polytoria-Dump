namespace MoonSharp.Interpreter.Execution;

[Token(Token = "0x2000140")]
internal interface IClosureBuilder
{

	[Token(Token = "0x6000BDD")]
	public SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol) { }

}

