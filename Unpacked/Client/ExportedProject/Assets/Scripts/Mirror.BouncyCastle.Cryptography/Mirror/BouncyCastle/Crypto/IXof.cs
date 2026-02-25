namespace Mirror.BouncyCastle.Crypto;

[Token(Token = "0x2000118")]
public interface IXof : IDigest
{

	[Token(Token = "0x6000B2B")]
	public int OutputFinal(Byte[] output, int outOff, int outLen) { }

}

