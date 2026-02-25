namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
[Token(Token = "0x200037B")]
public interface IChannelReceiver : IChannel
{

	[Token(Token = "0x17000305")]
	public object ChannelData
	{
		[Token(Token = "0x6001B54")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001B54")]
	public object get_ChannelData() { }

	[Token(Token = "0x6001B55")]
	public void StartListening(object data) { }

}

