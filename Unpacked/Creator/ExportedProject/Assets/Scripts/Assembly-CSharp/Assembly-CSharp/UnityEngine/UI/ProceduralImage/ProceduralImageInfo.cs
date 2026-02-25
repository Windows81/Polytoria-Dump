namespace UnityEngine.UI.ProceduralImage;

[Token(Token = "0x2000449")]
public struct ProceduralImageInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400123B")]
	public float width; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400123C")]
	public float height; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400123D")]
	public float fallOffDistance; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400123E")]
	public Vector4 radius; //Field offset: 0xC
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400123F")]
	public float borderWidth; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001240")]
	public float pixelSize; //Field offset: 0x20

	[Address(RVA = "0x4F63B0", Offset = "0x4F55B0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002D37")]
	public ProceduralImageInfo(float width, float height, float fallOffDistance, float pixelSize, Vector4 radius, float borderWidth) { }

}

