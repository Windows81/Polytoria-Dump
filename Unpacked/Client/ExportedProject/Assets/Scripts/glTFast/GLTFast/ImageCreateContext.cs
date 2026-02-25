namespace GLTFast;

[Token(Token = "0x200003F")]
internal struct ImageCreateContext
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000158")]
	public int imageIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000159")]
	public Byte[] buffer; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400015A")]
	public GCHandle gcHandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400015B")]
	public JobHandle jobHandle; //Field offset: 0x18

}

