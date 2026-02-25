namespace MoonSharp.Interpreter.Tree;

[Token(Token = "0x2000081")]
internal interface IVariable
{

	[Token(Token = "0x60006D7")]
	public void CompileAssignment(ByteCode bc, int stackofs, int tupleidx) { }

}

