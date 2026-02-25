namespace Unity.Jobs.LowLevel.Unsafe;

[Token(Token = "0x2000014")]
public enum ScheduleMode
{
	Run = 0,
	Batched = 1,
	Parallel = 1,
	Single = 2,
}

