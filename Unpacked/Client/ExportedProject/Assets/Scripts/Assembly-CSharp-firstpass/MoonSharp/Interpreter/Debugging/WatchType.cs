namespace MoonSharp.Interpreter.Debugging;

[Token(Token = "0x2000167")]
public enum WatchType
{
	Watches = 0,
	VStack = 1,
	CallStack = 2,
	Coroutines = 3,
	Locals = 4,
	Threads = 5,
	MaxValue = 6,
}

