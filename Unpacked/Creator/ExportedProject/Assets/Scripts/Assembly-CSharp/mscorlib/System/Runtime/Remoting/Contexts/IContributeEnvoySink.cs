namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x200036D")]
public interface IContributeEnvoySink
{

	[Token(Token = "0x6001B25")]
	public IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink) { }

}

