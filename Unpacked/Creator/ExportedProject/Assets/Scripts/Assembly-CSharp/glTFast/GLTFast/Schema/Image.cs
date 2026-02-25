namespace GLTFast.Schema;

[Token(Token = "0x2000098")]
public class Image : NamedObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400024C")]
	public string uri; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400024D")]
	public string mimeType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400024E")]
	public int bufferView; //Field offset: 0x28

	[Address(RVA = "0x1075A40", Offset = "0x1074C40", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E2")]
	public Image() { }

}

