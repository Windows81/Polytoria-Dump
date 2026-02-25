namespace System.Runtime.Remoting.Activation;

[ComVisible(True)]
[Token(Token = "0x2000386")]
public interface IConstructionCallMessage : IMessage, IMethodCallMessage, IMethodMessage
{

	[Token(Token = "0x17000310")]
	public Type ActivationType
	{
		[Token(Token = "0x6001B70")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000311")]
	public string ActivationTypeName
	{
		[Token(Token = "0x6001B71")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000312")]
	public IActivator Activator
	{
		[Token(Token = "0x6001B72")]
		 get { } //Length: 0
		[Token(Token = "0x6001B73")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000313")]
	public Object[] CallSiteActivationAttributes
	{
		[Token(Token = "0x6001B74")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000314")]
	public IList ContextProperties
	{
		[Token(Token = "0x6001B75")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001B70")]
	public Type get_ActivationType() { }

	[Token(Token = "0x6001B71")]
	public string get_ActivationTypeName() { }

	[Token(Token = "0x6001B72")]
	public IActivator get_Activator() { }

	[Token(Token = "0x6001B74")]
	public Object[] get_CallSiteActivationAttributes() { }

	[Token(Token = "0x6001B75")]
	public IList get_ContextProperties() { }

	[Token(Token = "0x6001B73")]
	public void set_Activator(IActivator value) { }

}

