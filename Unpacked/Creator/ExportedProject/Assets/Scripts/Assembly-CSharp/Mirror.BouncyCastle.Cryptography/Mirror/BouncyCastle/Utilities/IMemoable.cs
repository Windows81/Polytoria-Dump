namespace Mirror.BouncyCastle.Utilities;

[Token(Token = "0x2000007")]
public interface IMemoable
{

	[Token(Token = "0x6000028")]
	public IMemoable Copy() { }

	[Token(Token = "0x6000029")]
	public void Reset(IMemoable other) { }

}

