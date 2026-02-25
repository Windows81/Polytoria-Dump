namespace Unity.Profiling;

[Flags]
[Token(Token = "0x2000022")]
public enum ProfilerCounterOptions
{
	None = 0,
	FlushOnEndOfFrame = 2,
	ResetToZeroOnFlush = 4,
}

