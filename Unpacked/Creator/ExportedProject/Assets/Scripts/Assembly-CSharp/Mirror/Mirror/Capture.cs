namespace Mirror;

[Token(Token = "0x200001B")]
public interface Capture
{

	[Token(Token = "0x17000014")]
	public double timestamp
	{
		[Token(Token = "0x600009E")]
		 get { } //Length: 0
		[Token(Token = "0x600009F")]
		 set { } //Length: 0
	}

	[Token(Token = "0x60000A0")]
	public void DrawGizmo() { }

	[Token(Token = "0x600009E")]
	public double get_timestamp() { }

	[Token(Token = "0x600009F")]
	public void set_timestamp(double value) { }

}

