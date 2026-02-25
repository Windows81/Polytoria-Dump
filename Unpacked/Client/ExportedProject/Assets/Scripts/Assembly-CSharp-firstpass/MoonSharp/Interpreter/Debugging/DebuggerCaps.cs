namespace MoonSharp.Interpreter.Debugging;

[Flags]
[Token(Token = "0x2000161")]
public enum DebuggerCaps
{
	CanDebugSourceCode = 1,
	CanDebugByteCode = 2,
	HasLineBasedBreakpoints = 4,
}

