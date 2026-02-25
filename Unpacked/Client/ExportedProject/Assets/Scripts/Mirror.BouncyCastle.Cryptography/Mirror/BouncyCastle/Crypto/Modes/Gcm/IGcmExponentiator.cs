namespace Mirror.BouncyCastle.Crypto.Modes.Gcm;

[Obsolete("Will be removed")]
[Token(Token = "0x2000151")]
public interface IGcmExponentiator
{

	[Token(Token = "0x6000C84")]
	public void ExponentiateX(long pow, Byte[] output) { }

	[Token(Token = "0x6000C83")]
	public void Init(Byte[] x) { }

}

