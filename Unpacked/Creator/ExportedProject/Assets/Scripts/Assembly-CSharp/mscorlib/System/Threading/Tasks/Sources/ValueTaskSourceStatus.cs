namespace System.Threading.Tasks.Sources;

[Token(Token = "0x2000289")]
public enum ValueTaskSourceStatus
{
	Pending = 0,
	Succeeded = 1,
	Faulted = 2,
	Canceled = 3,
}

