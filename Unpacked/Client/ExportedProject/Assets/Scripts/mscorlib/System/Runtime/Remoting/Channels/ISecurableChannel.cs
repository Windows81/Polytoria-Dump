namespace System.Runtime.Remoting.Channels;

[Token(Token = "0x200037E")]
public interface ISecurableChannel
{

	[Token(Token = "0x17000307")]
	public bool IsSecured
	{
		[Token(Token = "0x6001B58")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6001B58")]
	public void set_IsSecured(bool value) { }

}

