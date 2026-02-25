namespace Mirror.BouncyCastle.Crypto.Prng;

[Token(Token = "0x200011E")]
public interface IRandomGenerator
{

	[Token(Token = "0x6000B5E")]
	public void AddSeedMaterial(Byte[] seed) { }

	[Token(Token = "0x6000B5F")]
	public void AddSeedMaterial(long seed) { }

	[Token(Token = "0x6000B60")]
	public void NextBytes(Byte[] bytes) { }

}

