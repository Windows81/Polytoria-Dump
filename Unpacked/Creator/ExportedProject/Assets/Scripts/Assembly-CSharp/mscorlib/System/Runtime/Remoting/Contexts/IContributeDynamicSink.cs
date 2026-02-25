namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x200036C")]
public interface IContributeDynamicSink
{

	[Token(Token = "0x6001B24")]
	public IDynamicMessageSink GetDynamicSink() { }

}

