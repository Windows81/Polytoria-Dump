namespace System.ComponentModel;

[Token(Token = "0x200014D")]
public interface ISite : IServiceProvider
{

	[Token(Token = "0x17000180")]
	public IContainer Container
	{
		[Token(Token = "0x6000822")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000181")]
	public bool DesignMode
	{
		[Token(Token = "0x6000823")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000182")]
	public string Name
	{
		[Token(Token = "0x6000824")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000822")]
	public IContainer get_Container() { }

	[Token(Token = "0x6000823")]
	public bool get_DesignMode() { }

	[Token(Token = "0x6000824")]
	public string get_Name() { }

}

