namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x20003AC")]
public interface IMethodMessage : IMessage
{

	[Token(Token = "0x1700034D")]
	public int ArgCount
	{
		[Token(Token = "0x6001C1A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700034E")]
	public Object[] Args
	{
		[Token(Token = "0x6001C1B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700034F")]
	public LogicalCallContext LogicalCallContext
	{
		[Token(Token = "0x6001C1C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000350")]
	public MethodBase MethodBase
	{
		[Token(Token = "0x6001C1D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000351")]
	public string MethodName
	{
		[Token(Token = "0x6001C1E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000352")]
	public object MethodSignature
	{
		[Token(Token = "0x6001C1F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000353")]
	public string TypeName
	{
		[Token(Token = "0x6001C20")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000354")]
	public string Uri
	{
		[Token(Token = "0x6001C21")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001C1A")]
	public int get_ArgCount() { }

	[Token(Token = "0x6001C1B")]
	public Object[] get_Args() { }

	[Token(Token = "0x6001C1C")]
	public LogicalCallContext get_LogicalCallContext() { }

	[Token(Token = "0x6001C1D")]
	public MethodBase get_MethodBase() { }

	[Token(Token = "0x6001C1E")]
	public string get_MethodName() { }

	[Token(Token = "0x6001C1F")]
	public object get_MethodSignature() { }

	[Token(Token = "0x6001C20")]
	public string get_TypeName() { }

	[Token(Token = "0x6001C21")]
	public string get_Uri() { }

	[Token(Token = "0x6001C22")]
	public object GetArg(int argNum) { }

}

