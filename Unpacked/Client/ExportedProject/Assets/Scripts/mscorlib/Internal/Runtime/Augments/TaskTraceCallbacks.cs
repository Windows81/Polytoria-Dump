namespace Internal.Runtime.Augments;

[Token(Token = "0x200008C")]
internal abstract class TaskTraceCallbacks
{

	[Token(Token = "0x17000037")]
	public abstract bool Enabled
	{
		[Token(Token = "0x6000258")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000258")]
	public abstract bool get_Enabled() { }

	[Token(Token = "0x600025C")]
	public abstract void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions) { }

	[Token(Token = "0x6000259")]
	public abstract void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	[Token(Token = "0x600025A")]
	public abstract void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	[Token(Token = "0x600025B")]
	public abstract void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

}

