namespace Mirror.BouncyCastle.Math.Field;

[Token(Token = "0x2000035")]
public interface IPolynomialExtensionField : IFiniteField
{

	[Token(Token = "0x1700001B")]
	public IPolynomial MinimalPolynomial
	{
		[Token(Token = "0x600021C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600021C")]
	public IPolynomial get_MinimalPolynomial() { }

}

