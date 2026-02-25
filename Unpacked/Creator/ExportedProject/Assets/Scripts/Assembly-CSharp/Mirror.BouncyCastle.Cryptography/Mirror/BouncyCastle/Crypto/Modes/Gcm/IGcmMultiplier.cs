namespace Mirror.BouncyCastle.Crypto.Modes.Gcm;

[Obsolete("Will be removed")]
[Token(Token = "0x2000152")]
public interface IGcmMultiplier
{

	[Token(Token = "0x6000C85")]
	public void Init(Byte[] H) { }

	[Token(Token = "0x6000C86")]
	public void MultiplyH(Byte[] x) { }

}

