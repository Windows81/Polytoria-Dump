namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x200033B")]
public interface IRemotingTypeInfo
{

	[Token(Token = "0x170002BE")]
	public string TypeName
	{
		[Token(Token = "0x60019CB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60019CC")]
	public bool CanCastTo(Type fromType, object o) { }

	[Token(Token = "0x60019CB")]
	public string get_TypeName() { }

}

