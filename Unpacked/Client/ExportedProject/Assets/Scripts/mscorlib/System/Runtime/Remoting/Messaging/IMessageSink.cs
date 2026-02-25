namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x20003AA")]
public interface IMessageSink
{

	[Token(Token = "0x6001C19")]
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Token(Token = "0x6001C18")]
	public IMessage SyncProcessMessage(IMessage msg) { }

}

