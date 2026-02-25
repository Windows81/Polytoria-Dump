namespace Mirror.Transports.Encryption;

[Token(Token = "0x200001C")]
public struct PubKeyInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000DE")]
	public string Fingerprint; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000DF")]
	public ArraySegment<Byte> Serialized; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000E0")]
	public AsymmetricKeyParameter Key; //Field offset: 0x18

}

