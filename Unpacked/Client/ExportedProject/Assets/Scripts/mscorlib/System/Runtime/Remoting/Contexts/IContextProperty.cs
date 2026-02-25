namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x200036A")]
public interface IContextProperty
{

	[Token(Token = "0x170002FA")]
	public string Name
	{
		[Token(Token = "0x6001B20")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001B21")]
	public void Freeze(Context newContext) { }

	[Token(Token = "0x6001B20")]
	public string get_Name() { }

	[Token(Token = "0x6001B22")]
	public bool IsNewContextOK(Context newCtx) { }

}

