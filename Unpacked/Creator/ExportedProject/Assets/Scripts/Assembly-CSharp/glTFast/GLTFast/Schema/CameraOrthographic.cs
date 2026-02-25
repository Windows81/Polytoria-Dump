namespace GLTFast.Schema;

[Token(Token = "0x2000095")]
public class CameraOrthographic
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000244")]
	public float xmag; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000245")]
	public float ymag; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000246")]
	public float zfar; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000247")]
	public float znear; //Field offset: 0x1C

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001DD")]
	public CameraOrthographic() { }

}

