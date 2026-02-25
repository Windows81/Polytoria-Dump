namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x2000369")]
public interface IContextAttribute
{

	[Token(Token = "0x6001B1E")]
	public void GetPropertiesForNewContext(IConstructionCallMessage msg) { }

	[Token(Token = "0x6001B1F")]
	public bool IsContextOK(Context ctx, IConstructionCallMessage msg) { }

}

