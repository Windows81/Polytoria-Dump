namespace UnityEngine.UIElements;

[Token(Token = "0x2000522")]
public interface IVisualElementScheduledItem
{

	[Token(Token = "0x170009B2")]
	public bool isActive
	{
		[Token(Token = "0x6002543")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002548")]
	public IVisualElementScheduledItem Every(long intervalMs) { }

	[Token(Token = "0x6002546")]
	public void ExecuteLater(long delayMs) { }

	[Token(Token = "0x6002543")]
	public bool get_isActive() { }

	[Token(Token = "0x6002545")]
	public void Pause() { }

	[Token(Token = "0x6002544")]
	public void Resume() { }

	[Token(Token = "0x6002547")]
	public IVisualElementScheduledItem StartingIn(long delayMs) { }

	[Token(Token = "0x6002549")]
	public IVisualElementScheduledItem Until(Func<Boolean> stopCondition) { }

}

