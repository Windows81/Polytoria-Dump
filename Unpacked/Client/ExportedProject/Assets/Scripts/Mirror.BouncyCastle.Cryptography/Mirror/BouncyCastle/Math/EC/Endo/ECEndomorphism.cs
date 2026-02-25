namespace Mirror.BouncyCastle.Math.EC.Endo;

[Token(Token = "0x2000078")]
public interface ECEndomorphism
{

	[Token(Token = "0x17000054")]
	public bool HasEfficientPointMap
	{
		[Token(Token = "0x6000457")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000053")]
	public ECPointMap PointMap
	{
		[Token(Token = "0x6000456")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000457")]
	public bool get_HasEfficientPointMap() { }

	[Token(Token = "0x6000456")]
	public ECPointMap get_PointMap() { }

}

