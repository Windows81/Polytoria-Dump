namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x2000198")]
public interface Asn1BitStringParser : IAsn1Convertible
{

	[Token(Token = "0x17000180")]
	public int PadBits
	{
		[Token(Token = "0x6000F0A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000F0A")]
	public int get_PadBits() { }

	[Token(Token = "0x6000F09")]
	public Stream GetBitStream() { }

}

