namespace Mirror.BouncyCastle.Crypto;

[Token(Token = "0x2000116")]
public interface IDigest
{

	[Token(Token = "0x6000B25")]
	public void BlockUpdate(Byte[] input, int inOff, int inLen) { }

	[Token(Token = "0x6000B26")]
	public int DoFinal(Byte[] output, int outOff) { }

	[Token(Token = "0x6000B23")]
	public int GetByteLength() { }

	[Token(Token = "0x6000B22")]
	public int GetDigestSize() { }

	[Token(Token = "0x6000B27")]
	public void Reset() { }

	[Token(Token = "0x6000B24")]
	public void Update(byte input) { }

}

