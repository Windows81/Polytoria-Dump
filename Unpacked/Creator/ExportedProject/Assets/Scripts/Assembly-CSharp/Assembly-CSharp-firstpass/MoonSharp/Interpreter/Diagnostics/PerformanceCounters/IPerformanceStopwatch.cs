namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters;

[Token(Token = "0x200015D")]
internal interface IPerformanceStopwatch
{

	[Token(Token = "0x6000CE3")]
	public PerformanceResult GetResult() { }

	[Token(Token = "0x6000CE2")]
	public IDisposable Start() { }

}

