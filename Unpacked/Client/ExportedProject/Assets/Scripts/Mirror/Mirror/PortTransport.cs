namespace Mirror;

[Token(Token = "0x2000071")]
public interface PortTransport
{

	[Token(Token = "0x17000060")]
	public ushort Port
	{
		[Token(Token = "0x60003D3")]
		 get { } //Length: 0
		[Token(Token = "0x60003D4")]
		 set { } //Length: 0
	}

	[Token(Token = "0x60003D3")]
	public ushort get_Port() { }

	[Token(Token = "0x60003D4")]
	public void set_Port(ushort value) { }

}

