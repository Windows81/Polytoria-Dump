namespace UnityEngine.UIElements;

[Token(Token = "0x2000523")]
public interface IVisualElementScheduler
{

	[Token(Token = "0x600254A")]
	public IVisualElementScheduledItem Execute(Action<TimerState> timerUpdateEvent) { }

	[Token(Token = "0x600254B")]
	public IVisualElementScheduledItem Execute(Action updateEvent) { }

}

