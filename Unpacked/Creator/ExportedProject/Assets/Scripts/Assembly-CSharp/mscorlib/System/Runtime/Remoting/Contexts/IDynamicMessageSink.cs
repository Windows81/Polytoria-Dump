namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x2000370")]
public interface IDynamicMessageSink
{

	[Token(Token = "0x6001B28")]
	public void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync) { }

	[Token(Token = "0x6001B29")]
	public void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync) { }

}

