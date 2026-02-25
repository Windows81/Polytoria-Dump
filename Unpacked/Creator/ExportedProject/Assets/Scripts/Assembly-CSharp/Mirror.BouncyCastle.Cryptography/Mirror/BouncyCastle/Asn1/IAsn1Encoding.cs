namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001EC")]
internal interface IAsn1Encoding
{

	[Token(Token = "0x600117F")]
	public void Encode(Asn1OutputStream asn1Out) { }

	[Token(Token = "0x6001180")]
	public int GetLength() { }

}

