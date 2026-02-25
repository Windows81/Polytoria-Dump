namespace MoonSharp.Interpreter;

[Token(Token = "0x2000046")]
public enum CoroutineState
{
	Main = 0,
	NotStarted = 1,
	Suspended = 2,
	ForceSuspended = 3,
	Running = 4,
	Dead = 5,
}

