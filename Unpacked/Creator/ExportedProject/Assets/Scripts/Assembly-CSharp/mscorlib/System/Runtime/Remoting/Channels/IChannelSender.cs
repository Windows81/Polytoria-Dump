namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
[Token(Token = "0x200037C")]
public interface IChannelSender : IChannel
{

	[Token(Token = "0x6001B56")]
	public IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { }

}

