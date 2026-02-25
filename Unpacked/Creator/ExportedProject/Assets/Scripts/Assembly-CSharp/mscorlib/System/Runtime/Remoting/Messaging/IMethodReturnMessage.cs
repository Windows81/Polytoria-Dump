namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x20003AD")]
public interface IMethodReturnMessage : IMethodMessage, IMessage
{

	[Token(Token = "0x17000355")]
	public Exception Exception
	{
		[Token(Token = "0x6001C23")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000356")]
	public Object[] OutArgs
	{
		[Token(Token = "0x6001C24")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000357")]
	public object ReturnValue
	{
		[Token(Token = "0x6001C25")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001C23")]
	public Exception get_Exception() { }

	[Token(Token = "0x6001C24")]
	public Object[] get_OutArgs() { }

	[Token(Token = "0x6001C25")]
	public object get_ReturnValue() { }

}

