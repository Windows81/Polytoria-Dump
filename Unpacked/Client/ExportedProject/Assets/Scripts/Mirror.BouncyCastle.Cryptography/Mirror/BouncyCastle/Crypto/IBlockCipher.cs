namespace Mirror.BouncyCastle.Crypto;

[Token(Token = "0x2000113")]
public interface IBlockCipher
{

	[Token(Token = "0x6000B20")]
	public int GetBlockSize() { }

	[Token(Token = "0x6000B1F")]
	public void Init(bool forEncryption, ICipherParameters parameters) { }

	[Token(Token = "0x6000B21")]
	public int ProcessBlock(Byte[] inBuf, int inOff, Byte[] outBuf, int outOff) { }

}

