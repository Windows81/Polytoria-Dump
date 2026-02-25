namespace Mirror.BouncyCastle.Math.EC;

[Token(Token = "0x2000047")]
public interface ECLookupTable
{

	[Token(Token = "0x17000039")]
	public int Size
	{
		[Token(Token = "0x60002E2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60002E2")]
	public int get_Size() { }

	[Token(Token = "0x60002E3")]
	public ECPoint Lookup(int index) { }

	[Token(Token = "0x60002E4")]
	public ECPoint LookupVar(int index) { }

}

