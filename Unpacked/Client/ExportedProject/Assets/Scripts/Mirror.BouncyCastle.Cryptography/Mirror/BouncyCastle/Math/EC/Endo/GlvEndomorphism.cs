namespace Mirror.BouncyCastle.Math.EC.Endo;

[Token(Token = "0x200007C")]
public interface GlvEndomorphism : ECEndomorphism
{

	[Token(Token = "0x6000464")]
	public BigInteger[] DecomposeScalar(BigInteger k) { }

}

