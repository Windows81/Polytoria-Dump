namespace System.ComponentModel.Design;

[Token(Token = "0x200019A")]
public interface IDesignerHost : IServiceProvider
{

	[Token(Token = "0x170001D0")]
	public IComponent RootComponent
	{
		[Token(Token = "0x60009D4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60009D4")]
	public IComponent get_RootComponent() { }

}

