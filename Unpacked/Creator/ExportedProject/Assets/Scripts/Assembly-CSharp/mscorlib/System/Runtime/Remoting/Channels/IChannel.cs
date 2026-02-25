namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
[Token(Token = "0x2000379")]
public interface IChannel
{

	[Token(Token = "0x17000303")]
	public string ChannelName
	{
		[Token(Token = "0x6001B52")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000304")]
	public int ChannelPriority
	{
		[Token(Token = "0x6001B53")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001B52")]
	public string get_ChannelName() { }

	[Token(Token = "0x6001B53")]
	public int get_ChannelPriority() { }

}

