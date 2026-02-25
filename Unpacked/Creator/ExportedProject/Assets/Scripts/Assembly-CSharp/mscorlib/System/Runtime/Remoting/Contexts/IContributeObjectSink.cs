namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x200036E")]
public interface IContributeObjectSink
{

	[Token(Token = "0x6001B26")]
	public IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink) { }

}

