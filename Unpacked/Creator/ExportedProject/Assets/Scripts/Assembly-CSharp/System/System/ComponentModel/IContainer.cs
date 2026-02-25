namespace System.ComponentModel;

[Token(Token = "0x200014C")]
public interface IContainer : IDisposable
{

	[Token(Token = "0x1700017F")]
	public ComponentCollection Components
	{
		[Token(Token = "0x6000820")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000820")]
	public ComponentCollection get_Components() { }

	[Token(Token = "0x6000821")]
	public void Remove(IComponent component) { }

}

