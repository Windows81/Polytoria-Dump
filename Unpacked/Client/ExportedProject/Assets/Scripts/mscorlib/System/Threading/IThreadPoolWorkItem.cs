namespace System.Threading;

[Token(Token = "0x200022E")]
internal interface IThreadPoolWorkItem
{

	[Token(Token = "0x6001270")]
	public void ExecuteWorkItem() { }

	[Token(Token = "0x6001271")]
	public void MarkAborted(ThreadAbortException tae) { }

}

