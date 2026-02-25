namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x200033A")]
public interface IEnvoyInfo
{

	[Token(Token = "0x170002BD")]
	public IMessageSink EnvoySinks
	{
		[Token(Token = "0x60019CA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60019CA")]
	public IMessageSink get_EnvoySinks() { }

}

