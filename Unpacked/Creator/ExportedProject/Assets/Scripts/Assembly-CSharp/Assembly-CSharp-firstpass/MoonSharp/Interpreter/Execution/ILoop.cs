namespace MoonSharp.Interpreter.Execution;

[Token(Token = "0x2000141")]
internal interface ILoop
{

	[Token(Token = "0x6000BDE")]
	public void CompileBreak(ByteCode bc) { }

	[Token(Token = "0x6000BDF")]
	public bool IsBoundary() { }

}

