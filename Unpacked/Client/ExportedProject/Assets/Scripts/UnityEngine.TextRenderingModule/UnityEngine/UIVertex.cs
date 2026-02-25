namespace UnityEngine;

[Token(Token = "0x200000E")]
[UsedByNativeCode]
public struct UIVertex
{
	[Token(Token = "0x4000050")]
	private static readonly Color32 s_DefaultColor; //Field offset: 0x0
	[Token(Token = "0x4000051")]
	private static readonly Vector4 s_DefaultTangent; //Field offset: 0x4
	[Token(Token = "0x4000052")]
	public static UIVertex simpleVert; //Field offset: 0x14
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000048")]
	public Vector3 position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000049")]
	public Vector3 normal; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004A")]
	public Vector4 tangent; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400004B")]
	public Color32 color; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400004C")]
	public Vector4 uv0; //Field offset: 0x2C
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400004D")]
	public Vector4 uv1; //Field offset: 0x3C
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400004E")]
	public Vector4 uv2; //Field offset: 0x4C
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400004F")]
	public Vector4 uv3; //Field offset: 0x5C

	[Address(RVA = "0x1A74840", Offset = "0x1A73A40", Length = "0x221")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600002A")]
	private static UIVertex() { }

}

