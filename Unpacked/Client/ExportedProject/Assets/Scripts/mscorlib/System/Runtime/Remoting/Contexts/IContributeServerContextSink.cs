namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x200036F")]
public interface IContributeServerContextSink
{

	[Token(Token = "0x6001B27")]
	public IMessageSink GetServerContextSink(IMessageSink nextSink) { }

}

