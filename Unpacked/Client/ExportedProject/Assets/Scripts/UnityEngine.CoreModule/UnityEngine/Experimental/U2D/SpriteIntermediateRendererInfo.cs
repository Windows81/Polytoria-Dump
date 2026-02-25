namespace UnityEngine.Experimental.U2D;

[NativeHeader("Runtime/2D/Renderer/SpriteRendererGroup.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000322")]
internal struct SpriteIntermediateRendererInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB0")]
	public int SpriteID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000AB1")]
	public int TextureID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000AB2")]
	public int MaterialID; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000AB3")]
	public Color Color; //Field offset: 0xC
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000AB4")]
	public Matrix4x4 Transform; //Field offset: 0x1C
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000AB5")]
	public Bounds Bounds; //Field offset: 0x5C
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000AB6")]
	public int Layer; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000AB7")]
	public int SortingLayer; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000AB8")]
	public int SortingOrder; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000AB9")]
	public ulong SceneCullingMask; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000ABA")]
	public IntPtr IndexData; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000ABB")]
	public IntPtr VertexData; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000ABC")]
	public int IndexCount; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000ABD")]
	public int VertexCount; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000ABE")]
	public int ShaderChannelMask; //Field offset: 0xA0

}

