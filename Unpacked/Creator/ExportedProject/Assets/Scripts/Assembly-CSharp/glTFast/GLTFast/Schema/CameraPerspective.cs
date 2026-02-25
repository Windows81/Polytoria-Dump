namespace GLTFast.Schema;

[Token(Token = "0x2000096")]
public class CameraPerspective
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000248")]
	public float aspectRatio; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000249")]
	public float yfov; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400024A")]
	public float zfar; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400024B")]
	public float znear; //Field offset: 0x1C

	[Address(RVA = "0x10758F0", Offset = "0x1074AF0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001DE")]
	public CameraPerspective() { }

}

