namespace System.Threading.Tasks;

[Flags]
[Token(Token = "0x200026A")]
internal enum InternalTaskOptions
{
	None = 0,
	InternalOptionsMask = 65280,
	ContinuationTask = 512,
	PromiseTask = 1024,
	LazyCancellation = 4096,
	QueuedByRuntime = 8192,
	DoNotDispose = 16384,
}

