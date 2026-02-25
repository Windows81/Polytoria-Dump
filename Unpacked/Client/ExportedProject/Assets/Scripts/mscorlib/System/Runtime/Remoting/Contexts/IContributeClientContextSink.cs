namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x200036B")]
public interface IContributeClientContextSink
{

	[Token(Token = "0x6001B23")]
	public IMessageSink GetClientContextSink(IMessageSink nextSink) { }

}

