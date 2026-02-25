namespace System.Runtime.Remoting.Activation;

[ComVisible(True)]
[Token(Token = "0x2000385")]
public interface IActivator
{

	[Token(Token = "0x1700030F")]
	public IActivator NextActivator
	{
		[Token(Token = "0x6001B6E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001B6F")]
	public IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	[Token(Token = "0x6001B6E")]
	public IActivator get_NextActivator() { }

}

