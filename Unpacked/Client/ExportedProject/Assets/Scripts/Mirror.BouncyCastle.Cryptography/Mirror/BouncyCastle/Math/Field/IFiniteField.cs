namespace Mirror.BouncyCastle.Math.Field;

[Token(Token = "0x2000033")]
public interface IFiniteField
{

	[Token(Token = "0x17000018")]
	public BigInteger Characteristic
	{
		[Token(Token = "0x6000218")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000019")]
	public int Dimension
	{
		[Token(Token = "0x6000219")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000218")]
	public BigInteger get_Characteristic() { }

	[Token(Token = "0x6000219")]
	public int get_Dimension() { }

}

