namespace System.Threading.Tasks.Sources;

[Flags]
[Token(Token = "0x2000288")]
public enum ValueTaskSourceOnCompletedFlags
{
	None = 0,
	UseSchedulingContext = 1,
	FlowExecutionContext = 2,
}

