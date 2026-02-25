namespace MoonSharp.Interpreter;

[Token(Token = "0x2000051")]
public enum SymbolRefType
{
	Local = 0,
	Upvalue = 1,
	Global = 2,
	DefaultEnv = 3,
}

