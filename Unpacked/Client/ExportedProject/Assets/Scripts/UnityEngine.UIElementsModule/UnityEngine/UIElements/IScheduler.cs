namespace UnityEngine.UIElements;

[Token(Token = "0x20002D9")]
internal interface IScheduler
{

	[Token(Token = "0x60013E5")]
	public void Schedule(ScheduledItem item) { }

	[Token(Token = "0x60013E4")]
	public void Unschedule(ScheduledItem item) { }

	[Token(Token = "0x60013E6")]
	public void UpdateScheduledEvents() { }

}

