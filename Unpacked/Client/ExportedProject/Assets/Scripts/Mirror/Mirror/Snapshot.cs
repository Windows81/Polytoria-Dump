namespace Mirror;

[Token(Token = "0x2000074")]
public interface Snapshot
{

	[Token(Token = "0x1700006B")]
	public double localTime
	{
		[Token(Token = "0x60003EA")]
		 get { } //Length: 0
		[Token(Token = "0x60003EB")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700006A")]
	public double remoteTime
	{
		[Token(Token = "0x60003E8")]
		 get { } //Length: 0
		[Token(Token = "0x60003E9")]
		 set { } //Length: 0
	}

	[Token(Token = "0x60003EA")]
	public double get_localTime() { }

	[Token(Token = "0x60003E8")]
	public double get_remoteTime() { }

	[Token(Token = "0x60003EB")]
	public void set_localTime(double value) { }

	[Token(Token = "0x60003E9")]
	public void set_remoteTime(double value) { }

}

